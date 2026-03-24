---
title: "**Debugging - jednoduchý**"
author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
# header-includes:
# - \let\oldsection\section
# - \renewcommand\section{\clearpage\oldsection}
---


# Instrukce

* Pracuj samostatně
* Zaměř se na správnou logiku, ne jen na to, aby se kód spustil
* Pracuj v jednom souboru Program.cs
* Před každý úkol napiš komentář s názvem úkolu

# Úkoly

## Úkol 1 - Oprav funkci

Program má vypsat pozdrav třikrát. Kód obsahuje chyby.

```csharp
void Greet
{
    Console.WriteLine("Ahoj!");
}

Greet;
Greet;
Greet;
```

**Úkol:**
Oprav chyby tak, aby program fungoval správně.


## Úkol 2 - Doplň podmínky

Program má určit, zda je číslo kladné, záporné nebo nula.

```csharp
Console.Write("Zadej číslo: ");
int number = int.Parse(Console.ReadLine());

if ()
{
    Console.WriteLine("Kladné číslo");
}
else if ()
{
    Console.WriteLine("Záporné číslo");
}
else
{
    Console.WriteLine("Nula");
}
```

**Úkol:**
Doplň správné podmínky do `if` a `else if`.



## Úkol 3 - Oprav cyklus while

Program má vypsat čísla od 1 do 5.

```csharp
int i = 1;

while ()
{
    Console.WriteLine(i);
}
```

**Úkol:**
Doplň chybějící části tak, aby program fungoval správně.



## Úkol 4 - Funkce s parametrem

Program má vypsat zadaný text.

```csharp
void PrintText()
{
    Console.WriteLine(text);
}

PrintText("Programování je zábava");
```

**Úkol:**
Oprav funkci tak, aby správně přijímala parametr.



## Úkol 5 - Oprava cyklu for

Program má vypsat pět hvězdiček.

```csharp
for (int i = 0; i > 5; i++)
{
    Console.Write("*");
}
```

**Úkol:**
Najdi a oprav chybu.


