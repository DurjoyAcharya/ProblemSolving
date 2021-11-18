using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProblemSolving.Sorting
{
    public class Box:IComparable<Box>
    {
        public Box(int h,int l,int w)
        {
            this.Height = h;
            this.Length = l;
            this.Weight = w;

        }
        public int Height { get; private set; }
        public int Length { get; private set; }
        public int Weight { get; private set; }
        

        public int CompareTo([AllowNull] Box other)
        {
            if (this.Height.CompareTo(other.Height) != 0)
            {
                return this.Height.CompareTo(other.Height);
            }
            else if (this.Weight.CompareTo(other.Weight) != 0)
            {
                return this.Weight.CompareTo(other.Weight);
            }
            else if (this.Length.CompareTo(other.Length) != 0)
            {
                return this.Length.CompareTo(other.Length);
            }
            else
            {
                return 0;
            }
        }
    }
}
