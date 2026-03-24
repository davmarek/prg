abstract class Entity
{
    public string Name { get; init; }
    public int Health { get; private set; }
    public bool IsAlive
    {
        get
        {
            return Health > 0;
        }
    }

    protected Entity(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack(Entity target);


    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} took {damage} damage. HP remaining {Health}");
    }

}
