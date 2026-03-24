for (int i = 1; i <= 100; i++)
{
    Console.Write($"{i}: ");
    bool isPrvocislo = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            Console.Write($"{j} ");
            isPrvocislo = false;
        }
    }
    if (isPrvocislo)
    {
        Console.Write("prvocislo");
    }
    Console.WriteLine();
}
