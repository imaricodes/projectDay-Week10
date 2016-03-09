using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDay_Week10
{
    class Book:Resource
    {
        #region Methods

        public override void AddTitle()
        {
            Console.Clear();
            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nEnter Book Information\n");
            base.AddTitle();

            Console.Write("Length (# of pages): ");
            Length = (Console.ReadLine());

        }

        public override void ViewTitle()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nBook Information\n");

            base.ViewTitle();
        }

        public override void CheckIn()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nBook Check In\n");
            base.CheckIn();
        }





        public override void CheckOut()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nBook Check Out\n");

            DueDate = DateTime.Now.AddDays(5).ToString("MMMM dd, yyyy");
         
            base.CheckOut();
        }
        #endregion

        #region Constructors
        public Book()
        {

        }
        
        #endregion

    }
}
