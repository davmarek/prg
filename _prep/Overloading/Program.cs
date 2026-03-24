Person person1 = new Person("Adam");
Console.WriteLine(person1.GetInfo());

Person person2 = new Person("Petr", 17);
Console.WriteLine(person2.GetInfo());

public class Person
{
    public string Name;
    public int Age;

    // TODO: Create a constructor that takes only a name parameter
    // Set Age to a default value of 0

    // TODO: Create a constructor that takes both name and age parameters

    public string GetInfo()
    {
        return $"{Name} is {Age} years old";
    }
}

