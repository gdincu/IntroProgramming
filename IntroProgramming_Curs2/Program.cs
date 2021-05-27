using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgramming_Curs2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program(console application) in which you will: (note: some of the requirements will throw errors, compile or runtime, this is expected so just comment out the code throwing errors but leave it in place)
            
            // -define a constant number PI = 3.14
            const double PI = 3.14;

            // - define three integer numbers: width and height of a rectangle and a circle radius and fill them with some chosen values
            int widthTemp = 3;
            int heightTemp = widthTemp + 2;
            double radiusTemp = 2.5;

            // - request a string variable from the user
            Console.Write("Provide a string: ");
            string stringTemp = Console.ReadLine();

            // -request a float variable from the user (make sure you enter 4 decimal places)
            Console.Write("Provide a float with 4 decimals: ");
            string tempString = Console.ReadLine();

            //Keeps asking for an input until a float value with 4 decimals is provided
            while (!float.TryParse(tempString, out _) ||                //Used to check whether the string provided can be parsed to float
                     !tempString.Contains('.') ||                       //Used to check whether the string provided contains a '.' (as the check above would return true if "1" was the string provided)
                     tempString.Split('.')[1].Length != 4               //Used to check the number of decimals provided
                     ) 
                {
                Console.Write("Ensure the number provided has exactly 4 decimals! Try again: ");
                tempString = Console.ReadLine();
                }

            float floatTemp = float.Parse(tempString);

            // -request a decimal variable from the user (make sure you enter 9 decimal places)
            Console.Write("Provide a decimal with 9 decimals: ");
            tempString = Console.ReadLine();

            //Keeps asking for an input until a decimal value with 9 decimals is provided
            while (!decimal.TryParse(tempString, out _) ||              //Used to check whether the string provided can be parsed to decimal
                     !tempString.Contains('.') ||                       //Used to check whether the string provided contains a '.' (as the check above would return true if "1" was the string provided)
                     tempString.Split('.')[1].Length != 9               //Used to check the number of decimals provided
                     )
            {
                Console.Write("Ensure the number provided has exactly 9 decimals! Try again: ");
                tempString = Console.ReadLine();
            }

            decimal decimalTemp = decimal.Parse(tempString);

            // -swap the values of width and height of the rectangle and display the new values
            Console.Write("Before - Width: " + widthTemp + " Height: " + heightTemp);
            widthTemp += heightTemp;
            heightTemp = widthTemp - heightTemp;
            widthTemp -= heightTemp;
            Console.Write("\nAfter - Width: " + widthTemp + " Height: " + heightTemp);

            // - perform the following operations(each result should be stored in a new variable and displayed):

            // -calculate rectangle area using the width and height of the rectangle
            int rectangleArea = heightTemp * widthTemp;
            Console.Write("\nrectangleArea: " + rectangleArea);

            // -calculate rectangle perimeter using the width and height of the rectangle
            int rectanglePerimeter = 2 * (heightTemp + widthTemp);
            Console.Write("\nrectanglePerimeter: " + rectanglePerimeter);

            // -calculate the circle circumference(formula: 2 x PI x R) using the circle radius
            double circleCircumference = 2 * PI * radiusTemp;
            Console.Write("\ncircleCircumference: " + circleCircumference);

            // -increase the circle radius with 5
            radiusTemp += 5;
            Console.Write("\nradiusTemp: " + radiusTemp);

            // -decrease the rectangle height by 2 in two different consecutive operations
            heightTemp -= 2;
            Console.Write("\nheightTemp after the 1st decrease: " + heightTemp);
            heightTemp = heightTemp - 2;
            Console.Write("\nheightTemp after the 2nd decrease: " + heightTemp);

            // -create a new char variable and cast the string value so that it is stored in the newly created variable
                 //Throws an error when the string provided has a length > 1
                 //char charTemp = char.Parse(stringTemp);
                 //Console.Write("\ncharTemp: " + charTemp);

            // -create a new byte variable and cast any integer defined above value so that it is stored in the newly created variable
                 //Throws an error - explicit conversion required
                 //byte byteTemp = widthTemp;

            // -create a new string variable and use it to store the concatenation of two new string values requested from the user -output the result
            Console.Write("\nString A to be concatenated: ");
            string s1 = Console.ReadLine();
            Console.Write("\nString B to be concatenated: ");
            string s2 = Console.ReadLine();
            string s3 = s1 + s2;
            Console.Write("ConcatenatedString: " + s3);

            // -create a new float variable and cast the decimal value so that it is stored in the newly created variable
            float decimalCastToFloat = (float)decimalTemp;
            Console.Write("\ndecimalCastToFloat: " + decimalCastToFloat);

            // -create a new decimal variable and cast the float value so that it is stored in the newly created variable
            decimal floatCastToDecimal = (decimal)decimalCastToFloat;
            Console.Write("\nfloatCastToDecimal: " + floatCastToDecimal);

            // -create a new decimal variable and cast any integer defined value so that it is stored in the newly created variable
            decimal intCastToDecimal = heightTemp;
            Console.Write("\nintCastToDecimal: " + intCastToDecimal);

            // -create a new decimal variable and use it to store the product of two decimal values(use the one defined twice) -output the value
            decimal productOfTwoDecimals = floatCastToDecimal * intCastToDecimal;
            Console.Write("\n[Decimal] Product of two decimal values: " + productOfTwoDecimals);

            // -create a new float variable and use it to store the product of two decimal values(use the one defined twice) -output the value
                   //Throws an error - explicit conversion required
                   //float floatTemp3 = intCastToDecimal * floatCastToDecimal;
                   //Console.Write("\n[Float] Product of two decimal values: " + floatTemp3);

            // -compare the result of the above two multiplication operations
                    //Throws an error - the equality operator does not work with 2 different data types in this case - should only work for the same data types or where an implicit conversion could be applied eg. 1 == 1.2d
                    // Console.WriteLine("[Decimal-Float] Comparison: " + (productOfTwoDecimals == floatTemp3));

            // -use a conversion method to create a new integer value from the decimal value declared above
            int intFromDecimal = Decimal.ToInt32(productOfTwoDecimals);
            Console.Write("\nintFromDecimal: " + intFromDecimal);

            // -use a conversion method to create a new decimal value using the integer value declared above
            decimal decimalFromInt = Convert.ToDecimal(heightTemp);
            Console.Write("\ndecimalFromInt: " + decimalFromInt);

            //- use a conversion method to create a new string value using the boolean value declared above
            string stringFromBool = true.ToString();
            Console.Write("\nstringFromBool: " + stringFromBool);

            //- use a conversion method to create a new string value using the integer value declared above
            string stringFromInteger = heightTemp.ToString();
            Console.Write("\nstringFromInteger: " + stringFromInteger);

            Console.ReadKey();
        }
    }
}
