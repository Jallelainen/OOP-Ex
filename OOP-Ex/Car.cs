using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Ex
{
    class Car
    {
        //fields
        int modelYear;
        string brand;
        string modelName;
        public string color; // not following encapsulation

        string regPlate;
        public string Regplate 
        {
            get
            {
                return regPlate;
            }
            set
            {
                regPlate = value.ToUpper();
            } 
        }


        //constructor
        public Car(int modelYear, string carBrand, string carModelName)
        {
            this.modelYear = modelYear; // this. = if you use the same name in constructor
            brand = carBrand;
            modelName = carModelName;
        }

        public string CarInfo()
        {
            return $"Car\nBrand: {brand}" +
                $"\nModel: {modelName}" +
                $"\nProduction Year: {modelYear}" +
                $"\nRegistration Plate: {regPlate}" +
                $"\nColor: {color}";
        }
    }
}
