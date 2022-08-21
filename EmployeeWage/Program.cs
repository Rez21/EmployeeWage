namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder Jio = new EmpWageBuilder("Jio", 20, 2, 10);
            EmpWageBuilder Airtel = new EmpWageBuilder("Airtel", 15, 2, 12);
            Jio.computeEmpWage();
            Console.WriteLine(Jio.ToString());
            Airtel.computeEmpWage();
            Console.WriteLine(Airtel.ToString());
        }
    }
}