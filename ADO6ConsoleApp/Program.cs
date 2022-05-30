
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
            string name, Lname, Gender;
            string IdNU;
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
                Access.AddMember(name, Lname, IdNU, Gender, connect);
            }

            //access the function from the access layer
          //  Access.Connect(connect);



           
        }
    }
}

