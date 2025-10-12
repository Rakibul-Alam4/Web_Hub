using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelDreamSTS
{
    public partial class MPage1 : Form
    {
        private DataAccess Da { get; set; }
        public MPage1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.RoomGridView0();
        }

        public void RoomGridView(string sql = "select * from HRoom")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.HRoom.AutoGenerateColumns = false;
                this.HRoom.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: "+exc.Message);
            }
        }

        public void RoomGridView0(string sql = "select * from HRoom")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.HRoom.AutoGenerateColumns = false;
                //this.HRoom.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        

        private void btnShow_Click(object sender, EventArgs e)
        {
            string sql = "select * from HRoom";
            this.RoomGridView(sql);
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
                DataSet ds = this.Da.ExecuteQuery("select * from HRoom");

                int ap = 0;
                while (ap < 200)
                {
                    if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][0].ToString().ToLower())
                    {
                        qtxt = "RoomNo";
                        sql = "select * from HRoom Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.RoomGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][1].ToString().ToLower())
                    {
                        qtxt = "RoomCategory";
                        sql = "select * from HRoom Where " + qtxt + "='"+ this.UniversalSearch.Text +"' ";
                        this.RoomGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][2].ToString().ToLower())
                    {
                        qtxt = "BookingState";
                        sql = sql = "select * from HRoom Where " + qtxt + "='" + this.UniversalSearch.Text + "' ";
                        this.RoomGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][3].ToString().ToLower())
                    {
                        qtxt = "RoomCost";
                        sql = "select * from HRoom Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.RoomGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text == ds.Tables[0].Rows[ap][4].ToString().ToLower())
                    {
                        qtxt = "CustomerID";
                        sql = "select * from HRoom Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.RoomGridView(sql);
                        break;
                    }
                    ap++;

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: "+exc.Message);
            }
        }

        private void UniversalSearch_TextChanged(object sender, EventArgs e)
        {

            string sql = "select * from HRoom Where RoomCategory like '" + this.UniversalSearch.Text + "%' ";
            this.RoomGridView(sql);

            
        }

        private void MPage1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MPage1_Load(object sender, EventArgs e)
        {

        }

        }

    }

