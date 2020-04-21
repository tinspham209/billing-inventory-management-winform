using AnyStore.BLL;
using AnyStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.UI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        BLL_Login l = new BLL_Login();
        DAL_Login dal = new DAL_Login();
        public static string loggedIn;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            l.username = txt_UserName.Text.Trim();
            l.password = txt_Password.Text.Trim();
            l.user_type = cmb_UserType.Text.Trim();

            //checking the login credentials
            bool success = dal.loginCheck(l);
            if(success == true)
            {
                MessageBox.Show("Login Sucessful.");
                loggedIn = l.username;
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            frm_AdminDashBoard admin = new frm_AdminDashBoard();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            frm_DashBoard_Users user = new frm_DashBoard_Users();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login Failed. Try Again.");
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            cmb_UserType.SelectedItem = null;
            cmb_UserType.SelectedText = "--Select--";
            checkbox_Password.Text = "Unhide";
            txt_Password.PasswordChar = '*' ;
        }

        private void checkbox_Password_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = checkbox_Password.Checked ? '\0' : '*';
            checkbox_Password.Text = checkbox_Password.Checked ? "Hide" : "Unhide";
        }
    }
}
