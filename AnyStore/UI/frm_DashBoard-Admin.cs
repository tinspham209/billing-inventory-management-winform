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
    public partial class frm_AdminDashBoard : Form
    {
        public frm_AdminDashBoard()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Users user = new frm_Users();
            user.Show();
        }

        private void frm_AdminDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Hide();
        }

        private void frm_AdminDashBoard_Load(object sender, EventArgs e)
        {
            lbl_LoggedInUser.Text = frm_Login.loggedIn;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categories category = new frm_Categories();
            category.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_Users users = new frm_Users();
            users.Hide();

            frm_Categories category = new frm_Categories();
            category.Hide();

            this.Hide();

            frm_Login login = new frm_Login();
            login.Show();
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Products product = new frm_Products();
            product.Show();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DealerCustomer DeaCust = new frm_DealerCustomer();
            DeaCust.Show();
        }
    }
}
