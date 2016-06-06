using System;

namespace InterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // On start, show a menu of functions
            // This console is purely for ease of use.

            string input = string.Empty;
            while (true)
            {
                Console.WriteLine("Select an exercise by number:\n\t1. Multiplier");
                input = Console.ReadLine();
                int result;

                if (input.ToLower() == "exit")
                {
                    break;
                }

                while (!int.TryParse(input, out result) || result < 1 || result > 1)
                {
                    Console.WriteLine("Enter a number between 1 and 1:");
                    input = Console.ReadLine();
                }

                switch (result)
                {
                    case 1:
                        Multiplier.Execute();
                        break;
                }
            }
        }
    }

    // Provide a method which multiplies two values without using loops, 
    // the multiply operator, or divide operator.
    public static class Multiplier
    {
        public static void Execute()
        {
            long var1, var2;

            Console.WriteLine("\n*** BEGIN MULTIPLIER ***");
            Console.WriteLine("Enter first input:");
            string line1 = Console.ReadLine();

            while (!long.TryParse(line1, out var1))
            {
                Console.WriteLine("Enter a valid number for first input:");
                line1 = Console.ReadLine();
            }

            Console.WriteLine("Enter second input:");
            string line2 = Console.ReadLine();

            while (!long.TryParse(line2, out var2))
            {
                Console.WriteLine("Enter a valid number for second input:");
                line2 = Console.ReadLine();
            }

            var result = Multiply(var1, var2);

            Console.WriteLine(string.Format("{0} x {1} = {2}", var1, var2, result));
            Console.WriteLine("*** END MULTIPLIER ***\n");
        }

        // Uses recursion to sum the value of x for y times.
        public static long Multiply(long x, long y)
        {
            // If either number is 0, stop recursion.
            // Also handles the scenario where the initial inputs contain a zero.
            if (x == 0 || y == 0)
            {
                return 0;
            }

            // y is essentially the counter. If it is positive, count down to 
            // zero (y - 1). Otherwise count up to zero (y + 1). This logic has one problem: 
            // if we treat y as a counter, it loses it's negativity during summation. Add
            // back the negativity by subtracting x recursively (instead of using addition).
            return y > 0 ? Multiply(x, y - 1) + x : Multiply(x, y + 1) - x;
        }
    }
}

