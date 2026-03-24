
Person person = new Person("David", 23, "david.marek@academicschool.cz");

public class Person
{
    // TODO: Convert these fields to auto-properties
    private string _name;
    private int _age;
    private string _email;

    public Person(string name, int age, string email)
    {
        _name = name;
        _age = age;
        _email = email;
    }

    public string GetName() { return _name; }
    public void SetName(string value) { _name = value; }

    public int GetAge() { return _age; }
    public void SetAge(int value) { _age = value; }

    public string GetEmail() { return _email; }
    public void SetEmail(string value) { _email = value; }
}
