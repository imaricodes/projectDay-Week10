using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDay_Week10
{
    class DVD:Resource
    {

        #region Methods



        public override void AddTitle()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nEnter DVD Information\n");
            base.AddTitle();

            Console.Write("Length (# of min): ");

            Length = Console.ReadLine();

        }

        public override void ViewTitle()
        {
            Console.Clear();
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("ISBN: " + Isbn);
            Console.WriteLine("Length: " + Length + " minutes");
            Console.WriteLine("Status: " + Status);

            Console.Write("\nPress any key to continue ");
            Console.ReadKey();
        }

        public override void CheckIn()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nDVD Check In\n");
            Length = Length;
            base.CheckIn();
        }





        public override void CheckOut()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nDVD Check Out\n");

            DueDate = DateTime.Now.AddDays(3).ToString("MMMM dd, yyyy");

            base.CheckOut();
        }
        #endregion

        #region Constructors
        public DVD()
        {

        }
        #endregion
    }
}
