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
            Console.WriteLine("Enter value for n");
            n = int.Parse(Console.ReadLine());
            EmpAttendance[] obj = new EmpAttendance[n];
            EmpSalary[] obj2 = new EmpSalary[n];
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Enter Compony name");
                String name = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("Compony Name : "+name);
                for (int i = 1; i <= month; i++)
                {
                    attend = rand.Next(1, 4);
                    obj[j].attendance(attend);
                    sal = obj2[j].attendance(attend, halfDayWage, fullDayWage, halfDayWage, perHourWage, halfDayHour, totalWage);
                    totalSal = totalSal + sal;
                }
                obj2[j].salary(totalSal);
            }

        }
    }
}
