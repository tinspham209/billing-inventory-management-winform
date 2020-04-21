namespace AnyStore
{
    partial class frm_DashBoard_Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_LoggedInUser = new System.Windows.Forms.Label();
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_SHead = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_AppFName = new System.Windows.Forms.Label();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lb_Footer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesFormsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1975, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip_Top";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // salesFormsToolStripMenuItem
            // 
            this.salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
            this.salesFormsToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.salesFormsToolStripMenuItem.Text = "Sales";
            this.salesFormsToolStripMenuItem.Click += new System.EventHandler(this.salesFormsToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(202, 29);
            this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
            // 
            // lbl_LoggedInUser
            // 
            this.lbl_LoggedInUser.AutoSize = true;
            this.lbl_LoggedInUser.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedInUser.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_LoggedInUser.Location = new System.Drawing.Point(74, 38);
            this.lbl_LoggedInUser.Name = "lbl_LoggedInUser";
            this.lbl_LoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.lbl_LoggedInUser.TabIndex = 9;
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(12, 38);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(56, 17);
            this.lb_User.TabIndex = 8;
            this.lb_User.Text = "User :";
            // 
            // lb_SHead
            // 
            this.lb_SHead.AutoSize = true;
            this.lb_SHead.Font = new System.Drawing.Font("Source Code Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SHead.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb_SHead.Location = new System.Drawing.Point(796, 413);
            this.lb_SHead.Name = "lb_SHead";
            this.lb_SHead.Size = new System.Drawing.Size(362, 24);
            this.lb_SHead.TabIndex = 13;
            this.lb_SHead.Text = "Billing and Inventory Management";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Source Code Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(943, 379);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(95, 34);
            this.lb_Name.TabIndex = 12;
            this.lb_Name.Text = "STORE";
            // 
            // lb_AppFName
            // 
            this.lb_AppFName.AutoSize = true;
            this.lb_AppFName.Font = new System.Drawing.Font("Source Code Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppFName.Location = new System.Drawing.Point(891, 379);
            this.lb_AppFName.Name = "lb_AppFName";
            this.lb_AppFName.Size = new System.Drawing.Size(63, 34);
            this.lb_AppFName.TabIndex = 11;
            this.lb_AppFName.Text = "ANY";
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnl_Footer.Controls.Add(this.lb_Footer);
            this.pnl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Footer.Location = new System.Drawing.Point(0, 547);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1975, 38);
            this.pnl_Footer.TabIndex = 10;
            // 
            // lb_Footer
            // 
            this.lb_Footer.AutoSize = true;
            this.lb_Footer.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Footer.ForeColor = System.Drawing.Color.White;
            this.lb_Footer.Location = new System.Drawing.Point(803, 5);
            this.lb_Footer.Name = "lb_Footer";
            this.lb_Footer.Size = new System.Drawing.Size(307, 24);
            this.lb_Footer.TabIndex = 0;
            this.lb_Footer.Text = "Developed by : PHAM VAN TIN";
            // 
            // frm_DashBoard_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1975, 585);
            this.Controls.Add(this.lb_SHead);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_AppFName);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.lbl_LoggedInUser);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_DashBoard_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_DashBoard_Users_FormClosed);
            this.Load += new System.EventHandler(this.frm_DashBoard_Users_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label lbl_LoggedInUser;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_SHead;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_AppFName;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lb_Footer;
        private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}