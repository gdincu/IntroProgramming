using System;
using System.Collections.Generic;
using System.Text;

namespace IntroProgramming_Curs14
{
    public abstract class Abstract
    {
        public int AbstractInt { get; set; }

        public void OutputMethod()
        {
            Console.WriteLine("Abstract class method");
        }

        public void AbstractEmptyMethod() { }

    }
}
