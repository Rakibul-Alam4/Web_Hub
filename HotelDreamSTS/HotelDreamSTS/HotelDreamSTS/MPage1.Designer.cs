namespace HotelDreamSTS
{
    partial class MPage1
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
            this.UniversalSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HRoom = new System.Windows.Forms.DataGridView();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.UniversalSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 224);
            this.panel2.TabIndex = 5;
            // 
            // UniversalSearch
            // 
            this.UniversalSearch.Location = new System.Drawing.Point(15, 181);
            this.UniversalSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UniversalSearch.Multiline = true;
            this.UniversalSearch.Name = "UniversalSearch";
            this.UniversalSearch.Size = new System.Drawing.Size(373, 37);
            this.UniversalSearch.TabIndex = 6;
            this.UniversalSearch.TextChanged += new System.EventHandler(this.UniversalSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(397, 181);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 39);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(792, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 119);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to All Options";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(707, 181);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(184, 39);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Room Info";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.HRoom);
            this.panel1.Location = new System.Drawing.Point(5, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 377);
            this.panel1.TabIndex = 6;
            // 
            // HRoom
            // 
            this.HRoom.AllowUserToAddRows = false;
            this.HRoom.AllowUserToDeleteRows = false;
            this.HRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNo,
            this.RoomCategory,
            this.BookingState,
            this.RoomCost,
            this.CustomerID});
            this.HRoom.Location = new System.Drawing.Point(15, 18);
            this.HRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HRoom.Name = "HRoom";
            this.HRoom.ReadOnly = true;
            this.HRoom.Size = new System.Drawing.Size(864, 342);
            this.HRoom.TabIndex = 0;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "RoomNo";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // RoomCategory
            // 
            this.RoomCategory.DataPropertyName = "RoomCategory";
            this.RoomCategory.HeaderText = "RoomCategory";
            this.RoomCategory.Name = "RoomCategory";
            this.RoomCategory.ReadOnly = true;
            // 
            // BookingState
            // 
            this.BookingState.DataPropertyName = "BookingState";
            this.BookingState.HeaderText = "BookingState";
            this.BookingState.Name = "BookingState";
            this.BookingState.ReadOnly = true;
            // 
            // RoomCost
            // 
            this.RoomCost.DataPropertyName = "RoomCost";
            this.RoomCost.HeaderText = "RoomCost";
            this.RoomCost.Name = "RoomCost";
            this.RoomCost.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // MPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(901, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MPage1";
            this.Text = "MPage1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MPage1_FormClosed);
            this.Load += new System.EventHandler(this.MPage1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView HRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingState;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox UniversalSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}