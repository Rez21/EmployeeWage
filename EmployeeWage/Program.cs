namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION");
            Console.WriteLine("\nEmployee Attendance");
            UC1_Employee_Attendance obj= new UC1_Employee_Attendance();
            obj.CheckAttendance();
        }
    }
}