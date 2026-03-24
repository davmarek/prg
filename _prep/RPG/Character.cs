abstract class Character : Entity
{

    public int Level { get; set; }
    public int MaxHealth { get; set; }

    public Character(string name, int health, int level) : base(name, health)
    {
        Level = level;
    }

    public virtual void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} leveled up to {Level}");
    }
}
