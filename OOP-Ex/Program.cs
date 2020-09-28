using System;
using System.Collections.Generic;

namespace OOP_Ex
{
    //deafult access modifier is private.
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(2000, "Audi", "RS4"); //new instance

            myCar.color = "Sky Blue";

            myCar.RegPlate = "klm 645";

            Console.WriteLine("Amount of cars:" + Car.Counter);//call Counter via class
            Console.WriteLine(myCar.CarInfo());

            Car odins = new Car(2009, "Honda", "Civic Type R");

            odins.color = "Racing Red";
            odins.RegPlate = "hgb 899";

            Console.WriteLine("Amount of cars:" + Car.Counter);//call Counter via class
            Console.WriteLine(odins.CarInfo());

            Car raisa = new Car(2006, "Volvo", "S80", "Stone Gray", "TlN 776");

            Console.WriteLine("Amount of cars:" + Car.Counter);
            Console.WriteLine(raisa.CarInfo());
        }
    }
}
