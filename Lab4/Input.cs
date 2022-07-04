using System;

namespace Lab4
{
    internal class Input
    {
        public static int GetNumber(int lower, int upper)
        {
            string answer;
            int number;
            bool incorrectInput;

            do
            {
                incorrectInput = true;
                answer = Console.ReadLine();
                if (int.TryParse(answer, out number) && number > lower && number < upper)
                    incorrectInput = false;
                else
                    Console.WriteLine("Неправильне введення. Спробуйте знову:");
            } while (incorrectInput);

            return number;
        }

        public static decimal GetNumber(decimal lower, decimal upper)
        {
            string answer;
            decimal number;
            bool incorrectInput;

            do
            {
                incorrectInput = true;
                answer = Console.ReadLine();
                if (decimal.TryParse(answer, out number) && number > lower && number < upper)
                    incorrectInput = false;
                else
                    Console.WriteLine("Неправильне введення. Спробуйте знову:");
            } while (incorrectInput);

            return number;
        }
    }
}
