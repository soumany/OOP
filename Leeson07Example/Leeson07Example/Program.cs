using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leeson07Example
{
    class School
    {
        public string strSchoolName;
        private string strAddress;
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        public School(string strSchoolName, string strAddress) //c
        {
            this.strSchoolName = strSchoolName;
            this.strAddress = strAddress;
        }
    }
    class Student : School //D
    {
        public string strStudentName;
        private float fltSchoolFees;
        public float SchoolFees //E
        {
            get { return fltSchoolFees; }
            set { if (value >0.0f)
                    fltSchoolFees = value; }
        }
        public Student(string strStudentName, string strSchoolName, string strAddress, float fltSchoolFees) : base (strSchoolName, strAddress)
        {
            this.strStudentName = strStudentName;
            SchoolFees = fltSchoolFees;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;
            Console.Write("Enter the school");
            string mySchool = Console.ReadLine();
            Console.Write("Enter the address:");
            string myAddress = Console.ReadLine();
            Console.Write("Enter the name of the student");
            string myName = Console.ReadLine();
            Console.Write("Enter the school Fees: ");
            float mySchoolFees = float.Parse(Console.ReadLine());
            objS1 = new Student(myName, mySchoolFees, mySchool, myAddress);
            Console.WriteLine("School name: {0}", objS1.strSchoolName);
            Console.WriteLine("Address: {0}", objS1.Address);
            Console.WriteLine("Student Name; {0}", objS1.strStudentName);
            Console.WriteLine("School Fees: {0}", objS1.SchoolFees);
        }
    }
}
