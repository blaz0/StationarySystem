namespace StationarySystem
{
    partial class CreateStationeryRequestForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStationeryRequestForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.utsLogo = new System.Windows.Forms.PictureBox();
            this.BtnRequests = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadingCircle1 = new CircularProgressBar.CircularProgressBar();
            this.LogOutBtn = new System.Windows.Forms.PictureBox();
            this.ProductsLbl = new System.Windows.Forms.Label();
            this.groupOrder = new System.Windows.Forms.GroupBox();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.TotalPriceTxt = new System.Windows.Forms.TextBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.PricePerItemLbl = new System.Windows.Forms.Label();
            this.QtyLbl = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.NumericUpDown();
            this.ProductNameTxt = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSet = new StationarySystem.sepdbDataSet();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.productTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loadingCircle = new CircularProgressBar.CircularProgressBar();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutBtn)).BeginInit();
            this.groupOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // utsLogo
            // 
            this.utsLogo.Image = ((System.Drawing.Image)(resources.GetObject("utsLogo.Image")));
            this.utsLogo.Location = new System.Drawing.Point(150, 158);
            this.utsLogo.Margin = new System.Windows.Forms.Padding(6);
            this.utsLogo.Name = "utsLogo";
            this.utsLogo.Size = new System.Drawing.Size(200, 288);
            this.utsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.utsLogo.TabIndex = 4;
            this.utsLogo.TabStop = false;
            // 
            // BtnRequests
            // 
            this.BtnRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRequests.FlatAppearance.BorderSize = 0;
            this.BtnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequests.ForeColor = System.Drawing.Color.White;
            this.BtnRequests.Location = new System.Drawing.Point(0, 812);
            this.BtnRequests.Margin = new System.Windows.Forms.Padding(6);
            this.BtnRequests.Name = "BtnRequests";
            this.BtnRequests.Size = new System.Drawing.Size(500, 77);
            this.BtnRequests.TabIndex = 3;
            this.BtnRequests.Text = "My Requests";
            this.BtnRequests.UseVisualStyleBackColor = true;
            this.BtnRequests.Click += new System.EventHandler(this.BtnSystemSettings_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProducts.FlatAppearance.BorderSize = 0;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.Location = new System.Drawing.Point(0, 725);
            this.BtnProducts.Margin = new System.Windows.Forms.Padding(6);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(500, 77);
            this.BtnProducts.TabIndex = 2;
            this.BtnProducts.Text = "Products";
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnNotifications_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile.ForeColor = System.Drawing.Color.White;
            this.BtnProfile.Location = new System.Drawing.Point(0, 638);
            this.BtnProfile.Margin = new System.Windows.Forms.Padding(6);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(500, 77);
            this.BtnProfile.TabIndex = 1;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Teal;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(0, 548);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(6);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(500, 77);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LoadingCircle1);
            this.panel1.Controls.Add(this.utsLogo);
            this.panel1.Controls.Add(this.BtnRequests);
            this.panel1.Controls.Add(this.BtnProducts);
            this.panel1.Controls.Add(this.BtnProfile);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1158);
            this.panel1.TabIndex = 28;
            // 
            // LoadingCircle1
            // 
            this.LoadingCircle1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.LoadingCircle1.AnimationSpeed = 500;
            this.LoadingCircle1.BackColor = System.Drawing.Color.Transparent;
            this.LoadingCircle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LoadingCircle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadingCircle1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadingCircle1.InnerMargin = 2;
            this.LoadingCircle1.InnerWidth = -1;
            this.LoadingCircle1.Location = new System.Drawing.Point(410, 388);
            this.LoadingCircle1.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingCircle1.MarqueeAnimationSpeed = 2000;
            this.LoadingCircle1.Name = "LoadingCircle1";
            this.LoadingCircle1.OuterColor = System.Drawing.Color.Gray;
            this.LoadingCircle1.OuterMargin = -35;
            this.LoadingCircle1.OuterWidth = 26;
            this.LoadingCircle1.ProgressColor = System.Drawing.Color.Teal;
            this.LoadingCircle1.ProgressWidth = 20;
            this.LoadingCircle1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LoadingCircle1.Size = new System.Drawing.Size(58, 60);
            this.LoadingCircle1.StartAngle = 270;
            this.LoadingCircle1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingCircle1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoadingCircle1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.LoadingCircle1.SubscriptText = "";
            this.LoadingCircle1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoadingCircle1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.LoadingCircle1.SuperscriptText = "";
            this.LoadingCircle1.TabIndex = 32;
            this.LoadingCircle1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingCircle1.Value = 68;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.Image")));
            this.LogOutBtn.Location = new System.Drawing.Point(2260, 38);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(100, 100);
            this.LogOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOutBtn.TabIndex = 24;
            this.LogOutBtn.TabStop = false;
            this.LogOutBtn.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ProductsLbl
            // 
            this.ProductsLbl.AutoSize = true;
            this.ProductsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLbl.Location = new System.Drawing.Point(630, 71);
            this.ProductsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProductsLbl.Name = "ProductsLbl";
            this.ProductsLbl.Size = new System.Drawing.Size(1171, 108);
            this.ProductsLbl.TabIndex = 21;
            this.ProductsLbl.Text = "Create Stationery Request";
            // 
            // groupOrder
            // 
            this.groupOrder.Controls.Add(this.DescriptionTxt);
            this.groupOrder.Controls.Add(this.TotalPriceTxt);
            this.groupOrder.Controls.Add(this.PriceTxt);
            this.groupOrder.Controls.Add(this.TotalPriceLbl);
            this.groupOrder.Controls.Add(this.PricePerItemLbl);
            this.groupOrder.Controls.Add(this.QtyLbl);
            this.groupOrder.Controls.Add(this.Qty);
            this.groupOrder.Controls.Add(this.ProductNameTxt);
            this.groupOrder.Location = new System.Drawing.Point(650, 281);
            this.groupOrder.Margin = new System.Windows.Forms.Padding(6);
            this.groupOrder.Name = "groupOrder";
            this.groupOrder.Padding = new System.Windows.Forms.Padding(6);
            this.groupOrder.Size = new System.Drawing.Size(1766, 567);
            this.groupOrder.TabIndex = 29;
            this.groupOrder.TabStop = false;
            this.groupOrder.Text = "Your Order";
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTxt.Location = new System.Drawing.Point(100, 223);
            this.DescriptionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(784, 24);
            this.DescriptionTxt.TabIndex = 9;
            this.DescriptionTxt.Text = "product description";
            // 
            // TotalPriceTxt
            // 
            this.TotalPriceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPriceTxt.BackColor = System.Drawing.SystemColors.Window;
            this.TotalPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TotalPriceTxt.ForeColor = System.Drawing.Color.Black;
            this.TotalPriceTxt.Location = new System.Drawing.Point(1457, 415);
            this.TotalPriceTxt.Margin = new System.Windows.Forms.Padding(6);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.ReadOnly = true;
            this.TotalPriceTxt.Size = new System.Drawing.Size(297, 73);
            this.TotalPriceTxt.TabIndex = 7;
            this.TotalPriceTxt.Text = "$0.00";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceTxt.BackColor = System.Drawing.SystemColors.Window;
            this.PriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PriceTxt.ForeColor = System.Drawing.Color.Black;
            this.PriceTxt.Location = new System.Drawing.Point(1484, 138);
            this.PriceTxt.Margin = new System.Windows.Forms.Padding(6);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.ReadOnly = true;
            this.PriceTxt.Size = new System.Drawing.Size(220, 43);
            this.PriceTxt.TabIndex = 6;
            this.PriceTxt.Text = "priceperitem";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TotalPriceLbl.Location = new System.Drawing.Point(1105, 415);
            this.TotalPriceLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(356, 73);
            this.TotalPriceLbl.TabIndex = 5;
            this.TotalPriceLbl.Text = "Total Price:";
            // 
            // PricePerItemLbl
            // 
            this.PricePerItemLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PricePerItemLbl.AutoSize = true;
            this.PricePerItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PricePerItemLbl.Location = new System.Drawing.Point(1214, 138);
            this.PricePerItemLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PricePerItemLbl.Name = "PricePerItemLbl";
            this.PricePerItemLbl.Size = new System.Drawing.Size(267, 44);
            this.PricePerItemLbl.TabIndex = 4;
            this.PricePerItemLbl.Text = "Price per item:";
            // 
            // QtyLbl
            // 
            this.QtyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QtyLbl.AutoSize = true;
            this.QtyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyLbl.Location = new System.Drawing.Point(660, 138);
            this.QtyLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.QtyLbl.Name = "QtyLbl";
            this.QtyLbl.Size = new System.Drawing.Size(91, 44);
            this.QtyLbl.TabIndex = 3;
            this.QtyLbl.Text = "Qty:";
            // 
            // Qty
            // 
            this.Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.Location = new System.Drawing.Point(758, 135);
            this.Qty.Margin = new System.Windows.Forms.Padding(6);
            this.Qty.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(126, 44);
            this.Qty.TabIndex = 2;
            this.Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qty.ValueChanged += new System.EventHandler(this.Qty_ValueChanged);
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.AutoSize = true;
            this.ProductNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "name", true));
            this.ProductNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTxt.Location = new System.Drawing.Point(90, 138);
            this.ProductNameTxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(286, 48);
            this.ProductNameTxt.TabIndex = 0;
            this.ProductNameTxt.Text = "Product Name";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.sepdbDataSet;
            this.productBindingSource.Filter = "";
            // 
            // sepdbDataSet
            // 
            this.sepdbDataSet.DataSetName = "sepdbDataSet";
            this.sepdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Teal;
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(1942, 905);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(474, 65);
            this.SubmitBtn.TabIndex = 30;
            this.SubmitBtn.Text = "Submit Product Request";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.orderedproductsTableAdapter = null;
            this.tableAdapterManager.productDetailTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.supplierorderTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.sepdbDataSet;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = this.sepdbDataSet;
            this.usersBindingSource.Position = 0;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.sepdbDataSet;
            // 
            // loadingCircle
            // 
            this.loadingCircle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingCircle.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.loadingCircle.AnimationSpeed = 500;
            this.loadingCircle.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.loadingCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadingCircle.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadingCircle.InnerMargin = 2;
            this.loadingCircle.InnerWidth = -1;
            this.loadingCircle.Location = new System.Drawing.Point(3429, 1263);
            this.loadingCircle.Margin = new System.Windows.Forms.Padding(4);
            this.loadingCircle.MarqueeAnimationSpeed = 2000;
            this.loadingCircle.Name = "loadingCircle";
            this.loadingCircle.OuterColor = System.Drawing.Color.Gray;
            this.loadingCircle.OuterMargin = -35;
            this.loadingCircle.OuterWidth = 26;
            this.loadingCircle.ProgressColor = System.Drawing.Color.Teal;
            this.loadingCircle.ProgressWidth = 20;
            this.loadingCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadingCircle.Size = new System.Drawing.Size(58, 60);
            this.loadingCircle.StartAngle = 270;
            this.loadingCircle.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingCircle.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingCircle.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.loadingCircle.SubscriptText = "";
            this.loadingCircle.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingCircle.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.loadingCircle.SuperscriptText = "";
            this.loadingCircle.TabIndex = 31;
            this.loadingCircle.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.loadingCircle.Value = 68;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(512, 23);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(6);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(82, 83);
            this.BackBtn.TabIndex = 39;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateStationeryRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2522, 1158);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.loadingCircle);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.groupOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ProductsLbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateStationeryRequestForm";
            this.Text = "CreateStationeryRequest";
            this.Load += new System.EventHandler(this.CreateStationeryRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogOutBtn)).EndInit();
            this.groupOrder.ResumeLayout(false);
            this.groupOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private sepdbDataSet sepdbDataSet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox utsLogo;
        private System.Windows.Forms.Button BtnRequests;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.PictureBox LogOutBtn;
        private System.Windows.Forms.Label ProductsLbl;
        private sepdbDataSetTableAdapters.productTableAdapter productTableAdapter;
        private sepdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sepdbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.GroupBox groupOrder;
        private System.Windows.Forms.TextBox TotalPriceTxt;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.Label PricePerItemLbl;
        private System.Windows.Forms.Label QtyLbl;
        private System.Windows.Forms.NumericUpDown Qty;
        private System.Windows.Forms.Label ProductNameTxt;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private CircularProgressBar.CircularProgressBar loadingCircle;
        private CircularProgressBar.CircularProgressBar LoadingCircle1;
        private System.Windows.Forms.Button BackBtn;
    }
}