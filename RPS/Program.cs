using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.RPS;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ThrowEnum userThrows = RPS.ReadThrow();
                Console.WriteLine($"User throws {userThrows.ToString()}");

                ThrowEnum computerThrows = RPS.ThrowRandom();
                Console.WriteLine($"Computer throws {computerThrows.ToString()}");
                
                switch(RPS.Compare(userThrows, computerThrows))
                {
                    case 0: Console.WriteLine($"Draw"); break;
                    case -1: Console.WriteLine($"User Wins"); break;
                    case 1: Console.WriteLine($"Computer Wins"); break;
                }
                
                Console.WriteLine();
            }

        }
    }
}
