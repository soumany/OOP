using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson03
{
    class Cube
    {
        private float fltSide;
        //a constructor is a special method
        //(1) it is public
        //(2) does not return anything , yes we do not put void
        //(3) it has the same name as the class
        public Cube(float x) // x is the float parameter
                             // x exist when Cube is called
                             //x is gone when Cube finishes running
                             //x is also kown as an automatic variable
        {
            fltSide = x;
        }
        public string GetSide()
        {
            return fltSide.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the length of the side for the cube: ");
            float x = float.Parse(Console.ReadLine());
            Cube c1Obj = new Cube(x); //2.5f is the float argument
            Console.WriteLine("The length of the side of the cube is {0}",c1Obj.GetSide());
        }
    }
}
