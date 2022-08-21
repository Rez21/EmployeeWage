using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageBuilder
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;

        private string company;
        private int empRatePerHr;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;


        public EmpWageBuilder(string company, int empRatePerHr, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }



        public void computeEmpWage()
        {
            int empHr = 0;
            int totalWorkDays = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkDays < this.numOfWorkingDays)
            {
                totalWorkDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case Full_Time:
                        empHr = 8;
                        break;
                    case Part_Time:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                totalEmpHrs += empHr;
                Console.WriteLine("Day: " + totalWorkDays + " Emp Hrs: " +empHr);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHr;
            
            Console.WriteLine("Total Wage for company: " + company + " is: " + totalEmpWage);
           
        }

        public string ToString()
        {
            return "Total Employee Wage for Company: " + this.company + " is " + this.totalEmpWage;
        }
    }
}
