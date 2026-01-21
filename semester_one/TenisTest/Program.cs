class Program
{
    static void Main()
    {
        int bodyA = 0;
        int bodyB = 0;
        int gemyA = 0;
        int gemyB = 0;
        int setyA = 0;
        int setyB = 0;

        while (setyA < 2 && setyB < 2)
        {
            Console.Clear();
            Console.WriteLine("SETY: " + setyA + " - " + setyB);
            Console.WriteLine("GEMY: " + gemyA + " - " + gemyB);
            Console.WriteLine("BODY: " + PrevedBody(bodyA) + " - " + PrevedBody(bodyB));
            Console.WriteLine();
            Console.Write("Kdo získal bod? (a/b): ");
            string vstup = Console.ReadLine();

            if (vstup == "a")
            {
                bodyA = bodyA + 1;
            }
            else if (vstup == "b")
            {
                bodyB = bodyB + 1;
            }
            else
            {
                Console.WriteLine("Špatný vstup! napiš jen 'a' nebo 'b'");
                Console.ReadKey();
                continue;
            }

            if (bodyA >= 4 && bodyA - bodyB >= 2)
            {
                gemyA = gemyA + 1;
                bodyA = 0;
                bodyB = 0;
                Console.WriteLine("Hráč A vyhrál game!");
                Console.ReadKey();
            }
            else if (bodyB >= 4 && bodyB - bodyA >= 2)
            {
                gemyB = gemyB + 1;
                bodyA = 0;
                bodyB = 0;
                Console.WriteLine("Hráč B vyhrál game!");
                Console.ReadKey();
            }

            if (gemyA == 6)
            {
                setyA = setyA + 1;
                gemyA = 0;
                gemyB = 0;
                Console.WriteLine("Hráč A vyhrál set!");
                Console.ReadKey();
            }
            else if (gemyB == 6)
            {
                setyB = setyB + 1;
                gemyA = 0;
                gemyB = 0;
                Console.WriteLine("Hráč B vyhrál set!");
                Console.ReadKey();
            }
        }

        Console.Clear();
        if (setyA > setyB)
        {
            Console.WriteLine("Hráč A vyhrál zápas!");
        }
        else
        {
            Console.WriteLine("Hráč B vyhrál zápas!");
        }

        Console.WriteLine("Konec hry.");
    }

    static string PrevedBody(int body)
    {
        if (body == 0) return "0";
        if (body == 1) return "15";
        if (body == 2) return "30";
        if (body == 3) return "40";
        return "";
    }
}
