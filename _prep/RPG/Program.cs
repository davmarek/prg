class Program
{
    public static void Main()
    {
        // Create player and enemies
        Warrior player = new Warrior("Thorin", 100, 2, "Fire Sword");
        List<Enemy> enemies = [new Goblin("Goblinion", 40), new Dragon("Dragonus", 120)];

        // Fight each enemy
        foreach (var enemy in enemies)
        {
            Console.WriteLine("======================");
            Console.WriteLine($"Starting a fight: {player.Name} vs. {enemy.Name}");
            Console.WriteLine("======================");

            // Turn attack as long as both player and enemy live
            while (player.IsAlive && enemy.IsAlive)
            {
                player.Attack(enemy);

                if (!enemy.IsAlive)
                {
                    break;
                }

                // Potentionaly block the enemy
                bool blocked = false;
                if (player is IBlockable blockable)
                {
                    blocked = blockable.Block();
                }

                if (!blocked)
                {
                    enemy.Attack(player);
                }
            }

            if (!player.IsAlive)
            {
                Console.WriteLine("Player died");
                return; // Exit the for each if the player is dead
            }

            Console.WriteLine("Enemy defeated");

            player.LevelUp();

            if (player is IHealable healable)
            {
                healable.Heal();
            }
        }

        Console.WriteLine("All enemies defeated");
    }
}
