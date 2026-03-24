class Enemy
{
    private static int _nextId = 1;
    public static double DifficultyMultiplier { get; private set; } = 1.0;


    public int Id { get; }
    public string Name { get; init; }
    public int BaseHealth { get; private set; }

    public double CurrentHealth => BaseHealth * DifficultyMultiplier;

    public Enemy(string name, int baseHealth)
    {
        Name = name;
        BaseHealth = baseHealth;
        Id = _nextId;
        _nextId++;
    }

    public static void SetDifficultyMultiplier(double m)
    {
        DifficultyMultiplier = m;
    }
}

