while (true)
{
    bool isValid;
    Console.WriteLine("Math Menu");
    Console.WriteLine("1. Vypocet faktorialu");
    Console.WriteLine("2. Vypocet mocniny");
    Console.WriteLine("3. Konec");


    Console.Write("Vyber akci z menu (1-3): ");
    int selected;
    isValid = int.TryParse(Console.ReadLine(), out selected);

    if (selected == 1)
    {
        Console.Write("Zadejte cislo:");
        int num;
        isValid = int.TryParse(Console.ReadLine(), out num);
        if (num < 1)
        {
            Console.WriteLine("Zadane cislo musi byt vic nez 0");
        }
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Faktorial pro {num} je {factorial}");
    }
    else if (selected == 2)
    {
        Console.Write("Zadejte mocnenec:");
        int num;
        isValid = int.TryParse(Console.ReadLine(), out num);

        Console.Write("Zadejte exponent:");
        int exponent;
        isValid = int.TryParse(Console.ReadLine(), out exponent);

        double result = Math.Round(Math.Pow(num, exponent), 2);
        Console.WriteLine($"Vysledek {num}^{exponent} je {result}");
    }
    else if (selected == 3)
    {
        Console.WriteLine("Koncim, bye");
        break;
    }
    else
    {
        Console.WriteLine("Neplatny vstup");
    }
    Console.WriteLine();
}
