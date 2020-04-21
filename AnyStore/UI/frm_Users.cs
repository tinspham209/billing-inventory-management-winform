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
    public partial class frm_Users : Form
    {
        public frm_Users()
        {
            InitializeComponent();
        }


        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        BLL_User u = new BLL_User();
        DAL_User dal = new DAL_User();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //getting username of the logged in user

            string loggedUser = frm_Login.loggedIn;


            //Getting data from UI
            u.first_name = txt_FirstName.Text;
            u.last_name = txt_LastName.Text;
            u.email = txt_Email.Text;
            u.username = txt_UserName.Text;
            u.password = txt_Password.Text;
            u.contact = txt_Contact.Text;
            u.address = txt_Address.Text;
            u.gender = cmb_Gender.Text;
            u.user_type = cmb_UserType.Text;
            u.added_date = DateTime.Now;

            BLL_User usr = dal.GetIdFromUsername(loggedUser);
            u.added_by = usr.id;

            // Inserting data into db
            bool success = dal.Insert(u);
            if(success == true)
            {
                MessageBox.Show("User Successfully created.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user.");
            }

            //Refreshing data grid view
            DataTable dt = dal.Select();
            dgv_Users.DataSource = dt;

        }

        private void frm_Users_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgv_Users.DataSource = dt;
            cmb_Gender.SelectedItem = null;
            cmb_Gender.SelectedText = "--Select--";
            cmb_UserType.SelectedItem = null;
            cmb_UserType.SelectedText = "--Select--";
        }

        private void clear()
        {
            txt_UserID.Text = "";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Email.Text = "";
            txt_UserName.Text = "";
            txt_Password.Text = "";
            txt_Contact.Text = "";
            txt_Address.Text = "";
            cmb_Gender.Text = "";
            cmb_UserType.Text = "";
        }

        private void dgv_Users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;
            txt_UserID.Text = dgv_Users.Rows[rowIndex].Cells[0].Value.ToString();
            txt_FirstName.Text = dgv_Users.Rows[rowIndex].Cells[1].Value.ToString();
            txt_LastName.Text = dgv_Users.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Email.Text = dgv_Users.Rows[rowIndex].Cells[3].Value.ToString();
            txt_UserName.Text = dgv_Users.Rows[rowIndex].Cells[4].Value.ToString();
            txt_Password.Text = dgv_Users.Rows[rowIndex].Cells[5].Value.ToString();
            txt_Contact.Text = dgv_Users.Rows[rowIndex].Cells[6].Value.ToString();
            txt_Address.Text = dgv_Users.Rows[rowIndex].Cells[7].Value.ToString();
            cmb_Gender.Text = dgv_Users.Rows[rowIndex].Cells[8].Value.ToString();
            cmb_UserType.Text = dgv_Users.Rows[rowIndex].Cells[9].Value.ToString();


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get the values from User UI
            u.id = Convert.ToInt32(txt_UserID.Text);
            u.first_name = txt_FirstName.Text;
            u.last_name = txt_LastName.Text;
            u.email = txt_Email.Text;
            u.username = txt_UserName.Text;
            u.password = txt_Password.Text;
            u.contact = txt_Contact.Text;
            u.address = txt_Address.Text;
            u.gender = cmb_Gender.Text;
            u.user_type = cmb_UserType.Text;
            u.added_date = DateTime.Now;

            //getting username of the logged in user

            string loggedUser = frm_Login.loggedIn;
            BLL_User usr = dal.GetIdFromUsername(loggedUser);
            u.added_by = usr.id;


            //Updating data into database
            bool success = dal.Update(u);
            if(success == true)
            {
                MessageBox.Show("User successfully updated");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to update user");
            }
            //Refreshing data grid view
            DataTable dt = dal.Select();
            dgv_Users.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Getting user id from Form
            u.id = Convert.ToInt32(txt_UserID.Text);
            
            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("User successfully deleted");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete user");
            }
            //Refreshing data grid view
            DataTable dt = dal.Select();
            dgv_Users.DataSource = dt;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox
            string keywords = txt_Search.Text;

            //check if the keyword has value or not
            if(keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgv_Users.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgv_Users.DataSource = dt;
            }
        }
    }
}
