using System.Data.SqlClient;



namespace AccessLayer

{

    public class Access
    {
       

        public static void AddMember( string Fname,string Lname, string IdNum, string gender, string pos, string programme, string qualification,  int exp, string occupation, string city, string salary, string connectionString)
        { 
            //string sql = "INSERT INTO Product(Id, Fname,Lname,IdNum,gender)VALUES(@Id, @first_name,@last_name,@idNumber, @gender)"
            {
                // Create SQL connection object in using block for automatic closing and disposing
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    // Create command object in using block for automatic disposal
                    using (SqlCommand cmd = new SqlCommand("AddMember", cnn))
                    {

                        // Create input parameters


                        cmd.Parameters.Add(new SqlParameter("@first_name", Fname));
                        cmd.Parameters.Add(new SqlParameter("@last_name", Lname));
                        cmd.Parameters.Add(new SqlParameter("@idNumber", IdNum));
                        cmd.Parameters.Add(new SqlParameter("@gender", gender));
                        cmd.Parameters.Add(new SqlParameter("@city", city));
                        cmd.Parameters.Add(new SqlParameter("@pos", pos));
                        cmd.Parameters.Add(new SqlParameter("@programme", programme));
                        cmd.Parameters.Add(new SqlParameter("@qualification", qualification));
                        cmd.Parameters.Add(new SqlParameter("@occupat", occupation));
                        cmd.Parameters.Add(new SqlParameter("@salary", salary));
                        cmd.Parameters.Add(new SqlParameter("@experience", exp));
                     
                        // Set CommandType
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        // Open the connection
                        cnn.Open();

                        // Execute the INSERT statement
                         cmd.ExecuteNonQuery();

                    }
                }
            }
          
        }


    }
}