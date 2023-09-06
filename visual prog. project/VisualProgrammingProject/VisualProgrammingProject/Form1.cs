using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace VisualProgrammingProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        static string myconnection2 = ConfigurationManager.ConnectionStrings["VisualProgrammingProject.Properties.Settings.patientsConnectionString"].ConnectionString;

        private DataTable Select2()
        {
            //DB connection
            SqlConnection con = new SqlConnection(myconnection2);

            //Create an Object for DataTable
            DataTable dataTable = new DataTable();

            try
            {
                // write sql query (your tables name)
                string sqlCode = "SELECT * FROM adminDB";

                // write sql query (your tables name)
                SqlCommand cmd = new SqlCommand(sqlCode, con);

                // create sqldataadapter using cmd
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                // open connection
                con.Open();
                dataAdapter.Fill(dataTable);

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }

        private bool isExistInTable(DataTable table, String username, String password)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                if (row[1].Equals(username))
                    if (row[2].Equals(password))
                        return true;
            }

            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = Select2();

            string username = textBox1.Text;
            string password = textBox2.Text;

            bool isExist = isExistInTable(table, username, password);
            if (isExist)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2 = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("Acess Denied!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }
    }
}
