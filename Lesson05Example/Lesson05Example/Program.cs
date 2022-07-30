using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05Example
{
    class Book
    {//Q (a)
        private string strTitle;
        //Q (b)
        public string Title
        {
            get { return strTitle; }
            set { strTitle = value; }
        }
        private float fltPrice;
        //Q(c)
        public float Price
        { get { return fltPrice; }
          set {fltPrice = value; } 
        }
        public Book() //empty constructoor
        {
        }
        public Book(string strTitle, float fltPrice)
        {
            this.strTitle = strTitle;
            this.fltPrice = fltPrice;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book objBook1, objBook2; //Q(f)
            objBook1 = new Book();
            objBook2 = new Book();
            Console.Write("Enter title of book1:");
            string title1 = Console.ReadLine();
            Console.Write("Enter the price of book1:");
            float price1 = float.Parse(Console.ReadLine());
            objBook1.Title = title1;
            objBook1.Price = price1;


            Console.Write("Enter title of book2:");
            string title2 = Console.ReadLine();
            Console.Write("Enter the price of book2:");
            float price2 = float.Parse(Console.ReadLine());
            objBook2 = new Book(title2, price2);
            Console.WriteLine("Book1: Title is {0}, Price is {1}",objBook1.Title,objBook1.Price);
            Console.WriteLine("Book2: Title is {0}, Price is {1}", objBook2.Title, objBook2.Price);
        }
    }
}
