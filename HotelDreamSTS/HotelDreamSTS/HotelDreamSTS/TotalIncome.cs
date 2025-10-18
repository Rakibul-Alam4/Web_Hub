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

   
    public partial class TotalIncome : Form
    {
        private DataAccess Da { get; set; }
        public TotalIncome()
        {
            
            InitializeComponent();
            this.Da = new DataAccess();
            this.BillGridView();
        }

        public void IncomeGridView1( string sql1 = "select * from HotelIncome;")
        {
            try
            {
                //sql = "select * from HotelIncome;";
                DataSet ds = this.Da.ExecuteQuery(sql1);
                this.IncomeGridView.AutoGenerateColumns = false;
                this.IncomeGridView.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR : " + exc.Message);
            }
        }

        public void IncomeGridView0(string sql1 )
        {
            try
            {
                //sql = "select * from HotelIncome;";
                DataSet ds = this.Da.ExecuteQuery(sql1);
                this.IncomeGridView.AutoGenerateColumns = false;
                //this.IncomeGridView.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR : " + exc.Message);
            }
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
                MessageBox.Show("Error: " + exc.Message);
            }
        }
 


        private void btnIncomeShow_Click(object sender, EventArgs e)
        {
            string sql = "select * from HotelIncome;";
            this.IncomeGridView1(sql);
        }

        private void TotalIncome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormOwnerPage owp2 = new FormOwnerPage();
            owp2.Visible = true;
            this.Visible = false;
        }

        internal int Add()
        {
            return Convert.ToInt32(this.textBill.Text);
        }

        private void billTotal_Click(object sender, EventArgs e)
        {
  
            
            MPage5 ds = new MPage5();
            D pi = new D(ds.Add);
            string pt= pi(this.textBill.Text);

            string qry1 = "select * from HotelIncome;";
            var dl = this.Da.ExecuteQuery(qry1);


            string sql = "insert into HotelIncome (DailyIncome,Loss,TotalIncome,IncomeDate) values  ("
                + this.textBill.Text + ",'No'," + this.textBill.Text + ",'" + this.CheckOut.Text + "')";
            this.IncomeGridView1();
            

            this.IncomeGridView1(sql);
        
           
           
           
        }

        private void update_Click(object sender, EventArgs e)
        {
            MPage5 ds = new MPage5();
            D pi = new D(ds.Add);
            string pt = pi(this.textBill.Text);

            string qry1 = "select * from HotelIncome;";
            var dl = this.Da.ExecuteQuery(qry1);

            string sql = "update HotelIncome set DailyIncome=(select DailyIncome from HotelIncome where IncomeDate='"
                + this.CheckOut.Text + "')+" + pt + ",TotalIncome=(select TotalIncome from HotelIncome where IncomeDate='"
                    + this.CheckOut.Text + "')+" + pt + ",Loss='No' where IncomeDate='" + this.CheckOut.Text + "'";
                this.IncomeGridView0(sql);
            
     
        }
    }
}
