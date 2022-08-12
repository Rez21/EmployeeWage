using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC1_Employee_Attendance

    {
        public void CheckAttendance()
        {
            int Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
