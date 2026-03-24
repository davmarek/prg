---
title: "**Funkce v C#**"
author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
---
\clearpage
# 1. Co je funkce

Funkce je pojmenovaný blok kódu, který provádí určitou činnost.
Umožňuje rozdělit program na menší části, které jsou snadno pochopitelné a znovu použitelné.

## Proč funkce používat

* Zpřehledňují program.
* Umožňují opakovaně využít stejný kód.
* Umožňují rozdělit složitý problém na menší části.
* Usnadňují testování jednotlivých částí programu.



# 2. Základní syntaxe funkce

Obecná podoba funkce v C#:

```cs
návratový_typ JménoFunkce(parametry)
{
    // tělo funkce (zde je kód)
}
```

Funkce se neprovede sama - musíme ji zavolat:

```cs
JménoFunkce(); // volání funkce
```



# 3. Funkce typu void bez parametrů

Funkce typu `void` nic nevrací.
Pokud nemá ani parametry, chová se jako jednoduchá samostatná akce.

## Příklad

```cs
void Greet()
{
    Console.WriteLine("Ahoj! Já jsem funkce.");
}
```

## Použití ve funkci Main

```cs
static void Main()
{
    Greet();
}
```

Tato funkce pouze vypíše text a tím končí.
Nepředává žádnou hodnotu zpět.


\clearpage
# 4. Funkce typu void s parametry

Parametry umožňují posílat do funkce hodnoty.
Díky tomu může funkce pracovat s různými daty.

## Příklad

```cs
void PrintMessage(string message)
{
    Console.WriteLine(message);
}
```

## Volání funkce

```cs
PrintMessage("Zdravím třídu!");
PrintMessage("Toto je další zpráva.");
```

## Co je důležité

* Každý parametr má svůj datový typ.
* Počet a typ parametrů musí při volání sedět.
* Funkce typu `void` se ukončuje návratem na další řádek programu.



# 5. Funkce s návratovým typem

Funkce může vracet hodnotu.
Vrací ji pomocí příkazu `return`.

## Příklad

```cs
int Add(int a, int b)
{
    int sum = a + b;
    return sum;
}
```

## Použití návratové hodnoty

```cs
int result = Add(5, 7);
Console.WriteLine(result); // vypíše 12
```

## Poznámky

* Návratový typ nesmí být `void`.
* Po provedení `return` funkce končí.
* Funkce může vrátit pouze jednu hodnotu.



\clearpage
# 6. Ukázka malého programu s funkcemi

```cs
string ReadName()
{
    Console.Write("Zadej své jméno: ");
    return Console.ReadLine();
}

void GreetUser(string name)
{
    Console.WriteLine($"Ahoj, {name}!");
}

int Add(int a, int b)
{
    return a + b;
}

static void Main()
{
    string user = ReadName();
    GreetUser(user);

    int x = 4;
    int y = 7;

    int sum = Add(x, y);
    Console.WriteLine($"Součet {x} a {y} je {sum}.");
}
```

Tento miniprogram ukazuje, jak lze funkce kombinovat:
jedna načítá vstup, druhá vypisuje, třetí počítá.



\clearpage
# 7. Procvičovací úkoly

## Úkol 1 - Jednoduchá funkce

Napiš funkci `void Hello()`, která vypíše „Ahoj světe!“.
Zavolej ji z `Main()` několikrát.



## Úkol 2 - Funkce s parametrem

Napiš funkci `void RepeatMessage(string message)`, která vypíše text dvakrát za sebou.



## Úkol 3 - Funkce s návratovou hodnotou

Napiš funkci `int Multiply(int a, int b)`, která vrátí součin dvou čísel.



## Úkol 4 - Vstup + funkce

Napiš funkci `int ReadNumber()`, která:

1. požádá uživatele o číslo,
2. převede ho na `int`,
3. vrátí tuto hodnotu.



## Úkol 5 - Mini kalkulačka

Použij funkce:

* `int Add(int a, int b)`
* `int Sub(int a, int b)`
* `int Mul(int a, int b)`
* `int Div(int a, int b)`

Naprogramuj jednoduchou konzolovou kalkulačku, která:

1. Načte dvě čísla.
2. Zeptá se na operaci.
3. Zavolá správnou funkci.
4. Vypíše výsledek.



## Úkol 6 - Kombinace více funkcí

Napiš program, který:

1. Funkcí `string GetName()` načte jméno uživatele.
2. Funkcí `int GetAge()` načte věk.
3. Funkcí `void DescribeUser(string name, int age)` vypíše shrnutí jako:
   „Ahoj Honzo, je ti 17 let.“


