---
title: "**Přetěžování, zapouzdření a vlastnosti (properties)**"
author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
---

# Přetěžování (Overloading)

Pokud chceme mít více způsobů, jak vytvořit objekt, můžeme konstrukor tzv. `přetížit`. Třída může mít více konstruktorů, pokud se liší svými parametry (počtem nebo typem).

To stejné také platí i pro ostatní funkce ve třídě. Jméno metody může zůstat stejné, stačí aby se lišili parametry.

```csharp
class Car
{
    public string model;
    public int year;

    // Konstruktor 1: Vyžaduje oba údaje
    public Car(string carModel, int carYear)
    {
        model = carModel;
        year = carYear;
    }

    // Konstruktor 2: Pokud neznáme rok, nastavíme výchozí 2024
    public Car(string carModel)
    {
        model = carModel;
        year = 2024;
    }
}

```

# Modifikátory přístupu: Public a Private

V programování existuje princip zvaný **zapouzdření** (*encapsulation*). Znamená to, že data uvnitř třídy by měla být chráněna před neúmyslnou změnou zvenčí. K tomu používáme klíčová slova:

* **private:** Proměnná nebo metoda je přístupná pouze uvnitř dané třídy. Pokud se ji pokusíte použít jinde, kompilátor nahlásí chybu. Je to výchozí nastavení v C#.
* **public:** Proměnná nebo metoda je "viditelná" pro celý zbytek programu.

Představte si třídu `BankAccount`. Zůstatek by měl být `private`, aby ho nikdo nemohl přepsat na milion, ale metoda pro výběr hotovosti by měla být `public`.


# Proč používat Gettery a Settery?

Možná vás napadne: *"Proč prostě neudělat všechno public?"* Odpovědí je **kontrola dat**. Pokud je proměnná `public`, může do ní kdokoliv zapsat nesmysl (např. věk -50 nebo prázdné jméno).

Díky metodám (getterům a setterům) můžeme data při zápisu kontrolovat. Jedná se o obyčejné veřejné metody, které vracejí (get) nebo nastavují (set) nějakou soukromou proměnnou.

```csharp
class User
{
    private int _age;

    // Getter - metoda pro čtení
    public int GetAge()
    {
        return _age;
    }

    // Setter - metoda pro zápis s validací
    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            _age = newAge;
        }
        else
        {
            Console.WriteLine("Error: Age cannot be negative!");
        }
    }
}

```

Všimněte si také, že název soukromé proměnné _age začíná podtržítkem. Téměř každý programovací jazyk má svá pravidla pojmenování (naming conventions), která bychom měli při psaní kódu dodržovat. Jedním z takových pravidel v C# je právě pojmenování veřejných (public) prvků velkým počátečním písmenem a soukromých (private) proměnných malým písmenem s podtržítkem na začátku.

\clearpage
# Vlastnosti (Properties) v C#

C# nabízí elegantnější způsob než psát dvě samostatné metody. Používá tzv. **Properties** (vlastnosti). Ty se navenek tváří jako proměnné, ale uvnitř obsahují bloky `get` a `set`. 

```csharp
class Player
{
    private int _health;

    public int Health
    {
        get 
        { 
            return _health; 
        }
        set 
        { 
            // Klíčové slovo 'value' představuje hodnotu, kterou se snažíme přiřadit
            if (value >= 0) _health = value; 
        }
    }
}

```

V programu pak s vlastností pracujete jednoduše: `hrac.Health = 100;` (všimněte si, že nepoužíváme závorky jako u metody `setHealth()`).

# Auto-Properties

Pokud nepotřebujete v setteru žádnou logiku (např. kontrolu záporných čísel) a jde vám jen o to, aby proměnná byla přístupná, C# nabízí nejkratší možný zápis. Kompilátor si sám na pozadí vytvoří skrytou proměnnou.

```csharp
class Book
{
    // Auto-property: vytvoří proměnnou i "get/set metody" za vás
    public string Title { get; set; }
    public string Author { get; set; }
    
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

```

### Proč používat auto-property místo public proměnné?

I když auto-property vypadá jako obyčejná `public` proměnná, je to bezpečnější pro budoucí úpravy. Pokud se za rok rozhodnete, že `Title` nesmí být prázdný, stačí upravit auto-property na klasickou property s podmínkou, aniž byste museli měnit zbytek programu.

# Shrnutí

* **Přetěžování** umožňuje definovat stejnou metody s různými parametry (např. konstruktor).
* **Private** schovává data, **Public** je dělá veřejnými.
* **Properties** (get a set) chrání integritu dat (validace).
* **Auto-properties** šetří čas, když nepotřebujeme speciální logiku.

