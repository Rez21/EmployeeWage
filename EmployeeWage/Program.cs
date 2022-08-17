namespace EmployeeWage
{
    internal class Program
    {
        public const int Part_Time = 2;
        public const int Full_Time = 1;
        public const int empRatePerHr = 20;
        public const int numOfWorkDay = 20;
        public const int MaxWorkHr = 100;

        public static int computeEmpWage()
        {
            int empHr = 0;
            int totalwage = 0;
            int totalWorkDays = 0;
            int totalEmpHrs = 0;

            while(totalEmpHrs <= MaxWorkHr && totalWorkDays < numOfWorkDay)
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
            }
            totalwage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Day: " + totalWorkDays + "\nEmployee working Hrs: " + totalEmpHrs);
            Console.WriteLine("Total Salary is: " + totalwage);
            return totalwage;

        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}