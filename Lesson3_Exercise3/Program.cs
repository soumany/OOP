using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Exercise3
{
    class Account
    {
        private string strType;
        private string strName;
        private float fltBalance
        {
            get { return fltBalance; }
        }
        public Account(string strType, string strName, float Balance)
        {
            this.strType = strType;
            this.strName = strName;
            fltBalance = Balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
