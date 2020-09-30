using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumber matchNumber = new RandomNumber(100);

            Console.WriteLine("Please enter your number between 1 and 100");

            do
            {
                int userNumber;

                while (!int.TryParse(Console.ReadLine(), out userNumber))
                {
                    Console.WriteLine("Error: Non-numeric character entered. Please enter a number!");
                }

                var result = matchNumber.MatchToRandomNumber(userNumber);

                if (result == 0)
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    break;
                }
                else if (result == 1)
                {
                    Console.WriteLine("Your number is greater");
                }
                else
                {
                    Console.WriteLine("Your number is less");
                }
            } while (true);
        }
    }
}
