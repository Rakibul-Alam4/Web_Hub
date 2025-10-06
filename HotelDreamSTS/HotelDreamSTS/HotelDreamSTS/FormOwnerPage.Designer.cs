namespace HotelDreamSTS
{
    partial class FormOwnerPage
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStaffDetalis = new System.Windows.Forms.Button();
            this.btnManagerDetails = new System.Windows.Forms.Button();
            this.TotalIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnBack.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(500, 370);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 103);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStaffDetalis
            // 
            this.btnStaffDetalis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStaffDetalis.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnStaffDetalis.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDetalis.Location = new System.Drawing.Point(131, 171);
            this.btnStaffDetalis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffDetalis.Name = "btnStaffDetalis";
            this.btnStaffDetalis.Size = new System.Drawing.Size(340, 81);
            this.btnStaffDetalis.TabIndex = 6;
            this.btnStaffDetalis.Text = "Staff Information";
            this.btnStaffDetalis.UseVisualStyleBackColor = false;
            this.btnStaffDetalis.Click += new System.EventHandler(this.btnStaffDetalis_Click);
            // 
            // btnManagerDetails
            // 
            this.btnManagerDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManagerDetails.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnManagerDetails.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerDetails.Location = new System.Drawing.Point(131, 65);
            this.btnManagerDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagerDetails.Name = "btnManagerDetails";
            this.btnManagerDetails.Size = new System.Drawing.Size(340, 90);
            this.btnManagerDetails.TabIndex = 5;
            this.btnManagerDetails.Text = " Manager Information";
            this.btnManagerDetails.UseVisualStyleBackColor = false;
            this.btnManagerDetails.Click += new System.EventHandler(this.btnManagerDetails_Click);
            // 
            // TotalIncome
            // 
            this.TotalIncome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalIncome.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.TotalIncome.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIncome.Location = new System.Drawing.Point(131, 270);
            this.TotalIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalIncome.Name = "TotalIncome";
            this.TotalIncome.Size = new System.Drawing.Size(340, 81);
            this.TotalIncome.TabIndex = 8;
            this.TotalIncome.Text = "IncomeDetails";
            this.TotalIncome.UseVisualStyleBackColor = false;
            this.TotalIncome.Click += new System.EventHandler(this.TotalIncome_Click);
            // 
            // FormOwnerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 487);
            this.Controls.Add(this.TotalIncome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStaffDetalis);
            this.Controls.Add(this.btnManagerDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOwnerPage";
            this.Text = "FormOwnerPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOwnerPage_FormClosed);
            this.Load += new System.EventHandler(this.FormOwnerPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStaffDetalis;
        private System.Windows.Forms.Button btnManagerDetails;
        private System.Windows.Forms.Button TotalIncome;
    }
}