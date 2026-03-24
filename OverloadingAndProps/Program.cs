
Car car = new Car(2020);
Console.WriteLine(car.Year);

class Car
{
    public int Year { get; set; }

    public Car(int year)
    {
        Year = year;
    }

    public void SetYear()
    {
        Year = 2000;
    }
}
