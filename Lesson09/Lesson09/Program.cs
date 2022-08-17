using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09Example
{
    class School
    {
        public string strSchoolName;
        private string strAddress;
        public string Address
        {
            get { return strAddress; }
        }

        static protected int intStudentCount = 0;
        public School(string strSchoolName, string strAddress)
        {
            this.strAddress = strAddress;
            this.strSchoolName = strSchoolName;
        }
        static public int GetTotalStudents()
        {
            return intStudentCount;
        }
    }

    class Student : School
    {
        private string strName;
        public Student(string strSchoolName, string strAddress, string strName)
          : base(strSchoolName, strAddress)
        {
            this.strName = strName;
            intStudentCount++;
        }
        public string GetInfo()
        {
            return ("Student name: " + strName + ", School name: " + strSchoolName
                + ", School Address: " + Address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1, objS2;
            Console.Write("Student Name: ");
            string StudentName = Console.ReadLine();
            Console.Write("School Name: ");
            string SchoolName = Console.ReadLine();
            Console.Write("School address: ");
            string SchoolAddress = Console.ReadLine();
            objS1 = new Student(StudentName, SchoolName, SchoolAddress);
            Console.WriteLine("objS1: {0}", objS1.GetInfo());
            Console.WriteLine("");

            Console.Write("Student Name: ");
            StudentName = Console.ReadLine();
            Console.Write("School Name: ");
            SchoolName = Console.ReadLine();
            Console.Write("School address: ");
            SchoolAddress = Console.ReadLine();
            objS2 = new Student(StudentName, SchoolName, SchoolAddress);
            Console.WriteLine("objS2: {0}", objS2.GetInfo());

            Console.WriteLine();
            Console.WriteLine("Total number of students: {0}", School.GetTotalStudents());
        }
    }
}