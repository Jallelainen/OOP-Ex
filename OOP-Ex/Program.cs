using System;
using System.Collections.Generic;

namespace OOP_Ex
{
    //deafult access modifier is private.
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(2000, "Audi", "RS4");

            myCar.color = "Sky Blue";

            myCar.Regplate = "klm 645";
            
            Console.WriteLine(myCar.CarInfo());
        }
    }
}
