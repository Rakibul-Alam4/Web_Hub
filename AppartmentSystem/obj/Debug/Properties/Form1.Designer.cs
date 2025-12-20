
namespace ManagerDetails
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
            this.txtMnid = new System.Windows.Forms.TextBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMjoining = new System.Windows.Forms.DateTimePicker();
            this.txtMPhone = new System.Windows.Forms.TextBox();
            this.txtMAdd = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtMID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMShow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtMsalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMIDsearch = new System.Windows.Forms.TextBox();
            this.dGVman = new System.Windows.Forms.DataGridView();
            this.ManagerJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVman)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMnid
            // 
            this.txtMnid.Location = new System.Drawing.Point(124, 195);
            this.txtMnid.Margin = new System.Windows.Forms.Padding(2);
            this.txtMnid.Name = "txtMnid";
            this.txtMnid.Size = new System.Drawing.Size(181, 20);
            this.txtMnid.TabIndex = 22;
            // 
            // btnSearchID
            // 
            this.btnSearchID.AutoSize = true;
            this.btnSearchID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchID.Location = new System.Drawing.Point(471, 11);
            this.btnSearchID.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(119, 29);
            this.btnSearchID.TabIndex = 21;
            this.btnSearchID.Text = "Search By ID";
            this.btnSearchID.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(376, 246);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(62, 20);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "NID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Manager Joining Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Manager Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manager ID";
            // 
            // dtpMjoining
            // 
            this.dtpMjoining.CustomFormat = "";
            this.dtpMjoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMjoining.Location = new System.Drawing.Point(124, 161);
            this.dtpMjoining.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMjoining.Name = "dtpMjoining";
            this.dtpMjoining.Size = new System.Drawing.Size(181, 20);
            this.dtpMjoining.TabIndex = 12;
            // 
            // txtMPhone
            // 
            this.txtMPhone.Location = new System.Drawing.Point(124, 123);
            this.txtMPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtMPhone.Name = "txtMPhone";
            this.txtMPhone.Size = new System.Drawing.Size(181, 20);
            this.txtMPhone.TabIndex = 10;
            // 
            // txtMAdd
            // 
            this.txtMAdd.Location = new System.Drawing.Point(124, 93);
            this.txtMAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtMAdd.Name = "txtMAdd";
            this.txtMAdd.Size = new System.Drawing.Size(181, 20);
            this.txtMAdd.TabIndex = 9;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(124, 60);
            this.txtMName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(181, 20);
            this.txtMName.TabIndex = 8;
            // 
            // txtMID
            // 
            this.txtMID.Location = new System.Drawing.Point(124, 26);
            this.txtMID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(181, 20);
            this.txtMID.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(301, 246);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 20);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // NID
            // 
            this.NID.DataPropertyName = "NID";
            this.NID.HeaderText = "NID";
            this.NID.Name = "NID";
            this.NID.ReadOnly = true;
            // 
            // PhoneNo
            // 
            this.PhoneNo.DataPropertyName = "PhoneNo";
            this.PhoneNo.HeaderText = "Phone Number";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // ManagerName
            // 
            this.ManagerName.DataPropertyName = "ManagerName";
            this.ManagerName.HeaderText = "Manager Name";
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.ReadOnly = true;
            // 
            // ManagerId
            // 
            this.ManagerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerId.DataPropertyName = "ManagerID";
            this.ManagerId.HeaderText = "Manager ID";
            this.ManagerId.Name = "ManagerId";
            this.ManagerId.ReadOnly = true;
            // 
            // btnMShow
            // 
            this.btnMShow.AutoSize = true;
            this.btnMShow.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMShow.Location = new System.Drawing.Point(633, 240);
            this.btnMShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnMShow.Name = "btnMShow";
            this.btnMShow.Size = new System.Drawing.Size(162, 29);
            this.btnMShow.TabIndex = 44;
            this.btnMShow.Text = "Manager Details >>";
            this.btnMShow.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnBack.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(676, 89);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 84);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // txtMsalary
            // 
            this.txtMsalary.Location = new System.Drawing.Point(124, 223);
            this.txtMsalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtMsalary.Name = "txtMsalary";
            this.txtMsalary.Size = new System.Drawing.Size(181, 20);
            this.txtMsalary.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Salary";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(224, 246);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 20);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txtMIDsearch
            // 
            this.txtMIDsearch.Location = new System.Drawing.Point(613, 15);
            this.txtMIDsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtMIDsearch.Name = "txtMIDsearch";
            this.txtMIDsearch.Size = new System.Drawing.Size(138, 20);
            this.txtMIDsearch.TabIndex = 24;
            // 
            // dGVman
            // 
            this.dGVman.AllowUserToAddRows = false;
            this.dGVman.AllowUserToDeleteRows = false;
            this.dGVman.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManagerId,
            this.ManagerName,
            this.Address,
            this.PhoneNo,
            this.NID,
            this.ManagerJoiningDate,
            this.Salary});
            this.dGVman.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGVman.Location = new System.Drawing.Point(0, 271);
            this.dGVman.Margin = new System.Windows.Forms.Padding(2);
            this.dGVman.Name = "dGVman";
            this.dGVman.ReadOnly = true;
            this.dGVman.RowTemplate.Height = 24;
            this.dGVman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVman.Size = new System.Drawing.Size(826, 268);
            this.dGVman.TabIndex = 23;
            // 
            // ManagerJoiningDate
            // 
            this.ManagerJoiningDate.DataPropertyName = "ManagerJoiningDate";
            this.ManagerJoiningDate.HeaderText = "Manager Joining Date";
            this.ManagerJoiningDate.Name = "ManagerJoiningDate";
            this.ManagerJoiningDate.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, -21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "MANAGER BOARD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnMShow);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtMsalary);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtMIDsearch);
            this.panel1.Controls.Add(this.dGVman);
            this.panel1.Controls.Add(this.txtMnid);
            this.panel1.Controls.Add(this.btnSearchID);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpMjoining);
            this.panel1.Controls.Add(this.txtMPhone);
            this.panel1.Controls.Add(this.txtMAdd);
            this.panel1.Controls.Add(this.txtMName);
            this.panel1.Controls.Add(this.txtMID);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.panel1.Location = new System.Drawing.Point(11, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 543);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 526);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ManagerDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dGVman)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMnid;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMjoining;
        private System.Windows.Forms.TextBox txtMPhone;
        private System.Windows.Forms.TextBox txtMAdd;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtMID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn NID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerId;
        private System.Windows.Forms.Button btnMShow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtMsalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMIDsearch;
        private System.Windows.Forms.DataGridView dGVman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerJoiningDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}

