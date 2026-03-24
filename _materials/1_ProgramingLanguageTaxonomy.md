---
title: "**Dělení programovacích jazyků**"
author: "David Marek"
geometry: margin=2cm
fontsize: 11pt
---

# Úvod do klasifikace jazyků

Programovacích jazyků existují stovky. Abychom se v nich vyznali, dělíme je do kategorií podle toho, jakým způsobem zpracovávají kód, jak pracují s pamětí nebo jak přistupují k datovým typům.

# 1. Kompilované vs. Interpretované jazyky

Tento rozdíl určuje, **kdy a jak** se váš zdrojový kód (text) mění na instrukce, kterým rozumí procesor (strojový kód).

### Kompilované jazyky (Compiled)

Před spuštěním programu musí proběhnout proces zvaný **kompilace**. Speciální program (kompilátor) vezme celý váš kód a vytvoří z něj spustitelný soubor (např. `.exe` ve Windows).

* **Příklady:** C++, Rust, Go.
* **Výhody:** Velmi vysoká rychlost běhu, kontrola chyb před spuštěním.
* **Nevýhody:** Delší vývoj (při každé změně se musí znovu kompilovat), závislost na operačním systému (pro každý OS musíme zkompilovat jednu verzi programu).

### Interpretované jazyky (Interpreted)

Kód se nepřekládá dopředu. Místo toho existuje program (interpret), který čte váš kód **řádek po řádku** a rovnou ho vykonává.

* **Příklady:** Python, JavaScript, PHP.
* **Výhody:** Rychlý vývoj, kód je snadno přenositelný mezi systémy.
* **Nevýhody:** Pomalejší běh (interpretace ubírá výkon), chyby se často objeví až ve chvíli, kdy program běží.

| Vlastnost | Kompilované | Interpretované |
| --- | --- | --- |
| **Rychlost** | Vysoká | Nižší |
| **Kdy se hledají chyby** | Při překladu (před spuštěním) | Za běhu programu |
| **Výstup** | Binární soubor (.exe, .bin) | Zdrojový kód (.py, .js) |

\clearpage
# 2. Statické vs. Dynamické linkování

Linkování (propojování) řeší otázku, jak program využívá **knihovny** (předpřipravený kód někoho jiného, např. pro kreslení oken nebo matematické výpočty).

### Statické linkování

Všechny potřebné knihovny se "přibalí" přímo do vašeho výsledného souboru `.exe`.

* **Výhoda:** Program je samostatný. Stačí jeden soubor a vše funguje.
* **Nevýhoda:** Výsledný soubor je velký a pokud se v knihovně opraví chyba, musíte svůj program znovu zkompilovat.

> Při běhu programu se také musí do operační paměti načíst kromě samotného programu i všechny přibalené knihovny. Pokud více programů využívá stejnou knihovnu a jsou staticky linkované, nemohou knihovnu mezi sebou sdílet.

### Dynamické linkování

Program si knihovny nepřibaluje. Pouze si do nich uloží "odkaz". Knihovny jsou v systému uloženy jako samostatné soubory (např. `.dll` ve Windows nebo `.so` v Linuxu).

* **Výhoda:** Menší velikost programu, více programů může sdílet jednu knihovnu v paměti.
* **Nevýhoda:** Pokud v počítači chybí potřebná `.dll` knihovna, program se nespustí.

# 3. Statické vs. Dynamické typování

Tato kategorie určuje, jak jazyk pracuje s **datovými typy** (čísla, texty, boolean). 

### Staticky typované jazyky

Typ proměnné musíte určit (nebo je pevně dán) už **při psaní kódu**. Pokud řeknete, že proměnná `vek` je celé číslo, nemůžete do ní později uložit text.

* **Příklad (C#):** `int vek = 20;`
* **Výhoda:** Programátor dělá méně chyb, IDE (editor) lépe napovídá.
* **Nevýhoda:** Vývoj může být pomalejší, kvůli potřebě řešit datové typy.

### Dynamicky typované jazyky

Typ proměnné se určí až **za běhu** podle toho, co do ní zrovna vložíte. Jedna proměnná může být chvíli číslo a chvíli text.

* **Příklad (Python):** `vek = 20` ... o kousek dál ... `vek = "dvacet"` (toto projde).
* **Výhoda:** Rychlejší psaní kódu, méně "zbytečného" textu.
* **Nevýhoda:** Snadno vzniknou skryté chyby (např. se pokusíte sečíst číslo s textem).

# Shrnutí pro rychlé opakování

**Zapamatujte si:**

1. **Kompilace** je překlad celého balíku naráz, **interpretace** je čtení za pochodu.
2. **Statické linkování** bere vše s sebou, **dynamické** se spoléhá na externí soubory.
3. **Statické typování** vyžaduje disciplínu v typech, **dynamické** dává volnost, ale riskuje chyby.

