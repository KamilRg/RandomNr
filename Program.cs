using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberz
{
    internal class RandomNumberz
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int guess = rnd.Next(1, 11);
            int myNumber;
            int howManyTimes = 0;
            Console.WriteLine("Guess number from 1 to 10");
            do
            {
                howManyTimes++;
                Console.WriteLine("Your number: ");
                myNumber = int.Parse(Console.ReadLine());
                if (myNumber > guess)
                {
                    Console.WriteLine("To high");
                }
                else if (myNumber < guess)
                {
                    Console.WriteLine("To low");
                }
                else
                {
                    Console.WriteLine("Gratz correct! You tried {0} times", howManyTimes);
                }



            } while (guess != myNumber);
        }
    }
}
