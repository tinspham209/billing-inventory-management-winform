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

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
