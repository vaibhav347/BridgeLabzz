using System;

namespace EmployeeWageComputation
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            int halfDayWage = 0, fullDayWage = 0, fullDayHour = 8, halfDayHour = 4, perHourWage = 20, month = 20, sal = 0, totalWage = 0,totalSal=0,n=0,attend=0;

            halfDayWage = halfDayHour * perHourWage;
            fullDayWage = fullDayHour * perHourWage;
            Random rand = new Random();
           
            EmpAttendance obj = new EmpAttendance();
            EmpSalary obj2 = new EmpSalary();
   
                WelcomeEmpWage obj3 = new WelcomeEmpWage();
                obj3.display();
              
                for (int i = 1; i <= month; i++)
                {
                    attend = rand.Next(1, 4);
                    obj.attendance(attend);
                    sal = obj2.attendanceUseCase2(attend, halfDayWage, fullDayWage, halfDayWage, perHourWage, halfDayHour, totalWage);
                    totalSal = totalSal + sal;
                }
                obj2.salary(totalSal);
            

        }
    }
}
