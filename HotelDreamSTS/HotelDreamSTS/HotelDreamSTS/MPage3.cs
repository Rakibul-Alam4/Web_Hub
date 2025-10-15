using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDreamSTS
{
    public partial class MPage3 : Form
    {
        private DataAccess Da { get; set; }
        public MPage3()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.FoodGridView();
        }

        public void FoodGridView(string sql="select * from FoodMenu")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.FoodMenu.AutoGenerateColumns = false;
                this.FoodMenu.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: "+exc.Message);
            }
        }

        public void FoodGridView0(string sql = "select * from FoodMenu")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.FoodMenu.AutoGenerateColumns = false;
               // this.FoodMenu.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }



        private void btnShow_Click(object sender, EventArgs e)
        {
            string sql = "select * from FoodMenu";
            this.FoodGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string qtxt, sql;
            try
            {
                DataSet ds = this.Da.ExecuteQuery("select * from FoodMenu");

                int ap = 0;
                while (ap < 200)
                {
                    if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][0].ToString().ToLower())
                    {
                        qtxt = "FoodItem";
                        sql = "select * from FoodMenu Where " + qtxt + "='" + this.UniversalSearch.Text + "'";
                        this.FoodGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][1].ToString().ToLower())
                    {
                        qtxt = "FoodCost";
                        sql = "select * from FoodMenu Where " + qtxt + "=" + this.UniversalSearch.Text + " ";
                        this.FoodGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][2].ToString().ToLower())
                    {
                        qtxt = "FoodID";
                        sql = sql = "select * from FoodMenu Where " + qtxt + "='" + this.UniversalSearch.Text + "' ";
                        this.FoodGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][3].ToString().ToLower())
                    {
                        qtxt = "RoomNo";
                        sql = "select * from FoodMenu Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.FoodGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text == ds.Tables[0].Rows[ap][4].ToString().ToLower())
                    {
                        qtxt = "OrderState";
                        sql = "select * from FoodMenu Where " + qtxt + "='" + this.UniversalSearch.Text + "'";
                        this.FoodGridView(sql);
                        break;
                    }
                    ap++;

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void UniversalSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from FoodMenu Where RoomNo like '" + this.UniversalSearch.Text + "%' ";
            this.FoodGridView(sql);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPage0 a1 = new ManagerPage0();
            a1.Visible = true;
            this.Visible = false;
        }

        private void Paid_Click(object sender, EventArgs e)
        {
            string sql = "update FoodMenu set RoomNo=" + this.RoomNocomboBox.Text + ",OrderState='Paid' where FoodItem='" + this.comboFoodID.Text + "'";
            this.FoodGridView0(sql);
        }

        private void UnPaid_Click(object sender, EventArgs e)
        {
            string sql = "update FoodMenu set RoomNo=" + this.RoomNocomboBox.Text + ",OrderState='UnPaid' where FoodItem='" + this.comboFoodID.Text + "'";
            MPage5 B1 = new MPage5();
            string b1 = "update Billdetails set FoodCost=isnull(FoodCost,0)+(select FoodCost from FoodMenu where FoodItem='" + this.comboFoodID.Text + "') where RoomNo=" + this.RoomNocomboBox.Text + " ";
            int count = this.Da.ExecuteDML(sql);

            if (count == 1)
            {
                MessageBox.Show("Added to Bill");
            }
            else
            {
                MessageBox.Show("Cannot Added to Bill");
            }
            this.FoodGridView0(sql);
            B1.BillGridView0(b1);
            
        }

        private void MPage3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MPage3_Load(object sender, EventArgs e)
        {

        }

       

    }
}
