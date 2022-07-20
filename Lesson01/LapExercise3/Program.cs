using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class MedicalRecord
    {
        public string strPatientName;
        public string strDoctorName;
        public float fltFees;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MedicalRecord objM1;
            objM1 = new MedicalRecord(); 
            Console.Write("what is the Patient Name:");
            objM1.strPatientName = Console.ReadLine();
            Console.Write("what is the Doctor Name:");
            objM1.strDoctorName= Console.ReadLine();
            Console.Write("How much fees:");
            objM1.fltFees = float.Parse(Console.ReadLine());
            Console.WriteLine("Patient name is :{0} , Doctor name is: {1} and The Fees is: {2}", objM1.strPatientName, objM1.strDoctorName, objM1.fltFees);

        }
    }
}
