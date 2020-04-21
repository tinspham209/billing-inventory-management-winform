namespace AnyStore.UI
{
    partial class frm_DealerCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DealerCustomer));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.dgv_DeaCust = new System.Windows.Forms.DataGridView();
            this.txt_DeaCustID = new System.Windows.Forms.TextBox();
            this.lbl_DeaCustID = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DeaCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(566, 394);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(178, 38);
            this.btn_Delete.TabIndex = 60;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(337, 394);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(178, 38);
            this.btn_Update.TabIndex = 59;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(106, 394);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(178, 38);
            this.btn_Add.TabIndex = 58;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(370, 39);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(419, 24);
            this.txt_Search.TabIndex = 57;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(308, 42);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(56, 17);
            this.lbl_Search.TabIndex = 56;
            this.lbl_Search.Text = "Search";
            // 
            // dgv_DeaCust
            // 
            this.dgv_DeaCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DeaCust.Location = new System.Drawing.Point(311, 69);
            this.dgv_DeaCust.Name = "dgv_DeaCust";
            this.dgv_DeaCust.Size = new System.Drawing.Size(478, 309);
            this.dgv_DeaCust.TabIndex = 55;
            this.dgv_DeaCust.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_DeaCust_RowHeaderMouseClick);
            // 
            // txt_DeaCustID
            // 
            this.txt_DeaCustID.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DeaCustID.Location = new System.Drawing.Point(106, 39);
            this.txt_DeaCustID.Name = "txt_DeaCustID";
            this.txt_DeaCustID.ReadOnly = true;
            this.txt_DeaCustID.Size = new System.Drawing.Size(178, 24);
            this.txt_DeaCustID.TabIndex = 54;
            // 
            // lbl_DeaCustID
            // 
            this.lbl_DeaCustID.AutoSize = true;
            this.lbl_DeaCustID.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeaCustID.Location = new System.Drawing.Point(10, 42);
            this.lbl_DeaCustID.Name = "lbl_DeaCustID";
            this.lbl_DeaCustID.Size = new System.Drawing.Size(24, 17);
            this.lbl_DeaCustID.TabIndex = 53;
            this.lbl_DeaCustID.Text = "ID";
            // 
            // cmb_Type
            // 
            this.cmb_Type.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.cmb_Type.Location = new System.Drawing.Point(106, 69);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(178, 25);
            this.cmb_Type.TabIndex = 52;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(10, 72);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(40, 17);
            this.lbl_Type.TabIndex = 51;
            this.lbl_Type.Text = "Type";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(106, 189);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(178, 94);
            this.txt_Address.TabIndex = 48;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(10, 192);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(64, 17);
            this.lbl_Address.TabIndex = 47;
            this.lbl_Address.Text = "Address";
            // 
            // txt_Contact
            // 
            this.txt_Contact.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contact.Location = new System.Drawing.Point(106, 159);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(178, 24);
            this.txt_Contact.TabIndex = 46;
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact.Location = new System.Drawing.Point(10, 162);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(64, 17);
            this.lbl_Contact.TabIndex = 45;
            this.lbl_Contact.Text = "Contact";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(106, 129);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(178, 24);
            this.txt_Email.TabIndex = 40;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(10, 132);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(48, 17);
            this.lbl_Email.TabIndex = 39;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(106, 99);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(178, 24);
            this.txt_Name.TabIndex = 38;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(10, 102);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(40, 17);
            this.lbl_Name.TabIndex = 37;
            this.lbl_Name.Text = "Name";
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(767, 0);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 2;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(296, 5);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(219, 24);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "DEALER and CUSTOMER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox_Close);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 35);
            this.panel1.TabIndex = 34;
            // 
            // frm_DealerCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 464);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.dgv_DeaCust);
            this.Controls.Add(this.txt_DeaCustID);
            this.Controls.Add(this.lbl_DeaCustID);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.txt_Contact);
            this.Controls.Add(this.lbl_Contact);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DealerCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DealerCustomer";
            this.Load += new System.EventHandler(this.frm_DealerCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DeaCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.DataGridView dgv_DeaCust;
        private System.Windows.Forms.TextBox txt_DeaCustID;
        private System.Windows.Forms.Label lbl_DeaCustID;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel panel1;
    }
}