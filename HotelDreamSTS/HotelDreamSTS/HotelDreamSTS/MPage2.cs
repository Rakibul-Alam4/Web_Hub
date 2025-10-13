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
    public partial class MPage2 : Form
    {
        private DataAccess Da { get; set; }
        public MPage2()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.CustomerGridView();
            this.AutoIDGenerate();
        }

        public void CustomerGridView(string sql="select * from CustomerDetails")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.CustomerDetails.AutoGenerateColumns = false;
                this.CustomerDetails.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPage0 a1 = new ManagerPage0();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //string sql = "select * from CustomerDetails";

            this.CustomerGridView();
            
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
                        qtxt = "CustomerName";
                        sql = "select * from CustomerDetails Where " + qtxt + "='" + this.UniversalSearch.Text + "'";
                        this.CustomerGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][1].ToString().ToLower())
                    {
                        qtxt = "CustomerID";
                        sql = "select * from CustomerDetails Where " + qtxt + "='" + this.UniversalSearch.Text + "' ";
                        this.CustomerGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][2].ToString().ToLower())
                    {
                        qtxt = "CustomerPhone";
                        sql = sql = "select * from CustomerDetails Where " + qtxt + "='" + this.UniversalSearch.Text + "' ";
                        this.CustomerGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text.ToLower() == ds.Tables[0].Rows[ap][3].ToString().ToLower())
                    {
                        qtxt = "EntryDate";
                        sql = "select * from CustomerDetails Where " + qtxt + "='" + this.UniversalSearch.Text + "'";
                        this.CustomerGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text == ds.Tables[0].Rows[ap][4].ToString().ToLower())
                    {
                        qtxt = "CheckOutDate";
                        sql = "select * from CustomerDetails Where " + qtxt + "='" + this.UniversalSearch.Text + "'";
                        this.CustomerGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text == ds.Tables[0].Rows[ap][5].ToString().ToLower())
                    {
                        qtxt = "AdvancePaid";
                        sql = "select * from CustomerDetails Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.CustomerGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text == ds.Tables[0].Rows[ap][6].ToString().ToLower())
                    {
                        qtxt = "BillNo";
                        sql = "select * from CustomerDetails Where " + qtxt + "='" + this.UniversalSearch.Text + "'";
                        this.CustomerGridView(sql);
                        break;
                    }
                    else if (this.UniversalSearch.Text == ds.Tables[0].Rows[ap][7].ToString().ToLower())
                    {
                        qtxt = "RoomNo";
                        sql = "select * from CustomerDetails Where " + qtxt + "=" + this.UniversalSearch.Text + "";
                        this.CustomerGridView(sql);
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
            string sql = "select * from CustomerDetails Where BillNo like '" + this.UniversalSearch.Text + "%' or RoomNo like '"
                + this.UniversalSearch.Text + "%' or CustomerName like '" + this.UniversalSearch.Text + "%' or CustomerID like '"
                + this.UniversalSearch.Text + "%' or AdvancePaid like '" + this.UniversalSearch.Text + "%' or CustomerPhone like '"
                + this.UniversalSearch.Text + "%' or EntryDate like '" + this.UniversalSearch.Text + "%' or CheckOutDate like '" 
                + this.UniversalSearch.Text + "%'";
            this.CustomerGridView(sql);

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.CName.Text) || String.IsNullOrEmpty(this.CPhone.Text) || String.IsNullOrEmpty(this.Entry.Text)
                    || String.IsNullOrEmpty(this.Checkin.Text) || String.IsNullOrEmpty(this.Advance.Text) || String.IsNullOrEmpty(this.RoomNocomboBox.Text)
                    || String.IsNullOrEmpty(this.IDcomboBox.Text))
                {
                    MessageBox.Show("Please fill all informations");
                    return;
                }

                MPage1 R1 = new MPage1();
                var qry = "select * from CustomerDetails";
                var dm = this.Da.ExecuteQuery(qry);
                int pp=0,tt=0,mm=0,nn=0;


                while (pp < (dm.Tables[0].Rows.Count))
                {
                    
                    if (dm.Tables[0].Rows[pp]["RoomNo"].ToString().Equals(this.RoomNocomboBox.Text))
                    {

                        MessageBox.Show("Room Reserved");
                        string r2 = "update HRoom set CustomerID=" + dm.Tables[0].Rows[pp]["CustomerID"].ToString() + ",BookingState='Booked' where RoomNo="
                           + this.RoomNocomboBox.Text + "";
                        R1.RoomGridView0(r2);
                        break;

                    }
                        pp++;
                }

                while (tt < (dm.Tables[0].Rows.Count))
                {

                    if (this.Entry.Value < DateTime.Parse(this.DateNow.Text) )
                    {

                        MessageBox.Show("Entry Date Invalid");
                        break;

                    }
                    tt++;
                }


                while (mm < (dm.Tables[0].Rows.Count))
                {

                    if (this.Checkin.Value < DateTime.Parse(this.DateNow.Text))
                    {

                        MessageBox.Show("CheckOut Date is not valid");
                        break;

                    }
                    mm++;
                }

                while (nn < (dm.Tables[0].Rows.Count))
                {

                    if (this.comboBill.Text == dm.Tables[0].Rows[nn]["BillNo"].ToString())
                    {

                        MessageBox.Show("Bill is Invalid");
                        break;

                    }
                    nn++;
                }

                if (pp == dm.Tables[0].Rows.Count && tt == dm.Tables[0].Rows.Count && mm == dm.Tables[0].Rows.Count && nn == dm.Tables[0].Rows.Count)
                    {

                        string r1 = "update HRoom set CustomerID=" + this.IDcomboBox.Text + ",BookingState='Booked' where RoomNo="
                            + this.RoomNocomboBox.Text + "";

                       

                        var query = "select * from CustomerDetails where CustomerID=" + this.IDcomboBox.Text + "";
                        var ds = this.Da.ExecuteQuery(query);

                        if (ds.Tables[0].Rows.Count == 1)
                        {
                            var CuBill = this.CustomerDetails.CurrentRow.Cells["BillNo"].Value.ToString();
                            var CuRoom = this.CustomerDetails.CurrentRow.Cells["RoomNo"].Value.ToString();
                            MPage5 B1 = new MPage5();
                            string b1 = "update Billdetails set RoomCost=(select RoomCost from HRoom where RoomNo="
                                + this.RoomNocomboBox.Text + "),AdvancePaid=" + this.Advance.Text + ",RoomNo=" +
                                CuRoom + " where BillNo='" + CuBill + "'";

                            string sql = "update CustomerDetails set CustomerName='" + this.CName.Text + "',CustomerPhone="
                            + this.CPhone.Text + ",EntryDate='" + this.Entry.Text + "',CheckOutDate='"
                            + this.Checkin.Text + "',AdvancePaid=" + this.Advance.Text + ",RoomNo="
                            + this.RoomNocomboBox.Text + ",BillNo='" + this.comboBill.Text + "' where CustomerID=" + this.IDcomboBox.Text + "";


                            int count = this.Da.ExecuteDML(sql);

                            if (count == 1)
                            {
                                MessageBox.Show("Customer Data Updated");

                            }
                            else
                            {
                                MessageBox.Show("Customer Data Not Updated");
                            }

                            B1.BillGridView0(b1);

                        }
                        else
                        {

                            MPage5 B1 = new MPage5();
                            string b1 = "update Billdetails set RoomCost=(select RoomCost from HRoom where RoomNo="
                                + this.RoomNocomboBox.Text + "),AdvancePaid=" + this.Advance.Text + ",RoomNo=" +
                                this.RoomNocomboBox.Text + " where BillNo='" + this.comboBill.Text + "'";

                            string sql = "insert into CustomerDetails (CustomerName,CustomerID,CustomerPhone,EntryDate,CheckOutDate,AdvancePaid,RoomNo,BillNo) values ('"
                                + this.CName.Text + "'," + this.IDcomboBox.Text + "," + this.CPhone.Text + ",'" + this.Entry.Text + "','" +
                               this.Checkin.Text + "'," + this.Advance.Text + "," +
                               this.RoomNocomboBox.Text + ",'" + this.comboBill.Text + "')";

                            int count = this.Da.ExecuteDML(sql);

                            if (count == 1)
                            {
                                MessageBox.Show("Customer Data Inserted");
                            }
                            else
                            {

                                MessageBox.Show("Customer Data Not Inserted");
                            }
                            B1.BillGridView0(b1);
                        }

                        this.CustomerGridView();
                        R1.RoomGridView0(r1);
                        
                       
                    }
               
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error: " + exc.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MPage5 B1 = new MPage5();
                
                var Cid = this.CustomerDetails.CurrentRow.Cells["CustomerID"].Value.ToString();
                var CuRoom = this.CustomerDetails.CurrentRow.Cells["RoomNo"].Value.ToString();
                MPage1 R1 = new MPage1();
               
                string r1 = "update HRoom set CustomerID=null,BookingState=null where RoomNo=" + CuRoom + "";

                string sql = "delete from CustomerDetails where CustomerID=" + Cid + "";

                string b1 = "update Billdetails set ExtraCost=null,FoodCost=null,RoomCost=null,AdvancePaid=null,TotalBill=null,RoomNo=null where BillNo=(select BillNo from Billdetails where RoomNo="
                    +CuRoom+")";
                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Customer Data for RoomNo:"+CuRoom+" Deleted");
                }
                else
                {
                    MessageBox.Show("Customer Data Not Deleted");
                }
                this.CustomerGridView();
                R1.RoomGridView0(r1);
                B1.BillGridView0(b1);
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void AutoIDGenerate()
        {
            string sql = "select CustomerID from CustomerDetails order by CustomerID desc";

            DataTable dt = this.Da.ExecuteQueryTable(sql);

            string prevId = dt.Rows[0]["CustomerID"].ToString();
            var no = Convert.ToInt32(prevId);
            string newId = (++no).ToString();
            this.IDcomboBox.Text = newId;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.CName.Text = "";
            this.CPhone.Text = ""; 
            this.Entry.Text = ""; 
            this.Checkin.Text = ""; 
            this.Advance.Text = ""; 
            this.RoomNocomboBox.Text = ""; 
            this.IDcomboBox.Text = "";

            this.UniversalSearch.Text = "";
            this.AutoIDGenerate();
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
            if (String.IsNullOrEmpty(this.CName.Text) || String.IsNullOrEmpty(this.CPhone.Text) || String.IsNullOrEmpty(this.Entry.Text)
                    || String.IsNullOrEmpty(this.Checkin.Text) || String.IsNullOrEmpty(this.Advance.Text) || String.IsNullOrEmpty(this.RoomNocomboBox.Text)
                    || String.IsNullOrEmpty(this.IDcomboBox.Text))
            {
                MessageBox.Show("Please fill all informations");
                return;
            }

           
            MPage1 R1 = new MPage1();

            string r1 = "update HRoom set CustomerID=" + this.IDcomboBox.Text + ",BookingState='Booked' where RoomNo="
                           + this.RoomNocomboBox.Text + "";

                var qry = "select * from CustomerDetails";
                var dm = this.Da.ExecuteQuery(qry);
                int pp = 0;
            while (pp < (dm.Tables[0].Rows.Count))
            {

                if (dm.Tables[0].Rows[pp]["RoomNo"].ToString() == this.RoomNocomboBox.Text)
                {

                    MessageBox.Show("Room Valid");
                    string r2 = "update HRoom set CustomerID=" + dm.Tables[0].Rows[pp]["CustomerID"].ToString() + ",BookingState='Booked' where RoomNo="
                       + this.RoomNocomboBox.Text + "";
                    R1.RoomGridView0(r2);
                  
                    break;
                     }
                pp++;
            }



            
            if (pp != dm.Tables[0].Rows.Count)
            {
                var query = "select * from CustomerDetails where CustomerID=" + this.IDcomboBox.Text + "";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var CuBill = this.CustomerDetails.CurrentRow.Cells["BillNo"].Value.ToString();
                    var CuRoom = this.CustomerDetails.CurrentRow.Cells["RoomNo"].Value.ToString();
                    MPage5 B1 = new MPage5();
                    string b1 = "update Billdetails set RoomCost=(select RoomCost from HRoom where RoomNo="
                        + this.RoomNocomboBox.Text + "),AdvancePaid=" + this.Advance.Text + ",RoomNo=" +
                        CuRoom + " where BillNo='" + CuBill + "'";

                    string sql = "update CustomerDetails set CustomerName='" + this.CName.Text + "',CustomerPhone="
                    + this.CPhone.Text + ",EntryDate='" + this.Entry.Text + "',CheckOutDate='"
                    + this.Checkin.Text + "',AdvancePaid=" + this.Advance.Text + " where CustomerID=" + this.IDcomboBox.Text + "";


                    int count = this.Da.ExecuteDML(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Customer Data Updated");

                    }
                    else
                    {
                        MessageBox.Show("Customer Data Not Updated");
                    }
                    B1.BillGridView0(b1);
                }
            }
            this.CustomerGridView();
            R1.RoomGridView0(r1);
            
             }
            catch (Exception exc)
            {

                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void MPage2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CustomerDetails_DoubleClick(object sender, EventArgs e)
        {
            this.CName.Text = this.CustomerDetails.CurrentRow.Cells["CustomerName"].Value.ToString();
            this.IDcomboBox.Text = this.CustomerDetails.CurrentRow.Cells["CustomerID"].Value.ToString();
            this.CPhone.Text = this.CustomerDetails.CurrentRow.Cells["CustomerPhone"].Value.ToString();
            this.Advance.Text = this.CustomerDetails.CurrentRow.Cells["AdvancePaid"].Value.ToString();
            this.comboBill.Text = this.CustomerDetails.CurrentRow.Cells["BillNo"].Value.ToString();
            this.Entry.Text = this.CustomerDetails.CurrentRow.Cells["EntryDate"].Value.ToString();
            this.Checkin.Text = this.CustomerDetails.CurrentRow.Cells["CheckOutDate"].Value.ToString();
            this.RoomNocomboBox.Text = this.CustomerDetails.CurrentRow.Cells["RoomNo"].Value.ToString();
        }

        private void MPage2_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
