
using AccessLayer;
using System.Data;
using System.Data.SqlClient;
using ADO6ConsoleApp.models;

namespace AD06ConsoleApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            //this is a connection string which is used to store the details.
            string connect = "Server=LAPTOP-L4RD8ILN; Database=AppFactoryDB;Integrated Security = True;";
            MemberModel model = new MemberModel();
           

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("Please Enter The Fields Required");

                Console.WriteLine("Please Enter Your Name");
                model.Name = Console.ReadLine();
                Console.WriteLine("Please Enter Your Last Name");
                model.surname = Console.ReadLine();
                Console.WriteLine("Please Enter Your ID number");
                model.IdNumber = Console.ReadLine();
                Console.WriteLine("Please Enter Your Gender");
                model.Gender = Console.ReadLine();
                Console.WriteLine("Please Enter the city you based at");
                model.City= Console.ReadLine();
                Console.WriteLine("Please Enter you Postion");
                model.Position= Console.ReadLine().ToUpper();
                Console.WriteLine("Please Enter the programme");
                model.Programme = Console.ReadLine();
                Console.WriteLine("Please Enter the qualification");
                model.Qualification = Console.ReadLine();

                if (model.Position == "FACILITATOR")
                {
                    Console.WriteLine("Please Enter years of experience");
                    model.YearsOfExperience= Convert.ToInt32(Console.ReadLine());
                }
                else if (model.Position == "INTERN")
                {
                    Console.WriteLine("Please Enter the your current Occupation");
                    model.Occupation = Console.ReadLine();
                    Console.WriteLine("please enter your current estimate salary per anum");
                    model.Salary = Console.ReadLine();
                }
                Access.AddMember(model.Name, model.surname, model.IdNumber, model.Gender, model.Position, model.Programme, model.Qualification, model.YearsOfExperience, model.Occupation, model.City, model.Salary, connect);


            //access the function from the access layer
            //  Access.Connect(connect);

        

            }
        }
    }
}

