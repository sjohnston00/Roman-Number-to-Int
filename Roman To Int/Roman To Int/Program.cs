using System;
using System.Collections.Generic;

namespace Roman_To_Int
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please type a roman number: ");
            string string_RomanNumber = Console.ReadLine();
            if (string_RomanNumber == "exit")
                Environment.Exit(0);

            int RomanNumber = RomanToInt(string_RomanNumber);
            if (RomanNumber != 0)
                Console.WriteLine($"Real Number: {RomanNumber}");

            Console.ReadLine();
            Console.Clear();
            Main(null);
        }

        public static int RomanToInt(string RomanNumber)
        {
            Dictionary<string, int> RomanNumbers = new Dictionary<string, int>()
            {
                { "I", 1 },
                { "IV", 4 },
                { "V", 5 },
                { "IX", 9 },
                { "X", 10 },
                { "XL", 40 },
                { "L", 50 },
                { "XC", 90 },
                { "C", 100 },
                { "CD", 400 },
                { "D", 500 },
                { "CM", 900 },
                { "M", 1000 },
            };
            var sum = 0;
            for (int i = 0; i < RomanNumber.Length; i++)
            {
                var indexString = RomanNumber[i].ToString();
                var TwoSum = indexString + (RomanNumber.Length > i + 1 ? RomanNumber[i + 1].ToString() : indexString);
                if (RomanNumbers.ContainsKey(TwoSum))
                {
                    sum = sum + RomanNumbers[TwoSum];
                    i++;
                }
                else if (RomanNumbers.ContainsKey(indexString))
                {
                    sum = sum + RomanNumbers[indexString];
                }
                else
                {
                    Console.WriteLine("Non roman number");
                    return 0;
                }

            }
            return sum;
        }
    }
}
