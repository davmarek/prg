namespace AcademicCompany.Employee;

class Director : Manager
{
    public int StockCount;


    public Director(string name, double salary, int stockCount) : base(name, salary)
    {
        StockCount = stockCount;
    }
    protected override double CalculateFinalSalary()
    {
        return base.CalculateFinalSalary() + StockCount * 100;
    }
    public void PrintDirectorInfo()
    {
        Console.WriteLine($"Ředitel {FullName} má plat {CalculateFinalSalary()}");
        Console.WriteLine($"Plat = základ({Salary}) + bonus({BaseBonus}) + stock({StockCount * 100})");

    }
}
