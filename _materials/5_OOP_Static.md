---
title: "**Statické členy (static)**"
author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
---

# Co znamená klíčové slovo static?

V předchozích lekcích jsme se naučili, že třída je "plánek" a objekt je "konkrétní věc" vytvořená podle tohoto plánku. Každý objekt má své vlastní vlastnosti (např. každé auto má jinou barvu).

Někdy ale potřebujeme něco, co nepatří konkrétnímu objektu, ale **patří to celé třídě**. K tomu slouží klíčové slovo `static`.

### Hlavní rozdíly:

* **Instanční členy (bez static):** Patří konkrétnímu objektu. Musíme použít `new`, abychom k nim měli přístup.
* **Statické členy (se static):** Patří třídě jako takové. Existují pouze jednou v celé paměti, i kdybychom vytvořili milion objektů. Voláme je přímo přes název třídy.

# Statické proměnné

Statickou proměnnou si můžete představit jako "sdílenou schránku". Pokud jeden objekt hodnotu změní, uvidí tuto změnu i všechny ostatní objekty této třídy.

Typickým příkladem je počítadlo vytvořených objektů:

```csharp
class Robot
{
    // Statická proměnná - společná pro všechny roboty
    private static int _robotCount = 0;
    
    public string Name { get; set; }

    public Robot(string name)
    {
        Name = name;
        _robotCount++; // Při každém vytvoření robota zvýšíme společné počítadlo
    }

    public static int GetRobotCount()
    {
        return _robotCount;
    }
}

```

# Statické metody

Statické metody jsou takové, které nepotřebují ke své práci data z konkrétního objektu. Jsou to často pomocné funkce (Utility).

Příkladem z praxe je třída `Math`. Nikdy nepíšete `Math m = new Math();`, ale rovnou voláte metodu na třídě:

```csharp
double root = Math.Sqrt(64); // Sqrt je statická metoda pro odmocninu

```

Vlastní statická metoda v našem kódu by vypadala takto:

```csharp
class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

// Použití v Main:
int result = Calculator.Add(5, 10);

```

# Kdy použít static?

1. **Konstanty a pomocné výpočty:** Pokud metoda jen vezme vstup a vrátí výstup (jako kalkulačka) a nepotřebuje si nic "pamatovat" o objektu.
2. **Globální stav:** Pokud potřebujete sdílet data mezi všemi instancemi (např. celkové skóre v týmu, počet nepřátel na mapě).
3. **Vstupní bod programu:** Samotná metoda `Main` musí být vždy `static`, protože se spouští ve chvíli, kdy ještě žádný objekt neexistuje.

# Pozor na omezení!

Statická metoda **nemůže** přímo přistupovat k věcem, které nejsou statické. Je to logické: statická metoda patří třídě a "neví", ze kterého konkrétního objektu by měla data brát.

```csharp
class User
{
    public string name; // Nestatická proměnná

    public static void SayHello()
    {
        Console.WriteLine(name); // CHYBA! Metoda neví, čí jméno vypsat.
    }
}
```
\clearpage
# Úkol k procvičení: Evidence skladu

Vytvořte jednoduchý systém pro evidenci produktů na skladě:

1. Vytvořte třídu `Product`.
2. Třída bude mít vlastnosti: `Name` (string) a `Price` (double) - použijte auto-properties z minule.
3. Třída bude mít **statickou proměnnou** `_totalProductsCount`, která se zvýší v konstruktoru při každém vytvoření nového produktu.
4. Třída bude mít **statickou proměnnou** `_totalValue`, do které se v konstruktoru přičte cena právě vytvářeného produktu.
5. Vytvořte statickou metodu `PrintWarehouseSummary()`, která vypíše: "Celkem produktů: X, Celková hodnota skladu: Y".

**V metodě Main:**

* Vytvořte 3 různé produkty s různými cenami.
* Na konci zavolejte statickou metodu pro výpis souhrnu.


\clearpage

# Úkol k procvičení: Unikátní identifikátory a globální nastavení
V praxi se `static` často používá k automatickému generování unikátních ID (např. v databázích) nebo k ukládání globálních koeficientů, které ovlivňují celý program najednou.

## Zadání: Simulace bojové hry

Vytvořte systém pro správu nepřátel v jednoduché hře.

### 1. Třída Enemy

Každý nepřítel bude mít své vlastní jméno a životy, ale zároveň bude sdílet globální nastavení obtížnosti.

* **Statické soukromá proměnná `_nextId`**: Celé číslo, které začíná na 1. Bude sloužit jako "výrobní linka" na ID.
* **Statická veřejná vlastnost `DifficultyMultiplier`**: Desetinné číslo (double), které bude v základu 1.0.
* **Vlastnosti objektu**: `Id` (int), `Name` (string), `BaseHealth` (double).
* **Vlastnost `CurrentHealth`**: Tato vlastnost bude typu `get`. Bude vracet výsledek výpočtu: `BaseHealth * DifficultyMultiplier`.

### 2. Konstruktor Enemy

Konstruktor přijme parametry pro jméno a základní životy.

* Při vytvoření objektu se do vlastnosti `Id` uloží aktuální hodnota `_nextId`.
* Ihned poté se `_nextId` zvýší o 1, aby další nepřítel dostal unikátní vyšší číslo.

```csharp
// Ukázka logiky v konstruktoru
public Enemy(string name, double baseHealth)
{
Name = name;
BaseHealth = baseHealth;
Id = _nextId;
_nextId++;
}
```

### 3. Statická metoda `SetDifficulty`

Metoda, která umožní změnit `DifficultyMultiplier` pro všechny nepřátele naráz.

## Úkol pro vás

1. Vytvořte `List<Enemy>` a přidejte do něj 3 různé nepřátele (např. "Goblin", "Orc", "Troll").
2. Vypište jejich data (Id, Name, CurrentHealth) na obrazovku.
3. Změňte obtížnost hry pomocí statické metody na **2.5** (např. hráč vstoupil do těžší zóny).
4. Znovu vypište stejný seznam nepřátel. Všimněte si, že se jim životy (`CurrentHealth`) změnily, aniž byste museli každý objekt ručně upravovat!

## K zamyšlení

Proč je v tomto případě lepší mít `DifficultyMultiplier` jako `static` než jako běžnou proměnnou v každém objektu? Co by se stalo, kdybyste měli ve hře 10 000 nepřátel a chtěli změnit obtížnost bez použití `static`?

