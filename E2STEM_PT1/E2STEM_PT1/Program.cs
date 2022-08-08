using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2STEM_PT1
{
    class ComputerBrand
    {
        public string strBrandName;
        private float fltPrice;
        public static float fltTotalPrice;
        public ComputerBrand(string strBrandName, float fltPrice)
        {
            this.strBrandName = strBrandName;
            this.fltPrice = fltPrice;
            fltTotalPrice += fltPrice;
        }
        public float Price
        {
            get { return fltPrice; }
        }
        public string GetInfo()
        { return "Computer brand:{0} ,Price:{1}"+ strBrandName + fltPrice.ToString() ; }
    }
    internal class Program
    {
        static void Main(string[] args)

        {
            ComputerBrand ComObj1, ComObj2;
            ComObj1 = new ComputerBrand();
            ComObj2 = new ComputerBrand();
            Console.WriteLine("Enter Computer Brand 1:");
            ComObj1.strBrandName = Console.ReadLine();
            Console.WriteLine("Enter the price of Computer 1:");
            ComObj2.Price = float.Parse(Console.ReadLine());



        }
    }
}
