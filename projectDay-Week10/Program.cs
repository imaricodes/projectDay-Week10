using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDay_Week10
{
    class Program
    {
        static void Main(string[] args)
        {
            //BOOK

            //create Book object
            Book book1 = new Book();

            //set properties
            book1.AddTitle();

            //check out
            book1.CheckOut();
            book1.ViewTitle();


            // check in
            book1.CheckIn();
            book1.ViewTitle();


            //DVD

            //create dvd object
            DVD dvd1 = new DVD();

            //set properties
            dvd1.AddTitle();

            //check out
            dvd1.CheckOut();
            dvd1.ViewTitle();

            //check in
            dvd1.CheckIn();
            dvd1.ViewTitle();

            //Magazine

            //create dvd object
            Magazine mag1 = new Magazine();

            //set properties
            mag1.AddTitle();

            //check out
            mag1.CheckOut();
            mag1.ViewTitle();

            //check in
            mag1.CheckIn();
            mag1.ViewTitle();

            Console.Clear();
            Console.WriteLine("End of Program");

            Console.ReadKey();
        }
    }
}
