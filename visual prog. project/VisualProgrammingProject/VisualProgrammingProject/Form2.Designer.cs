
namespace VisualProgrammingProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblstudentID;
            System.Windows.Forms.Label lblfirstName;
            System.Windows.Forms.Label lbllastname;
            System.Windows.Forms.Label lbladdress;
            System.Windows.Forms.Label lblcity;
            System.Windows.Forms.Label lblDOB;
            System.Windows.Forms.Label lblGENDER;
            System.Windows.Forms.Label lbllangauges;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cboxdiagn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchbox = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.DGVpatient = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbturkish = new System.Windows.Forms.CheckBox();
            this.cbenglish = new System.Windows.Forms.CheckBox();
            this.cbarabic = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.datetpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbocity = new System.Windows.Forms.ComboBox();
            this.txtpatientID = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontactNO = new System.Windows.Forms.TextBox();
            this.contactNOlbl = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            lblstudentID = new System.Windows.Forms.Label();
            lblfirstName = new System.Windows.Forms.Label();
            lbllastname = new System.Windows.Forms.Label();
            lbladdress = new System.Windows.Forms.Label();
            lblcity = new System.Windows.Forms.Label();
            lblDOB = new System.Windows.Forms.Label();
            lblGENDER = new System.Windows.Forms.Label();
            lbllangauges = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpatient)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudentID
            // 
            lblstudentID.AutoSize = true;
            lblstudentID.Location = new System.Drawing.Point(77, 40);
            lblstudentID.Name = "lblstudentID";
            lblstudentID.Size = new System.Drawing.Size(24, 13);
            lblstudentID.TabIndex = 92;
            lblstudentID.Text = " ID:";
            // 
            // lblfirstName
            // 
            lblfirstName.AutoSize = true;
            lblfirstName.Location = new System.Drawing.Point(74, 76);
            lblfirstName.Name = "lblfirstName";
            lblfirstName.Size = new System.Drawing.Size(57, 13);
            lblfirstName.TabIndex = 94;
            lblfirstName.Text = "FirstName:";
            // 
            // lbllastname
            // 
            lbllastname.AutoSize = true;
            lbllastname.Location = new System.Drawing.Point(77, 111);
            lbllastname.Name = "lbllastname";
            lbllastname.Size = new System.Drawing.Size(52, 13);
            lbllastname.TabIndex = 96;
            lbllastname.Text = "lastname:";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Location = new System.Drawing.Point(77, 212);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new System.Drawing.Size(47, 13);
            lbladdress.TabIndex = 98;
            lbladdress.Text = "address:";
            // 
            // lblcity
            // 
            lblcity.AutoSize = true;
            lblcity.Location = new System.Drawing.Point(77, 265);
            lblcity.Name = "lblcity";
            lblcity.Size = new System.Drawing.Size(26, 13);
            lblcity.TabIndex = 100;
            lblcity.Text = "city:";
            lblcity.Click += new System.EventHandler(this.lblcity_Click);
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new System.Drawing.Point(74, 350);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new System.Drawing.Size(33, 13);
            lblDOB.TabIndex = 101;
            lblDOB.Text = "DOB:";
            // 
            // lblGENDER
            // 
            lblGENDER.AutoSize = true;
            lblGENDER.Location = new System.Drawing.Point(68, 311);
            lblGENDER.Name = "lblGENDER";
            lblGENDER.Size = new System.Drawing.Size(56, 13);
            lblGENDER.TabIndex = 102;
            lblGENDER.Text = "GENDER:";
            // 
            // lbllangauges
            // 
            lbllangauges.AutoSize = true;
            lbllangauges.Location = new System.Drawing.Point(70, 393);
            lbllangauges.Name = "lbllangauges";
            lbllangauges.Size = new System.Drawing.Size(59, 13);
            lbllangauges.TabIndex = 103;
            lbllangauges.Text = "langauges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(162, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 119;
            this.label3.Text = "Welcome to our IT Hospital";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(56, 519);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 118;
            this.pictureBox3.TabStop = false;
            // 
            // cboxdiagn
            // 
            this.cboxdiagn.FormattingEnabled = true;
            this.cboxdiagn.Items.AddRange(new object[] {
            "aids",
            "covid-19",
            "diabetes",
            "cancer",
            "asthma",
            "heart stroke",
            "brain stroke",
            "broken arm",
            "broken leg",
            "concussion",
            "stomach ache",
            "broken ribs",
            "flu",
            "cold"});
            this.cboxdiagn.Location = new System.Drawing.Point(146, 483);
            this.cboxdiagn.Name = "cboxdiagn";
            this.cboxdiagn.Size = new System.Drawing.Size(121, 21);
            this.cboxdiagn.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "diagnostics";
            // 
            // txtsearchbox
            // 
            this.txtsearchbox.Location = new System.Drawing.Point(632, 241);
            this.txtsearchbox.Multiline = true;
            this.txtsearchbox.Name = "txtsearchbox";
            this.txtsearchbox.Size = new System.Drawing.Size(512, 20);
            this.txtsearchbox.TabIndex = 114;
            this.txtsearchbox.TextChanged += new System.EventHandler(this.txtsearchbox_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(571, 248);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(41, 13);
            this.lblsearch.TabIndex = 113;
            this.lblsearch.Text = "Search";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(1069, 473);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 112;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(901, 474);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 111;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.Location = new System.Drawing.Point(724, 474);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 110;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Lime;
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadd.Location = new System.Drawing.Point(574, 474);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 109;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // DGVpatient
            // 
            this.DGVpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpatient.Location = new System.Drawing.Point(574, 280);
            this.DGVpatient.Name = "DGVpatient";
            this.DGVpatient.Size = new System.Drawing.Size(570, 150);
            this.DGVpatient.TabIndex = 108;
            this.DGVpatient.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbturkish);
            this.groupBox2.Controls.Add(this.cbenglish);
            this.groupBox2.Controls.Add(this.cbarabic);
            this.groupBox2.Location = new System.Drawing.Point(144, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 75);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            // 
            // cbturkish
            // 
            this.cbturkish.AutoSize = true;
            this.cbturkish.Location = new System.Drawing.Point(14, 52);
            this.cbturkish.Name = "cbturkish";
            this.cbturkish.Size = new System.Drawing.Size(57, 17);
            this.cbturkish.TabIndex = 2;
            this.cbturkish.Text = "turkish";
            this.cbturkish.UseVisualStyleBackColor = true;
            // 
            // cbenglish
            // 
            this.cbenglish.AutoSize = true;
            this.cbenglish.Location = new System.Drawing.Point(106, 10);
            this.cbenglish.Name = "cbenglish";
            this.cbenglish.Size = new System.Drawing.Size(59, 17);
            this.cbenglish.TabIndex = 1;
            this.cbenglish.Text = "english";
            this.cbenglish.UseVisualStyleBackColor = true;
            // 
            // cbarabic
            // 
            this.cbarabic.AutoSize = true;
            this.cbarabic.Location = new System.Drawing.Point(14, 11);
            this.cbarabic.Name = "cbarabic";
            this.cbarabic.Size = new System.Drawing.Size(55, 17);
            this.cbarabic.TabIndex = 0;
            this.cbarabic.Text = "arabic";
            this.cbarabic.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdofemale);
            this.groupBox1.Controls.Add(this.rdomale);
            this.groupBox1.Location = new System.Drawing.Point(144, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 30);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(92, 8);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(56, 17);
            this.rdofemale.TabIndex = 1;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(0, 7);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(47, 17);
            this.rdomale.TabIndex = 0;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // datetpDOB
            // 
            this.datetpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetpDOB.Location = new System.Drawing.Point(144, 344);
            this.datetpDOB.Name = "datetpDOB";
            this.datetpDOB.Size = new System.Drawing.Size(200, 20);
            this.datetpDOB.TabIndex = 105;
            // 
            // cbocity
            // 
            this.cbocity.FormattingEnabled = true;
            this.cbocity.Items.AddRange(new object[] {
            "Jerusalem",
            "qalqilia",
            "london",
            "madrid",
            "rome",
            "istanbul"});
            this.cbocity.Location = new System.Drawing.Point(144, 265);
            this.cbocity.Name = "cbocity";
            this.cbocity.Size = new System.Drawing.Size(121, 21);
            this.cbocity.TabIndex = 104;
            // 
            // txtpatientID
            // 
            this.txtpatientID.Location = new System.Drawing.Point(144, 33);
            this.txtpatientID.Name = "txtpatientID";
            this.txtpatientID.Size = new System.Drawing.Size(100, 20);
            this.txtpatientID.TabIndex = 93;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(144, 76);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(100, 20);
            this.txtfirstname.TabIndex = 95;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(144, 111);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(100, 20);
            this.txtlastname.TabIndex = 97;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(144, 209);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(123, 42);
            this.txtaddress.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(382, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 654);
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(144, 183);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 120;
            // 
            // txtcontactNO
            // 
            this.txtcontactNO.Location = new System.Drawing.Point(144, 149);
            this.txtcontactNO.Name = "txtcontactNO";
            this.txtcontactNO.Size = new System.Drawing.Size(100, 20);
            this.txtcontactNO.TabIndex = 121;
            // 
            // contactNOlbl
            // 
            this.contactNOlbl.AutoSize = true;
            this.contactNOlbl.Location = new System.Drawing.Point(74, 149);
            this.contactNOlbl.Name = "contactNOlbl";
            this.contactNOlbl.Size = new System.Drawing.Size(59, 13);
            this.contactNOlbl.TabIndex = 122;
            this.contactNOlbl.Text = "contactNO";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(77, 181);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 13);
            this.lblemail.TabIndex = 123;
            this.lblemail.Text = "email";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 648);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.contactNOlbl);
            this.Controls.Add(this.txtcontactNO);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cboxdiagn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearchbox);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.DGVpatient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datetpDOB);
            this.Controls.Add(this.cbocity);
            this.Controls.Add(lblstudentID);
            this.Controls.Add(this.txtpatientID);
            this.Controls.Add(lblfirstName);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(lbllastname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(lbladdress);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(lblcity);
            this.Controls.Add(lblDOB);
            this.Controls.Add(lblGENDER);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(lbllangauges);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpatient)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cboxdiagn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearchbox;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView DGVpatient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbturkish;
        private System.Windows.Forms.CheckBox cbenglish;
        private System.Windows.Forms.CheckBox cbarabic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.DateTimePicker datetpDOB;
        private System.Windows.Forms.ComboBox cbocity;
        private System.Windows.Forms.TextBox txtpatientID;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcontactNO;
        private System.Windows.Forms.Label contactNOlbl;
        private System.Windows.Forms.Label lblemail;
    }
}