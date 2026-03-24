Console.WriteLine("Hello, World!");
var dog = new Dog("Hafan", 2);

MakeTheAnimalSpeak(dog);

void MakeTheAnimalSpeak(Animal a)
{
    a.MakeSound();
}
