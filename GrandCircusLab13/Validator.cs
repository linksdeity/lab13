using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GrandCircusLab13
{
    class Validator
    {

        public string GetString(string message, string regExpect)
        {
            //verify that a string is formatted as expected

            while (true)

            {
                Console.WriteLine(message);

                string words = Console.ReadLine();

                if (Regex.IsMatch(words, regExpect))
                {
                    return words;

                }
                else
                {
                    continue;
                }
            }
        }


        public int GetNumber(string message, int minValue, int maxValue)
        {
            //verify input is a number and within boundaries
            while (true)

            {
                Console.WriteLine(message);

                int number;

                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number, no letters or symbols!");
                    continue;
                }

                if (number < minValue || number > maxValue)
                {
                    continue;
                }
                else
                {
                    return number;
                }
            }

        }
    }
}
