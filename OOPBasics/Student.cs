class Student
{
    public string name;
    public int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Greet()
    {
        Console.WriteLine($"My name is {name} and I'm {age}");
    }
}
