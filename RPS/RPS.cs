using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RPS
    {
        public static Random random = new Random();

        public enum ThrowEnum { Rock = 1, Paper = 2, Scissors = 3 };

        public static ThrowEnum ThrowRandom()
        {
            return (ThrowEnum)((random.Next() % 3) + 1);
        }

        public static ThrowEnum ReadThrow(string msg = null)
        {
            ThrowEnum result;
            string line;

            do
            {
                Console.WriteLine(msg ?? $"Pick Rock, Paper or Scissors to play");
                Console.Write(">");

                line = Console.ReadLine();
            }
            while (!Enum.TryParse(line, true, out result));
          
            return result;
        }

        public static int Compare(ThrowEnum t1, ThrowEnum t2)
        {
            if (t1 == t2)
                return 0;   //draw
            else if (((int)t1 % 3) + 1 == (int)t2)
                return 1;   //t2 wins
            else
                return -1;  //t1 wins
        }
    }
}
