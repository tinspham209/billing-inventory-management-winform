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
        }
    }
}
