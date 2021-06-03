using System;

namespace IntroProgramming_Curs4
{
    class Program
    {
        static int MethodA(int a, int b = 0)
        {
            return a;
        }

        static int MethodA(int a)
        {
            return a;
        }

        static bool MethodBTrue()
        {
            return true;
        }

        static bool MethodBFalse()
        {
            return false;
        }

        static public long Factorial(int n)
        {
            if (n == 0)
                return 1;
            long value = 1;
            for (int i = n; i > 0; i--)
            {
                value *= i;
            }
            return value;
        }

        static public long FactorialRecursive(int n)
        {
            if (n == 0)//The condition that limites the method for calling itself
                return 1;
            return n * FactorialRecursive(n - 1);
        }


        static void Main(string[] args)
        {
            //Method overloading and optional parameters
            int a = MethodA(3,5);

            //Logical AND / OR vs AND / OR
            if (MethodBFalse() & MethodBTrue())
                Console.WriteLine("1");

            if (MethodBFalse() && MethodBTrue())
                Console.WriteLine("1");

            if (MethodBFalse() | MethodBTrue())
                Console.WriteLine("1");

            if (MethodBFalse() || MethodBTrue())
                Console.WriteLine("1");

            //Basic recursivity
            Console.WriteLine(Factorial(5));
            Console.WriteLine(FactorialRecursive(5));

            Console.ReadKey();
        }
    }
}
