// 1. Euro Converter

/**
double ConvertToEuro(double czk)
{
    return czk / 25;
}

Console.WriteLine("Zadejte CZK:");
string input = Console.ReadLine();
double czk = double.Parse(input);

double eur = ConvertToEuro(czk);
Console.WriteLine($"Hodnota v EUR: {eur}");
*/


























// 2. Password Validator

// Načte heslo od uživatele (string)
// Zavolá funkci na kotrolu hesla
// Napíše jestli je bezpečné nebo ne


// FUNKCE: Vrátí true nebo false (nic nevypisuje)
// BEZPEČNÉ HESLO = delší než 8 znaků AND neobsahuje slovo "heslo"

// Nápověda: heslo.Contains("hledaný string")
//           vrací string jestli string heslo obsahuje "hledaný string"
/**
bool CheckPasswordIsSafe(string password)
{
    return password.Length > 8 && !password.Contains("heslo");
}

Console.WriteLine("Zadej heslo:");
string input = Console.ReadLine();

if (CheckPasswordIsSafe(input))
{
    Console.WriteLine("Heslo je bezpečné");
}
else
{
    Console.WriteLine("Heslo je NEbezpečné");
}


*/

























// 3. Ukol
/*
void FrameWord(string word)
{
    int firstRowLength = word.Length + 4;
    void printFirstRow()
    {

        for (int i = 0; i < firstRowLength; i++)
        {
            Console.Write("+");
        }
        Console.WriteLine();
    }

    printFirstRow();
    Console.WriteLine("+ " + word + " +");
    printFirstRow();
}

FrameWord("abc");
FrameWord("ahoj jak se mas");
FrameWord("hello world");


*/



double? ReadInputDouble(string message = "")
{
    if (message != "")
    {
        Console.Write(message);
    }
    string? input = Console.ReadLine();
    double num;
    if (double.TryParse(input, out num))
    {
        return num;
    }
    else
    {
        return null;
    }
}
string? ReadOperation(string message)
{
    string[] operators = { "+", "-", "*", "/" };

    while (true)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine().Trim();
        if (operators.Contains(input))
        {
            return input;
        }
        Console.WriteLine("Invalid operator entered");
    }
}

double Add(double a, double b)
{
    return a + b;
}
double Subtract(double a, double b)
{
    return a - b;
}
double Multiply(double a, double b)
{
    return a * b;
}
double Divide(double a, double b)
{
    if (b == 0.0)
    {
        Console.WriteLine("Cannot divide by zero!");
    }
    return a / b;
}

double? Calculate(double a, double b, string operation)
{
    switch (operation)
    {
        case "+":
            return Add(a, b);
        case "-":
            return Subtract(a, b);
        case "*":
            return Multiply(a, b);
        case "/":
            return Divide(a, b);
        default:
            return null;
    }
}




double? a = ReadInputDouble("Enter first number: ");
if (a == null)
{
    return;
}
double? b = ReadInputDouble("Enter second number: ");
if (b == null)
{
    return;
}

string operation = ReadOperation("ahoj");

double? result = Calculate(a, b, operation);
if (result == null)
{
    Console.WriteLine("Could not calculate result with given operator");
}
Console.WriteLine($"{a} {operation} {b} = {result}");

