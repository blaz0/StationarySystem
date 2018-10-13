namespace StationarySystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.utsLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingCircle = new CircularProgressBar.CircularProgressBar();
            this.BtnSystemSettings = new System.Windows.Forms.Button();
            this.BtnNotifications = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnRequests = new System.Windows.Forms.Button();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.ProductPic = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.sepdbDataSet = new StationarySystem.sepdbDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter1 = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSet1 = new StationarySystem.sepdbDataSet();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.WelcomeTxt = new System.Windows.Forms.TextBox();
            this.BtnStockLevel = new System.Windows.Forms.Button();
            this.StockPicture = new System.Windows.Forms.PictureBox();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.SettingsPicture = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnProfile2 = new System.Windows.Forms.Button();
            this.OkPicture = new System.Windows.Forms.PictureBox();
            this.ApproveReqBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OkPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // utsLogo
            // 
            this.utsLogo.Image = ((System.Drawing.Image)(resources.GetObject("utsLogo.Image")));
            this.utsLogo.Location = new System.Drawing.Point(152, 158);
            this.utsLogo.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.utsLogo.Name = "utsLogo";
            this.utsLogo.Size = new System.Drawing.Size(200, 286);
            this.utsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.utsLogo.TabIndex = 4;
            this.utsLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.loadingCircle);
            this.panel1.Controls.Add(this.utsLogo);
            this.panel1.Controls.Add(this.BtnSystemSettings);
            this.panel1.Controls.Add(this.BtnNotifications);
            this.panel1.Controls.Add(this.BtnProfile);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1399);
            this.panel1.TabIndex = 7;
            // 
            // loadingCircle
            // 
            this.loadingCircle.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.loadingCircle.AnimationSpeed = 500;
            this.loadingCircle.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.loadingCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadingCircle.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadingCircle.InnerMargin = 2;
            this.loadingCircle.InnerWidth = -1;
            this.loadingCircle.Location = new System.Drawing.Point(416, 386);
            this.loadingCircle.MarqueeAnimationSpeed = 2000;
            this.loadingCircle.Name = "loadingCircle";
            this.loadingCircle.OuterColor = System.Drawing.Color.Gray;
            this.loadingCircle.OuterMargin = -35;
            this.loadingCircle.OuterWidth = 26;
            this.loadingCircle.ProgressColor = System.Drawing.Color.Teal;
            this.loadingCircle.ProgressWidth = 20;
            this.loadingCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadingCircle.Size = new System.Drawing.Size(58, 59);
            this.loadingCircle.StartAngle = 270;
            this.loadingCircle.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingCircle.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingCircle.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.loadingCircle.SubscriptText = "";
            this.loadingCircle.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingCircle.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.loadingCircle.SuperscriptText = "";
            this.loadingCircle.TabIndex = 26;
            this.loadingCircle.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.loadingCircle.Value = 68;
            // 
            // BtnSystemSettings
            // 
            this.BtnSystemSettings.FlatAppearance.BorderSize = 0;
            this.BtnSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSystemSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSystemSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSystemSettings.Location = new System.Drawing.Point(0, 814);
            this.BtnSystemSettings.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnSystemSettings.Name = "BtnSystemSettings";
            this.BtnSystemSettings.Size = new System.Drawing.Size(500, 77);
            this.BtnSystemSettings.TabIndex = 3;
            this.BtnSystemSettings.Text = "My Requests";
            this.BtnSystemSettings.UseVisualStyleBackColor = true;
            this.BtnSystemSettings.Click += new System.EventHandler(this.BtnSystemSettings_Click);
            // 
            // BtnNotifications
            // 
            this.BtnNotifications.FlatAppearance.BorderSize = 0;
            this.BtnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotifications.ForeColor = System.Drawing.Color.White;
            this.BtnNotifications.Location = new System.Drawing.Point(0, 725);
            this.BtnNotifications.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnNotifications.Name = "BtnNotifications";
            this.BtnNotifications.Size = new System.Drawing.Size(500, 77);
            this.BtnNotifications.TabIndex = 2;
            this.BtnNotifications.Text = "Products";
            this.BtnNotifications.UseVisualStyleBackColor = true;
            this.BtnNotifications.Click += new System.EventHandler(this.BtnNotifications_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile.ForeColor = System.Drawing.Color.White;
            this.BtnProfile.Location = new System.Drawing.Point(0, 636);
            this.BtnProfile.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
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
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(0, 548);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(500, 77);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.Black;
            this.BtnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.Location = new System.Drawing.Point(544, 298);
            this.BtnProducts.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(600, 250);
            this.BtnProducts.TabIndex = 8;
            this.BtnProducts.Text = "View Products";
            this.BtnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProducts.UseVisualStyleBackColor = false;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnRequests
            // 
            this.BtnRequests.BackColor = System.Drawing.Color.Black;
            this.BtnRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequests.ForeColor = System.Drawing.Color.White;
            this.BtnRequests.Location = new System.Drawing.Point(1180, 298);
            this.BtnRequests.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnRequests.Name = "BtnRequests";
            this.BtnRequests.Size = new System.Drawing.Size(600, 250);
            this.BtnRequests.TabIndex = 9;
            this.BtnRequests.Text = "Requests";
            this.BtnRequests.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRequests.UseVisualStyleBackColor = false;
            this.BtnRequests.Click += new System.EventHandler(this.BtnRequests_Click);
            // 
            // BtnOrders
            // 
            this.BtnOrders.BackColor = System.Drawing.Color.Black;
            this.BtnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrders.ForeColor = System.Drawing.Color.White;
            this.BtnOrders.Location = new System.Drawing.Point(1820, 298);
            this.BtnOrders.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(600, 250);
            this.BtnOrders.TabIndex = 10;
            this.BtnOrders.Text = "Orders";
            this.BtnOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOrders.UseVisualStyleBackColor = false;
            // 
            // ProductPic
            // 
            this.ProductPic.BackColor = System.Drawing.Color.Black;
            this.ProductPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductPic.Image = ((System.Drawing.Image)(resources.GetObject("ProductPic.Image")));
            this.ProductPic.Location = new System.Drawing.Point(771, 336);
            this.ProductPic.Name = "ProductPic";
            this.ProductPic.Size = new System.Drawing.Size(135, 141);
            this.ProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPic.TabIndex = 12;
            this.ProductPic.TabStop = false;
            this.ProductPic.Tag = "";
            this.ProductPic.Click += new System.EventHandler(this.ProductPic_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Black;
            this.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(1408, 336);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(135, 141);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 13;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackColor = System.Drawing.Color.Black;
            this.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
            this.PictureBox4.Location = new System.Drawing.Point(2054, 336);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(135, 141);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox4.TabIndex = 14;
            this.PictureBox4.TabStop = false;
            // 
            // sepdbDataSet
            // 
            this.sepdbDataSet.DataSetName = "sepdbDataSet";
            this.sepdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.sepdbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.orderedproductsTableAdapter = null;
            this.tableAdapterManager1.productDetailTableAdapter = null;
            this.tableAdapterManager1.productTableAdapter = null;
            this.tableAdapterManager1.supplierorderTableAdapter = null;
            this.tableAdapterManager1.supplierTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = null;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.sepdbDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // sepdbDataSet1
            // 
            this.sepdbDataSet1.DataSetName = "sepdbDataSet";
            this.sepdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.sepdbDataSet1;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.sepdbDataSet1;
            // 
            // WelcomeTxt
            // 
            this.WelcomeTxt.BackColor = System.Drawing.SystemColors.Window;
            this.WelcomeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeTxt.Location = new System.Drawing.Point(544, 56);
            this.WelcomeTxt.Name = "WelcomeTxt";
            this.WelcomeTxt.ReadOnly = true;
            this.WelcomeTxt.Size = new System.Drawing.Size(1648, 145);
            this.WelcomeTxt.TabIndex = 15;
            this.WelcomeTxt.Text = "Welcome [first name of user]";
            // 
            // BtnStockLevel
            // 
            this.BtnStockLevel.BackColor = System.Drawing.Color.Black;
            this.BtnStockLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStockLevel.ForeColor = System.Drawing.Color.White;
            this.BtnStockLevel.Location = new System.Drawing.Point(1820, 625);
            this.BtnStockLevel.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnStockLevel.Name = "BtnStockLevel";
            this.BtnStockLevel.Size = new System.Drawing.Size(600, 250);
            this.BtnStockLevel.TabIndex = 16;
            this.BtnStockLevel.Text = "Stock Levels";
            this.BtnStockLevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnStockLevel.UseVisualStyleBackColor = false;
            // 
            // StockPicture
            // 
            this.StockPicture.BackColor = System.Drawing.Color.Black;
            this.StockPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockPicture.Image = ((System.Drawing.Image)(resources.GetObject("StockPicture.Image")));
            this.StockPicture.Location = new System.Drawing.Point(2054, 661);
            this.StockPicture.Name = "StockPicture";
            this.StockPicture.Size = new System.Drawing.Size(135, 141);
            this.StockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StockPicture.TabIndex = 17;
            this.StockPicture.TabStop = false;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.Black;
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Location = new System.Drawing.Point(544, 955);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(600, 250);
            this.BtnSettings.TabIndex = 18;
            this.BtnSettings.Text = "System Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSettings.UseVisualStyleBackColor = false;
            // 
            // SettingsPicture
            // 
            this.SettingsPicture.BackColor = System.Drawing.Color.Black;
            this.SettingsPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsPicture.Image = ((System.Drawing.Image)(resources.GetObject("SettingsPicture.Image")));
            this.SettingsPicture.Location = new System.Drawing.Point(772, 992);
            this.SettingsPicture.Name = "SettingsPicture";
            this.SettingsPicture.Size = new System.Drawing.Size(140, 141);
            this.SettingsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsPicture.TabIndex = 19;
            this.SettingsPicture.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Black;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(1408, 661);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(135, 141);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 21;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // BtnProfile2
            // 
            this.BtnProfile2.BackColor = System.Drawing.Color.Black;
            this.BtnProfile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProfile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile2.ForeColor = System.Drawing.Color.White;
            this.BtnProfile2.Location = new System.Drawing.Point(1180, 625);
            this.BtnProfile2.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BtnProfile2.Name = "BtnProfile2";
            this.BtnProfile2.Size = new System.Drawing.Size(600, 250);
            this.BtnProfile2.TabIndex = 20;
            this.BtnProfile2.Text = "View Profile";
            this.BtnProfile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProfile2.UseVisualStyleBackColor = false;
            this.BtnProfile2.Click += new System.EventHandler(this.BtnProfile2_Click);
            // 
            // OkPicture
            // 
            this.OkPicture.BackColor = System.Drawing.Color.Black;
            this.OkPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkPicture.Image = ((System.Drawing.Image)(resources.GetObject("OkPicture.Image")));
            this.OkPicture.Location = new System.Drawing.Point(771, 661);
            this.OkPicture.Name = "OkPicture";
            this.OkPicture.Size = new System.Drawing.Size(135, 141);
            this.OkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OkPicture.TabIndex = 23;
            this.OkPicture.TabStop = false;
            this.OkPicture.Click += new System.EventHandler(this.OkPicture_Click);
            // 
            // ApproveReqBtn
            // 
            this.ApproveReqBtn.BackColor = System.Drawing.Color.Black;
            this.ApproveReqBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApproveReqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveReqBtn.ForeColor = System.Drawing.Color.White;
            this.ApproveReqBtn.Location = new System.Drawing.Point(544, 625);
            this.ApproveReqBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ApproveReqBtn.Name = "ApproveReqBtn";
            this.ApproveReqBtn.Size = new System.Drawing.Size(600, 250);
            this.ApproveReqBtn.TabIndex = 22;
            this.ApproveReqBtn.Text = "Approve / Deny Requests";
            this.ApproveReqBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ApproveReqBtn.UseVisualStyleBackColor = false;
            this.ApproveReqBtn.Click += new System.EventHandler(this.ApproveReqBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
            this.logOutBtn.Location = new System.Drawing.Point(3480, 56);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(100, 100);
            this.logOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutBtn.TabIndex = 25;
            this.logOutBtn.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(2320, 56);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(100, 100);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 26;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2564, 1399);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.OkPicture);
            this.Controls.Add(this.ApproveReqBtn);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.BtnProfile2);
            this.Controls.Add(this.SettingsPicture);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.StockPicture);
            this.Controls.Add(this.BtnStockLevel);
            this.Controls.Add(this.WelcomeTxt);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.ProductPic);
            this.Controls.Add(this.BtnOrders);
            this.Controls.Add(this.BtnRequests);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnProducts);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "Home";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OkPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sepdbDataSet sepdbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private sepdbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private sepdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sepdbDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private sepdbDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private sepdbDataSet sepdbDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.PictureBox utsLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSystemSettings;
        private System.Windows.Forms.Button BtnNotifications;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnRequests;
        private System.Windows.Forms.Button BtnOrders;
        private System.Windows.Forms.PictureBox ProductPic;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.PictureBox PictureBox4;
        private System.Windows.Forms.TextBox WelcomeTxt;
        private System.Windows.Forms.Button BtnStockLevel;
        private System.Windows.Forms.PictureBox StockPicture;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.PictureBox SettingsPicture;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button BtnProfile2;
        private System.Windows.Forms.PictureBox OkPicture;
        private System.Windows.Forms.Button ApproveReqBtn;
        private System.Windows.Forms.PictureBox logOutBtn;
        private CircularProgressBar.CircularProgressBar loadingCircle;
        private System.Windows.Forms.PictureBox PictureBox2;
    }
}