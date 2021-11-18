using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProblemSolving.Sorting
{
    class BoxLengthFirst : Comparer<Box>
    {
        public override int Compare([AllowNull] Box x, [AllowNull] Box y)
        {
            if (x.Height.CompareTo(y.Height) != 0)
            {
                return x.Height.CompareTo(y.Height);
            }
            else if (x.Weight.CompareTo(y.Weight) != 0)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            else if (x.Length.CompareTo(y.Length) != 0)
            {
                return x.Length.CompareTo(y.Length);
            }
            else {
                return 0;
            }
            
        }
    }
}
