using System;
using System.Collections.Generic;
using System.Text;

namespace IntroProgramming_Curs13
{
    class Student:GoingToSchool
    {
        public void AddGrade(int i)
        {
            gradesList.Add(i);
        }

        public double CalculateAverage()
        {
            int sum = 0;
            foreach (int a in gradesList)
                sum += a;
            return sum / gradesList.Count;
        }

        public override int GetAge()
        {
            return base.GetAge()*2;
        }
    }
}
