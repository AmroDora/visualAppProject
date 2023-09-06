using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    class patientsclass1
    {
        public int patientID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string contactNO { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string gender { get; set; }
        public string DOB { get; set; }
        public string languages { get; set; }
        public string diagnostics { get; set; }

        static string myconnection1 = ConfigurationManager.ConnectionStrings["VisualProgrammingProject.Properties.Settings.patientsConnectionString"].ConnectionString;



        public DataTable Select()
        {
            // Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnection1);

            //Create an Object for DataTable
            DataTable dt = new DataTable();
            try
            {
                // Step 2: Write Sql Query
                string sql = "SELECT * FROM patientDB";
                // Create Command using "sql" and "conn"
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Create SqlDataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // Open connection
                conn.Open();
                // Fill our dt with our adapter.
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        
        public bool Insert(patientsclass1 std)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;

            // Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnection1);

            try
            {
                // Step 2: Write Sql Query to insert data
                string sql = "INSERT INTO patientDB (firstName, lastName, contactNO, email, address, city, gender, DOB, languages, diagnostics) VALUES (@firstName, @lastName, @contactNO, @email, @address, @city, @gender, @DOB, @languages, @diagnostics) ";

                // Create Command using "sql" and "conn"
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Create Parameters to add data
                cmd.Parameters.AddWithValue("@firstname", std.firstname);
                cmd.Parameters.AddWithValue("@lastname", std.lastname);
                cmd.Parameters.AddWithValue("@contactNO", std.contactNO);
                cmd.Parameters.AddWithValue("@email", std.email);
                cmd.Parameters.AddWithValue("@address", std.address);
                cmd.Parameters.AddWithValue("@city", std.city);
                cmd.Parameters.AddWithValue("@gender", std.gender);
                cmd.Parameters.AddWithValue("@DOB", std.DOB);
                cmd.Parameters.AddWithValue("@languages", std.languages);
                cmd.Parameters.AddWithValue("@diagnostics", std.diagnostics);



                // Open connection
                conn.Open();

                // Run the Query
                int rows = cmd.ExecuteNonQuery();

                // If the query runs successfully then the value "rows" will be greater then zero else it will be zero
                
                if (rows > 0)
                { 
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            { 
                 MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Update(patientsclass1 std)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnection1);
            try
            {
                // Step 2: Write Sql Query to update data in DB
                string sql = "UPDATE patientDB SET firstName=@firstname, lastname=@lastname, contactNO=@ContactNO,email=@email,address=@address,city=@city,gender=@gender,DOB=@DOB,languages=@languages WHERE patientID = @patientID";

                // Create Command using "sql" and "conn"
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Create Parameters to update data
                cmd.Parameters.AddWithValue("@patientID", std.patientID);
                cmd.Parameters.AddWithValue("@firstname", std.firstname);
                cmd.Parameters.AddWithValue("@lastname", std.lastname);
                cmd.Parameters.AddWithValue("@contactNO", std.contactNO);
                cmd.Parameters.AddWithValue("@email", std.email);
                cmd.Parameters.AddWithValue("@address", std.address);
                cmd.Parameters.AddWithValue("@city", std.city);
                cmd.Parameters.AddWithValue("@gender", std.gender);
                cmd.Parameters.AddWithValue("@DOB", std.DOB);
                cmd.Parameters.AddWithValue("@languages", std.languages);
                cmd.Parameters.AddWithValue("@diagnostics", std.diagnostics);



                // Open connection
                conn.Open();

                // Run the Query
                int rows = cmd.ExecuteNonQuery();

                // If the query runs successfully then the value "rows" will be greater then zero else it will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Delete(patientsclass1 std)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;
            // Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnection1);
            try
            {
                // Step 2: Write Sql Query to Delete data in DB
                string sql = "DELETE FROM patientDB WHERE patientID = @patientID ";

                // Create Command using "sql" and "conn"
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Create Parameter to delete data
                cmd.Parameters.AddWithValue("@patientID", std.patientID);


                // Open connection
                conn.Open();

                // Run the Query
                int rows = cmd.ExecuteNonQuery();

                // If the query runs successfully then the value "rows" will be greater then zero else it will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}