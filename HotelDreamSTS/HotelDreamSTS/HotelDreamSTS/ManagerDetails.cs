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
    public partial class ManagerDetails : Form
    {
        private DataAccess Da { get; set; }
        public ManagerDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.popularGridView();
       }

        private void popularGridView(string sql = "select * from manDetails;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dGVman.AutoGenerateColumns = false;
                this.dGVman.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR" + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtMID.Text = ""; this.txtMName.Text = "";

              this.txtMAdd.Text = ""; this.txtMPhone.Text = "";

              this.txtMnid.Text = ""; this.txtMsalary.Text = ""; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             try
           {
                 if (String.IsNullOrEmpty(this.txtMID.Text) || String.IsNullOrEmpty(this.txtMName.Text) ||
                    String.IsNullOrEmpty(this.txtMAdd.Text) || String.IsNullOrEmpty(this.txtMPhone.Text) ||
                    String.IsNullOrEmpty(this.txtMnid.Text) || String.IsNullOrEmpty(this.dtpMjoining.Text)||
                    String.IsNullOrEmpty(this.txtMsalary.Text))
               {
                   MessageBox.Show(" ERROR: Please fill up the data correctly");
                   return;
               }
         
               var sql = "select * from manDetails where ManagerID= '" + this.txtMID.Text + "';";
               var ds = this.Da.ExecuteQuery(sql);
               if (ds.Tables[0].Rows.Count == 1)
               {
                   //update

                   string query = "update manDetails  set ManagerName ='" + this.txtMName.Text + "',Address='" + this.txtMAdd.Text + "',PhoneNumber= " + this.txtMPhone.Text + ",NID= " + this.txtMnid.Text + ",ManagerJoiningDate='" + this.dtpMjoining.Text + "',Salary= " + this.txtMsalary.Text + " where ManagerID ='" + this.txtMID.Text + "';";

                   int count = this.Da.ExecuteDML(query);
                   if (count == 1)
                   {
                       MessageBox.Show("Information update successfully ");
                   }
               
               else
               {
                   MessageBox.Show("Sorry,Data upgrade failed .Please check again ");
               } 
         } 
             else

                 { 
                   //Insert
                     string query = "insert into manDetails values ('" + this.txtMID.Text + "','" + this.txtMName.Text + "','" + this.txtMAdd.Text + "','" + this.txtMPhone.Text + "'," + this.txtMnid.Text + ",'" + this.dtpMjoining.Text + "','" + this.txtMsalary.Text + "');";

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
    

             catch(Exception exc)
            {
                MessageBox.Show("ERROR" + exc.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
              {
                  var ID = this.dGVman.CurrentRow.Cells["ManagerID"].Value.ToString();
                  var name = this.dGVman.CurrentRow.Cells["ManagerName"].Value.ToString();

                  string sql = " delete from manDetails where ManagerID='"+ID+"';";
                  int count = this.Da.ExecuteDML(sql);

                  if (count == 1)
                  {
                      MessageBox.Show("MANAGER's" + ManagerName + "information has been Deleted ");
                  }
                  else
                  {
                      MessageBox.Show(" Delete procedure has been failed .please try and check again");
                  }
                  this.popularGridView();
              }
              catch (Exception exc)
              {
                  MessageBox.Show("ERROR delete" + exc.Message);
              }   
        }



        

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            string sql = "select * from manDetails where ManagerID ='" + this.txtMIDsearch.Text + "';";
     
                this.popularGridView(sql); 
        }

        private void dGVman_DoubleClick(object sender, EventArgs e)
        {
            this.txtMID.Text = this.dGVman.CurrentRow.Cells["ManagerID"].Value.ToString();
              this.txtMName.Text = this.dGVman.CurrentRow.Cells["ManagerName"].Value.ToString();
              this.txtMAdd.Text = this.dGVman.CurrentRow.Cells["Address"].Value.ToString();
              this.txtMPhone.Text = this.dGVman.CurrentRow.Cells["PhoneNo"].Value.ToString();
              this.txtMnid.Text = this.dGVman.CurrentRow.Cells["NID"].Value.ToString();
              this.dtpMjoining.Text = this.dGVman.CurrentRow.Cells["ManagerJoiningDate"].Value.ToString();
              this.txtMsalary.Text = this.dGVman.CurrentRow.Cells["Salary"].Value.ToString();
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormOwnerPage owp2 = new FormOwnerPage();
            owp2.Visible = true;
            this.Visible = false;
        }

        private void ManagerDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMShow_Click(object sender, EventArgs e)
        {
            popularGridView();
        }

        private void ManagerDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
