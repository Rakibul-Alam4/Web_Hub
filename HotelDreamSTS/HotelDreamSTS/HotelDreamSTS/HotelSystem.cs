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
    
    public partial class HotelSystem : Form
    {
        public HotelSystem()
        {
            InitializeComponent();
            
            
        }
        


        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from InfoUserAdmin where  Name ='" + this.textName.Text.ToLower() + "' and Password = " + this.textPassword.Text + "; ";
                // string query = "select * from InfoUserAdmin";
                SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9LQADLV;Initial Catalog=ProjectC#;User ID=sa;Password=9095");
                //SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-KA2838Q;Initial Catalog=ProjectC#;Persist Security Info=True;User ID=sa;Password=QETUOwryip1999*");
                sqlCon.Open(); //1st step
            SqlCommand sqlCom = new SqlCommand(sql, sqlCon);//2nd step
            SqlDataAdapter sdAdapter = new SqlDataAdapter(sqlCom);// 3rd step

            DataSet ds = new DataSet();
            sdAdapter.Fill(ds);//4th, result store
              
            if (ds.Tables[0].Rows.Count == 1)
            {
                // MessageBox.Show("Login Sucessful");
                 if (ds.Tables[0].Rows[0][3].ToString().Equals("Manager"))
                    { 
                        ManagerPage0 mm = new ManagerPage0();
                        mm.Visible = true;
                        this.Visible = false;
                        
                    }
                   else 
                    {
                        FormOwnerPage op = new FormOwnerPage();
                        op.Visible = true;
                        this.Visible = false;
                            
                    }
                    
                }
            
            else
            {
                MessageBox.Show("Login invalid");
            }
            sqlCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR" + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textName.Text = "";
            this.textPassword.Text = "";
        }

        private void HotelSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HotelSystem_Load(object sender, EventArgs e)
        {

        }

        
    }
}
