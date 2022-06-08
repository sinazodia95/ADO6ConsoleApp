using System.Data.SqlClient;



namespace AccessLayer

{

    public class Access
    {
       
        public static void AddFacilitator(string qua, string pos, int exp, DateTime start, DateTime end, string connectionString)
        {
            var RowsAffected = 0;

            {
                // Create SQL connection object in using block for automatic closing and disposing
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    // Create command object in using block for automatic disposal
                    using (SqlCommand cmd = new SqlCommand("Masterinsertfas", cnn))
                    {



                        cmd.Parameters.Add(new SqlParameter("@Qualif", qua));
                        cmd.Parameters.Add(new SqlParameter("@Position", pos));
                        cmd.Parameters.Add(new SqlParameter("@experience", exp));
                        cmd.Parameters.Add(new SqlParameter("@Start", start));
                        cmd.Parameters.Add(new SqlParameter("@end", end));
                        cmd.Parameters.Add(new SqlParameter("@StatementType", "insert"));

                        // Set CommandType
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        // Open the connection
                        cnn.Open();

                        // Execute the INSERT statement
                        cmd.ExecuteNonQuery();




                        var ResultText = "Rows Affected: " + RowsAffected.ToString();
                    }
                }

            }
        }

        public static void AddMember( string Fname,string Lname, string IdNum, string gender, string pos, string connectionString)
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
                        string Qauli = "";

                        int fk = 0, exp=0;
                        var end = new DateTime(2018, 1, 5, 20, 0, 0);
                        var start = new DateTime(2018, 3, 2, 15, 0, 0);
                        
                        if (pos.ToLower() == "software development")
                        {
                           fk = 1;
                        }else if (pos.ToLower() == "digital animation")
                        {
                            fk = 2;
                        }
                        else if (pos.ToLower() == "cyber security")
                        {
                            fk = 3;
                        }
                        else if(pos.ToLower()== "Facilitator")
                        {
                            fk = 4;
                            AddFacilitator(Qauli, pos, exp, start,end, connectionString);
                        }


                        cmd.Parameters.Add(new SqlParameter("@first_name", Fname));
                        cmd.Parameters.Add(new SqlParameter("@last_name", Lname));
                        cmd.Parameters.Add(new SqlParameter("@idNumber",IdNum));
                        cmd.Parameters.Add(new SqlParameter("@gender", gender));
                        cmd.Parameters.Add(new SqlParameter("@pos", fk));
                        cmd.Parameters.Add(new SqlParameter("@StatementType", "insert"));

                        // Set CommandType
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        // Open the connection
                        cnn.Open();

                        // Execute the INSERT statement
                         cmd.ExecuteNonQuery();
                        

                        

                         ResultText =$"Rows Affected: " + RowsAffected.ToString();
                    }
                }
            }
          
        }

       
        
    }
}