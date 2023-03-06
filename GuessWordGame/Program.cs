namespace GuessWordGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretKey = "Alireza";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (secretKey != guess && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter Word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine("you lose");
            }
            else
            {
                Console.WriteLine("you win");
            }
        }
    }
}