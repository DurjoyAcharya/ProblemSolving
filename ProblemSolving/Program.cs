using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 50;
            var pro = new Program();
            pro.Show(ref val);
            Console.WriteLine(val);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Value Before Modify");
            pro.Show2(out val);
            Console.WriteLine("After Moduifying:   " + val);

        }
        public void TestM()
        {
              for(var i=1;i<10;i++)
            {
                for(var j=0;j<i;j++)
                {
                    Console.Write("i: "+ i+" J: "+j);
                }
                Console.WriteLine();
            }
        }
        public void Show(ref int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        public void Show2(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value  
        }
    }
}
