for (int f = 0; f <= 100; f++)
{
    double c = (5.0 / 9.0) * (f - 32.0);
    c = Math.Round(c, 3);
    Console.WriteLine($"{f}F -> {c}C");
}
