using System;

namespace OOP4LabaUtils
{
    class Utils
    {
        public static int Greater(int a, int b)
        { return (a > b ? a : b); } // if a > b returns a, returns b otherwise
        
        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        public static bool Factorial(in int n, out int answer)
        {
            answer = 1;
            try
            {
                if (n < 0)
                    throw new ArgumentOutOfRangeException("factorial can't be taken from a negative number");
                for (int i = 2; i <= n; i++)
                    answer *= i;
                return true;
            }
            catch (ArgumentOutOfRangeException negative_number)
            {
                Console.WriteLine("Error: {0} \nStack: {1}", negative_number.Message, negative_number.StackTrace);
                return false;
            }
        }

        public static bool RecursiveFactorial(in int n, out int answer)
        {
            answer = n;
            try
            {
                if (n < 0)
                    throw new ArgumentOutOfRangeException("factorial can't be taken from a negative number");
                else if (n <= 1)
                    answer = 1;
                else
                {
                    int sub_answer;
                    if (RecursiveFactorial(n - 1, out sub_answer))
                        answer *= sub_answer;
                }
                return true; // true if n = 0 and if n = 1
            }
            catch (ArgumentOutOfRangeException negative_number)
            {
                Console.WriteLine("Error: {0} \nStack: {1}", negative_number.Message, negative_number.StackTrace);
                return false;
            }
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            int x, y, greater;
            Console.WriteLine("Please, enter first integer number for comparison");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter second integer number for comparison");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("You've entered numbers: {0}, {1}", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("The result of swap: {0}, {1}", x, y);
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater number is: {0}", greater);
            Console.WriteLine("Please, enter the integer positive number for calculation the factorial");
            x = int.Parse(Console.ReadLine());
            if (Utils.Factorial(x, out y))
                Console.WriteLine(" {0}! = {1}", x, y);
            Console.WriteLine("Please, enter the integer positive number for calculation the factorial");
            x = int.Parse(Console.ReadLine());
            if (Utils.RecursiveFactorial(x, out y))
                Console.WriteLine(" {0}! = {1}", x, y);
        }
    }

}
