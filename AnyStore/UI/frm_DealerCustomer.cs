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
    public partial class frm_DealerCustomer : Form
    {
        public frm_DealerCustomer()
        {
            InitializeComponent();
        }
        BLL_DealerCustomer dc = new BLL_DealerCustomer();
        DAL_DealerCustomer dcDal = new DAL_DealerCustomer();
        DAL_User uDal = new DAL_User();
        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dc.type = cmb_Type.Text;
            dc.name = txt_Name.Text;
            dc.email = txt_Email.Text;
            dc.contact = txt_Contact.Text;
            dc.address = txt_Address.Text;
            dc.added_date = DateTime.Now;

            //getting id in added by field
            string loggedUser = frm_Login.loggedIn;
            BLL_User usr = uDal.GetIdFromUsername(loggedUser);

            //passing the id of logged in user in added by field
            dc.added_by = usr.id;

            bool success = dcDal.Insert(dc);
            if (success == true)
            {
                MessageBox.Show("New Dealer/Customer Added successfully.");
                clear();
                //Refreshing data grid view
                DataTable dt = dcDal.Select();
                dgv_DeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to insert new category .");
            }
        }
        public void clear()
        {
            txt_DeaCustID.Text = "";
            txt_Name.Text = "";
            txt_Email.Text = "";
            txt_Contact.Text = "";
            txt_Address.Text = "";
            txt_Search.Text = "";
            cmb_Type.SelectedItem = null;
            cmb_Type.SelectedText = "--Select--";
        }

        private void frm_DealerCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = dcDal.Select();
            dgv_DeaCust.DataSource = dt;
            cmb_Type.SelectedItem = null;
            cmb_Type.SelectedText = "--Select--";
        }

        private void dgv_DeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;
            txt_DeaCustID.Text = dgv_DeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmb_Type.Text = dgv_DeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Name.Text = dgv_DeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Email.Text = dgv_DeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Contact.Text = dgv_DeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            txt_Address.Text = dgv_DeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get the values from User UI
            dc.id = int.Parse(txt_DeaCustID.Text);
            dc.type = cmb_Type.Text;
            dc.name = txt_Name.Text;
            dc.email = txt_Email.Text;
            dc.contact = txt_Contact.Text;
            dc.address = txt_Address.Text;
            dc.added_date = DateTime.Now;


            //getting id in added by field
            string loggedUser = frm_Login.loggedIn;
            BLL_User usr = uDal.GetIdFromUsername(loggedUser);

            //passing the id of logged in user in added by field
            dc.added_by = usr.id;

            //Updating data into database
            bool success = dcDal.Update(dc);
            if (success == true)
            {
                MessageBox.Show("Dealer/Customer updated successfully");
                clear();
                //Refreshing data grid view
                DataTable dt = dcDal.Select();
                dgv_DeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update Dealer/Customer");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Getting user id from Form
            dc.id = int.Parse(txt_DeaCustID.Text);


            bool success = dcDal.Delete(dc);
            if (success == true)
            {
                MessageBox.Show("Dealer/Customer deleted successfully ");
                clear();
                //Refreshing data grid view
                DataTable dt = dcDal.Select();
                dgv_DeaCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to delete Dealer/Customer");
            }

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox
            string keywords = txt_Search.Text;

            //check if the keyword has value or not
            if (keywords != null)
            {
                DataTable dt = dcDal.Search(keywords);
                dgv_DeaCust.DataSource = dt;
            }
            else
            {
                DataTable dt = dcDal.Select();
                dgv_DeaCust.DataSource = dt;
            }
        }
    }
}
