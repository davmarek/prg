---
title: "**Debugging - střední**"
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
## Úkol 1 - Funkce s návratovou hodnotou

Napiš funkci, která vrátí větší ze dvou čísel.

```csharp
int Bigger(int a, int b)
{
    if (a > b)
    {
        return;
    }
    else
    {
        return;
    }
}
```

**Úkol:**
Oprav funkci tak, aby vždy vracela správnou hodnotu.



## Úkol 2 - Sudé nebo liché

Program má zjistit, zda je číslo sudé.

```csharp
bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
}
```

```csharp
Console.Write("Zadej číslo: ");
int n = int.Parse(Console.ReadLine());

if (IsEven(n))
{
    Console.WriteLine("Sudé");
}
else
{
    Console.WriteLine("Liché");
}
```

**Úkol:**
Oprav funkci tak, aby vždy vracela hodnotu.



## Úkol 3 - Odpočítávání

Napiš funkci:

```csharp
void Countdown(int n)
```

která vypíše čísla od `n` do `1`.

Příklad:

```
Countdown(3);
3
2
1
```



## Úkol 4 - Součet čísel

Napiš funkci:

```csharp
int SumFromOne(int n)
```

která vrátí součet čísel od 1 do `n`.



## Úkol 5 - Mini menu

Napiš program, který v cyklu vypisuje:

```
1 - Pozdrav
2 - Součet dvou čísel
3 - Konec
```

Podle volby:

* 1 → vypíše pozdrav
* 2 → načte dvě čísla a vypíše jejich součet
* 3 → ukončí program



### Poznámka

Používej:

* `if / else` nebo `switch`
* `while` cyklus
* funkce tam, kde to dává smysl



