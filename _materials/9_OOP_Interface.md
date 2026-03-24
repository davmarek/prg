---
title: "**Interfaces (Rozhraní)**"
author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
---

# Co je to Interface?

Rozhraní (interface) je v podstatě **smlouva** (kontrakt). Třída, která se rozhodne rozhraní implementovat, se tím zavazuje, že bude obsahovat všechny metody a vlastnosti, které toto rozhraní definuje.

Zatímco dědičnost říká, že objekt **je** něčím (Pes je Zvíře), rozhraní říká, co objekt **umí** (Stroj umí Tisknout, Auto umí BýtŘízeno).

# Syntaxe a naming conventions

Rozhraní definujeme klíčovým slovem `interface`. V C# je silným zvykem (konvencí), že název rozhraní vždy začíná velkým písmenem **I**.

```csharp
// Definice rozhraní
public interface IPlayable
{
    // Metody v interface nemají modifikátor (jsou automaticky public)
    // a v základu nemají tělo.
    void Play();
    void Pause();
}

// Implementace ve třídě
public class MusicPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Music is playing...");
    }

    public void Pause()
    {
        Console.WriteLine("Music is paused.");
    }
}

```

\clearpage
# Rozdíl: Interface vs. Abstraktní třída

Toto je jedna z nejčastějších otázek u pohovorů na programátora. I když se zdají podobné, jejich účel je jiný:

| Vlastnost | Interface | Abstraktní třída |
| --- | --- | --- |
| **Vztah** | Schopnost ("Umí to") | Identita ("Je to") |
| **Vícenásobná dědičnost** | **Ano** (můžete mít mnoho rozhraní) | **Ne** (můžete dědit jen z jedné třídy) |
| **Proměnné (Fields)** | Nemůže mít pole (pouze vlastnosti) | Může mít klasické proměnné a stavy |
| **Logika** | Tradičně jen definice (viz C# 8+) | Může obsahovat kompletní kód |

**Co je populárnější?**
V moderním programování (zejména u webových aplikací a velkých systémů) jsou **Interfaces mnohem populárnější**. Umožňují totiž tzv. *volnou vazbu* (loose coupling), což usnadňuje testování kódu a výměnu částí programu bez nutnosti přepisovat zbytek aplikace.


**Představte si:**

- programujete e-shop, který zákazníkům posílá aktuální nabídky o slevněných produktech
- definujete rozhraní `IMessageService`, které bude definovat schopnost posílat zprávu uživateli
- definujete `SmsService`, který implementuje `IMessageService`
Kdekoliv budeme pracovat se zprávami budeme vyžadovat `IMessageService`(ne `SmsService`). Jakmile bychom se rozhodli, že chceme místo SMS posílat emaily, stačí vytvořit třídu `EmailService`, která implementuje `IMessageService` a pouze nahradit vytvoření `SmsService` za `EmailService`.


# Vícenásobná implementace

V C# nemůžete dědit z více tříd najednou (např. třída `Auto` nemůže dědit zároveň ze `Stroj` a `DopravniProstredek`). U rozhraní to ale jde bez problémů.

```csharp
public interface IFlashlight
{
    void ToggleLight();
}

public interface IPhone
{
    void MakeCall(string number);
}

// Smartphone implementuje obě rozhraní
public class Smartphone : IPhone, IFlashlight
{
    public void MakeCall(string number) => Console.WriteLine($"Calling {number}");
    public void ToggleLight() => Console.WriteLine("Light toggled!");
}

```

# Výchozí implementace (C# 8+)

Od verze C# 8.0 může mít rozhraní i tzv. **default implementation**. To je užitečné, když přidáváte novou metodu do existujícího rozhraní a nechcete rozbít všechny třídy, které ho už používají.

```csharp
public interface ILogger
{
    void Log(string message);

    // Výchozí tělo metody - třídy ji nemusí implementovat, pokud nechtějí
    void LogError(string error)
    {
        Log($"ERROR: {error}");
    }
}

```

\clearpage
# Úkol k procvičení: Notifikační systém

Vytvořte systém, který dokáže odesílat zprávy různými kanály.

1. **Interface `IMessageService`**:
* Metoda `void SendMessage(string target, string message)`.


2. **Třída `SmsService`**:
* Implementuje rozhraní, vypíše: "Sending SMS to {target}: {message}".


3. **Třída `EmailService`**:
* Implementuje rozhraní, vypíše: "Sending Email to {target}: {message}".


4. **Třída `NotificationManager`**:
* Bude mít statickou metodu `NotifyAll(List<IMessageService> services, string msg)`.
* Tato metoda projde seznam služeb a každou z nich použije k odeslání zprávy.

```csharp
class NotificationManager
{
    public static void NotifyAll(
        List<IMessageService> services,
        string target,
        string message)
    {
        // TODO: tady implementujte cyklus pro zavolání metody SendMessage na všech services
    }
}

```


**V Program.cs:**
Vytvořte seznam služeb, přidejte do něj jednu instanci `SmsService` a jednu `EmailService`. Poté pomocí manažera odešlete testovací zprávu "Ahoj, toto je test!".

Mělo by to vypadat asi takto:


```csharp
var services = new List<IMessageService>{
    new EmailService(),
    new SmsService()
};

NotificationManager.NotifyAll(services, "David", "Hello to everyone!");
```

