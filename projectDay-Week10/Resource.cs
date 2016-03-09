using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDay_Week10
{
    abstract class Resource
    {
        #region Fields

        private string title = null;
        private string isbn = null;
        private string length = null;
        private string status = "Available";
        private string dueDate = null;

        #endregion

        #region Properties
        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { this.isbn = value; }
        }

        public string Length
        {
            get { return length; }
            set { this.length = value; }
        }


        public string Status
        {
            get { return status; }
            set { this.status = value; }
        }

        public string DueDate
        {
            get { return dueDate; }
            set { this.dueDate = value; }
        }

        #endregion

        #region Methods

        public virtual void ViewTitle()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("ISBN: " + Isbn);
            Console.WriteLine("Length: " + Length + " pages");
            Console.WriteLine("Status: " + Status);

            Console.Write("\nPress any key to continue ");
            Console.ReadKey();


        }

        public virtual void AddTitle()
        {

            Console.Write("Name of Title: ");
            Title = Console.ReadLine();

            Console.Write("ISBN number: ");
            Isbn = Console.ReadLine();



        }

        public virtual void CheckOut()
        {

            Console.Write("Would you like to check out " + Title + "?  (y/n)");
            string input = Console.ReadLine();

            if (input == "y")
            {
                //overide this method to calculate days from today, then run base method
                Status = "Checked Out";
                Console.Clear();
                Console.WriteLine(Title + " has been checked out.");
                Console.WriteLine(Title + " is due " + DueDate + ".");

                Console.Write("\nPress any key to continue ");
                Console.ReadKey();

            }

        }

        public virtual void CheckIn()
        {

            Console.Write("Would you like to check in " + Title + "?  (y/n) ");
            string input = Console.ReadLine();

            if (input == "y")
            {
                Status = "Available";
                Console.Clear();
                Console.WriteLine("++++++++++++++++++++ Resource Manager ++++++++++++++++++++\n");

                Console.WriteLine(Title + " has been returned.");

                Console.Write("\nPress any key to continue ");
                Console.ReadKey();
            }

        }



        #endregion

        #region Constructors
        #endregion
    }
}
