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
    public partial class frm_Categories : Form
    {
        public frm_Categories()
        {
            InitializeComponent();
        }

        BLL_categories c = new BLL_categories();
        DAL_categories dal = new DAL_categories();
        DAL_User udal = new DAL_User();

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            c.title = txt_Title.Text;
            c.description = txt_Description.Text;
            c.added_date = DateTime.Now;

            //getting id in added by field
            string loggedUser = frm_Login.loggedIn;
            BLL_User usr = udal.GetIdFromUsername(loggedUser);

            //passing the id of logged in user in added by field
            c.added_by = usr.id;

            bool success = dal.Insert(c);
            if(success == true)
            {
                MessageBox.Show("New category inserted successfully.");
                clear();
                //Refreshing data grid view
                DataTable dt = dal.Select();
                dgv_Categories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to insert new category .");
            }
        }

        public void clear()
        {
            txt_CategoryID.Text = "";
            txt_Description.Text = "";
            txt_Title.Text = "";
            txt_Search.Text = "";
        }

        private void frm_Categories_Load(object sender, EventArgs e)
        {
            //load data grid view from db
            DataTable dt = dal.Select();
            dgv_Categories.DataSource = dt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get the values from User UI
            c.id = int.Parse(txt_CategoryID.Text);
            c.title = txt_Title.Text;
            c.description = txt_Description.Text;
            c.added_date = DateTime.Now;
            

            //getting username of the logged in user
            string loggedUser = frm_Login.loggedIn;
            BLL_User usr = udal.GetIdFromUsername(loggedUser);
            c.added_by = usr.id;


            //Updating data into database
            bool success = dal.Update(c);
            if (success == true)
            {
                MessageBox.Show("Category updated successfully");
                clear();
                //Refreshing data grid view
                DataTable dt = dal.Select();
                dgv_Categories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update category");
            }
            
        }

        private void dgv_Categories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;
            txt_CategoryID.Text = dgv_Categories.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Title.Text = dgv_Categories.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Description.Text = dgv_Categories.Rows[rowIndex].Cells[2].Value.ToString();
            

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Getting user id from Form
            c.id = int.Parse(txt_CategoryID.Text);
            

            bool success = dal.Delete(c);
            if (success == true)
            {
                MessageBox.Show("User deleted successfully ");
                clear();
                //Refreshing data grid view
                DataTable dt = dal.Select();
                dgv_Categories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete category");
            }
            
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox
            string keywords = txt_Search.Text;

            //check if the keyword has value or not
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgv_Categories.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgv_Categories.DataSource = dt;
            }
        }
    }
}
