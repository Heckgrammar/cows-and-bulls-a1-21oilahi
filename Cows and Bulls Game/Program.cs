using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cows_and_Bulls_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool duplicate = true;
            string ranNum = "0";
            bool valid = true;
            string guess = "0";
            int bulls = 0;
            ranNum = Convert.ToString(rnd.Next(1023, 9877));
            do
            {
                duplicate = false;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i != j)
                        {
                            if (ranNum[i] == ranNum[j])
                            {
                                duplicate = true;
                            }
                        }
                    }
                }
            } while (duplicate == true);
            do
            {
                bulls = 0;
                int cows = 0;
                if (valid == true)
                {
                    Console.WriteLine("Enter a 4 digit number that doesn’t start with 0 and no repeated numbers.");
                    guess = Console.ReadLine();
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i != j)
                        {
                            if (guess[i] == guess[j])
                            {
                                duplicate = true;
                            }
                            else
                            {
                                duplicate = false;
                            }
                        }
                    }
                }
                int numGuess = Convert.ToInt32(guess);
                if (duplicate == true || numGuess > 9876 || numGuess < 1023)
                {
                    valid = false;
                    Console.WriteLine("Enter a 4 digit number that doesn’t start with 0 and no repeated numbers again.");
                    guess = Console.ReadLine();
                }
                else if (duplicate == false && numGuess > 1022 && numGuess < 9877)
                {
                    valid = true;
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (guess[i] == ranNum[j])
                        {
                            cows = cows + 1;
                        }
                        if (guess[i] == ranNum[i])
                        {
                            bulls = bulls + 1;
                        }
                    }
                }
                Console.WriteLine($"Cows: {cows} Bulls: {bulls}");
            } while (bulls < 4);
        }
    }
}
