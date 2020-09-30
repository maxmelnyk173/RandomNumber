using System;

namespace GuessNumber
{
    public class RandomNumber
    {
        private static readonly Random random = new Random();

        private int RndNumber { get; }

        public RandomNumber(int range)
        {
            RndNumber = random.Next(range);
        }

        public int MatchToRandomNumber(int userNumber)
        {
            if (this.RndNumber == userNumber)
            {
                return 0;
            }
            else if (this.RndNumber > userNumber)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
