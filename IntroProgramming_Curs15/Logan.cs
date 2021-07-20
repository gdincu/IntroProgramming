using System;
using System.Collections.Generic;
using System.Text;

namespace IntroProgramming_Curs15
{
    public class Logan : ICar
    {
        public int Age { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }

        public void Build()
        {
            Console.WriteLine("Building a Logan");
        }

        public void BuildWheel()
        {
            Console.WriteLine("Building a Logan wheel");
        }

        public void Paint()
        {
            Console.WriteLine("Painting a Logan");
        }
    }
}
