using System;
using System.Collections.Generic;
using System.Text;

namespace Day8LineComparisonProblem
{
    public class UC3:UC2
    {
        public override void comp(double line1,double line2)
        {
            if (line1 > line2)
                Console.WriteLine("Line1 is greater");
            else if (line1 < line2)
                Console.WriteLine("Line2 is greatter");
            else
                Console.WriteLine("Both lines are equal");
        }
    }
}
