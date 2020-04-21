namespace AnyStore.UI
{
    partial class frm_PurchaseAndSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PurchaseAndSales));
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gB_DeaCust = new System.Windows.Forms.GroupBox();
            this.txt_SearchDeaCust = new System.Windows.Forms.TextBox();
            this.lbl_SearchDeaCust = new System.Windows.Forms.Label();
            this.txt_AddressDeaCust = new System.Windows.Forms.TextBox();
            this.lbl_AddressDeaCust = new System.Windows.Forms.Label();
            this.txt_ContactDeaCust = new System.Windows.Forms.TextBox();
            this.lbl_ContactDeaCust = new System.Windows.Forms.Label();
            this.txt_EmailDeaCust = new System.Windows.Forms.TextBox();
            this.lbl_EmailDeaCust = new System.Windows.Forms.Label();
            this.txt_NameDeaCust = new System.Windows.Forms.TextBox();
            this.lbl_NameDeaCust = new System.Windows.Forms.Label();
            this.lb_BillDateDeaCust = new System.Windows.Forms.Label();
            this.dateTimePicker_DeaCust = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_SearchProduct = new System.Windows.Forms.Label();
            this.gB_Product = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_RateProduct = new System.Windows.Forms.Label();
            this.lbl_NameProduct = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_InventoryProduct = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_QtyProduct = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gB_AddedProducts = new System.Windows.Forms.GroupBox();
            this.gB_Calculation = new System.Windows.Forms.GroupBox();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.txt_VAT = new System.Windows.Forms.TextBox();
            this.txt_GrandTotal = new System.Windows.Forms.TextBox();
            this.lbl_GrandTotal = new System.Windows.Forms.Label();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.txt_PaidAmount = new System.Windows.Forms.TextBox();
            this.txt_ReturnAmount = new System.Windows.Forms.TextBox();
            this.lbl_ReturnAmount = new System.Windows.Forms.Label();
            this.lbl_PaidAmount = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dgv_AddedProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.panel1.SuspendLayout();
            this.gB_DeaCust.SuspendLayout();
            this.gB_Product.SuspendLayout();
            this.gB_AddedProducts.SuspendLayout();
            this.gB_Calculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(1225, 0);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 2;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox_Close);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 35);
            this.panel1.TabIndex = 35;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(550, 5);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(208, 24);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "PURCHASE and SALES";
            // 
            // gB_DeaCust
            // 
            this.gB_DeaCust.Controls.Add(this.dateTimePicker_DeaCust);
            this.gB_DeaCust.Controls.Add(this.lb_BillDateDeaCust);
            this.gB_DeaCust.Controls.Add(this.txt_AddressDeaCust);
            this.gB_DeaCust.Controls.Add(this.txt_SearchDeaCust);
            this.gB_DeaCust.Controls.Add(this.lbl_AddressDeaCust);
            this.gB_DeaCust.Controls.Add(this.txt_NameDeaCust);
            this.gB_DeaCust.Controls.Add(this.txt_ContactDeaCust);
            this.gB_DeaCust.Controls.Add(this.lbl_SearchDeaCust);
            this.gB_DeaCust.Controls.Add(this.lbl_ContactDeaCust);
            this.gB_DeaCust.Controls.Add(this.lbl_NameDeaCust);
            this.gB_DeaCust.Controls.Add(this.txt_EmailDeaCust);
            this.gB_DeaCust.Controls.Add(this.lbl_EmailDeaCust);
            this.gB_DeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_DeaCust.Location = new System.Drawing.Point(13, 43);
            this.gB_DeaCust.Name = "gB_DeaCust";
            this.gB_DeaCust.Size = new System.Drawing.Size(1235, 81);
            this.gB_DeaCust.TabIndex = 36;
            this.gB_DeaCust.TabStop = false;
            this.gB_DeaCust.Text = "Dealer and Customer Details";
            // 
            // txt_SearchDeaCust
            // 
            this.txt_SearchDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchDeaCust.Location = new System.Drawing.Point(68, 17);
            this.txt_SearchDeaCust.Name = "txt_SearchDeaCust";
            this.txt_SearchDeaCust.Size = new System.Drawing.Size(193, 24);
            this.txt_SearchDeaCust.TabIndex = 67;
            // 
            // lbl_SearchDeaCust
            // 
            this.lbl_SearchDeaCust.AutoSize = true;
            this.lbl_SearchDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchDeaCust.Location = new System.Drawing.Point(6, 20);
            this.lbl_SearchDeaCust.Name = "lbl_SearchDeaCust";
            this.lbl_SearchDeaCust.Size = new System.Drawing.Size(56, 17);
            this.lbl_SearchDeaCust.TabIndex = 66;
            this.lbl_SearchDeaCust.Text = "Search";
            // 
            // txt_AddressDeaCust
            // 
            this.txt_AddressDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddressDeaCust.Location = new System.Drawing.Point(660, 17);
            this.txt_AddressDeaCust.Multiline = true;
            this.txt_AddressDeaCust.Name = "txt_AddressDeaCust";
            this.txt_AddressDeaCust.Size = new System.Drawing.Size(193, 54);
            this.txt_AddressDeaCust.TabIndex = 65;
            // 
            // lbl_AddressDeaCust
            // 
            this.lbl_AddressDeaCust.AutoSize = true;
            this.lbl_AddressDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddressDeaCust.Location = new System.Drawing.Point(590, 20);
            this.lbl_AddressDeaCust.Name = "lbl_AddressDeaCust";
            this.lbl_AddressDeaCust.Size = new System.Drawing.Size(64, 17);
            this.lbl_AddressDeaCust.TabIndex = 64;
            this.lbl_AddressDeaCust.Text = "Address";
            // 
            // txt_ContactDeaCust
            // 
            this.txt_ContactDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContactDeaCust.Location = new System.Drawing.Point(363, 47);
            this.txt_ContactDeaCust.Name = "txt_ContactDeaCust";
            this.txt_ContactDeaCust.Size = new System.Drawing.Size(197, 24);
            this.txt_ContactDeaCust.TabIndex = 63;
            // 
            // lbl_ContactDeaCust
            // 
            this.lbl_ContactDeaCust.AutoSize = true;
            this.lbl_ContactDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContactDeaCust.Location = new System.Drawing.Point(293, 50);
            this.lbl_ContactDeaCust.Name = "lbl_ContactDeaCust";
            this.lbl_ContactDeaCust.Size = new System.Drawing.Size(64, 17);
            this.lbl_ContactDeaCust.TabIndex = 62;
            this.lbl_ContactDeaCust.Text = "Contact";
            // 
            // txt_EmailDeaCust
            // 
            this.txt_EmailDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailDeaCust.Location = new System.Drawing.Point(363, 17);
            this.txt_EmailDeaCust.Name = "txt_EmailDeaCust";
            this.txt_EmailDeaCust.Size = new System.Drawing.Size(197, 24);
            this.txt_EmailDeaCust.TabIndex = 61;
            // 
            // lbl_EmailDeaCust
            // 
            this.lbl_EmailDeaCust.AutoSize = true;
            this.lbl_EmailDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailDeaCust.Location = new System.Drawing.Point(293, 20);
            this.lbl_EmailDeaCust.Name = "lbl_EmailDeaCust";
            this.lbl_EmailDeaCust.Size = new System.Drawing.Size(48, 17);
            this.lbl_EmailDeaCust.TabIndex = 60;
            this.lbl_EmailDeaCust.Text = "Email";
            // 
            // txt_NameDeaCust
            // 
            this.txt_NameDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameDeaCust.Location = new System.Drawing.Point(68, 47);
            this.txt_NameDeaCust.Name = "txt_NameDeaCust";
            this.txt_NameDeaCust.Size = new System.Drawing.Size(193, 24);
            this.txt_NameDeaCust.TabIndex = 59;
            // 
            // lbl_NameDeaCust
            // 
            this.lbl_NameDeaCust.AutoSize = true;
            this.lbl_NameDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameDeaCust.Location = new System.Drawing.Point(6, 50);
            this.lbl_NameDeaCust.Name = "lbl_NameDeaCust";
            this.lbl_NameDeaCust.Size = new System.Drawing.Size(40, 17);
            this.lbl_NameDeaCust.TabIndex = 58;
            this.lbl_NameDeaCust.Text = "Name";
            // 
            // lb_BillDateDeaCust
            // 
            this.lb_BillDateDeaCust.AutoSize = true;
            this.lb_BillDateDeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BillDateDeaCust.Location = new System.Drawing.Point(885, 20);
            this.lb_BillDateDeaCust.Name = "lb_BillDateDeaCust";
            this.lb_BillDateDeaCust.Size = new System.Drawing.Size(80, 17);
            this.lb_BillDateDeaCust.TabIndex = 68;
            this.lb_BillDateDeaCust.Text = "Bill Date";
            // 
            // dateTimePicker_DeaCust
            // 
            this.dateTimePicker_DeaCust.CalendarFont = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DeaCust.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DeaCust.Location = new System.Drawing.Point(975, 17);
            this.dateTimePicker_DeaCust.Name = "dateTimePicker_DeaCust";
            this.dateTimePicker_DeaCust.Size = new System.Drawing.Size(251, 24);
            this.dateTimePicker_DeaCust.TabIndex = 69;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(68, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 24);
            this.textBox1.TabIndex = 67;
            // 
            // lbl_SearchProduct
            // 
            this.lbl_SearchProduct.AutoSize = true;
            this.lbl_SearchProduct.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchProduct.Location = new System.Drawing.Point(6, 20);
            this.lbl_SearchProduct.Name = "lbl_SearchProduct";
            this.lbl_SearchProduct.Size = new System.Drawing.Size(56, 17);
            this.lbl_SearchProduct.TabIndex = 66;
            this.lbl_SearchProduct.Text = "Search";
            // 
            // gB_Product
            // 
            this.gB_Product.Controls.Add(this.btn_Add);
            this.gB_Product.Controls.Add(this.textBox2);
            this.gB_Product.Controls.Add(this.lbl_QtyProduct);
            this.gB_Product.Controls.Add(this.textBox1);
            this.gB_Product.Controls.Add(this.textBox3);
            this.gB_Product.Controls.Add(this.textBox4);
            this.gB_Product.Controls.Add(this.lbl_SearchProduct);
            this.gB_Product.Controls.Add(this.lbl_RateProduct);
            this.gB_Product.Controls.Add(this.lbl_NameProduct);
            this.gB_Product.Controls.Add(this.textBox5);
            this.gB_Product.Controls.Add(this.lbl_InventoryProduct);
            this.gB_Product.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_Product.Location = new System.Drawing.Point(13, 131);
            this.gB_Product.Name = "gB_Product";
            this.gB_Product.Size = new System.Drawing.Size(1235, 48);
            this.gB_Product.TabIndex = 70;
            this.gB_Product.TabStop = false;
            this.gB_Product.Text = "Product Details";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(274, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 24);
            this.textBox3.TabIndex = 59;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(730, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 24);
            this.textBox4.TabIndex = 63;
            // 
            // lbl_RateProduct
            // 
            this.lbl_RateProduct.AutoSize = true;
            this.lbl_RateProduct.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RateProduct.Location = new System.Drawing.Point(684, 20);
            this.lbl_RateProduct.Name = "lbl_RateProduct";
            this.lbl_RateProduct.Size = new System.Drawing.Size(40, 17);
            this.lbl_RateProduct.TabIndex = 62;
            this.lbl_RateProduct.Text = "Rate";
            // 
            // lbl_NameProduct
            // 
            this.lbl_NameProduct.AutoSize = true;
            this.lbl_NameProduct.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameProduct.Location = new System.Drawing.Point(228, 20);
            this.lbl_NameProduct.Name = "lbl_NameProduct";
            this.lbl_NameProduct.Size = new System.Drawing.Size(40, 17);
            this.lbl_NameProduct.TabIndex = 58;
            this.lbl_NameProduct.Text = "Name";
            this.lbl_NameProduct.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(520, 17);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 24);
            this.textBox5.TabIndex = 61;
            // 
            // lbl_InventoryProduct
            // 
            this.lbl_InventoryProduct.AutoSize = true;
            this.lbl_InventoryProduct.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InventoryProduct.Location = new System.Drawing.Point(434, 20);
            this.lbl_InventoryProduct.Name = "lbl_InventoryProduct";
            this.lbl_InventoryProduct.Size = new System.Drawing.Size(80, 17);
            this.lbl_InventoryProduct.TabIndex = 60;
            this.lbl_InventoryProduct.Text = "Inventory";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(932, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 24);
            this.textBox2.TabIndex = 69;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_QtyProduct
            // 
            this.lbl_QtyProduct.AutoSize = true;
            this.lbl_QtyProduct.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QtyProduct.Location = new System.Drawing.Point(894, 20);
            this.lbl_QtyProduct.Name = "lbl_QtyProduct";
            this.lbl_QtyProduct.Size = new System.Drawing.Size(32, 17);
            this.lbl_QtyProduct.TabIndex = 68;
            this.lbl_QtyProduct.Text = "Qty";
            this.lbl_QtyProduct.Click += new System.EventHandler(this.lbl_QtyProduct_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1119, 16);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 24);
            this.btn_Add.TabIndex = 71;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // gB_AddedProducts
            // 
            this.gB_AddedProducts.Controls.Add(this.dgv_AddedProducts);
            this.gB_AddedProducts.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_AddedProducts.Location = new System.Drawing.Point(13, 186);
            this.gB_AddedProducts.Name = "gB_AddedProducts";
            this.gB_AddedProducts.Size = new System.Drawing.Size(608, 267);
            this.gB_AddedProducts.TabIndex = 71;
            this.gB_AddedProducts.TabStop = false;
            this.gB_AddedProducts.Text = "Added Products";
            // 
            // gB_Calculation
            // 
            this.gB_Calculation.Controls.Add(this.btn_Save);
            this.gB_Calculation.Controls.Add(this.txt_PaidAmount);
            this.gB_Calculation.Controls.Add(this.txt_ReturnAmount);
            this.gB_Calculation.Controls.Add(this.lbl_ReturnAmount);
            this.gB_Calculation.Controls.Add(this.lbl_PaidAmount);
            this.gB_Calculation.Controls.Add(this.txt_VAT);
            this.gB_Calculation.Controls.Add(this.txt_GrandTotal);
            this.gB_Calculation.Controls.Add(this.lbl_GrandTotal);
            this.gB_Calculation.Controls.Add(this.lbl_VAT);
            this.gB_Calculation.Controls.Add(this.txt_SubTotal);
            this.gB_Calculation.Controls.Add(this.txt_Discount);
            this.gB_Calculation.Controls.Add(this.lbl_Discount);
            this.gB_Calculation.Controls.Add(this.lbl_SubTotal);
            this.gB_Calculation.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_Calculation.Location = new System.Drawing.Point(635, 186);
            this.gB_Calculation.Name = "gB_Calculation";
            this.gB_Calculation.Size = new System.Drawing.Size(613, 267);
            this.gB_Calculation.TabIndex = 72;
            this.gB_Calculation.TabStop = false;
            this.gB_Calculation.Text = "Calculation Details";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubTotal.Location = new System.Drawing.Point(140, 23);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(462, 24);
            this.txt_SubTotal.TabIndex = 73;
            // 
            // txt_Discount
            // 
            this.txt_Discount.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.Location = new System.Drawing.Point(140, 53);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(462, 24);
            this.txt_Discount.TabIndex = 71;
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTotal.Location = new System.Drawing.Point(11, 26);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(80, 17);
            this.lbl_SubTotal.TabIndex = 72;
            this.lbl_SubTotal.Text = "Sub Total";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(11, 56);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(104, 17);
            this.lbl_Discount.TabIndex = 70;
            this.lbl_Discount.Text = "Discount (%)";
            // 
            // txt_VAT
            // 
            this.txt_VAT.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VAT.Location = new System.Drawing.Point(140, 83);
            this.txt_VAT.Name = "txt_VAT";
            this.txt_VAT.Size = new System.Drawing.Size(462, 24);
            this.txt_VAT.TabIndex = 77;
            // 
            // txt_GrandTotal
            // 
            this.txt_GrandTotal.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GrandTotal.Location = new System.Drawing.Point(140, 113);
            this.txt_GrandTotal.Name = "txt_GrandTotal";
            this.txt_GrandTotal.ReadOnly = true;
            this.txt_GrandTotal.Size = new System.Drawing.Size(462, 24);
            this.txt_GrandTotal.TabIndex = 75;
            // 
            // lbl_GrandTotal
            // 
            this.lbl_GrandTotal.AutoSize = true;
            this.lbl_GrandTotal.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GrandTotal.Location = new System.Drawing.Point(11, 116);
            this.lbl_GrandTotal.Name = "lbl_GrandTotal";
            this.lbl_GrandTotal.Size = new System.Drawing.Size(96, 17);
            this.lbl_GrandTotal.TabIndex = 74;
            this.lbl_GrandTotal.Text = "Grand Total";
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VAT.Location = new System.Drawing.Point(11, 86);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(64, 17);
            this.lbl_VAT.TabIndex = 76;
            this.lbl_VAT.Text = "VAT (%)";
            // 
            // txt_PaidAmount
            // 
            this.txt_PaidAmount.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PaidAmount.Location = new System.Drawing.Point(140, 143);
            this.txt_PaidAmount.Name = "txt_PaidAmount";
            this.txt_PaidAmount.Size = new System.Drawing.Size(462, 24);
            this.txt_PaidAmount.TabIndex = 81;
            // 
            // txt_ReturnAmount
            // 
            this.txt_ReturnAmount.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReturnAmount.Location = new System.Drawing.Point(140, 173);
            this.txt_ReturnAmount.Multiline = true;
            this.txt_ReturnAmount.Name = "txt_ReturnAmount";
            this.txt_ReturnAmount.ReadOnly = true;
            this.txt_ReturnAmount.Size = new System.Drawing.Size(462, 44);
            this.txt_ReturnAmount.TabIndex = 79;
            // 
            // lbl_ReturnAmount
            // 
            this.lbl_ReturnAmount.AutoSize = true;
            this.lbl_ReturnAmount.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReturnAmount.Location = new System.Drawing.Point(11, 176);
            this.lbl_ReturnAmount.Name = "lbl_ReturnAmount";
            this.lbl_ReturnAmount.Size = new System.Drawing.Size(112, 17);
            this.lbl_ReturnAmount.TabIndex = 78;
            this.lbl_ReturnAmount.Text = "Return Amount";
            // 
            // lbl_PaidAmount
            // 
            this.lbl_PaidAmount.AutoSize = true;
            this.lbl_PaidAmount.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaidAmount.Location = new System.Drawing.Point(11, 146);
            this.lbl_PaidAmount.Name = "lbl_PaidAmount";
            this.lbl_PaidAmount.Size = new System.Drawing.Size(96, 17);
            this.lbl_PaidAmount.TabIndex = 80;
            this.lbl_PaidAmount.Text = "Paid Amount";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(241, 223);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(178, 38);
            this.btn_Save.TabIndex = 72;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // dgv_AddedProducts
            // 
            this.dgv_AddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AddedProducts.Location = new System.Drawing.Point(9, 21);
            this.dgv_AddedProducts.Name = "dgv_AddedProducts";
            this.dgv_AddedProducts.Size = new System.Drawing.Size(590, 237);
            this.dgv_AddedProducts.TabIndex = 72;
            // 
            // frm_PurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 463);
            this.Controls.Add(this.gB_Calculation);
            this.Controls.Add(this.gB_AddedProducts);
            this.Controls.Add(this.gB_Product);
            this.Controls.Add(this.gB_DeaCust);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PurchaseAndSales";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gB_DeaCust.ResumeLayout(false);
            this.gB_DeaCust.PerformLayout();
            this.gB_Product.ResumeLayout(false);
            this.gB_Product.PerformLayout();
            this.gB_AddedProducts.ResumeLayout(false);
            this.gB_Calculation.ResumeLayout(false);
            this.gB_Calculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddedProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gB_DeaCust;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DeaCust;
        private System.Windows.Forms.Label lb_BillDateDeaCust;
        private System.Windows.Forms.TextBox txt_AddressDeaCust;
        private System.Windows.Forms.TextBox txt_SearchDeaCust;
        private System.Windows.Forms.Label lbl_AddressDeaCust;
        private System.Windows.Forms.TextBox txt_NameDeaCust;
        private System.Windows.Forms.TextBox txt_ContactDeaCust;
        private System.Windows.Forms.Label lbl_SearchDeaCust;
        private System.Windows.Forms.Label lbl_ContactDeaCust;
        private System.Windows.Forms.Label lbl_NameDeaCust;
        private System.Windows.Forms.TextBox txt_EmailDeaCust;
        private System.Windows.Forms.Label lbl_EmailDeaCust;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_SearchProduct;
        private System.Windows.Forms.GroupBox gB_Product;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_RateProduct;
        private System.Windows.Forms.Label lbl_NameProduct;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_InventoryProduct;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_QtyProduct;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox gB_AddedProducts;
        private System.Windows.Forms.GroupBox gB_Calculation;
        private System.Windows.Forms.TextBox txt_PaidAmount;
        private System.Windows.Forms.TextBox txt_ReturnAmount;
        private System.Windows.Forms.Label lbl_ReturnAmount;
        private System.Windows.Forms.Label lbl_PaidAmount;
        private System.Windows.Forms.TextBox txt_VAT;
        private System.Windows.Forms.TextBox txt_GrandTotal;
        private System.Windows.Forms.Label lbl_GrandTotal;
        private System.Windows.Forms.Label lbl_VAT;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dgv_AddedProducts;
    }
}