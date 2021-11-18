namespace ProblemSolving.Sorting
{
    class BubbleSort<T>
    {
        private BubbleSort() { }
        public static T[] Sort(T[] unsorted)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                int length = unsorted.Length;
                for (int i = 1; i < length; i++)
                {
                    if (unsorted[i].Equals(unsorted[i + 1]))
                    {
                        Swap(i, i - 1, unsorted);
                        swapped = true;
                    }
                }
                length--;
            }
            return unsorted;
        }
        private static void Swap(int index, int index2, T[] unsorted)
        {
            T value = unsorted[index];
            unsorted[index] = unsorted[index2];
            unsorted[index2] = value;
        }

    }
}
