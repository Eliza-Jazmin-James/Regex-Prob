Using Regex

using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace SplitAndSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList inputArray = new ArrayList(30);
            Console.WriteLine("Enter the number of integers");
            int numberOfData = Convert.ToInt32(Console.ReadLine());
            string[] stringarr = new string[30];
            for (int i = 0; i < numberOfData; i++)
            {
                stringarr[i] = Console.ReadLine();
            }
            for (int j = 0; j < numberOfData; j++)
            {
                showMatch(stringarr[j], @"\b@gmail.com", inputArray);
            }
           
            inputArray.Sort();
            foreach (var output in inputArray)
            {
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
        private static void showMatch(string text, string expr, ArrayList inputArray)
        {
            MatchCollection mc = Regex.Matches(text, expr);
            if (mc.Count != 0)
            {
                string pattern = @".*?(?=\s)";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(text);
                inputArray.Add(match.ToString());
            }
        }
    }
}
