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
    public partial class ManagerPage0 : Form
    {
        public ManagerPage0()
        {
            InitializeComponent();
        }



        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            HotelSystem a1 = new HotelSystem();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnRoom_Click_1(object sender, EventArgs e)
        {
            MPage1 a1 = new MPage1();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            MPage2 a1 = new MPage2();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnFood_Click_1(object sender, EventArgs e)
        {

            MPage3 a1 = new MPage3();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnServices_Click_1(object sender, EventArgs e)
        {
            MPage4 a1 = new MPage4();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnBill_Click_1(object sender, EventArgs e)
        {
            MPage5 a1 = new MPage5();
            a1.Visible = true;
            this.Visible = false;
        }

        private void btnLoginPage_Click_1(object sender, EventArgs e)
        {
            HotelSystem a1 = new HotelSystem();
            a1.Visible = true;
            this.Visible = false;
        }

        private void ManagerPage0_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ManagerPage0_Load(object sender, EventArgs e)
        {

        }
    }
}
