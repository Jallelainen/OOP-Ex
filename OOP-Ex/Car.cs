using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Ex
{
    class Car
    {
        //static
        private static int carCounter = 0;
        public static int Counter
        {
            get { return carCounter; }
        }


        //fields
        int id;
        int modelYear;
        string brand;
        string modelName;
        public string color; // not following encapsulation

        string regPlate;
        public string RegPlate
        {
            get { return regPlate; }
            set { regPlate = value.ToUpper(); }
        }


        //constructor
        public Car(int modelYear, string carBrand, string carModelName)
        {
            id = ++carCounter;

            this.modelYear = modelYear; // this. = if you use the same name in constructor
            brand = carBrand;
            modelName = carModelName;
        }

        public Car(int modelYear, string carBrand, string carModelName, string color, string regPlate)
            : this(modelYear, carBrand, carModelName) //chain constructor
        {
            this.color = color;
            RegPlate = regPlate;
        }

        public string CarInfo()
        {
            return $"CAR" +
                $"\nId: {id}" +
                $"\nBrand: {brand}" +
                $"\nModel: {modelName}" +
                $"\nProduction Year: {modelYear}" +
                $"\nRegistration Plate: {regPlate}" +
                $"\nColor: {color}\n";
        }
    }
}
