using System;

namespace IntroProgramming_Curs11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student A = new Student();
            //A.age = 3;
            A.name = "Student A";
            Console.WriteLine("The average for student " + A.name + " is: " + A.returnAverage(A));

            Animal B = new Animal();
            //Console.WriteLine("Number of legs: " + B.numberOfLegs);
            //B.Sound();
            B.MakesSound();

            int valueToChange = 5;
            Console.WriteLine("Int value before being altered: " + valueToChange);
            A.AlterValueByRef(ref valueToChange);
            Console.WriteLine("Int value after AlterValueByRef: " + valueToChange);
            A.AlterValue(valueToChange);
            Console.WriteLine("Int value after AlterValue: " + valueToChange);



        }
    }
}
