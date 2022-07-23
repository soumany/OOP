using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapExercise1
{
    class Car
    {
        public string strModel;
        public string strBrand;
        public float fltPrice;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car objCar1; //part b declare an object name of type car
            objCar1 = new Car(); // part c
            //Car objcar = new Car();
            Console.Write("what is teh model of your car:");
            objCar1.strModel = Console.ReadLine();
            Console.Write("what is teh brand  of your car:");
            objCar1.strBrand = Console.ReadLine();
            Console.Write("what is teh price of your car:");
            objCar1.fltPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Car Model is {0} , Brand car is {1} and Price is {2}", objCar1.strModel, objCar1.strBrand, objCar1.fltPrice);


        }
    }
}
