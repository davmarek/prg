namespace AcademicCompany.Employee;

public class Employee
{
    public string FullName { get; set; }
    protected double Salary { get; set; }
    protected double BaseBonus { get; set; } = 5000;

    public Employee(string name, double salary)
    {
        FullName = name;
        Salary = salary;
    }

    protected virtual double CalculateFinalSalary()
    {
        return Salary + BaseBonus;
    }

}

