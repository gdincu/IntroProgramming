using System;

namespace IntroProgramming_Curs14
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiate an Abstract class object
            //cannot be instantiated directly
            Abstract abstractObject = new Derived();
            //instantiate a Derived class object
            Derived derived = new Derived();
            //set the AbstractInt object from the derived object to 5
            derived.AbstractInt = 10;
            //call the OutputMethod from the derived object
            derived.OutputMethod();
            //call the AbstractEmptyMethod from the derived object
            derived.AbstractEmptyMethod();
            //debug the above code using F11 to see the differences between method calls


            //instantiate a new Car object without parameters(car)
            Car car = new Car();
            //instantiate a new Car object with value 5 (secondCar)
            Car secondCar = new Car(5);
            //instantiate a new Logan object without parameters(firstLogan)
            Logan firstLogan = new Logan();
            //instantiate a new Logan object with value 2 (secondLogan)
            Logan secondLogan = new Logan(2);
            //debug the above code using F11 to see the differences between method calls

            Console.ReadKey();
        }
    }
}
