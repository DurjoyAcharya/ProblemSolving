using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class Student {
        private Int64 id;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Int64 Id {

            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        } 
    }
    class ProProperties
    {
        static void Main(string[] args)
        {
            Student[] obj = new Student[3];
            for (int i = 0; i < obj.Length; i++)
                obj[i] = new Student();
            for(int i=0;i<obj.Length;i++)
            {
                obj[i].Id = int.Parse(Console.ReadLine());
                obj[i].Name = Console.ReadLine();
            }
            for(int i=0;i<obj.Length;i++)
            {
                Console.WriteLine(obj[i].Name);
                Console.WriteLine(obj[i].Id);

            }

        }
    }
}
