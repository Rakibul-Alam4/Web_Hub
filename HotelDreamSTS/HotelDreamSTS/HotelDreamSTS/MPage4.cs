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
    public partial class MPage4 : Form
    {
         private DataAccess Da { get; set; }
        public MPage4()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.EServiceGridView();
        }

        public void EServiceGridView(string sql = "select * from ExtraService")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.ExtraService.AutoGenerateColumns = false;
                this.ExtraService.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: "+exc.Message);
            }
        }

        public void EServiceGridView0(string sql = "select * from ExtraService")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.ExtraService.AutoGenerateColumns = false;
               // this.ExtraService.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string sql = "select * from ExtraService";
            this.EServiceGridView(sql);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPage0 a1 = new ManagerPage0();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string qtxt, sql;
            try
            {
                DataSet ds = this.Da.ExecuteQuery("select * from ExtraService");

                int ap = 0;
                while (ap < 200)
                {
                    if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][0].ToString().ToLower())
                    {
                        qtxt = "ExtraService";
                        sql = "select * from ExtraService Where " + qtxt + "='" + this.UniversalSearch.Text + "'";
                        this.EServiceGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][1].ToString().ToLower())
                    {
                        qtxt = "ServiceID";
                        sql = "select * from ExtraService Where " + qtxt + "=" + this.UniversalSearch.Text + " ";
                        this.EServiceGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][2].ToString().ToLower())
                    {
                        qtxt = "ServiceCost";
                        sql = sql = "select * from ExtraService Where " + qtxt + "=" + this.UniversalSearch.Text + " ";
                        this.EServiceGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][3].ToString().ToLower())
                    {
                        qtxt = "RoomNo";
                        sql = "select * from ExtraService Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.EServiceGridView(sql);
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
            string sql = "select * from ExtraService Where RoomNo like '" + this.UniversalSearch.Text + "%' ";
            this.EServiceGridView(sql);
        }

        

        private void Billaddedcombo_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update ExtraService set RoomNo=" + this.RoomNocomboBox.Text + " where ExtraService='" + this.comboServiceID.Text + "'";
            MPage5 B1 = new MPage5();
            string b1 = "update Billdetails set ExtraCost=isnull(ExtraCost,0)+(select ServiceCost from ExtraService where ExtraService='" 
                + this.comboServiceID.Text + "') where RoomNo=" + this.RoomNocomboBox.Text + " ";
            int count = this.Da.ExecuteDML(sql);

            if (count == 1)
            {
                MessageBox.Show("Added to Bill");
            }
            else
            {
                MessageBox.Show("Cannot Added to Bill");
            }
            this.EServiceGridView0(sql);
            B1.BillGridView0(b1);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void MPage4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MPage4_Load(object sender, EventArgs e)
        {

        }

        
    }
}
