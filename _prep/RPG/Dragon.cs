class Dragon : Enemy
{
    public Dragon(string name, int health) : base(name, health)
    {
    }

    public override void Attack(Entity target)
    {
        target.TakeDamage(25);
    }

}
