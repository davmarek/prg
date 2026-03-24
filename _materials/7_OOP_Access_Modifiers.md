---
title: "**Modifikátory přístupu a Namespaces**"
author: "David Marek"
geometry: margin=1.5cm
fontsize: 11pt
---

# Modifikátory přístupu (Access Modifiers)

Modifikátory přístupu určují, kdo může vidět a používat vaše třídy, metody nebo proměnné. V C# je to základní nástroj pro tzv. **zapouzdření** (encapsulation).

Doposud jsme pracovali hlavně s `public` a `private`. Nyní do skládačky přidáme `protected`, který úzce souvisí s dědičností.

### Přehled modifikátorů u prvků třídy

| Modifikátor | Kdo k němu má přístup? |
| --- | --- |
| **public** | Kdokoliv (z jakékoliv třídy v projektu). |
| **private** | Pouze kód uvnitř stejné třídy. (Výchozí nastavení) |
| **protected** | Třída samotná **a všichni její potomci** (dědičnost). |

### Praktická ukázka

```csharp
class BaseRobot
{
    public string ModelName;      // Vidí všichni
    private int _batteryLevel;    // Vidí jen BaseRobot
    protected string SerialCode;  // Vidí BaseRobot a např. CombatRobot

    public BaseRobot(string name, string serial)
    {
        ModelName = name;
        SerialCode = serial;
        _batteryLevel = 100;
    }
}

class CombatRobot : BaseRobot
{
    public CombatRobot(string name, string serial) : base(name, serial) { }

    public void ShowStatus()
    {
        Console.WriteLine(ModelName);  // OK - je public
        Console.WriteLine(SerialCode); // OK - je protected (jsem potomek)
        // Console.WriteLine(_batteryLevel); // CHYBA - je private v rodiči
    }
}

```


# Namespaces (Jmenné prostory)

Namespaces slouží k organizaci kódu do logických celků. Představte si je jako **složky v počítači**. V jedné složce nemůžete mít dva soubory se stejným názvem, ale v různých složkách ano.

Stejně tak můžete mít ve velkém projektu dvě třídy `User`, pokud jsou v jiných jmenných prostorech (např. `MyApp.Database.User` a `MyApp.FacebookAPI.User`).

### Deklarace a použití

Prvním způsobem jak vložit třídu do namespace je její *"obalení"* v bloku samotného namespace:
```csharp
namespace MyApp.Models
{
    public class User
    {
        public string Username { get; set; }
    }
}

```

Nebo můžeme říct, že celý soubor patří do daného namespace:

```csharp
namespace MyApp.Models;

public class User
{
    public string Username { get; set; }
}

```

Pokud chcete třídu z jiného jmenného prostoru použít, máte dvě možnosti:

1. **Plný název:** `MyApp.Models.User u = new MyApp.Models.User();`
2. **Klíčové slovo using:** (nejčastější způsob na začátku souboru)
```csharp
using MyApp.Models;

User u = new User();

```
\clearpage

# Úkol k procvičení: Správa zaměstnanců

Vytvořte strukturu tříd, která využije různé úrovně přístupu:

1. Vytvořte projekt `AcademicCompany`.
2. Vytvořte namespace `AcademicCompany.Employees`.
3. Vytvořte třídu `Employee`:
* `public` vlastnost `FullName`.
* `protected` vlastnost `Salary`.
* `private` vlastnost `_socialSecurityNumber` (nastavte v konstruktoru).


4. Vytvořte třídu `Manager`, která dědí z `Employee`:
* Vytvořte v `Manager` metodu `PrintSalary()`, která vypíše plat (všimněte si, že k němu máte přístup díky `protected`).


5. V `Program.cs` (který bude v jiném namespace):
* Zkuste si vytvořit instanci `Manager` (budete muset přidat `using`).
* Zkuste z `Main` vypsat `FullName` (půjde to) a `Salary` (nahlásí chybu).



**Otázka k zamyšlení:** Proč je u platu výhodné použít `protected` místo `public`, pokud chceme počítat bonusy v odvozených třídách (Manager, Director), ale nechceme, aby k platu měl přístup kdokoliv jiný zvenčí?


\clearpage

# Rozšíření úkolu: Správa bonusů a chráněná logika

### 1. Rozšíření třídy Employee

Upravte svou třídu `Employee` o následující prvky:

* **Protected vlastnost `BaseBonus`**: Desetinné číslo (double), které představuje základní odměnu pro každého zaměstnance.
* **Protected metoda `CalculateFinalSalary()`**: Tato metoda sečte `Salary` a `BaseBonus` a vrátí výsledek. Metoda bude `virtual`, aby ji šlo v budoucnu upravit.

### 2. Nová třída: Director

Vytvořte třídu `Director`, která dědí z `Manager`:

* Má navíc `public` vlastnost `StockCount` (počet akcií).
* **Override metody `CalculateFinalSalary()`**: Ředitel má k platu nejen základní bonus, ale navíc ještě bonus za každou akcii (např. +100 Kč za každou akcii).
* Všimněte si, že i `Director` (potomek potomka `Employee`) stále vidí vlastnosti označené jako `protected`.

### 3. Logika v kódu (Ukázka)

```csharp
public class Employee
{
    public string FullName { get; set; }
    protected double Salary { get; set; }
    protected double BaseBonus { get; set; } = 5000;

    public Employee(string name, double salary)
    {
        FullName = name;
        Salary = salary;
    }

    protected virtual double CalculateFinalSalary()
    {
        return Salary + BaseBonus;
    }
}

```
# Úkol pro vás

1. Doplňte kód podle požadavků výše (nezapomeňte změnit metodu `PrintSalary()` tak, aby využívala `CalculateFinalSalary()`)
2. Doplňte do třídy `Director` metodu `PrintDirectorInfo()`, která vypíše jméno a výsledek volání metody `CalculateFinalSalary()`.
3. V `Main` vytvořte instanci `Director` s platem 100 000 a 50 akciemi.
4. Ověřte, že z `Main` **nemůžete** zavolat metodu `CalculateFinalSalary()` přímo (měla by být chráněná), ale můžete zavolat `PrintDirectorInfo()`, která ji využívá vnitřně.

