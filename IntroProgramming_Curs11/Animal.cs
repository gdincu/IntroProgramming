using System;
using System.Collections.Generic;
using System.Text;

namespace IntroProgramming_Curs11
{
    class Animal
    {
        public Animal()
        {
            this.numberOfLegs = 4;
        }

        private int numberOfLegs;

        private void Sound ()
        {
            Console.WriteLine("Sound");
        }

        public void MakesSound()
        {
            Sound();
        }
    }
}
