---
title: "**Úkol - Přetěžování, zapouzdření a properties**"
#author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
---


Kód každého úkolu si zkopírujte do Program.cs, opravte/doplňte podle zadání, otestujte a udělejte si screenshot.
Odevzdávat budete dokument se screenshoty pro každý úkol.

Doplňte chybějící části kódu označené `TODO` tak, aby kód fungoval. Po doplnění komentář s `TODO` smažte.

# Úkol 1 - Přetěžování konstruktorů

Vytvořte požadované konstruktory.

```csharp
Person person1 = new Person("Adam");
Console.WriteLine(person1.GetInfo());

Person person2 = new Person("Petr", 17);
Console.WriteLine(person2.GetInfo());

public class Person
{
    public string Name;
    public int Age;

    // TODO: Create a constructor that takes only a name parameter
    // Set Age to a default value of 0

    // TODO: Create a constructor that takes both name and age parameters

    public string GetInfo()
    {
        return $"{Name} is {Age} years old";
    }
}
```

\clearpage
# Úkol 2 - Properties

Vytvořte požadované soukromé proměnné pro jméno a cenu produktu. Následně vytvořte veřejné properties pro tyto proměnné (s případnou validací).

```csharp
Product product = new Product();
product.Name = name;
product.Price = price;
Console.WriteLine($"{product.Name}: ${product.Price}");

public class Product
{
    // Step 1: Declare a private backing field for name

    // Step 2: Declare a private backing field for price

    // Step 3: Create a property for Name with get and set accessors
    // The get accessor should return the backing field
    // The set accessor should assign the value to the backing field

    // Step 4: Create a property for Price with get and set accessors
    // In the set accessor, only allow positive values (if value <= 0, keep current price)
}
```

\clearpage
# Úkol 3 - Auto-properties

Upravte existující třídu Person, aby používala C# auto-properties.

```csharp
Person person = new Person("David", 23, "david.marek@academicschool.cz");

public class Person
{
    // TODO: Convert these fields to auto-properties
    private string _name;
    private int _age;
    private string _email;
    
    public Person(string name, int age, string email)
    {
        _name = name;
        _age = age;
        _email = email;
    }
    
    public string GetName() { return _name; }
    public void SetName(string value) { _name = value; }
    
    public int GetAge() { return _age; }
    public void SetAge(int value) { _age = value; }
    
    public string GetEmail() { return _email; }
    public void SetEmail(string value) { _email = value; }
}
```
