namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION");
            // UC1 - Employee attendance
            Console.WriteLine("\nEmployee Attendance");
            UC1_Employee_Attendance obj= new UC1_Employee_Attendance();
            obj.CheckAttendance();
            // UC2- Employee Wage calculation
            Console.WriteLine("Employee Wage Calculation");
            UC2_EmployeeWage_Calculation wage = new UC2_EmployeeWage_Calculation();
            wage.DailyWage();
            // UC3 - Part time wage calculation
            Console.WriteLine("Employee Part-Time Wage Calculation");
            UC3_PartTime_Wage partTime= new UC3_PartTime_Wage();
            partTime.PartTimeWage();
            // UC4 employee wage calculation using switch case
            Console.WriteLine("Employee Wage Calculation using switch case");
            UC4_EmployeeWage_using_switch wageCase = new UC4_EmployeeWage_using_switch();
            wageCase.Empwage();
            //UC 5 employee monthly wage calculation
            UC5_MonthlyWage_Calculation monthlyWage = new UC5_MonthlyWage_Calculation();
            monthlyWage.EmpWageMonth();
            // UC6 Employee total wage calculation
            UC6_Employee_TotalWage totalWage = new UC6_Employee_TotalWage();
            totalWage.EmpWageTotal();
                 

        }
    }
}