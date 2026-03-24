---
title: "**Dedičnost**"
author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
---

# Co je to dědičnost?

Dědičnost je jedním z pilířů objektově orientovaného programování. Umožňuje nám vytvořit novou třídu na základě třídy existující. Nová třída (potomek) "zdědí" všechny vlastnosti a metody své mateřské třídy (rodiče), a k tomu si může přidat své vlastní nebo upravit ty stávající.

**Proč ji používat?**

1. **Znovupoužitelnost kódu:** Nemusíme psát stejný kód vícekrát.
2. **Organizace:** Pomáhá nám vytvářet hierarchie (např. Pes je Zvíře, Auto je Dopravní prostředek).

# Základní syntaxe

V C# používáme pro dědění symbol dvojtečky `:`.

```csharp
// Rodičovská třída (Base Class)
class Animal
{
    public string Name { get; set; }
    
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

// Odvozená třída (Derived Class) - dědí z Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

```

V tomto případě má `Dog` automaticky vlastnost `Name` i metodu `Eat()`, i když nejsou v jeho těle napsané.

\clearpage

# Použití base konstruktoru

Když vytváříme instanci potomka, musí se nejdříve "postavit" jeho rodič. Pokud má rodič konstruktor s parametry, potomek mu musí tyto parametry předat pomocí klíčového slova `base`.

```csharp
class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
}

class Dog : Animal
{
    public string Breed { get; set; }

    // Konstruktor psa přijme jméno i rasu
    // Jméno pošle "nahoru" rodiči (Animal) pomocí : base(name)
    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }
}

```


\clearpage

# Polymorfismus: Virtual a Override

Někdy chceme, aby potomek dělal stejnou věc jako rodič, ale **jiným způsobem**. Například každé zvíře vydává zvuk, ale pes štěká a kočka mňouká. Tomuto přepisování chování se říká **polymorfismus** (už jsme si ukazovali klasický polymorfismus uvnitř jedné třídy).

K tomu potřebujeme dvě klíčová slova:

1. **virtual:** Napíšeme v rodičovské třídě u metody, o které říkáme: "Tuto metodu si potomci mohou upravit podle svého."
2. **override:** Napíšeme v třídě potomka, čímž říkáme: "Tady přepisuji původní chování z rodičovské třídy."

```csharp
class Animal
{
    public string Name { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a generic sound.");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

```

\clearpage
# Úkol k procvičení: RPG Postavy

Vytvořte jednoduchý systém pro postavy v RPG hře:

1. **Třída `Character` (Rodič):**
* Vlastnosti: `Name`, `Level`.
* Konstruktor, který nastaví jméno a level.
* Metoda `virtual void Attack()`, která vypíše: "[Jméno] útočí!"


2. **Třída `Warrior` (Potomek):**
* Vlastnost: `WeaponName` (např. "Meč").
* Konstruktor, který využije `base` pro jméno a level.
* Přepsaná metoda `Attack()` (override), která vypíše: "[Jméno] útočí pomocí [WeaponName]!"


3. **Třída `Mage` (Potomek):**
* Vlastnost: `ManaPoints`.
* Konstruktor využívající `base`.
* Přepsaná metoda `Attack()` (override), která vypíše: "[Jméno] sesílá kouzlo a zbývá mu [ManaPoints] many!"



**V Main:**
Vytvořte `List<Character>`, vložte do něj jednoho Válečníka a jednoho Mága. Pomocí cyklu `foreach` projděte seznam a u každé postavy zavolejte metodu `Attack()`. Všimněte si, jak se zavolá správná verze útoku pro každou postavu, i když jsou uložené v jednom seznamu typu `Character`.
