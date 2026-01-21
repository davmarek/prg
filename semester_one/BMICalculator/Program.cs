// váha kg (int)
// výška cm (int)

Console.Clear();

Console.WriteLine("Zadej vahu:");
string vstupVaha = Console.ReadLine();
float vaha = float.Parse(vstupVaha);

Console.WriteLine("Zadej vysku:");
string vstupVyska = Console.ReadLine();
float vyska = float.Parse(vstupVyska) / 100f;

float bmi = vaha / (vyska * vyska);

Console.WriteLine($"BMI: {bmi}");

/*
...18,49	Podváha
18,5–24,99	Normální
25–29,99	Nadváha
30–...	    Obezita
*/

if (bmi >= 30)
{
    Console.WriteLine("Obezita");
}
else if (bmi >= 25)
{
    Console.WriteLine("Nadvaha");
}
else if (bmi >= 18.5f)
{
    Console.WriteLine("Normalni");
}
else
{
    Console.WriteLine("Podvaha");
}