while (true)
{
    Console.WriteLine("1 - Prvni");
    Console.WriteLine("2 - Druhe");
    Console.WriteLine("3 - Konec");
    int input = int.Parse(Console.ReadLine());
    if (input < 1 || input > 3)
    {
        Console.WriteLine("Neplatny vyber");
        continue;
    }

    if (input == 1)
    {
        Console.WriteLine("Prvni moznost vybrana");
    }
    else if (input == 2)
    {
        Console.WriteLine("Druha moznost vybrana");
    }
    else
    {
        Console.WriteLine("Kones vybran");
        break;
    }
}
