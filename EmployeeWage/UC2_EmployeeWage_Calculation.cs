using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC2_EmployeeWage_Calculation
    {
        public void DailyWage()
        {
            int Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == Full_Time)
            {
                int empRatePerHr = 20;
                int empHour = 8;
                int salary = (empRatePerHr * empHour);
                Console.WriteLine("Employee's Full Day salary is: " + salary);
            }
            else
            {
                int salary = 0;
                Console.WriteLine("Employee is Absent then salary is:" + salary);
            }
        }
    }
}
