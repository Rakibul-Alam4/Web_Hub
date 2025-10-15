namespace HotelDreamSTS
{
    partial class MPage3
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
            this.UnPaid = new System.Windows.Forms.Button();
            this.Paid = new System.Windows.Forms.Button();
            this.UniversalSearch = new System.Windows.Forms.TextBox();
            this.comboFoodID = new System.Windows.Forms.ComboBox();
            this.FID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.RoomNocomboBox = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FoodMenu = new System.Windows.Forms.DataGridView();
            this.FoodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.UnPaid);
            this.panel2.Controls.Add(this.Paid);
            this.panel2.Controls.Add(this.UniversalSearch);
            this.panel2.Controls.Add(this.comboFoodID);
            this.panel2.Controls.Add(this.FID);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.RoomNocomboBox);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 224);
            this.panel2.TabIndex = 5;
            // 
            // UnPaid
            // 
            this.UnPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnPaid.Location = new System.Drawing.Point(469, 12);
            this.UnPaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnPaid.Name = "UnPaid";
            this.UnPaid.Size = new System.Drawing.Size(156, 62);
            this.UnPaid.TabIndex = 70;
            this.UnPaid.Text = "Unpaid";
            this.UnPaid.UseVisualStyleBackColor = true;
            this.UnPaid.Click += new System.EventHandler(this.UnPaid_Click);
            // 
            // Paid
            // 
            this.Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paid.Location = new System.Drawing.Point(317, 12);
            this.Paid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(144, 62);
            this.Paid.TabIndex = 69;
            this.Paid.Text = "Paid";
            this.Paid.UseVisualStyleBackColor = true;
            this.Paid.Click += new System.EventHandler(this.Paid_Click);
            // 
            // UniversalSearch
            // 
            this.UniversalSearch.Location = new System.Drawing.Point(11, 181);
            this.UniversalSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UniversalSearch.Multiline = true;
            this.UniversalSearch.Name = "UniversalSearch";
            this.UniversalSearch.Size = new System.Drawing.Size(373, 37);
            this.UniversalSearch.TabIndex = 10;
            this.UniversalSearch.TextChanged += new System.EventHandler(this.UniversalSearch_TextChanged);
            // 
            // comboFoodID
            // 
            this.comboFoodID.BackColor = System.Drawing.Color.ForestGreen;
            this.comboFoodID.ForeColor = System.Drawing.SystemColors.Window;
            this.comboFoodID.FormattingEnabled = true;
            this.comboFoodID.Items.AddRange(new object[] {
            "Rice",
            "Bread",
            "VegetableMix",
            "ChickenMeat",
            "BeafCurry",
            "CocaCola",
            "Tea",
            "Water",
            "Biriyani",
            "EggFry"});
            this.comboFoodID.Location = new System.Drawing.Point(120, 48);
            this.comboFoodID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboFoodID.Name = "comboFoodID";
            this.comboFoodID.Size = new System.Drawing.Size(188, 24);
            this.comboFoodID.TabIndex = 68;
            // 
            // FID
            // 
            this.FID.AutoSize = true;
            this.FID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FID.Location = new System.Drawing.Point(20, 54);
            this.FID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FID.Name = "FID";
            this.FID.Size = new System.Drawing.Size(69, 20);
            this.FID.TabIndex = 67;
            this.FID.Text = "FoodID";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(788, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 119);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back to All Options";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "RoomNo";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(393, 181);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 39);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.RoomNocomboBox.Location = new System.Drawing.Point(120, 16);
            this.RoomNocomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomNocomboBox.Name = "RoomNocomboBox";
            this.RoomNocomboBox.Size = new System.Drawing.Size(188, 24);
            this.RoomNocomboBox.TabIndex = 65;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(703, 181);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(184, 39);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show Food Info";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.FoodMenu);
            this.panel1.Location = new System.Drawing.Point(1, 234);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 377);
            this.panel1.TabIndex = 6;
            // 
            // FoodMenu
            // 
            this.FoodMenu.AllowUserToAddRows = false;
            this.FoodMenu.AllowUserToDeleteRows = false;
            this.FoodMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodItem,
            this.FoodCost,
            this.FoodID,
            this.RoomNo,
            this.OrderState});
            this.FoodMenu.Location = new System.Drawing.Point(15, 18);
            this.FoodMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FoodMenu.Name = "FoodMenu";
            this.FoodMenu.ReadOnly = true;
            this.FoodMenu.Size = new System.Drawing.Size(864, 342);
            this.FoodMenu.TabIndex = 0;
            // 
            // FoodItem
            // 
            this.FoodItem.DataPropertyName = "FoodItem";
            this.FoodItem.HeaderText = "FoodItem";
            this.FoodItem.Name = "FoodItem";
            this.FoodItem.ReadOnly = true;
            // 
            // FoodCost
            // 
            this.FoodCost.DataPropertyName = "FoodCost";
            this.FoodCost.HeaderText = "FoodCost";
            this.FoodCost.Name = "FoodCost";
            this.FoodCost.ReadOnly = true;
            // 
            // FoodID
            // 
            this.FoodID.DataPropertyName = "FoodID";
            this.FoodID.HeaderText = "FoodID";
            this.FoodID.Name = "FoodID";
            this.FoodID.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "RoomNo";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // OrderState
            // 
            this.OrderState.DataPropertyName = "OrderState";
            this.OrderState.HeaderText = "OrderState";
            this.OrderState.Name = "OrderState";
            this.OrderState.ReadOnly = true;
            // 
            // MPage3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(895, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MPage3";
            this.Text = "MPage3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MPage3_FormClosed);
            this.Load += new System.EventHandler(this.MPage3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView FoodMenu;
        private System.Windows.Forms.TextBox UniversalSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderState;
        private System.Windows.Forms.Button UnPaid;
        private System.Windows.Forms.Button Paid;
        private System.Windows.Forms.ComboBox comboFoodID;
        private System.Windows.Forms.Label FID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoomNocomboBox;
    }
}