namespace AnyStore
{
    partial class frm_AdminDashBoard
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
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lb_Footer = new System.Windows.Forms.Label();
            this.menuStrip_Top = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_User = new System.Windows.Forms.Label();
            this.lbl_LoggedInUser = new System.Windows.Forms.Label();
            this.lb_AppFName = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_SHead = new System.Windows.Forms.Label();
            this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Footer.SuspendLayout();
            this.menuStrip_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnl_Footer.Controls.Add(this.lb_Footer);
            this.pnl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Footer.Location = new System.Drawing.Point(0, 545);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1963, 38);
            this.pnl_Footer.TabIndex = 0;
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
            // menuStrip_Top
            // 
            this.menuStrip_Top.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip_Top.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Top.Name = "menuStrip_Top";
            this.menuStrip_Top.Size = new System.Drawing.Size(1963, 33);
            this.menuStrip_Top.TabIndex = 1;
            this.menuStrip_Top.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(12, 37);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(56, 17);
            this.lb_User.TabIndex = 2;
            this.lb_User.Text = "User :";
            // 
            // lbl_LoggedInUser
            // 
            this.lbl_LoggedInUser.AutoSize = true;
            this.lbl_LoggedInUser.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedInUser.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_LoggedInUser.Location = new System.Drawing.Point(74, 37);
            this.lbl_LoggedInUser.Name = "lbl_LoggedInUser";
            this.lbl_LoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.lbl_LoggedInUser.TabIndex = 3;
            // 
            // lb_AppFName
            // 
            this.lb_AppFName.AutoSize = true;
            this.lb_AppFName.Font = new System.Drawing.Font("Source Code Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppFName.Location = new System.Drawing.Point(888, 409);
            this.lb_AppFName.Name = "lb_AppFName";
            this.lb_AppFName.Size = new System.Drawing.Size(63, 34);
            this.lb_AppFName.TabIndex = 4;
            this.lb_AppFName.Text = "ANY";
            this.lb_AppFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Source Code Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(940, 409);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(95, 34);
            this.lb_Name.TabIndex = 5;
            this.lb_Name.Text = "STORE";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_SHead
            // 
            this.lb_SHead.AutoSize = true;
            this.lb_SHead.Font = new System.Drawing.Font("Source Code Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SHead.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb_SHead.Location = new System.Drawing.Point(793, 443);
            this.lb_SHead.Name = "lb_SHead";
            this.lb_SHead.Size = new System.Drawing.Size(362, 24);
            this.lb_SHead.TabIndex = 6;
            this.lb_SHead.Text = "Billing and Inventory Management";
            this.lb_SHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(202, 29);
            this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
            // 
            // frm_AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1963, 583);
            this.Controls.Add(this.lb_SHead);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_AppFName);
            this.Controls.Add(this.lbl_LoggedInUser);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.menuStrip_Top);
            this.MainMenuStrip = this.menuStrip_Top;
            this.Name = "frm_AdminDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_AdminDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.frm_AdminDashBoard_Load);
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.menuStrip_Top.ResumeLayout(false);
            this.menuStrip_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lb_Footer;
        private System.Windows.Forms.MenuStrip menuStrip_Top;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lbl_LoggedInUser;
        private System.Windows.Forms.Label lb_AppFName;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_SHead;
        private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}

