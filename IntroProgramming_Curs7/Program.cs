using System;
using System.Collections.Generic;

namespace IntroProgramming_Curs7
{
    class Program
    {
        //    - define a method DisplayElements that will:
        //     -receive a list of integers and a boolean value useForeach
        //    - parse the list of integers using for or foreach as dictated by the boolean parameter
        //    - output the elements from the integer list
        static void DisplayElements(List<int> listInt, bool useForeach)
        {
            Console.WriteLine();

            if (useForeach)
            {
                foreach (var item in listInt)
                {
                    Console.Write(item + " ");
                }
                return;
            }

            for (int i = 0; i < listInt.Count; i++)
            {
                Console.Write(listInt[i] + " ");
            }
        }

        //- define a method DisplayEvenNumbers that will:
        //    -receive a list of integers
        //    - parse the list and output only the even numbers from the list (use % operator to check for even numbers)
        static void DisplayEvenNumbers(List<int> listInt)
        {
            Console.WriteLine();

            foreach (var item in listInt) { 
                if (item % 2 == 0) { 
                    Console.Write(item + " ");
                }
            }
        }

        //  Define and call a method ParseString that will:
        //  -receive the string as input
        //  - parse the list using a for block and output the characters to the user
        static void ParseString(string s)
        {
            Console.WriteLine();

            for (int i = 0; i < s.Length; i++) { 
                Console.Write(s[i] + " ");
            }
        }

        //- define and call a method ReverseNumber that will:
        //    -receive a number(bigger than 1000)
        //    - display the digits of the number to console
        //    - create the reversed - number from the one received as parameter and return the value of it
        //      - ex: for number 3679236 the method will display 3, 6, 7, 9, 2, 3, 6 and will return 6329763
        static int ReverseNumber(int n)
        {
            Console.WriteLine();

            var tempInt = new List<int>();

            while (n > 0)
            {
                tempInt.Add(n % 10);
                n /= 10;
            }

            tempInt.Reverse();

            int resFinal = 0;

            for (int i = 0; i < tempInt.Count; i++) 
            { 
                resFinal += (tempInt[i] * ToThePowerOf(10, i));
            }

            for (int i = 0; i < tempInt.Count-1; i++)
            { 
                Console.Write(tempInt[i] + ",");
            }
            Console.Write(tempInt[tempInt.Count-1]);

            return resFinal;
        }

        //Method to raise x to the power of y - to avoid using Math.Pow()
        static int ToThePowerOf(int x,int y)
        {
            int resFinal = 1;

            for (int i = 0; i < y; i++) 
            { 
                resFinal *= x;
            }

            return resFinal;
        }

        static void Main(string[] args)
        {
            //  Create a program(console application) in which you will:
            //  Define and initialize a list of integers with the following values: 7, 2, 6, 9, 3, 4, 10
            var listInt = new List<int>() { 7, 2, 6, 9, 3, 4, 10 };
            //  Call the above method (DisplayElements) twice using the integers list and true respectively false for the boolean parameter
            DisplayElements(listInt, true);
            DisplayElements(listInt, false);
            //  Call the above method (DisplayEvenNumbers)
            DisplayEvenNumbers(listInt);
            //  Define a string value and fill it with the following: "The quick brown fox."
            string tempString = "The quick brown fox.";
            //  Call the above method (ParseString)
            ParseString(tempString);
            //  Call the above method (ReverseNumber)
            Console.Write("\nThe reversed number is: " + ReverseNumber(706352800));
            Console.Write("\nThe reversed number is: " + ReverseNumber(654654));
            Console.Write("\nThe reversed number is: " + ReverseNumber(789468123));
            Console.Write("\nThe reversed number is: " + ReverseNumber(889955));

            Console.ReadKey();
        }
    }
}
