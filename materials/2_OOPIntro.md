---
title: "**Základy OOP v C# - Třídy a objekty**"
author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
---

# 1. Hodnotové vs. Referenční typy

Než začneme s objekty, musíme pochopit, jak C# ukládá data do paměti. Rozlišujeme dva hlavní způsoby:

### Hodnotové typy (Value Types)

* **Příklady:** `int`, `bool`, `double`, `char`, `struct`.
* **Jak fungují:** Hodnota je uložena přímo v proměnné. Když vytvoříte kopii (např. `b = a`), vytvoří se úplně nová nezávislá hodnota.
* **Místo v paměti:** Ukládají se na tzv. **Stack** (zásobník), což je velmi rychlá část paměti.

### Referenční typy (Reference Types)

* **Příklady:** `string`, **třídy (class)**, pole.
* **Jak fungují:** Proměnná neobsahuje přímo data, ale pouze **odkaz** (adresu), kde data v paměti leží. Pokud vytvoříte kopii, obě proměnné ukazují na stejné místo. Změna v jedné se projeví i ve druhé.
* **Místo v paměti:** Samotná data jsou uložena na **Heap** (haldě), v proměnné je jen "ukazatel".


# 2. Třída: Návrh (Blueprint)

Třída je jako **vzor nebo plánek**. Pokud chceme v programu pracovat s "Auty", nejdříve si vytvoříme třídu `Auto`, která definuje, co každé auto umí a jaké má vlastnosti.

### Základní syntaxe

Ve třídě definujeme **vlastnosti** (proměnné) a **schopnosti** (metody).

```csharp
class Auto
{
    // Proměnné (vlastnosti)
    public string barva;
    public int rychlost;

    // Metoda (schopnost)
    public void Zatrub()
    {
        Console.WriteLine("Tút tút!");
    }
}

```

# 3. Přístup k datům (Public vs. Private)

V C# platí pravidlo bezpečnosti: **Vše, co není označeno, je tajné (private).**

* **private:** K proměnné nebo metodě se dostanete pouze "uvnitř" dané třídy. Zvenčí je neviditelná. (V C# je toto výchozí nastavení).
* **public:** K proměnné se dostanete i z jiných částí programu (např. z `Main`).

> **Poznámka:** Pro začátek budeme u všeho psát `public`, abychom s daty mohli snadno pracovat. O tom, proč je lepší věci skrývat, se dozvíme v lekci o *Zapouzdření*.



# 4. Tvorba objektu (Instance)

Třída je jen plánek na papíře. Abychom s autem mohli jezdit, musíme si ho **vytvořit** (inicializovat). K tomu slouží klíčové slovo `new`.

```csharp
// Tvorba objektu typu Auto
Auto mojeAuto = new Auto();

// Nastavení hodnot
mojeAuto.barva = "Červená";
mojeAuto.rychlost = 120;

// Volání metody
mojeAuto.Zatrub();

```



# 5. Konstruktor

Konstruktor je speciální metoda, která se **spustí automaticky ve chvíli, kdy píšete `new**`. Používá se k nastavení počátečních hodnot, aby objekt nebyl "prázdný".

* Musí se jmenovat **přesně stejně jako třída**.
* Nemá žádný návratový typ (ani `void`).

### Definice třídy s konstruktorem:

```csharp
class Auto
{
    public string barva;
    public int rychlost;

    // Konstruktor
    public Auto(string barvaAuta, int rychlostAuta)
    {
        barva = barvaAuta;
        rychlost = rychlostAuta;
    }
}

```

\clearpage
### Použití v programu:

Díky konstruktoru můžeme nastavit vlastnosti rovnou při vytváření objektu na jednom řádku:

```csharp
// Program už nebude hlásit chybu, že barva není vyplněná
Auto sportovniAuto = new Auto("Modrá", 250);

Console.WriteLine(sportovniAuto.barva); // Vypíše: Modrá

```



# Shrnutí

1. **Třída** je plánek, **Objekt** je konkrétní věc vytvořená podle plánku.
2. **new** vytvoří nové místo v paměti (referenci) a zavolá konstruktor.
3. **Konstruktor** slouží k povinnému nastavení dat hned při startu.
4. Nezapomeňte na **public**, jinak vaše proměnné nebudou v `Main` vidět.

# Cvičení
Zkuste vytvořit třídu `Wall`, která bude mít vlastnosti `height (float)`, `width (float)` a `material (string)` a konstruktor, který tyto hodnoty nastaví.

Dále třída bude obsahovat metodu `GetSurface()`, která bude vracet celkovou vypočítanou plochu zdi a metodu `PrintInfo()`, která nebude nic vrace, ale vypíše informace o zdi na jeden řádek.

Poté vytvořte dvě různé instance této třídy a zkuste využít vytvořené metody.
