
namespace StaffDetails
{
    partial class Form1
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
            this.btnSearchPost = new System.Windows.Forms.Button();
            this.txtSnid = new System.Windows.Forms.TextBox();
            this.btnRemoveS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpSjoining = new System.Windows.Forms.DateTimePicker();
            this.txtSPhone = new System.Windows.Forms.TextBox();
            this.txtSAdd = new System.Windows.Forms.TextBox();
            this.btnAddS = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.btnSdetails = new System.Windows.Forms.Button();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbSsalary = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.cmbSSearchPost = new System.Windows.Forms.ComboBox();
            this.dGVstf = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVstf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPost
            // 
            this.btnSearchPost.AutoSize = true;
            this.btnSearchPost.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPost.Location = new System.Drawing.Point(540, 6);
            this.btnSearchPost.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPost.Name = "btnSearchPost";
            this.btnSearchPost.Size = new System.Drawing.Size(134, 29);
            this.btnSearchPost.TabIndex = 33;
            this.btnSearchPost.Text = "Search By Post";
            this.btnSearchPost.UseVisualStyleBackColor = true;
            // 
            // txtSnid
            // 
            this.txtSnid.Location = new System.Drawing.Point(109, 151);
            this.txtSnid.Margin = new System.Windows.Forms.Padding(2);
            this.txtSnid.Name = "txtSnid";
            this.txtSnid.Size = new System.Drawing.Size(181, 20);
            this.txtSnid.TabIndex = 32;
            // 
            // btnRemoveS
            // 
            this.btnRemoveS.Location = new System.Drawing.Point(285, 240);
            this.btnRemoveS.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveS.Name = "btnRemoveS";
            this.btnRemoveS.Size = new System.Drawing.Size(59, 21);
            this.btnRemoveS.TabIndex = 31;
            this.btnRemoveS.Text = "Remove";
            this.btnRemoveS.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "NID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Staff Joining Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Phone Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Address";
            // 
            // dtpSjoining
            // 
            this.dtpSjoining.CustomFormat = "";
            this.dtpSjoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSjoining.Location = new System.Drawing.Point(109, 121);
            this.dtpSjoining.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSjoining.Name = "dtpSjoining";
            this.dtpSjoining.Size = new System.Drawing.Size(181, 20);
            this.dtpSjoining.TabIndex = 26;
            // 
            // txtSPhone
            // 
            this.txtSPhone.Location = new System.Drawing.Point(109, 91);
            this.txtSPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.Size = new System.Drawing.Size(181, 20);
            this.txtSPhone.TabIndex = 25;
            // 
            // txtSAdd
            // 
            this.txtSAdd.Location = new System.Drawing.Point(109, 66);
            this.txtSAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtSAdd.Name = "txtSAdd";
            this.txtSAdd.Size = new System.Drawing.Size(181, 20);
            this.txtSAdd.TabIndex = 24;
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(208, 240);
            this.btnAddS.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(59, 21);
            this.btnAddS.TabIndex = 23;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 41);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Staff ID";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(109, 41);
            this.txtSName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(181, 20);
            this.txtSName.TabIndex = 8;
            // 
            // btnSdetails
            // 
            this.btnSdetails.AutoSize = true;
            this.btnSdetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSdetails.Location = new System.Drawing.Point(669, 234);
            this.btnSdetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnSdetails.Name = "btnSdetails";
            this.btnSdetails.Size = new System.Drawing.Size(144, 30);
            this.btnSdetails.TabIndex = 2;
            this.btnSdetails.Text = "Staff Details >>";
            this.btnSdetails.UseVisualStyleBackColor = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // StaffPost
            // 
            this.StaffPost.DataPropertyName = "StaffPost";
            this.StaffPost.HeaderText = "Staff Post";
            this.StaffPost.Name = "StaffPost";
            this.StaffPost.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.cmbSsalary);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbPost);
            this.panel2.Controls.Add(this.cmbSSearchPost);
            this.panel2.Controls.Add(this.dGVstf);
            this.panel2.Controls.Add(this.btnSearchPost);
            this.panel2.Controls.Add(this.txtSnid);
            this.panel2.Controls.Add(this.btnRemoveS);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dtpSjoining);
            this.panel2.Controls.Add(this.txtSPhone);
            this.panel2.Controls.Add(this.txtSAdd);
            this.panel2.Controls.Add(this.btnAddS);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtSName);
            this.panel2.Controls.Add(this.txtSID);
            this.panel2.Controls.Add(this.btnSdetails);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 523);
            this.panel2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "STAFF BOARD";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(121, 241);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 20);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnBack.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(731, 115);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 37);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // cmbSsalary
            // 
            this.cmbSsalary.FormattingEnabled = true;
            this.cmbSsalary.Items.AddRange(new object[] {
            " 8000",
            "12000",
            "10000",
            "6000"});
            this.cmbSsalary.Location = new System.Drawing.Point(109, 214);
            this.cmbSsalary.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSsalary.Name = "cmbSsalary";
            this.cmbSsalary.Size = new System.Drawing.Size(92, 21);
            this.cmbSsalary.TabIndex = 40;
            this.cmbSsalary.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Staff Post";
            // 
            // cmbPost
            // 
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Items.AddRange(new object[] {
            "Junior",
            "Senior",
            "Cleaner",
            "Security "});
            this.cmbPost.Location = new System.Drawing.Point(109, 174);
            this.cmbPost.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(92, 21);
            this.cmbPost.TabIndex = 36;
            this.cmbPost.Text = ".";
            // 
            // cmbSSearchPost
            // 
            this.cmbSSearchPost.FormattingEnabled = true;
            this.cmbSSearchPost.Items.AddRange(new object[] {
            "Junior",
            "Senior",
            "Security ",
            "Cleaner"});
            this.cmbSSearchPost.Location = new System.Drawing.Point(679, 12);
            this.cmbSSearchPost.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSSearchPost.Name = "cmbSSearchPost";
            this.cmbSSearchPost.Size = new System.Drawing.Size(134, 21);
            this.cmbSSearchPost.TabIndex = 35;
            // 
            // dGVstf
            // 
            this.dGVstf.AllowUserToAddRows = false;
            this.dGVstf.AllowUserToDeleteRows = false;
            this.dGVstf.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVstf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVstf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.StaffName,
            this.Address,
            this.PhoneNumber,
            this.StaffJoiningDate,
            this.NID,
            this.StaffPost,
            this.Salary});
            this.dGVstf.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVstf.Location = new System.Drawing.Point(-3, 277);
            this.dGVstf.Margin = new System.Windows.Forms.Padding(2);
            this.dGVstf.Name = "dGVstf";
            this.dGVstf.ReadOnly = true;
            this.dGVstf.RowTemplate.Height = 24;
            this.dGVstf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVstf.Size = new System.Drawing.Size(860, 220);
            this.dGVstf.TabIndex = 34;
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.HeaderText = "Staff ID";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "Staff Name";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // StaffJoiningDate
            // 
            this.StaffJoiningDate.DataPropertyName = "StaffJoiningDate";
            this.StaffJoiningDate.HeaderText = "Staff Joining Date";
            this.StaffJoiningDate.Name = "StaffJoiningDate";
            this.StaffJoiningDate.ReadOnly = true;
            // 
            // NID
            // 
            this.NID.DataPropertyName = "NID";
            this.NID.HeaderText = "NID";
            this.NID.Name = "NID";
            this.NID.ReadOnly = true;
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(109, 14);
            this.txtSID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(181, 20);
            this.txtSID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 494);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "StaffDetails";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVstf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPost;
        private System.Windows.Forms.TextBox txtSnid;
        private System.Windows.Forms.Button btnRemoveS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpSjoining;
        private System.Windows.Forms.TextBox txtSPhone;
        private System.Windows.Forms.TextBox txtSAdd;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Button btnSdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbSsalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.ComboBox cmbSSearchPost;
        private System.Windows.Forms.DataGridView dGVstf;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NID;
        private System.Windows.Forms.TextBox txtSID;
    }
}

