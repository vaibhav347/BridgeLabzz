using System;
using System.Collections.Generic;
using System.Text;


namespace Day8LineComparisonProblem
{
   public class UC1
    {
        public void getAxis(int x1,int x2,int y1,int y2)
        {

           
            double line1 = Math.Sqrt((x2 - x1 ) ^ 2 + (y2 - y1) ^ 2);
            double line2 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Line1 : "+line1);
            Console.WriteLine("Line2 : " + line2);
            UC2 ob = new UC2();
            UC3 ob1 = new UC3();
            ob.comp(line1,line2);
            ob1.comp(line1, line2);

        }
    }
}
