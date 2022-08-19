using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class House
    {
        public string strType;
        private string strAddress;
        private float fltPrice;
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }

        }
        public float Price
        { get { return fltPrice; }
          set { if (value>0)fltPrice = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            House hObj = new House();
            Console.WriteLine("Enter the type of house:");
            hObj.strType = Console.ReadLine();
            Console.WriteLine("enter the address:");
            hObj.Address = Console.ReadLine();
            Console.WriteLine("Enter the price:");
            hObj.Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Type {0} Address {1} Price {2}",
                              hObj.strType, hObj.Address, hObj.Price);        }
    }
}
