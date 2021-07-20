using System;

namespace IntroProgramming_Curs13
{
    class Program
    {
        static void Main(string[] args)
        {
            //define and instantiate a Human object
            Human human = new Human();
            //set the age to 25
            human.SetAge(25);
            //output the age of the human
            Console.WriteLine("Age for the human: " + human.GetAge());
            //define and instantiate a GoingToSchool object
            GoingToSchool goingToSchool = new GoingToSchool();
            //set the age to 25
            goingToSchool.SetAge(25);
            //output the age of the above defined object
            Console.WriteLine("Age for goingToSchool: "+goingToSchool.GetAge());
            //define and instantiate a Student object
            Student student = new Student();
            //set the age to 25
            student.SetAge(25);
            //output the age of the student
            Console.WriteLine("Age of the student: " + student.GetAge());


            //using the student object
            //set the student name - choose any name
            student.Name = "Name A";
            //set the weight and height of the student to any values
            student.SetHeight(100);
            student.SetWeight(100);
            //set the YearOfSchool to any chosen value - commented as the field being private restricts access to this property
            //student.YearOfSchool = 2000;
            //output the weight of the student
            Console.WriteLine("Weight of the student: " + student.GetWeight());
            //output the height of the student
            Console.WriteLine("Height of the student: " + student.GetHeight());
            //add two grades to the student object
            student.AddGrade(10);
            student.AddGrade(6);
            //output the average of the student grades
            Console.WriteLine("Average grade: " + student.CalculateAverage());
            Console.ReadKey();
        }
    }
}
