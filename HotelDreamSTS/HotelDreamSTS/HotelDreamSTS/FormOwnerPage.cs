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
    public partial class FormOwnerPage : Form
    {
        public FormOwnerPage()
        {
            InitializeComponent();
        }

        private void btnManagerDetails_Click(object sender, EventArgs e)
        {
            ManagerDetails md = new ManagerDetails();
            md.Visible = true;
            this.Visible = false;
        }

        private void btnStaffDetalis_Click(object sender, EventArgs e)
        {
            StaffDetails std = new StaffDetails();
            std.Visible = true;
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HotelSystem a1 = new HotelSystem();
            a1.Visible = true;
            this.Visible = false;
        }

        private void FormOwnerPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TotalIncome_Click(object sender, EventArgs e)
        {
            TotalIncome a = new TotalIncome();
            a.Visible = true;
            this.Visible = false;
        }

        private void FormOwnerPage_Load(object sender, EventArgs e)
        {

        }
    }
}
