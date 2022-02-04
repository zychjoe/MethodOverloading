using System;

namespace MehodOverloading
{
    class Program
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool money)
        {
            int sum = a + b;
            if (sum == 1)
            {
                return money ? $"{sum} dollar" : $"{sum}";
            }
            else
            {
                return money ? $"{sum} dollars" : $"{sum}";
            }
        }


        static void Main(string[] args)
        {
            int answer1 = Add(1, 2);
            decimal answer2 = Add(4.0m, 5.0m);
            string answer3A = Add(1, 0, true);
            string answer3B = Add(1, 0, false);
            string answer3C = Add(1, 3, true);
            string answer3D = Add(1, 3, false);

            Console.WriteLine($"2 + 3 = {answer1}, 4 + 5 = {answer2}");
            Console.WriteLine($"$1 + $0 = {answer3A}");
            Console.WriteLine($"1 + 0 = {answer3B}");
            Console.WriteLine($"$1 + $3 = {answer3C}");
            Console.WriteLine($"1 + 3 = {answer3D}");
        }
    }
}
