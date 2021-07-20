using System;
using System.Collections.Generic;
using System.Text;

namespace IntroProgramming_Curs11
{
    class Student
    {
        private int age;
        private List<int> grades = new List<int>{ 8, 6, 10, 9 };
        public string name;
        public double average;

        public double returnAverage(Student s)
        {
            int sum = 0;
            foreach (int x in this.grades)
                sum += x;
            return sum / this.grades.Count;
        }

        public void AlterValueByRef(ref int i)
        {
            i *= 2;
        }

        public void AlterValue (int i)
        {
            i *= 2;
        }
      
    }
}
