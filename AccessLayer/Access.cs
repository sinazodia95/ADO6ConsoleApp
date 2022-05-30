using System.Data.SqlClient;



namespace AccessLayer

{

    public class Access
    {
       
        // method grabs string input
        //create a method that would connect to the database
        //public static void Connect(string connectionString)
        //{
        //    //create connection
        //    SqlConnection con = new SqlConnection(connectionString);
        //    //create query that writes to database
        //    string sql = "Insert Into Member(Member ID, FirstName, LastName, ID Number, Gender) values (@id,'@first_name', '@last_name', '@idNumber', '@gender'  )";

        //    //open connection
        //    con.Open();

        //    //create a sql command referencing the connection
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.ExecuteNonQuery();

        //    //close connection
        //    con.Close();

        //    //open connection
        //    con.Open();
        //    //create query that reads from database
        //    string sql2 = "SELECT * FROM YourTable";
        //    //create a sql command referencing the connection
        //    SqlCommand cmd2 = new SqlCommand(sql2, con);

        //    //create sql data reader
        //    SqlDataReader dataReader = cmd2.ExecuteReader();

        //    //while its reading
        //    while (dataReader.Read())
        //    {
        //        //store the columns in variables
        //        var id = dataReader.GetInt32(0);
        //        var itemName = dataReader.GetString(1);
        //        decimal itemPrice = dataReader.GetDecimal(2);

        //        //write to console
        //        Console.WriteLine(id + " " + itemName + " " + itemPrice);


        //    }
        //    //close connection
        //    con.Close();
        //    //dispose of connection
        //    con.Dispose();




        //}

        public static void AddMember( string Fname,string Lname, string IdNum, string gender, string connectionString)
        {
            //SqlConnection con = new SqlConnection();
            var RowsAffected = 0;
            var ResultText = "";


            // Create SQL statement to submit

            //string sql = "INSERT INTO Product(Id, Fname,Lname,IdNum,gender)VALUES(@Id, @first_name,@last_name,@idNumber, @gender)";


            {
                // Create SQL connection object in using block for automatic closing and disposing
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    // Create command object in using block for automatic disposal
                    using (SqlCommand cmd = new SqlCommand("Masterinsert", cnn))
                    {

                        // Create input parameters
                      
                        cmd.Parameters.Add(new SqlParameter("@first_name", Fname));
                        cmd.Parameters.Add(new SqlParameter("@last_name", Lname));
                        cmd.Parameters.Add(new SqlParameter("@idNumber",IdNum));
                        cmd.Parameters.Add(new SqlParameter("@gender", gender));
                        cmd.Parameters.Add(new SqlParameter("@StatementType", "insert"));

                        // Set CommandType
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        // Open the connection
                        cnn.Open();

                        // Execute the INSERT statement
                         cmd.ExecuteNonQuery();

                         ResultText = "Rows Affected: " + RowsAffected.ToString();
                    }
                }
            }
          
        }

       
        
    }
}