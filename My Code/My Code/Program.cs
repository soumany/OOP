using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height");
            float Height = float.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0}. Your age is {1}.Your height is {2}",Name, Age, Height); 

        }
    }
}
