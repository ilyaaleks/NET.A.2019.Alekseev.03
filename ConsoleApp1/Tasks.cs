using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp1
{
    ///<summary>Class with tasks</summary>
    public static class Tasks
    {
        ///<summary>method for inserting bits from one number to another</summary>
        ///<param name="numberSource"> First number</param>
        ///<param name="numberin">Second number</param>
        ///<param name="i">Start bit</param>
        ///<param name="j">End bit</param>
        public static int InsertNumber(int numberSource, int numberin, int i, int j)
        {
            if (j < i)
            {
                throw new ArgumentException();
            }
            int bits = j - i + 1;
            uint mask = uint.MaxValue >> (32 - bits);
            Console.WriteLine("Mask: " + Convert.ToString(mask, 2));
            Console.WriteLine($"Second number: {Convert.ToString(numberin, 2)}");
            numberin = numberin & (int)mask;
            Console.WriteLine($"First number: {Convert.ToString(numberSource, 2)}");
            mask = ~(mask << i);
            numberSource = numberSource & (int)mask;
            numberSource = numberSource | (numberin << i);
            return numberSource;
        }
        /// <summary>
        /// Finding the next larger number
        /// </summary>
        /// <param name="number">Number</param>
        public static int FindNextBiggerNumber(string number)
        {
            int i, j;
            char[] charNumbers = number.ToCharArray();
            for (i = charNumbers.Length - 1; i > 0; i--)
            {
                if (charNumbers[i] > charNumbers[i - 1])
                {
                    break;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("No more number");
                return -1;
            }
            int x = charNumbers[i - 1], nSmallestLoc = i;
            for (j = i + 1; j < charNumbers.Length; j++)
            {
                if (charNumbers[j] > x && charNumbers[j] < charNumbers[nSmallestLoc])
                {
                    nSmallestLoc = j;
                }
            }
            Swap(ref charNumbers[nSmallestLoc], ref charNumbers[i - 1]);

            Array.Sort(charNumbers, i - 1, charNumbers.Length - i - 1);
            int Number = Convert.ToInt32(string.Join("", charNumbers));
            return Number;

            void Swap(ref char a, ref char b)
            {
                char temp = a;
                a = b;
                b = temp;
            }
        }
        /// <summary>
        /// Method finding a number with a given digit
        /// </summary>
        /// <param name="numeral">Numeral</param>
        /// <param name="numbers">Number</param>
        public static List<int> FilterDigit(char numeral, string numbers)
        {
            string[] masOfNumbers = numbers.Split(",");
            List<int> numberList = new List<int>();
            foreach (string str in masOfNumbers)
            {
                if (str.Contains(numeral))
                {
                    numberList.Add(Convert.ToInt32(str));

                }
            }
            return numberList;
        }
        /// <summary>
        /// Finding a Newton Root
        /// </summary>
        /// <param name="a">Number</param>
        /// <param name="n">root sign</param>
        /// <param name="eps">precision</param>
        public static double FindNthRoot(double a, uint n, double eps)
        {
            var x0 = a / n;
            var x1 = (1.0 / n) * ((n - 1) * x0 + a / Math.Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) >= eps)
            {
                x0 = x1;
                x1 = (1.0 / n) * ((n - 1) * x0 + a / Math.Pow(x0, (int)n - 1));
            }

            return x1;
        }
    }
}
