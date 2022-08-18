using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Student
    {
        public string strName;
        public string strGroup;
        public string strCourse;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;
            objS1 = new Student();
            Console.Write("Enter your name:");
            objS1.strName = Console.ReadLine();
            Console.Write("Enter the course");
            objS1.strCourse = Console.ReadLine();
            Console.Write("Enter the group:");
            objS1.strGroup = Console.ReadLine();
            Console.WriteLine("Name: {0} Course{1} Group{2}",
                objS1.strName, objS1.strCourse, objS1.strGroup);
            Student objS2;
            objS2 = new Student();
            Console.Write("Enter your name:");
            objS2.strName = Console.ReadLine();
            Console.Write("Enter your course:");
            objS2.strCourse = Console.ReadLine();
            Console.Write("Enter group:");
            objS2.strGroup = Console.ReadLine();
            Console.WriteLine("Name:{0} Course:{1} Group:{2}",
                              objS2.strName, objS2.strCourse, objS2.strGroup);
            Console.ReadKey();
        }
    }
}
