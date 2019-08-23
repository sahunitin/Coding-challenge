using System;
using System.Collections.Generic;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            string input = Console.ReadLine();
            int value;
            if(int.TryParse(input, out value))
            {
                Console.WriteLine("Result: {0}", Solution(value));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("input invalid");
            }
        }

        private static int Solution(int N)
        {
            String output = Convert.ToString(N, 2).TrimStart('0').TrimEnd('0');
            char[] array = output.ToCharArray();
            if (array.Length <= 1) return 0;
            int initialIndex = 0;
            List<int> length = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    length.Add(i - initialIndex - 1);
                    initialIndex = i;
                }

            }
            length.Sort();
            return length[length.Count - 1];
        }

    }
}
