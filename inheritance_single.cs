using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{//This is a program about single level inheritance.
    class Car
    {
        public string model;
        public string brand;
        public int price;
        public void PrintCarInfo()
        {
            Console.WriteLine("Car Brand: " + brand);
            Console.WriteLine("Car Model: " + model);
            Console.WriteLine("Car Price: " + price);
        }
    }
    class Maruti : Car
    {
        int year;
        int mileage;
        void PrintOthherInfo()
        {
            Console.WriteLine("Manufacturing Year: " + year);
            Console.WriteLine("Mileage: " + mileage);
        }
        static void Main(string[] args)
        {
            Maruti obj = new Maruti();
            obj.brand = "Maruti";
            obj.model = "SX4";
            obj.price = 1200000;
            obj.year = 2022;
            obj.mileage = 18;
            obj.PrintCarInfo();
            obj.PrintOthherInfo();
            Console.ReadLine();
        }
    }
    
}
