List<Enemy> enemies = [
    new Enemy("Goblin" , 80),
    new Enemy("Orc" , 150),
    new Enemy("Troll", 100)
];

Console.WriteLine("Enemies with DifficultyMultiplier 1.0");
PrintEnemies(enemies);

Enemy.SetDifficultyMultiplier(2.0);

Console.WriteLine("Enemies with DifficultyMultiplier 2.0");
PrintEnemies(enemies);

// Helper function for printing info about enemies
void PrintEnemies(List<Enemy> enemies)
{
    foreach (var e in enemies)
    {
        Console.WriteLine($"{e.Id}: {e.Name,-10} ({e.CurrentHealth})");
    }
}
