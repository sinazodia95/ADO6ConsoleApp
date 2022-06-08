
using AccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace AD06ConsoleApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a connection string which is used to store the details.
            string connect = "Server=LAPTOP-L4RD8ILN; Database=AppFactoryDB;Integrated Security = True;";
            string name, Lname, Gender, Qaulif;
            string IdNU;
            string position;
            int experience;
            DateTime starts, ends;

            
            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("Please Enter The Fields Required");
                
                Console.WriteLine("Please Enter Your Name");
                name = Console.ReadLine();
                Console.WriteLine("Please Enter Your Last Name");
                Lname = Console.ReadLine();
                Console.WriteLine("Please Enter Your ID number");
                IdNU= Console.ReadLine();
                Console.WriteLine("Please Enter Your Gender");
                Gender= Console.ReadLine();

                Console.WriteLine("Please Enter you Postion");
             
                position = Console.ReadLine();
                
               

                if (position == "facilitator")
                {

                    Console.WriteLine("Please Enter the qualification");
                    Qaulif= Console.ReadLine();
                    Console.WriteLine("please enter your postion");
                    position = Console.ReadLine();
                    Console.WriteLine("Please Enter years of experience");
                    experience = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the month for start: ");
                    int month = int.Parse(Console.ReadLine());
                    Console.Write("Enter The day: ");
                    int day = int.Parse(Console.ReadLine());
                    Console.Write("Enter The year: ");
                    int year = int.Parse(Console.ReadLine());

                    starts = new DateTime(year, month, day);
                  
                    Console.Write("Enter a month for End: ");
                    int month1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter a day: ");
                    int day1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter a year: ");
                    int year1 = int.Parse(Console.ReadLine());
                    ends = new DateTime(year, month, day);

                    Access.AddFacilitator(Qaulif, position, experience, starts, ends, connect);
                }

                 Access.AddMember(name, Lname, IdNU, Gender,position, connect);
            }

            //access the function from the access layer
          //  Access.Connect(connect);



           
        }
    }
}

