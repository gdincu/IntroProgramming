using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IntroProgramming_Curs5
{
    class car
    {
        public int id { get; set; }
        public int year { get; set; }
        public string name { get; set; }
        public car(int id,int year,string name)
        {
            this.id = id;
            this.year = year;
            this.name = name;
        }
    }

    class Program
    {
        static void PrintIntArray(int[] a,string t)
        {
            Console.Write(t + ": ");
            foreach (int element in a)
                Console.Write(element + " ");
        }

        static void PrintList(List<int>? a,List<char>? b,string t)
        {
            Console.Write(t);
            if(a != null)
                a.ForEach(x => Console.Write(x + " "));
            if (b != null)
                b.ForEach(x => Console.Write(x + " "));
        }

        static void Main(string[] args)
        {
            //  Create a program(console application) in which you will:
            //  -declare an array of size 2
            int[] array1 = new int[2];
            //        - set the first item of the array with value 10 and the second item with value 34
            array1[0] = 10;
            array1[1] = 34;
            PrintIntArray(array1, "Array of size 2");
            //  - output the second element of the array to console
            Console.Write("\nSecond element of the array" + array1[1]);
            // -output the sum of the 2 elements in the array
            Console.Write("\nSum of the 2 elements: " + (array1[0] + array1[1]));
            // -declare another array that has the same elements as the first one(the declaration and assignment of values should be done in one line)
            int[] array2 = new int[] { 10,34};
            PrintIntArray(array2, "\nAnother array with the same elements: ");
            // -define and initialize a list of integers with the following values: 2, 8, 6, 15, 4, 10
            List<int> list1 = new List<int>() { 2, 8, 6, 15, 4, 10 };
            PrintList(list1, null, "\nList of integers: ");
            //- define a new list of integers
            List<int> list2 = new List<int>();
            // -initialize the second list of integers with the same values as above but from end to start(10, 4, ...)
            list1.Reverse();
            list2.AddRange(list1);
            PrintList(list2, null, "\nSecond list of integers: ");
            //- define a list of characters and populate it with the following characters: q, w, e, r, t, y
            List<char> list3 = new List<char>{ 'q', 'w', 'e', 'r', 't', 'y' };
            PrintList(null, list3, "\nList of characters: ");
            //- Output the length of one of the integer lists and the characters list
            Console.Write("\nLength of list1: " + list1.Count);
            Console.WriteLine("\nLength of list3: " + list3.Count);
            // -Add the following characters at the end of the characters list: a, s, d, f
            list3.Add('a');
            list3.Add('s');
            list3.Add('d');
            list3.Add('f');
            PrintList(null, list3, "List of characters after adding a, s, d, f: ");
            //- Output the length of the characters list
            Console.Write("\nLength of list3: " + list3.Count);
            // -Remove the first and the last values from any of the integer lists
            PrintList(list1, null, "\nList1 before removing the first and last item: ");
            list1.RemoveAt(0);
            list1.RemoveAt(list1.Count-1);
            PrintList(list1, null, "\nList1 after removing the first and last item: ");
            // -Update the characters collection so that the 3rd character is x(e => x)
            PrintList(null, list3, "\nList of characters before updating the 3rs character to x: ");
            list3[2] = 'x';
            PrintList(null, list3, "\nList of characters after updating the 3rs character to x: ");

            List<car> temp = new List<car>();
            car A = new car(1,2,"A");
            temp.Add(A);

            int[] tt1 = new int[2] { 1, 2 };
            int[] tt2 = tt1;
            tt1[0] = 5;
            tt2[0] = 10;

            Console.WriteLine("\n");

            

            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            



            Console.ReadKey();
        }
    }
}
