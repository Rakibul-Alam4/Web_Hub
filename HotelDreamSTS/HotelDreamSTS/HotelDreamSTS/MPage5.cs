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
    internal delegate string D(string p);
    public partial class MPage5 : Form
    {
       private DataAccess Da { get; set; }

       
        public MPage5()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.BillGridView();
        }

        internal string Add(string p0)
        {
            return p0;
        }

        public void BillGridView(string sql = "select * from Billdetails")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.BillDetails.AutoGenerateColumns = false;
                this.BillDetails.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: "+exc.Message);
            }
        }

        public void BillGridView0(string sql )
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.BillDetails.AutoGenerateColumns = false;
                //this.BillDetails.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {

            string sql = "select * from Billdetails";
            this.BillGridView(sql);
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
                DataSet ds = this.Da.ExecuteQuery("select * from CustomerDetails");

                int ap = 0;
                while (ap < 200)
                {
                    if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][0].ToString().ToLower())
                    {
                        qtxt = "RoomCost";
                        sql = "select * from Billdetails Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.BillGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][1].ToString().ToLower())
                    {
                        qtxt = "FoodCost";
                        sql = "select * from Billdetails Where " + qtxt + "=" + this.UniversalSearch.Text + " ";
                        this.BillGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][2].ToString().ToLower())
                    {
                        qtxt = "ExtraCost";
                        sql = sql = "select * from Billdetails Where " + qtxt + "=" + this.UniversalSearch.Text + " ";
                        this.BillGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][3].ToString().ToLower())
                    {
                        qtxt = "RoomNo";
                        sql = "select * from Billdetails Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.BillGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text == ds.Tables[0].Rows[ap][4].ToString().ToLower())
                    {
                        qtxt = "BillNo";
                        sql = "select * from Billdetails Where " + qtxt + "='" + this.UniversalSearch.Text + "'";
                        this.BillGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text == ds.Tables[0].Rows[ap][5].ToString().ToLower())
                    {
                        qtxt = "TotalBill";
                        sql = "select * from Billdetails Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.BillGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text == ds.Tables[0].Rows[ap][6].ToString().ToLower())
                    {
                        qtxt = "AdvancePaid";
                        sql = "select * from Billdetails Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.BillGridView(sql);
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
            string sql = "select * from Billdetails Where RoomNo like '" + this.UniversalSearch.Text + "%' ";
            this.BillGridView(sql);
        }

        private void btnTotalBill_Click(object sender, EventArgs e)
        {
            MPage5 B1 = new MPage5();
            string b1 = "update Billdetails set TotalBill=(select RoomCost*(select Day(CheckOutDate)-day(EntryDate) from CustomerDetails where RoomNo=" 
                + this.RoomNocomboBox.Text + ")+isnull(FoodCost,0)+isnull(ExtraCost,0)-AdvancePaid from HRoom where RoomNo=" 
                + this.RoomNocomboBox.Text + ") where RoomNo=" + this.RoomNocomboBox.Text + "";
            B1.BillGridView0(b1);
        }

        private void MPage5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BillDetails_DoubleClick(object sender, EventArgs e)
        {
            this.txtRoom.Text = this.BillDetails.CurrentRow.Cells["RoomNo"].Value.ToString();
            this.txtRCost.Text = this.BillDetails.CurrentRow.Cells["RoomCost"].Value.ToString();
            this.txtFCost.Text = this.BillDetails.CurrentRow.Cells["FoodCost"].Value.ToString();
            this.txtECost.Text = this.BillDetails.CurrentRow.Cells["ExtraCost"].Value.ToString();
            this.txtBId.Text = this.BillDetails.CurrentRow.Cells["BillNo"].Value.ToString();
            this.txtTotal.Text = this.BillDetails.CurrentRow.Cells["TotalBill"].Value.ToString();
            this.txtAdvance.Text = this.BillDetails.CurrentRow.Cells["AdvancePaid"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {//TotalBill-AdvancePaid=have to pay-npid=rturned
                double hv = 0;
                double rv = 0;
                string total = this.txtTotal.Text;
                var T = Convert.ToDouble(total);
                string advance = this.txtAdvance.Text;
                var A = Convert.ToDouble(advance);
                string npay = this.txtNPaid.Text;
                var N = Convert.ToDouble(npay);
                hv = T-A;
                rv = N - hv;
                txtReturned.Text = Convert.ToString(rv);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int x = 100, y = 100; //start position

                //Image newImage = Image.FromFile("logo.png");
                int width = 80, height = 50;
                //int ix = x, iy = y; //image position
                //e.Graphics.DrawImage(newImage, ix, iy, width, height);

                x += 0; //left align texts with logo image
                y += height + 30; //some space below logo

                var header = new Font("Calibri", 21, FontStyle.Bold);
                int hdy = (int)header.GetHeight(e.Graphics); //30; //line height spacing

                var fnt = new Font("Times new Roman", 14, FontStyle.Bold);
                int dy = (int)fnt.GetHeight(e.Graphics); //20; //line height spacing

                e.Graphics.DrawString("Hotel Dream", header, Brushes.Black, new PointF(x, y)); y += hdy + hdy + hdy;
                e.Graphics.DrawString("Customer Name : " + txtCName.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
                e.Graphics.DrawString("Bill Id : " + txtBId.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
                e.Graphics.DrawString("Room Id : " + txtRoom.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
                e.Graphics.DrawString("Room Cost : " + txtRCost.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
                e.Graphics.DrawString("Food Cost : " + txtFCost.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
                e.Graphics.DrawString("Extra Service Cost : " + txtECost.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
                e.Graphics.DrawString("Total : " + txtTotal.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
                e.Graphics.DrawString("Advance : " + txtAdvance.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
                e.Graphics.DrawString("Now Paid Amount : " + txtNPaid.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
                e.Graphics.DrawString("Returned Amount : " + txtReturned.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        public DataGridView Bill
        {
            get { return this.BillDetails; }
            set { this.BillDetails = value; }
        }

        private void MPage5_Load(object sender, EventArgs e)
        {

        }
    }
}
