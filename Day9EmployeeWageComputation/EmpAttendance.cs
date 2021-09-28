using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class EmpAttendance
    {
        
        public void attendance(int attend)
        {
            
            switch(attend)
            {
            case 0:
                Console.WriteLine("Employee is absent");
                break;
            case 1:
                Console.WriteLine("Half Day");
                break;
            case 2:
                Console.WriteLine("Full Day");
                break;
            }
        }

    }
}
