using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProblemSolving.Sorting
{
    class Driver
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2,1,5,3};
            foreach(int i in BubbleSort<int>.Sort(arr))
            {
                Console.Write("{0} ", i);
            }
         
        }
        public T[] Reverse<T>(T[] array) 
        {
            var result = new T[array.Length];
            int j = 0;
            for(int i=array.Length-1;i>=0;i--)
            {
                result[j] = array[i];
                j++;
            }
            return result;
        }
    }
    class info : IComparable<info>
    {
        public info(int age,string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public int Age { get; private set; }
        public string Name { get; private set; }

        public int CompareTo([AllowNull] info other)
        {
            return this.Age.CompareTo(other.Age);
            
        }
    }
}
