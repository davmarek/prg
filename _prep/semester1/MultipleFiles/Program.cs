// See https://aka.ms/new-console-template for more information
// Úkol 1 - Oprav funkci
void Greet()
{
    Console.WriteLine("Ahoj!");
}
Greet();
Greet();
Greet();



// Úkol 2 - Doplň podmínky
Console.WriteLine("Zadej číslo: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Kladné číslo");
}
else if (number < 0)
{
    Console.WriteLine("Záporné číslo");
}
else
{
    Console.WriteLine("Nula");
}





// Úkol 3 - Oprav cyklus while no
int i = 0;
while (i < 5)
{
    Console.WriteLine(i = i + 1);
}




// Úkol 4 - Funkce s parametrem
void PrintText(string text)
{
    Console.WriteLine(text);
}
PrintText("Programování je zábava");




// Úkol 5 - Oprava cyklu for

for (int j = 0; j < 5; j++)
{
    Console.Write("*");
}
