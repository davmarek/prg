class Goblin : Enemy
{
    public Goblin(string name, int health) : base(name, health)
    {
    }

    public override void Attack(Entity target)
    {
        target.TakeDamage(8);
    }

}
