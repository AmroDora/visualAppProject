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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        patientsclass1 std = new patientsclass1();
        private void btnadd_Click(object sender, EventArgs e)
        {
            string x1;
            string x3 = "";
            if (rdomale.Checked)
            {
                x1 = rdomale.Text;
            }
            else
            {
                x1 = rdofemale.Text;
            }

            if (cbarabic.Checked)
            {
                x3 = x3 + cbarabic.Text;
            }
            if (cbenglish.Checked)
            {
                x3 = x3 + " " + cbenglish.Text;
            }
            if (cbturkish.Checked)
            {
                x3 = x3 + " " + cbturkish.Text;
            }
            // Get the values from Input Fields
            //std.patientID = int.Parse(txtpatientID.Text);
            std.firstname = txtfirstname.Text;
            std.lastname = txtlastname.Text;
            std.contactNO= txtcontactNO.Text;
            std.email = txtemail.Text;
            std.diagnostics = cboxdiagn.Text;
            std.address = txtaddress.Text;
            std.city = cbocity.Text;
            std.gender = x1;
            std.DOB = datetpDOB.Text;
            std.languages = x3;

           

            // Insert a record to the table using the previous method
            bool success = std.Insert(std);

            if (success == true)
            {
                MessageBox.Show("A new Patient inserted to DB");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed");
            }

            DataTable dt = std.Select();
            DGVpatient.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = std.Select();
            DGVpatient.DataSource = dt;
        }
        public void Clear()
        {
           
            txtpatientID.Text = "";
            txtfirstname.Text = "";
            txtlastname.Clear();
            txtcontactNO.Text = String.Empty;
            txtaddress.Clear();
            txtemail.Clear();
            datetpDOB.Text = "";
            cbocity.Text="";
            rdomale.Checked=false;
            rdofemale.Checked = false;
            cbarabic.Checked = false;
            cbenglish.Checked = false;
            cbturkish.Checked = false;
            cboxdiagn.Text = "";
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            // Get the Data From DGV to form controls
            // Identify the row on which  mouse is clicked

            int rowindex = e.RowIndex;

            txtpatientID.Text = DGVpatient.Rows[rowindex].Cells[0].Value.ToString();
            txtfirstname.Text = DGVpatient.Rows[rowindex].Cells[1].Value.ToString();
            txtlastname.Text = DGVpatient.Rows[rowindex].Cells[2].Value.ToString();
            txtcontactNO.Text = DGVpatient.Rows[rowindex].Cells[3].Value.ToString();
            txtemail.Text = DGVpatient.Rows[rowindex].Cells[4].Value.ToString();
            txtaddress.Text = DGVpatient.Rows[rowindex].Cells[5].Value.ToString();
            cbocity.SelectedItem = DGVpatient.Rows[rowindex].Cells[6].Value.ToString();
            string gender = DGVpatient.Rows[rowindex].Cells[7].Value.ToString();
            rdomale.Checked = gender.Equals("male");
            rdofemale.Checked = gender.Equals("female");
            string languages = DGVpatient.Rows[rowindex].Cells[9].Value.ToString();
            var languageArr = languages.Split(' ');
            foreach (var lang in languageArr)
            {
                if(lang.Equals("arabic"))
                {
                    cbarabic.Checked = true;
                }
                if (lang.Equals("english"))
                {
                    cbenglish.Checked = true;
                }
                if (lang.Equals("turkish"))
                {
                    cbturkish.Checked = true;
                }
            }
            
            datetpDOB.Text = DGVpatient.Rows[rowindex].Cells[8].Value.ToString();
            cboxdiagn.SelectedItem = DGVpatient.Rows[rowindex].Cells[10].Value.ToString();
            

        }

        private void lblcity_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string x1;
            string x3 = "";
            if (rdomale.Checked)
            {
                x1 = rdomale.Text;
            }
            else
            {
                x1 = rdofemale.Text;
            }

            if (cbarabic.Checked)
            {
                x3 = x3 + cbarabic.Text;
            }
            if (cbenglish.Checked)
            {
                x3 = x3 + " " + cbenglish.Text;
            }
            if (cbturkish.Checked)
            {
                x3 = x3 + " " + cbturkish.Text;
            }
            // Transfer the Form values to StudentdClass
            std.patientID = int.Parse(txtpatientID.Text);
            std.firstname = txtfirstname.Text;
            std.lastname = txtlastname.Text;
            std.contactNO = txtcontactNO.Text;
            std.email = txtemail.Text;
            std.address = txtaddress.Text;
            std.city = cbocity.Text;
            std.gender = x1;
            std.DOB = datetpDOB.Text;
            std.languages = x3;
            std.diagnostics = cboxdiagn.Text;


            // Update the row in the table in DB
            bool success = std.Update(std);

            if (success == true)
            {
                MessageBox.Show("Record has been updated");

                // Load DGV from DB
                DataTable dt = std.Select();
                DGVpatient.DataSource = dt;

                // Call the Clear() method
                Clear();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Get the data from From
            std.patientID =(int) DGVpatient.CurrentRow.Cells[0].Value;
            bool success = std.Delete(std);
            if (success)
            {
                // Successfully deleted
                MessageBox.Show("Record has been deleted");
                // Refresh the DGV
                DataTable dt = std.Select();
                DGVpatient.DataSource = dt;

                // Call the Clear() method
                Clear();

            }
            else
            {
                // Failed to delete
                MessageBox.Show("Record has not been deleted");
            }
        }

        string myconnection1 = ConfigurationManager.ConnectionStrings["VisualProgrammingProject.Properties.Settings.patientsConnectionString"].ConnectionString;
        private void txtsearchbox_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtsearchbox.Text;
            SqlConnection conn = new SqlConnection(myconnection1);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM patientDB WHERE firstname LIKE '%" + keyword +"%' OR lastname LIKE '%" + keyword + "%'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGVpatient.DataSource = dt;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
