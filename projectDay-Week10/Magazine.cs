using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDay_Week10
{
    class Magazine:Resource
    {
        #region Methods



        public override void AddTitle()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nEnter Magazine Information\n");

            base.AddTitle();

            Console.Write("Length (pages): ");
            Length = Console.ReadLine();


        }

        public override void ViewTitle()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nMagazine Information\n");
          

            base.ViewTitle();
        }

        public override void CheckIn()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nMagazine Check In\n");
            
            base.CheckIn();
        }





        public override void CheckOut()
        {
            Console.Clear();

            Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++");

            Console.WriteLine("\nMagazine Check Out\n");

            DueDate = DateTime.Now.AddDays(2).ToString("MMMM dd, yyyy");

            base.CheckOut();
        }
        #endregion

        #region Constructors
        public Magazine()
        {

        }
        #endregion
    }
}
