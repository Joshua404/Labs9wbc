using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{

    //public abstract class Car
    //{
    //    public string Model { get; set; }
    //    public decimal Price { get; set; }
    //}


    //public class NewCar: Car
    //{
    //}

    //public class UsedCar: Car
    //{
    //    public bool UnderWarranty { get; set; }
    //}

    //public class CertifiedUsedCar: UsedCar
    //{
    //    public int NumberOfInspections { get; set; }
    //}

    public class NewCar : ICar
    {
        public string Model { get; set; }
        public string Price { get; set; }
    }

    public class UsedCar: ICar
    {
        public string Model { get; set; }
        public string Price { get; set; }
        public bool UnderWarranty { get; set; }
    }


    class Program
    {

        //static void ShowCar(Car car)
        //{
        //Console.WriteLine(car.Model);
        //if (car is UsedCar) {
        //    var usedCar = car as UsedCar;
        //    Console.WriteLine(usedCar.UnderWarranty);
        //}
        
        
        //}

        public class Sorter : IComparer

            


        static void Main(string[] args)
        {
        //    var newCar = new NewCar {
        //    Model = "BMW",
        //    Price = 8992772.88m
        //    };


        //    var usedCar = new UsedCar
        //    {
        //    Model = "Tesla",
        //    Price = 3983983.88m
        //    };

        //    ShowCar(newCar);
        //    ShowCar(usedCar);
            var colors = new


        }
    }
}
