using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgramming_Curs1
{
    class Program
    {
        //Nullable type
        public static void Metoda(int? tempInt)
        {
            Console.WriteLine(tempInt.HasValue ? tempInt.ToString() : "NULL");
        }

        //Optional parameter
        public static void Metoda(int tempInt = 10)
        {
            Console.WriteLine(tempInt.ToString());
        }

        static void Main(string[] args)
        {
            Metoda(null);
            Metoda(1);
            Metoda();

            sbyte tSbyte = sbyte.MaxValue;
            byte tByte = byte.MinValue;
 
            Console.ReadKey();

        }
    }
}
