using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        patientsclass1 std = new patientsclass1();

        public void Clear()
        {

            
            txtfirstname2.Text = "";
            txtlastname2.Clear();
            txtcontactNO2.Text = String.Empty;
            txtaddress2.Clear();
            txtemail2.Clear();
            datetpDOB2.Text = "";
            cbocity2.Text = "";
            rdomale2.Checked = false;
            rdofemale2.Checked = false;
            cbarabic2.Checked = false;
            cbenglish2.Checked = false;
            cbturkish2.Checked = false;
            cboxdiagn2.Text = "";
        }
        private void diagno(string diagnostics)
        {
            if (diagnostics == "aids")
            {
                MessageBox.Show("Currently, there's no cure for HIV/AIDS. Once you have the infection, your body can't get rid of it. However, there are many medications that can control HIV and prevent complications. These medications are called antiretroviral therapy (ART). Everyone diagnosed with HIV should be started on ART, regardless of their stage of infection or complications.");
            }
            if (diagnostics == "covid-19")
            {
                MessageBox.Show("Getting your coronavirus (COVID-19) vaccination remains the best way to protect yourself from the virus. ");
            }
            if (diagnostics == "cancer")
            {
                MessageBox.Show("Cancer treatment is the use of surgery, radiation, medications and other therapies to cure a cancer, shrink a cancer or stop the progression of a cancer,Many cancer treatments exist.Depending on your particular situation, you may receive one treatment or you may receive a combination of treatments.");
            }
            if (diagnostics == "diabetes")
            {
                MessageBox.Show("Taking insulin or other diabetes medicines is often part of treating diabetes. In addition to making healthy food and beverage choices, getting physical activity, getting enough sleep, and managing stress, medicines can help you manage the disease. Some other treatment options are also available.");
            }
            if (diagnostics == "asthma")
            {
                MessageBox.Show("Long-term control medications such as inhaled corticosteroids are the most important medications used to keep asthma under control. ...Quick - relief inhalers contain a fast - acting medication such as albuterol.");
            }
            if (diagnostics == "heart attack")
            {
                MessageBox.Show("You might receive clot-dissolving drugs (thrombolysis), balloon angioplasty (PCI), surgery or a combination of treatments.");
            }
            if (diagnostics == "brain stroke")
            {
                MessageBox.Show("An IV injection of recombinant tissue plasminogen activator (TPA) — also called alteplase (Activase) or tenecteplase (TNKase) — is the gold standard treatment for ischemic stroke. An injection of TPA is usually given through a vein in the arm within the first three hours");
            }
            if (diagnostics == "heart stroke")
            {
                MessageBox.Show("An IV injection of recombinant tissue plasminogen activator (TPA) — also called alteplase (Activase) or tenecteplase (TNKase) — is the gold standard treatment for ischemic stroke. An injection of TPA is usually given through a vein in the arm within the first three hours");
            }
            if (diagnostics == "broken arm")
            {
                MessageBox.Show("A simple break might be treated with a sling, ice and rest. However, the bone may require realignment (reduction) in the emergency room. A more complicated break might require surgery to realign the broken bone and to implant wires, plates, nails or screws to keep the bone in place during healing.");
            }
            if (diagnostics == "broken leg")
            {
                MessageBox.Show("Immobilization with a cast or splint heals most broken bones.However, you may need surgery to implant plates, rods or screws to maintain proper position of the bones during healing.This type of surgery is more likely in people who have: Multiple fractures.");
            }
            if (diagnostics == "concussion")
            {
                MessageBox.Show("Your doctor will recommend that you physically and mentally rest to recover from a concussion. Relative rest, which includes limiting activities that require thinking and mental concentration, is recommended for the first two days after a concussion.");
            }
            if (diagnostics == "stomach ache")
            {
                MessageBox.Show("Bowel rest. Stop eating, or only eat easy-to-digest foods like crackers or bananas.Hydration.Drink plenty of water or a hydration formula.Heat therapy.Try a warm water bottle or a soak in the bath.Home remedies.");
            }
            if (diagnostics == "cold")
            {
                MessageBox.Show("rest and sleep.drink plenty of water(fruit juice or squash mixed with water is OK) to avoid dehydration.gargle salt water to soothe a sore throat(not suitable for children) ");
            }
            if (diagnostics == "flu")
            {
                MessageBox.Show("If you get sick with flu, influenza antiviral drugs may be a treatment option. Antiviral drugs work best when started early, such as one to two days after your flu symptoms begin. Check with your doctor promptly if you are at higher risk of serious flu complications and you get flu symptoms.");
            }
            if (diagnostics == "broken ribs")
            {
                MessageBox.Show("Most broken ribs heal on their own within six weeks.Restricting activities and icing the area regularly can help with healing and pain relief.");
            }
        }
        private void signupbtn_Click(object sender, EventArgs e)
        {
            string x1;
            string x3 = "";
            if (rdomale2.Checked)
            {
                x1 = rdomale2.Text;
            }
            else
            {
                x1 = rdofemale2.Text;
            }

            if (cbarabic2.Checked)
            {
                x3 = x3 + cbarabic2.Text;
            }
            if (cbenglish2.Checked)
            {
                x3 = x3 + " " + cbenglish2.Text;
            }
            if (cbturkish2.Checked)
            {
                x3 = x3 + " " + cbturkish2.Text;
            }
            // Get the values from Input Fields
            //std.patientID = int.Parse(txtpatientID.Text);
            std.firstname = txtfirstname2.Text;
            std.lastname = txtlastname2.Text;
            std.contactNO = txtcontactNO2.Text;
            std.email = txtemail2.Text;
            std.diagnostics = cboxdiagn2.Text;
            std.address = txtaddress2.Text;
            std.city = cbocity2.Text;
            std.gender = x1;
            std.DOB = datetpDOB2.Text;
            std.languages = x3;



            // Insert a record to the table using the previous method
            bool success = std.Insert(std);

            if (success == true)
            {
                MessageBox.Show("A new Patient inserted to DB");
                
            }
            else
            {
                MessageBox.Show("Failed");
            }

            diagno(cboxdiagn2.Text);
            Clear();
        }
    }
}
