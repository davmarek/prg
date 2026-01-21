// NOTE: Change this Accoring to your liking
const int LEVELS = 10;
// WARNING: Keep this as is!
const int LAST_WIDTH = 2 * LEVELS - 1;

for (int i = 0; i < LEVELS; i++)
{
    int current_level_width = 2 * i + 1;
    int padding_width = (LAST_WIDTH - current_level_width) / 2;

    for (int j = 0; j < padding_width; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < current_level_width; j++)
    {
        if (j % 2 == 0)
            Console.Write("*");
        else
            Console.Write(" ");
    }

    Console.WriteLine();
}
