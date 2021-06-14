using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroProgramming_Curs6
{
    class Program
    {
        static void Main(string[] args)
        {
			//Create a program(console application) in which you will:
			//create a dictionary of int and string
			var dictionary = new Dictionary<int, string>();
			//fill the dictionary with the following value pairs: (1, a), (2, b), ... (6, f)
			dictionary.Add(1, "a");
			dictionary.Add(2, "b");
			dictionary.Add(3, "c");
			dictionary.Add(4, "d");
			dictionary.Add(5, "e");
			dictionary.Add(6, "f");
			//check if the dictionary contains a record with key 4 and output "Yes dictionary contains key 4" or "No dictionary does not contain key 4" to the user
			if (dictionary.ContainsKey(4))
				Console.Write("Yes dictionary contains key 4");
			else
				Console.Write("No dictionary does not contain key 4");
			//check if the dictionary contains a record with value h and output "Yes dictionary contains value h" or "No dictionary does not contain value h" to the user
			if(dictionary.ContainsValue("h"))
				Console.Write("\nYes dictionary contains value h");
			else
				Console.Write("\nNo dictionary does not contain value h");
			//remove from the dictionary the pair with key 5
			dictionary.Remove(5);
			//retrieve from the dictionary the value of key 3
			var valueOfKey3 = dictionary[3];
			//output all the values from the dictionary as follows: "Key = 1, Value = a"...
			foreach(var item in dictionary)
				Console.Write("\nKey = " + item.Key + ", Value = " + item.Value);
			//create a method SortAndDisplay that will receive as a parameter a list of integers and outputs to the user the sorted list
			SortAndDisplay(new List<int>() { 2, 11, 1, 999, 43, 23, 7, -2 });
			//define and initialize a list of integers with the following values: 7, 2, 6, 9, 3, 4, 10
			var tempList1 = new List<int>() { 7, 2, 6, 9, 3, 4, 10 };
			//define and initialize a second list of integers with the following values: 3, 1, 4, 9, 2, 6, 10
			var tempList2 = new List<int>() { 3, 1, 4, 9, 2, 6, 10 };
			//call the SortAndDisplay method for both lists, one after the other
			SortAndDisplay(tempList1);
			SortAndDisplay(tempList2);

			tempList1.AddRange(tempList2);
			SortAndDisplay(tempList1);

			Console.ReadKey();
		}

        private static void SortAndDisplay(List<int> integers)
        {
			integers.Sort();
			Console.WriteLine();
			foreach (var integer in integers)
				Console.Write(integer + " ");
        }
    }
}
