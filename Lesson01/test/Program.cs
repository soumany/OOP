using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Movie
{
    public string strTitle;
    public string strGenre;
    public int intYear;
}
internal class Program
    {
        static void Main(string[] args)
        {
            Movie objMovie1; //part b declare an object name of type car
            objMovie1 = new Movie(); // part c
            //Car objcar = new Car();
            Console.Write("what is the Title of the movie:");
            objMovie1.strTitle = Console.ReadLine();
            Console.Write("what is the genre of the movie:");
            objMovie1.strGenre = Console.ReadLine();
            Console.Write("what is the year of the movie:");
            objMovie1.intYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Title of the Movie is:{0} , Genre of the Movie is: {1} and The year of the Movie is: {2}", objMovie1.strTitle, objMovie1.strGenre, objMovie1.intYear);

        }
    }
}
