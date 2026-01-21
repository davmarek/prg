using System;
using System.Diagnostics;


public class TennisScore
{

    private const int SetsToWinMatch = 2;
    private const int GamesToWinSet = 6;



    private int scoreA = 0;
    private int scoreB = 0;
    private int gamesA = 0;
    private int gamesB = 0;
    private int setsA = 0;
    private int setsB = 0;



    private readonly string[] pointNames = { "0", "15", "30", "40", "A" };


    public void StartMatch()
    {
        Console.Title = "Tenisové Skóre";
        DisplayScore();

        bool matchInProgress = true;



        while (matchInProgress)
        {
            Console.Write("\nKdo získal bod? (A/B, Q pro konec): ");
            string input = Console.ReadLine()?.ToUpper();


            if (input == "Q")
            {
                Console.WriteLine("\nZápas byl ukončen uživatelem.");
                matchInProgress = false;
                continue;
            }



            if (input == "A")
            {
                ProcessPoint(1);
            }
            else if (input == "B")
            {
                ProcessPoint(2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Neplatný vstup. Zadejte 'A', 'B' nebo 'Q'.");
                Console.ResetColor();

                continue;
            }



            Console.Clear();
            DisplayScore();


            if (CheckMatchEnd())
            {
                string winner = setsA > setsB ? "A" : "B";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n*** Konec Zápasu! Vítěz: Hráč {winner} ***");
                Console.ResetColor();
                matchInProgress = false;
            }
        }
    }



    private void ProcessPoint(int winner)
    {
        ref int scorerScore = ref (winner == 1 ? ref scoreA : ref scoreB);
        ref int opponentScore = ref (winner == 1 ? ref scoreB : ref scoreA);





        if (scoreA == 3 && scoreB == 3)
        {

            scorerScore = 4;
            opponentScore = 3;
        }

        else if (scorerScore == 4)
        {

            WinGame(winner);
        }
        else if (opponentScore == 4)
        {

            scorerScore = 3;
            opponentScore = 3;
        }

        else
        {
            scorerScore++;



            if (scorerScore == 4)
            {
                WinGame(winner);
            }
        }
    }



    private void WinGame(int winner)
    {
        if (winner == 1)
        {
            gamesA++;
        }
        else
        {
            gamesB++;
        }



        scoreA = 0;
        scoreB = 0;



        CheckSetEnd();
    }



    private void CheckSetEnd()
    {

        if ((gamesA >= GamesToWinSet || gamesB >= GamesToWinSet) && Math.Abs(gamesA - gamesB) >= 2)
        {
            if (gamesA > gamesB)
            {
                setsA++;
            }
            else
            {
                setsB++;
            }



            gamesA = 0;
            gamesB = 0;
        }
    }



    private bool CheckMatchEnd()
    {
        return setsA == SetsToWinMatch || setsB == SetsToWinMatch;
    }



    private void DisplayScore()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n*** AKTUÁLNÍ SKÓRE ***");
        Console.ResetColor();
        Console.WriteLine($"SETY: {setsA} - {setsB}");
        Console.WriteLine($"GEMY: {gamesA} - {gamesB}");
        Console.WriteLine($"BODY: {GetPointDisplay(scoreA)} - {GetPointDisplay(scoreB)}");
    }



    private string GetPointDisplay(int internalScore)
    {
        if (internalScore >= 0 && internalScore <= 3)
        {
            return pointNames[internalScore];
        }
        else if (internalScore == 4 && (scoreA == 4 || scoreB == 4))
        {

            return pointNames[4];
        }
        return pointNames[0];
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        TennisScore game = new TennisScore();
        game.StartMatch();
    }
}
