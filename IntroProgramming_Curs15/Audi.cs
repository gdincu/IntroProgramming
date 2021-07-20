using System;
using System.Collections.Generic;
using System.Text;

namespace IntroProgramming_Curs15
{
    public class Audi : ICar
    {
        public int Age { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }

        public void Build()
        {
            Console.WriteLine("Building an Audi");
        }

        public void BuildWheel()
        {
            Console.WriteLine("Building an Audi wheel");
        }

        public void Paint()
        {
            Console.WriteLine("Painting an Audi");
        }
    }
}
