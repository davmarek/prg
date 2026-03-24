(new Cat("Lula")).EatAndSleep();

Console.WriteLine("========");

List<Animal> animals = [
    new Dog("Dogo", "Labrador"),
    new Cat("Mica")
];

foreach (var animal in animals)
{
    animal.Eat();
}



class Animal
{
    public string Name { get; set; } = "";

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
}


class Dog : Animal
{

    public string Breed { get; set; }
    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }

    public override void Eat()
    {
        Console.WriteLine($"Dog named {Name} is eating");
    }

    public void Bark()
    {
        Console.WriteLine("Haf haf!");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine($"Cat named {Name} is eating");
    }

    public void EatAndSleep()
    {
        base.Eat();
        Console.WriteLine($"Cat named {Name} is sleeping");
    }









}
