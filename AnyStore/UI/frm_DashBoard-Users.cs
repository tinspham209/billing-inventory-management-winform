using AnyStore.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore
{
    public partial class frm_DashBoard_Users : Form
    {
        public frm_DashBoard_Users()
        {
            InitializeComponent();
        }

        private void salesFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {

        }

        private void frm_DashBoard_Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Hide();
        }

        private void frm_DashBoard_Users_Load(object sender, EventArgs e)
        {

        }

        private void frm_DashBoard_Users_Load_1(object sender, EventArgs e)
        {
            lbl_LoggedInUser.Text = frm_Login.loggedIn;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DealerCustomer DeaCust = new frm_DealerCustomer();
            DeaCust.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PurchaseAndSales purchase = new frm_PurchaseAndSales();
            purchase.Show();
        }
    }
}
