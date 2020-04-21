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
    public partial class frm_Products : Form
    {
        public frm_Products()
        {
            InitializeComponent();
        }

        DAL_categories cdal = new DAL_categories();
        BLL_Products p = new BLL_Products();
        DAL_Products pdal = new DAL_Products();
        DAL_User udal = new DAL_User();
        private void cmb_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Gender_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Products_Load(object sender, EventArgs e)
        {
            //creating data table to hold the categories from db
            DataTable categoriesDT = cdal.Select();

            //specify dataSource for category combobox
            cmb_Category.DataSource = categoriesDT;

            //specify display member & value for combobox
            cmb_Category.DisplayMember = "title";
            cmb_Category.ValueMember = "title";

            //load all the products in data grid view
            DataTable dt = pdal.Select();
            dgv_Products.DataSource = dt;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            


            //Getting data from UI
            p.name = txt_Name.Text;
            p.category = cmb_Category.Text;
            p.description = txt_Description.Text;
            p.rate = decimal.Parse(txt_Rate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            //getting username of the logged in user

            string loggedUser = frm_Login.loggedIn;

            BLL_User usr = udal.GetIdFromUsername(loggedUser);
            p.added_by = usr.id;

            // Inserting data into db
            bool success = pdal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("Product Added Successfully.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add new product.");
            }

            //Refreshing data grid view
            DataTable dt = pdal.Select();
            dgv_Products.DataSource = dt;

        }

        public void clear()
        {
            txt_ProductID.Text = "";
            txt_Name.Text = "";
            txt_Description.Text = "";
            txt_Rate.Text = "";
            txt_Search.Text = "";
        }

        private void dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;
            txt_ProductID.Text = dgv_Products.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Name.Text = dgv_Products.Rows[rowIndex].Cells[1].Value.ToString();
            cmb_Category.Text = dgv_Products.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Description.Text = dgv_Products.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Rate.Text = dgv_Products.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get the values from User UI
            p.id = int.Parse(txt_ProductID.Text);
            p.name = txt_Name.Text;
            p.category = cmb_Category.Text;
            p.description = txt_Description.Text;
            p.rate = decimal.Parse(txt_Rate.Text);
            p.added_date = DateTime.Now;

            //getting username of the logged in user

            string loggedUser = frm_Login.loggedIn;
            BLL_User usr = udal.GetIdFromUsername(loggedUser);
            p.added_by = usr.id;


            //Updating data into database
            bool success = pdal.Update(p);
            if (success == true)
            {
                MessageBox.Show("Product successfully updated");
                clear();

                //Refreshing data grid view
                DataTable dt = pdal.Select();
                dgv_Products.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update product");
            }
            
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Getting user id from Form
            p.id = int.Parse(txt_ProductID.Text);

            bool success = pdal.Delete(p);
            if (success == true)
            {
                MessageBox.Show("Product successfully deleted");
                clear();
                //Refreshing data grid view
                DataTable dt = pdal.Select();
                dgv_Products.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete product");
            }
            
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox
            string keywords = txt_Search.Text;

            //check if the keyword has value or not
            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dgv_Products.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgv_Products.DataSource = dt;
            }
        }
    }
}
