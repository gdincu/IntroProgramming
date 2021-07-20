using System;

namespace IntroProgramming_Curs15
{
    public class Program
    {
        public static void TestMethod(ICar car)
        {
            car.BuildWheel();
            car.Build();
            car.Paint();
        }

        static void Main(string[] args)
        {
            Logan logan = new Logan();
            logan.Color = "Red";
            logan.Age = 5;

            Audi audi = new Audi();
            audi.Color = "Blue";
            audi.Age = 1;

            TestMethod(logan);
            TestMethod(audi);


            Console.ReadKey();
        }
    }
}
