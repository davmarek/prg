namespace AcademicCompany.Employee;

class Manager : Employee
{
    public Manager(string name, double salary) : base(name, salary)
    {
    }

    public void PrintSalary()
    {
        Console.WriteLine($"Plat manažera je {CalculateFinalSalary()}");
    }
}
