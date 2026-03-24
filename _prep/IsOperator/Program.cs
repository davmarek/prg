Animal a = new Eagle();
IFlyable? e = a as IFlyable;
if (e is not null)
{
    e.Fly();
}

interface IFlyable
{
    void Fly();
}
class Animal
{

}
class Eagle : Animal, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Flying eagle");
    }
}

