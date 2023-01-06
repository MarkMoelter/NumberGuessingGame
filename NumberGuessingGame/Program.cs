namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int winNumber = random.Next(0, 100);

            bool win = false;


            do
            {
                Console.WriteLine("Guess a number between 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNumber)
                {
                    Console.WriteLine("Too high! Try again!");
                }
                else if (i < winNumber)
                {
                    Console.WriteLine("Too low! Try again!");
                }
                else if (i == winNumber)
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }

            } while (win == false);
        }
    }
}