namespace HotelDreamSTS
{
    partial class TotalIncome
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
            this.btnIncomeShow = new System.Windows.Forms.Button();
            this.IncomeGridView = new System.Windows.Forms.DataGridView();
            this.IncomeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIncomes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.billTotal = new System.Windows.Forms.Button();
            this.BillDetails = new System.Windows.Forms.DataGridView();
            this.RoomCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvancePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBill = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncomeShow
            // 
            this.btnIncomeShow.AutoSize = true;
            this.btnIncomeShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomeShow.Location = new System.Drawing.Point(776, 52);
            this.btnIncomeShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncomeShow.Name = "btnIncomeShow";
            this.btnIncomeShow.Size = new System.Drawing.Size(165, 32);
            this.btnIncomeShow.TabIndex = 3;
            this.btnIncomeShow.Text = "Total Income >>";
            this.btnIncomeShow.UseVisualStyleBackColor = true;
            this.btnIncomeShow.Click += new System.EventHandler(this.btnIncomeShow_Click);
            // 
            // IncomeGridView
            // 
            this.IncomeGridView.AllowUserToAddRows = false;
            this.IncomeGridView.AllowUserToDeleteRows = false;
            this.IncomeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncomeDate,
            this.Loss,
            this.DailyIncome,
            this.TotalIncomes});
            this.IncomeGridView.Location = new System.Drawing.Point(19, 90);
            this.IncomeGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IncomeGridView.Name = "IncomeGridView";
            this.IncomeGridView.ReadOnly = true;
            this.IncomeGridView.Size = new System.Drawing.Size(919, 254);
            this.IncomeGridView.TabIndex = 4;
            // 
            // IncomeDate
            // 
            this.IncomeDate.DataPropertyName = "IncomeDate";
            this.IncomeDate.HeaderText = "IncomeDate";
            this.IncomeDate.Name = "IncomeDate";
            this.IncomeDate.ReadOnly = true;
            // 
            // Loss
            // 
            this.Loss.DataPropertyName = "Loss";
            this.Loss.HeaderText = "Loss";
            this.Loss.Name = "Loss";
            this.Loss.ReadOnly = true;
            // 
            // DailyIncome
            // 
            this.DailyIncome.DataPropertyName = "DailyIncome";
            this.DailyIncome.HeaderText = "DailyIncome";
            this.DailyIncome.Name = "DailyIncome";
            this.DailyIncome.ReadOnly = true;
            // 
            // TotalIncomes
            // 
            this.TotalIncomes.DataPropertyName = "TotalIncome";
            this.TotalIncomes.HeaderText = "TotalIncomes";
            this.TotalIncomes.Name = "TotalIncomes";
            this.TotalIncomes.ReadOnly = true;
            // 
            // CheckOut
            // 
            this.CheckOut.CustomFormat = "yyyy-MM-dd";
            this.CheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckOut.Location = new System.Drawing.Point(17, 15);
            this.CheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(264, 22);
            this.CheckOut.TabIndex = 77;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(772, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 32);
            this.btnBack.TabIndex = 78;
            this.btnBack.Text = "Back >>";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // billTotal
            // 
            this.billTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTotal.Location = new System.Drawing.Point(535, 351);
            this.billTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billTotal.Name = "billTotal";
            this.billTotal.Size = new System.Drawing.Size(191, 30);
            this.billTotal.TabIndex = 79;
            this.billTotal.Text = "BillAdded";
            this.billTotal.UseVisualStyleBackColor = true;
            this.billTotal.Click += new System.EventHandler(this.billTotal_Click);
            // 
            // BillDetails
            // 
            this.BillDetails.AllowUserToAddRows = false;
            this.BillDetails.AllowUserToDeleteRows = false;
            this.BillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomCost,
            this.FoodCost,
            this.ExtraCost,
            this.RoomNo,
            this.dataGridViewTextBoxColumn1,
            this.TotalBill,
            this.AdvancePaid});
            this.BillDetails.Location = new System.Drawing.Point(-45, 388);
            this.BillDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BillDetails.Name = "BillDetails";
            this.BillDetails.ReadOnly = true;
            this.BillDetails.Size = new System.Drawing.Size(987, 342);
            this.BillDetails.TabIndex = 80;
            // 
            // RoomCost
            // 
            this.RoomCost.DataPropertyName = "RoomCost";
            this.RoomCost.HeaderText = "RoomCost";
            this.RoomCost.Name = "RoomCost";
            this.RoomCost.ReadOnly = true;
            // 
            // FoodCost
            // 
            this.FoodCost.DataPropertyName = "FoodCost";
            this.FoodCost.HeaderText = "FoodCost";
            this.FoodCost.Name = "FoodCost";
            this.FoodCost.ReadOnly = true;
            // 
            // ExtraCost
            // 
            this.ExtraCost.DataPropertyName = "ExtraCost";
            this.ExtraCost.HeaderText = "ExtraCost";
            this.ExtraCost.Name = "ExtraCost";
            this.ExtraCost.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "RoomNo";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BillNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "BillNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TotalBill
            // 
            this.TotalBill.DataPropertyName = "TotalBill";
            this.TotalBill.HeaderText = "TotalBill";
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.ReadOnly = true;
            // 
            // AdvancePaid
            // 
            this.AdvancePaid.DataPropertyName = "AdvancePaid";
            this.AdvancePaid.HeaderText = "AdvancePaid";
            this.AdvancePaid.Name = "AdvancePaid";
            this.AdvancePaid.ReadOnly = true;
            // 
            // textBill
            // 
            this.textBill.Location = new System.Drawing.Point(41, 356);
            this.textBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBill.Name = "textBill";
            this.textBill.Size = new System.Drawing.Size(380, 22);
            this.textBill.TabIndex = 81;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(733, 351);
            this.update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(191, 30);
            this.update.TabIndex = 82;
            this.update.Text = "BillUpdated";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // TotalIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 660);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textBill);
            this.Controls.Add(this.BillDetails);
            this.Controls.Add(this.billTotal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.IncomeGridView);
            this.Controls.Add(this.btnIncomeShow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TotalIncome";
            this.Text = "TotalIncome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TotalIncome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncomeShow;
        private System.Windows.Forms.DataGridView IncomeGridView;
        private System.Windows.Forms.DateTimePicker CheckOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button billTotal;
        private System.Windows.Forms.DataGridView BillDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvancePaid;
        private System.Windows.Forms.TextBox textBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loss;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIncomes;
        private System.Windows.Forms.Button update;
    }
}