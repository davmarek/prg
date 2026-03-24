List<Student> students = new List<Student>();

while (true)
{
    Console.Write("Name:");
    string? name = Console.ReadLine();

    if (name == "q" || string.IsNullOrWhiteSpace(name))
        break;

    Console.Write("Age:");
    int age = int.Parse(Console.ReadLine());

    students.Add(new Student(name, age));
}

foreach (var s in students)
{
    s.Greet();
}
























