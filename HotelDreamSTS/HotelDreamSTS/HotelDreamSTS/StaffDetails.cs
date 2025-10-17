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
    public partial class StaffDetails : Form
    {
        private DataAccess Da { get; set; }
        public StaffDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.popularGridView();
        }

        private void popularGridView(string sql = "select * from StaffDetails;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dGVstf.AutoGenerateColumns = false;
                this.dGVstf.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR" + exc.Message);
            }
        }

        private void btnSdetails_Click(object sender, EventArgs e)
        {
            this.popularGridView();
        }

        private void btnSearchPost_Click(object sender, EventArgs e)
        {
            string sql = "select * from StaffDetails where StaffPost ='" + this.cmbSSearchPost.Text + "';";

            this.popularGridView(sql);
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtSID.Text) || String.IsNullOrEmpty(this.txtSName.Text) ||
                     String.IsNullOrEmpty(this.txtSAdd.Text) || String.IsNullOrEmpty(this.txtSPhone.Text) ||
                     String.IsNullOrEmpty(this.txtSnid.Text) || String.IsNullOrEmpty(this.dtpSjoining.Text) ||
                    String.IsNullOrEmpty(this.cmbPost.Text) || String.IsNullOrEmpty(this.cmbSsalary.Text))
                {
                    MessageBox.Show(" ERROR: Please fill up the data correctly");
                    return;
                }
                var sql = "select * from StaffDetails where StaffID= '" + this.txtSID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update

                    string query = "update StaffDetails  set StaffName ='" + this.txtSName.Text + "',Address='" + this.txtSAdd.Text + "',PhoneNumber= " + this.txtSPhone.Text + ",NID= " + this.txtSnid.Text + ",StaffjoiningDate='" + this.dtpSjoining.Text + "',StaffPost='" + this.cmbPost.Text + "',Salary=" + this.cmbSsalary.Text + " where StaffID ='" + this.txtSID.Text + "';";

                    int count = this.Da.ExecuteDML(query);
                    if (count == 1)
                    {
                        MessageBox.Show("Infromation update successfully ");
                    }

                    else
                    {
                        MessageBox.Show("Sorry,Data upgrade failed .Please check again ");
                    }
                }
                else
                {
                    //Insert
                    string query = "insert into StaffDetails (StaffID,StaffName,Address,PhoneNumber,NID,StaffjoiningDate,StaffPost,Salary) values ('" + this.txtSID.Text + "','" + this.txtSName.Text + "','" + this.txtSAdd.Text + "'," + this.txtSPhone.Text + "," + this.txtSnid.Text + ",'" + this.dtpSjoining.Text + "','" + this.cmbPost.Text + "','" + this.cmbSsalary.Text + "');";

                    int count = this.Da.ExecuteDML(query);
                    if (count == 1)
                    {
                        MessageBox.Show("Data insertion Successfully done ");
                    }
                    else
                    {
                        MessageBox.Show("Sorry,Data insertion failed .Please check it again");
                    }

                }

                this.popularGridView();
            }

            catch (Exception exc)
            {
                MessageBox.Show("ERROR" + exc.Message);
            }
        }

        private void btnRemoveS_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = this.dGVstf.CurrentRow.Cells["StaffID"].Value.ToString();
                var name = this.dGVstf.CurrentRow.Cells["StaffName"].Value.ToString();

                string sql = " delete from StaffDetails where StaffID ='" + ID + "';";
                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Staff" + StaffName + "information has been Deleted ");
                }
                else
                {
                    MessageBox.Show("Data Delete procedure has been failed .please try and check again");
                }
                this.popularGridView();
            }

            catch (Exception exc)
            {
                MessageBox.Show("ERROR delete" + exc.Message);
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSID.Text = ""; this.txtSName.Text = ""; this.txtSAdd.Text = ""; this.txtSPhone.Text = "";

            this.txtSnid.Text = ""; this.cmbPost.Text = ""; this.cmbSsalary.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormOwnerPage owp2 = new FormOwnerPage();
            owp2.Visible = true;
            this.Visible = false;
        }

        private void StaffDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StaffDetails_DoubleClick(object sender, EventArgs e)
        {
            this.txtSID.Text = this.dGVstf.CurrentRow.Cells["StaffID"].Value.ToString();
            this.txtSName.Text = this.dGVstf.CurrentRow.Cells["StaffName"].Value.ToString();
            this.txtSAdd.Text = this.dGVstf.CurrentRow.Cells["Address"].Value.ToString();
            this.txtSPhone.Text = this.dGVstf.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            this.txtSnid.Text = this.dGVstf.CurrentRow.Cells["NID"].Value.ToString();
            this.dtpSjoining.Text = this.dGVstf.CurrentRow.Cells["StaffjoiningDate"].Value.ToString();
            this.cmbPost.Text = this.dGVstf.CurrentRow.Cells["StaffPost"].Value.ToString();
            this.cmbSsalary.Text = this.dGVstf.CurrentRow.Cells["Salary"].Value.ToString();
        }

        private void dGVstf_DoubleClick(object sender, EventArgs e)
        {
            this.txtSID.Text = this.dGVstf.CurrentRow.Cells["StaffID"].Value.ToString();
            this.txtSName.Text = this.dGVstf.CurrentRow.Cells["StaffName"].Value.ToString();
            this.txtSAdd.Text = this.dGVstf.CurrentRow.Cells["Address"].Value.ToString();
            this.txtSPhone.Text = this.dGVstf.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            this.txtSnid.Text = this.dGVstf.CurrentRow.Cells["NID"].Value.ToString();
            this.dtpSjoining.Text = this.dGVstf.CurrentRow.Cells["StaffjoiningDate"].Value.ToString();
            this.cmbPost.Text = this.dGVstf.CurrentRow.Cells["StaffPost"].Value.ToString();
            this.cmbSsalary.Text = this.dGVstf.CurrentRow.Cells["Salary"].Value.ToString();
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
