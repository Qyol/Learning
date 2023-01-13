namespace IfStatements2
{
    internal class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "George";
        static void Main(string[] args)
        {
            Check(250, "Dimitris");
            Check(315, "Alex");
            Check(350, "George");
        }
        public static void Check(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore= score;
                highscorePlayer= playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }else
            {
                Console.WriteLine("The old highscore could not be broken. It is still " + highscore + " and held by " + highscorePlayer);
            }
        }
    }
}