namespace HotelDreamSTS
{
    partial class MPage4
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
            this.Billaddedcombo = new System.Windows.Forms.Button();
            this.comboServiceID = new System.Windows.Forms.ComboBox();
            this.SID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomNocomboBox = new System.Windows.Forms.ComboBox();
            this.UniversalSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExtraService = new System.Windows.Forms.DataGridView();
            this.ExtraServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.Billaddedcombo);
            this.panel2.Controls.Add(this.comboServiceID);
            this.panel2.Controls.Add(this.SID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.RoomNocomboBox);
            this.panel2.Controls.Add(this.UniversalSearch);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Location = new System.Drawing.Point(4, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 224);
            this.panel2.TabIndex = 4;
            // 
            // Billaddedcombo
            // 
            this.Billaddedcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billaddedcombo.Location = new System.Drawing.Point(333, 22);
            this.Billaddedcombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Billaddedcombo.Name = "Billaddedcombo";
            this.Billaddedcombo.Size = new System.Drawing.Size(144, 62);
            this.Billaddedcombo.TabIndex = 74;
            this.Billaddedcombo.Text = "Add to Bill";
            this.Billaddedcombo.UseVisualStyleBackColor = true;
            this.Billaddedcombo.Click += new System.EventHandler(this.Billaddedcombo_Click);
            // 
            // comboServiceID
            // 
            this.comboServiceID.BackColor = System.Drawing.Color.ForestGreen;
            this.comboServiceID.ForeColor = System.Drawing.SystemColors.Window;
            this.comboServiceID.FormattingEnabled = true;
            this.comboServiceID.Items.AddRange(new object[] {
            "CinemaHall",
            "Gym",
            "Pool",
            "Spa and Parlor"});
            this.comboServiceID.Location = new System.Drawing.Point(136, 58);
            this.comboServiceID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboServiceID.Name = "comboServiceID";
            this.comboServiceID.Size = new System.Drawing.Size(188, 24);
            this.comboServiceID.TabIndex = 73;
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID.Location = new System.Drawing.Point(36, 64);
            this.SID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(91, 20);
            this.SID.TabIndex = 72;
            this.SID.Text = "ServiceID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 71;
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
            this.RoomNocomboBox.Location = new System.Drawing.Point(136, 26);
            this.RoomNocomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomNocomboBox.Name = "RoomNocomboBox";
            this.RoomNocomboBox.Size = new System.Drawing.Size(188, 24);
            this.RoomNocomboBox.TabIndex = 70;
            // 
            // UniversalSearch
            // 
            this.UniversalSearch.Location = new System.Drawing.Point(7, 183);
            this.UniversalSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UniversalSearch.Multiline = true;
            this.UniversalSearch.Name = "UniversalSearch";
            this.UniversalSearch.Size = new System.Drawing.Size(373, 37);
            this.UniversalSearch.TabIndex = 14;
            this.UniversalSearch.TextChanged += new System.EventHandler(this.UniversalSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(784, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 119);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back to All Options";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(389, 183);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 39);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(671, 183);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(212, 39);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show Service Info";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.ExtraService);
            this.panel1.Location = new System.Drawing.Point(4, 234);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 377);
            this.panel1.TabIndex = 5;
            // 
            // ExtraService
            // 
            this.ExtraService.AllowUserToAddRows = false;
            this.ExtraService.AllowUserToDeleteRows = false;
            this.ExtraService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExtraService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExtraServices,
            this.ServiceID,
            this.ServiceCost,
            this.RoomNo});
            this.ExtraService.Location = new System.Drawing.Point(15, 18);
            this.ExtraService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtraService.Name = "ExtraService";
            this.ExtraService.ReadOnly = true;
            this.ExtraService.Size = new System.Drawing.Size(864, 342);
            this.ExtraService.TabIndex = 0;
            // 
            // ExtraServices
            // 
            this.ExtraServices.DataPropertyName = "ExtraService";
            this.ExtraServices.HeaderText = "ExtraServices";
            this.ExtraServices.Name = "ExtraServices";
            this.ExtraServices.ReadOnly = true;
            // 
            // ServiceID
            // 
            this.ServiceID.DataPropertyName = "ServiceID";
            this.ServiceID.HeaderText = "ServiceID";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            // 
            // ServiceCost
            // 
            this.ServiceCost.DataPropertyName = "ServiceCost";
            this.ServiceCost.HeaderText = "ServiceCost";
            this.ServiceCost.Name = "ServiceCost";
            this.ServiceCost.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "RoomNo";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // MPage4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(901, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MPage4";
            this.Text = "MPage4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MPage4_FormClosed);
            this.Load += new System.EventHandler(this.MPage4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExtraService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ExtraService;
        private System.Windows.Forms.TextBox UniversalSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.Button Billaddedcombo;
        private System.Windows.Forms.ComboBox comboServiceID;
        private System.Windows.Forms.Label SID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoomNocomboBox;
    }
}