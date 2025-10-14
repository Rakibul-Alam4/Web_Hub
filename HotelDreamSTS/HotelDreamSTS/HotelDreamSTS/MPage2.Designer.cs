namespace HotelDreamSTS
{
    partial class MPage2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateNow = new System.Windows.Forms.DateTimePicker();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.comboBill = new System.Windows.Forms.ComboBox();
            this.Bill = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.Advance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomNocomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Checkin = new System.Windows.Forms.DateTimePicker();
            this.Entry = new System.Windows.Forms.DateTimePicker();
            this.CPhone = new System.Windows.Forms.TextBox();
            this.IDcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.UniversalSearch = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerDetails = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvancePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.DateNow);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.comboBill);
            this.panel2.Controls.Add(this.Bill);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.Advance);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.RoomNocomboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Checkin);
            this.panel2.Controls.Add(this.Entry);
            this.panel2.Controls.Add(this.CPhone);
            this.panel2.Controls.Add(this.IDcomboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.UniversalSearch);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 224);
            this.panel2.TabIndex = 5;
            // 
            // DateNow
            // 
            this.DateNow.CustomFormat = "yyyy-MM-dd";
            this.DateNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNow.Location = new System.Drawing.Point(879, 28);
            this.DateNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateNow.Name = "DateNow";
            this.DateNow.Size = new System.Drawing.Size(117, 22);
            this.DateNow.TabIndex = 66;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(813, 113);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 62);
            this.btn_Edit.TabIndex = 65;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // comboBill
            // 
            this.comboBill.BackColor = System.Drawing.Color.ForestGreen;
            this.comboBill.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBill.FormattingEnabled = true;
            this.comboBill.Items.AddRange(new object[] {
            "b-02",
            "b-03",
            "b-04",
            "b-05",
            "b-06",
            "b-07",
            "b-08",
            "b-09",
            "b-10"});
            this.comboBill.Location = new System.Drawing.Point(585, 47);
            this.comboBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBill.Name = "comboBill";
            this.comboBill.Size = new System.Drawing.Size(284, 24);
            this.comboBill.TabIndex = 63;
            // 
            // Bill
            // 
            this.Bill.AutoSize = true;
            this.Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill.Location = new System.Drawing.Point(485, 53);
            this.Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(60, 20);
            this.Bill.TabIndex = 62;
            this.Bill.Text = "BillNo";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(708, 113);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 97);
            this.btnClear.TabIndex = 61;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Advance
            // 
            this.Advance.Location = new System.Drawing.Point(585, 81);
            this.Advance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Advance.Name = "Advance";
            this.Advance.Size = new System.Drawing.Size(284, 22);
            this.Advance.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Advance";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(489, 112);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 97);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(599, 112);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 97);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(485, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "RoomNo";
            // 
            // RoomNocomboBox
            // 
            this.RoomNocomboBox.BackColor = System.Drawing.Color.ForestGreen;
            this.RoomNocomboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.RoomNocomboBox.FormattingEnabled = true;
            this.RoomNocomboBox.Items.AddRange(new object[] {
            "102",
            "103",
            "104",
            "105",
            "201",
            "202",
            "203",
            "204",
            "205"});
            this.RoomNocomboBox.Location = new System.Drawing.Point(585, 15);
            this.RoomNocomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomNocomboBox.Name = "RoomNocomboBox";
            this.RoomNocomboBox.Size = new System.Drawing.Size(284, 24);
            this.RoomNocomboBox.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "CheckOut Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Entry Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Customer Phone";
            // 
            // Checkin
            // 
            this.Checkin.CustomFormat = "yyyy-MM-dd";
            this.Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Checkin.Location = new System.Drawing.Point(180, 145);
            this.Checkin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Checkin.Name = "Checkin";
            this.Checkin.Size = new System.Drawing.Size(264, 22);
            this.Checkin.TabIndex = 50;
            // 
            // Entry
            // 
            this.Entry.CustomFormat = "yyyy-MM-dd";
            this.Entry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Entry.Location = new System.Drawing.Point(180, 113);
            this.Entry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(264, 22);
            this.Entry.TabIndex = 49;
            // 
            // CPhone
            // 
            this.CPhone.Location = new System.Drawing.Point(180, 81);
            this.CPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CPhone.Name = "CPhone";
            this.CPhone.Size = new System.Drawing.Size(264, 22);
            this.CPhone.TabIndex = 48;
            // 
            // IDcomboBox
            // 
            this.IDcomboBox.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.IDcomboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.IDcomboBox.FormattingEnabled = true;
            this.IDcomboBox.Items.AddRange(new object[] {
            "1002",
            "1003",
            "1004",
            "1005",
            "1006",
            "1007",
            "1008",
            "1009",
            "1010",
            "1011"});
            this.IDcomboBox.Location = new System.Drawing.Point(180, 47);
            this.IDcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDcomboBox.Name = "IDcomboBox";
            this.IDcomboBox.Size = new System.Drawing.Size(264, 24);
            this.IDcomboBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Customer Name";
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(180, 15);
            this.CName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(264, 22);
            this.CName.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(387, 180);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 39);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UniversalSearch
            // 
            this.UniversalSearch.BackColor = System.Drawing.SystemColors.Info;
            this.UniversalSearch.Location = new System.Drawing.Point(4, 181);
            this.UniversalSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UniversalSearch.Multiline = true;
            this.UniversalSearch.Name = "UniversalSearch";
            this.UniversalSearch.Size = new System.Drawing.Size(373, 37);
            this.UniversalSearch.TabIndex = 7;
            this.UniversalSearch.TextChanged += new System.EventHandler(this.UniversalSearch_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(879, 181);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(225, 39);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Customer Info";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1005, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 119);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to All Options";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.CustomerDetails);
            this.panel1.Location = new System.Drawing.Point(1, 234);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 377);
            this.panel1.TabIndex = 6;
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.AllowUserToAddRows = false;
            this.CustomerDetails.AllowUserToDeleteRows = false;
            this.CustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.CustomerID,
            this.CustomerPhone,
            this.EntryDate,
            this.CheckOutDate,
            this.AdvancePaid,
            this.BillNo,
            this.RoomNo});
            this.CustomerDetails.Location = new System.Drawing.Point(15, 18);
            this.CustomerDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.ReadOnly = true;
            this.CustomerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDetails.Size = new System.Drawing.Size(1089, 342);
            this.CustomerDetails.TabIndex = 0;
            this.CustomerDetails.DoubleClick += new System.EventHandler(this.CustomerDetails_DoubleClick);
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.DataPropertyName = "CustomerPhone";
            this.CustomerPhone.HeaderText = "CustomerPhone";
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.ReadOnly = true;
            // 
            // EntryDate
            // 
            this.EntryDate.DataPropertyName = "EntryDate";
            this.EntryDate.HeaderText = "EntryDate";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.DataPropertyName = "CheckOutDate";
            this.CheckOutDate.HeaderText = "CheckOutDate";
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.ReadOnly = true;
            // 
            // AdvancePaid
            // 
            this.AdvancePaid.DataPropertyName = "AdvancePaid";
            this.AdvancePaid.HeaderText = "AdvancePaid";
            this.AdvancePaid.Name = "AdvancePaid";
            this.AdvancePaid.ReadOnly = true;
            // 
            // BillNo
            // 
            this.BillNo.DataPropertyName = "BillNo";
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "RoomNo";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // MPage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1111, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MPage2";
            this.Text = "MPage2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MPage2_FormClosed);
            this.Load += new System.EventHandler(this.MPage2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CustomerDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox UniversalSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox Advance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoomNocomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Checkin;
        private System.Windows.Forms.DateTimePicker Entry;
        private System.Windows.Forms.TextBox CPhone;
        private System.Windows.Forms.ComboBox IDcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comboBill;
        private System.Windows.Forms.Label Bill;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvancePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DateTimePicker DateNow;
    }
}