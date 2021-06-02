using System;
using System.Linq;

namespace IntroProgramming_Curs3
{
    class Program
    {
        static void Main(string[] args)
        {
            int requestNumberFromUser(string MessageToBeDisplayed)
            {
                Console.Write(MessageToBeDisplayed);
                return Int32.Parse(Console.ReadLine());
            }

            //  Create and call a method in which you will:
            void returnTriangleTypeAndMinMaxSides()
            {
                //  request 3 numbers from the user which will represent the sides of a triangle
                //	store the three numbers in corresponding variables(e.g.SideA, SideB and SideC)
                int SideA = requestNumberFromUser("1)\nSide A length: ");
                int SideB = requestNumberFromUser("Side B length: ");
                int SideC = requestNumberFromUser("Side C length: ");

                //Testing whether the values provided can form a triangle - based on the Triangle Inequality Theorem
                while (
                    SideA + SideB < SideC ||
                    SideB + SideC < SideA ||
                    SideA + SideC < SideB
                    )
                {
                    SideA = requestNumberFromUser("1)\nSide A length: ");
                    SideB = requestNumberFromUser("Side B length: ");
                    SideC = requestNumberFromUser("Side C length: ");
                }

                //	determine the triangle type and output it to the user:
                //  if all sides have different values: ordinary triangle
                //  if two sizes are equal: isosceles triangle
                //  if all sizes are equal: equilateral triangle
                Console.Write("Type of triangle: ");
                if ((3 * SideA) == (SideA + SideB + SideC))
                    Console.Write("Equilateral");
                else if ((SideA == SideB && SideB != SideC) || (SideB == SideC && SideB != SideA) || (SideA == SideC && SideB != SideA))
                    Console.Write("Isosceles");
                else
                    Console.Write("Ordinary");

                //	write the value of the smallest triangle side
                //	write the value of the largest triangle side
                int[] Sides = { SideA, SideB, SideC };
                //Smallest side length
                Console.Write("\nSmallest triangle side value: " + Sides.Min());
                //Largest triangle side
                Console.Write("\nLargest triangle side value: " + Sides.Max());

                //	check the behavior of the method using different values from the user
            }

            //Create and call a method in which you will:
            void numberCheck()
            {
                //  request one number from the user(between 4 and 8)
                //	store that number in a variable
                int TempNumber = requestNumberFromUser("\n\n2)\nTempNumber: ");
                while (TempNumber < 4 || TempNumber > 8)
                    TempNumber = requestNumberFromUser("Try again! Needs to be between 4 and 8!\nTempNumber: ");

                //	check if the number if even or odd and display a message according to this
                Console.Write(TempNumber + " is ");
                Console.Write(TempNumber % 2 == 0 ? "even" : "odd");

                //	write the letter representation of the number based on the value(e.g. 4->four) so that all the cases are covered
                //  perform the checks using one or more if blocks
                //  perform the checks using one switch block
                Console.Write("\nUsing one switch block - " + TempNumber + " = ");
                switch (TempNumber)
                {
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    default:
                        break;
                }

                Console.Write("\nUsing one or more if blocks - " + TempNumber + " = ");
                if (TempNumber == 4)
                    Console.Write("four");
                else if (TempNumber == 5)
                    Console.Write("five");
                else if (TempNumber == 6)
                    Console.Write("six");
                else if (TempNumber == 7)
                    Console.Write("seven");
                else
                    Console.Write("eight");

            }

            //Create and call a method in which you will:
            void decimalOperation()
            {
                //  request two decimal values from the user and one operator (+, -, *,/)
                //	store the values in some variables
                Console.Write("\n\n3)\nDecimal 1: ");
                decimal TempDecimal1 = Decimal.Parse(Console.ReadLine());

                Console.Write("Decimal 2: ");
                decimal TempDecimal2 = Decimal.Parse(Console.ReadLine());

                Console.Write(@"Operator( +, -, *,/): ");
                string TempOperator = Console.ReadLine();

                //If the input operator is different than the 4 above mentioned, output the message 'Invalid operator'
                string[] PossibleOperators = { "+", "-", "/", "*" };
                while (!PossibleOperators.Any(p => p.Equals(TempOperator)))
                {
                    Console.Write("Try again! Operator should be one of the following ( +, -, *,/): ");
                    TempOperator = Console.ReadLine();
                }

                //	write the result after performing the operation between the 2 decimal values using the input operator
                //		e.g.: input: 2.5,  2.0 and * => output: 5.0
                Console.Write("Result: " + TempDecimal1 + TempOperator + TempDecimal2 + " = ");
                switch (TempOperator)
                {
                    case "+":
                        Console.Write(TempDecimal1 + TempDecimal2);
                        break;
                    case "-":
                        Console.Write(TempDecimal1 - TempDecimal2);
                        break;
                    case "/":
                        Console.Write(TempDecimal1 / TempDecimal2);
                        break;
                    case "*":
                        Console.Write(TempDecimal1 * TempDecimal2);
                        break;
                }
            }

            //Create and call a method in which you will:
            void twoDigitsIntegerCheck()
            {
                // request a 2 digits integer number
                // store that number in a variable
                int TempValue = requestNumberFromUser("\n\n4)\nTwo digits integer: ");
                while (TempValue < 10 || TempValue > 99)
                {
                    Console.Write("Value needs to be > 10. Please try again!");
                    TempValue = requestNumberFromUser("Two digits integer: ");
                }

                //	check whether the number contains digit 6 in it and display a proper message for this
                //e.g.: input: 56 => output: "Number contains digit 6"
                //		e.g.: input 22 => output: "Number does not contain digit 6"
                if (TempValue % 10 == 6 || TempValue / 10 == 6)
                    Console.WriteLine("Number contains digit 6");
                else
                    Console.WriteLine("Number does not contain digit 6");
            }

            returnTriangleTypeAndMinMaxSides();
            numberCheck();
            decimalOperation();
            twoDigitsIntegerCheck();

            Console.ReadKey();
        }
    }
}
