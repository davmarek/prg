for (int i = 1; i <= 50; i++)
{
    bool jePrvocislo = true;
    Console.Write($"{i}: ");
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            Console.Write($"{j} ");
            jePrvocislo = false;
        }
    }
    if (jePrvocislo)
    {
        Console.Write("prvocislo");
    }
    Console.WriteLine();
}
