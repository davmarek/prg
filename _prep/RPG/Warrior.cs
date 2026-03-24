class Warrior : Character, IBlockable
{
    public string WeaponName { get; set; }
    public Warrior(string name, int health, int level, string weaponName) : base(name, health, level)
    {
        WeaponName = weaponName;
    }

    public override void Attack(Entity target)
    {
        target.TakeDamage(Level * 8);
    }


    public bool Block()
    {
        return Random.Shared.Next(100) < 40;
    }



}
