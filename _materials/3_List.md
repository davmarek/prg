---
title: "**Kolekce dat: Používání List v C#**"
author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
---

# Proč potřebujeme List?

Doposud jste používali **pole** (Array). Pole mají jednu velkou nevýhodu: jejich velikost musíte určit při vytvoření a už ji nelze změnit. Pokud vytvoříte pole pro 10 prvků a pak jich potřebujete 11, máte smůlu.

**List** (seznam) je tzv. dynamická kolekce. Můžete si ho představit jako "nafukovací pole". Když přidáte prvek, List se sám zvětší. Když prvek odeberete, List se zmenší.


# Základní syntaxe

List používá tzv. **generiku** – to jsou ty špičaté závorky `< >`. Do nich píšeme, jaký typ dat bude List obsahovat.

```csharp
// Vytvoření prázdného seznamu celých čísel
List<int> cisla = new List<int>();

// Vytvoření seznamu textových řetězců
List<string> jmena = new List<string>();

```

# Základní operace s Listem

Práce s Listem je díky vestavěným metodám velmi jednoduchá.

### Přidávání a odebírání prvků

```csharp
List<string> ovoce = new List<string>();

ovoce.Add("Jablko");   // Přidá prvek na konec
ovoce.Add("Banán");
ovoce.Insert(0, "Pomeranč"); // Vloží na konkrétní index (posune ostatní)

ovoce.Remove("Banán");  // Najde a odstraní konkrétní hodnotu
ovoce.RemoveAt(0);     // Odstraní prvek na indexu 0

```

### Zjištění počtu prvků

U pole používáme vlastnost `Length`, u Listu používáme **`Count`**.

```csharp
int kolikMamPrvku = ovoce.Count;

```

# Průchod Listem (Cyklus foreach)

Nejlepším způsobem, jak vypsat všechny prvky v Listu, je cyklus `foreach`. Ten postupně projde celý seznam od začátku do konce. Pokud chcete, můžete používat původní `for` s proměnnou `i` a do ukončovací podmínky dát `Count`.

```csharp
List<string> studenti = new List<string> { "Petr", "Alena", "Karel" };

foreach (string student in studenti)
{
    Console.WriteLine("Student: " + student);
}

```

# List a vlastní objekty

To nejzajímavější nastává, když do Listu uložíme objekty našich vlastních tříd. Můžeme tak vytvořit například databázi aut nebo inventář v počítačové hře.

Představme si, že máme třídu `Auto` z minulé hodiny:

```csharp
List<Auto> mojeGaraz = new List<Auto>();

// Přidání nových objektů přímo do seznamu
mojeGaraz.Add(new Auto("Červená", 150));
mojeGaraz.Add(new Auto("Modrá", 200));

// Výpis všech aut v garáži
foreach (Auto auto in mojeGaraz)
{
    Console.WriteLine($"Barva: {auto.barva}, Rychlost: {auto.rychlost}");
}

```

# Srovnání: Pole vs. List

| Vlastnost | Pole (Array) | List |
| --- | --- | --- |
| **Velikost** | Pevná (neměnná) | Dynamická (mění se za běhu) |
| **Rychlost** | Mírně rychlejší | Mírně pomalejší (kvůli správě paměti) |
| **Zjištění délky** | `.Length` | `.Count` |
| **Přidávání prvků** | Nelze přímo (musí se vytvořit nové pole) | Metoda `.Add()` |

\clearpage
# Úkol k procvičení
Vytvořte program, který:

1. Vytvoří třídu `Student` s vlastnostmi `Name` a `Grade`.
2. Vytvoří `List<Student>`.
3. V cyklu (např. pomocí `while`) se bude uživatele ptát na jména a známky, dokud uživatel nezadá "konec".
4. Všechny studenty uloží do Listu.
5. Na závěr vypíše seznam všech studentů a jejich průměrnou známku.

