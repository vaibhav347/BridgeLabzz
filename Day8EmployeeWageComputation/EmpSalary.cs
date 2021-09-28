using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class EmpSalary
    {
         
        public int attendanceUseCase2(int attend, int halfDayWage, int fullDayWage, int fullDayHour, int halfDayHour, int perHourWage,int totalWage)
        {
            
            switch (attend)
            {
                case 1:
                    Console.WriteLine("Day Eage : 00");
                    break;
                case 2:
                    
                    totalWage = totalWage + halfDayWage;
                    Console.WriteLine("Half Day Wage : "+ halfDayWage);
                    break;
                case 3:
                   
                    totalWage = totalWage + fullDayWage;
                    Console.WriteLine("Half Day Wage : " + fullDayWage);
                    break;
            }
            
            return totalWage;
        }
        public void salary(int totalWage)
        {
            Console.WriteLine("Monthly Salary : " + totalWage);

        }

    }
}
