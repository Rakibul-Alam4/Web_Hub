
namespace page2
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
            this.TotalIncome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStaffDetalis = new System.Windows.Forms.Button();
            this.btnManagerDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalIncome
            // 
            this.TotalIncome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalIncome.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.TotalIncome.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIncome.Location = new System.Drawing.Point(218, 259);
            this.TotalIncome.Margin = new System.Windows.Forms.Padding(2);
            this.TotalIncome.Name = "TotalIncome";
            this.TotalIncome.Size = new System.Drawing.Size(255, 66);
            this.TotalIncome.TabIndex = 12;
            this.TotalIncome.Text = "IncomeDetails";
            this.TotalIncome.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnBack.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(564, 334);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 84);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnStaffDetalis
            // 
            this.btnStaffDetalis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStaffDetalis.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnStaffDetalis.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDetalis.Location = new System.Drawing.Point(218, 163);
            this.btnStaffDetalis.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffDetalis.Name = "btnStaffDetalis";
            this.btnStaffDetalis.Size = new System.Drawing.Size(255, 66);
            this.btnStaffDetalis.TabIndex = 10;
            this.btnStaffDetalis.Text = "Staff Information";
            this.btnStaffDetalis.UseVisualStyleBackColor = false;
            // 
            // btnManagerDetails
            // 
            this.btnManagerDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManagerDetails.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnManagerDetails.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerDetails.Location = new System.Drawing.Point(218, 59);
            this.btnManagerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnManagerDetails.Name = "btnManagerDetails";
            this.btnManagerDetails.Size = new System.Drawing.Size(255, 73);
            this.btnManagerDetails.TabIndex = 9;
            this.btnManagerDetails.Text = " Manager Information";
            this.btnManagerDetails.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.TotalIncome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStaffDetalis);
            this.Controls.Add(this.btnManagerDetails);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TotalIncome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStaffDetalis;
        private System.Windows.Forms.Button btnManagerDetails;
    }
}

