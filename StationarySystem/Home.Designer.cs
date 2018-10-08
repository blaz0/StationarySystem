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
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.productPic = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
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
            this.welcomeTxt = new System.Windows.Forms.TextBox();
            this.btnStockLevel = new System.Windows.Forms.Button();
            this.stockPicture = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.settingsPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProfile2 = new System.Windows.Forms.Button();
            this.okPicture = new System.Windows.Forms.PictureBox();
            this.approveReqBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // utsLogo
            // 
            this.utsLogo.Image = ((System.Drawing.Image)(resources.GetObject("utsLogo.Image")));
            this.utsLogo.Location = new System.Drawing.Point(100, 101);
            this.utsLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.utsLogo.Name = "utsLogo";
            this.utsLogo.Size = new System.Drawing.Size(133, 184);
            this.utsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.utsLogo.TabIndex = 4;
            this.utsLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.loadingCircle);
            this.panel1.Controls.Add(this.utsLogo);
            this.panel1.Controls.Add(this.btnSystemSettings);
            this.panel1.Controls.Add(this.btnNotifications);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 1055);
            this.panel1.TabIndex = 7;
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
            this.loadingCircle.Location = new System.Drawing.Point(281, 409);
            this.loadingCircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadingCircle.MarqueeAnimationSpeed = 2000;
            this.loadingCircle.Name = "loadingCircle";
            this.loadingCircle.OuterColor = System.Drawing.Color.Gray;
            this.loadingCircle.OuterMargin = -35;
            this.loadingCircle.OuterWidth = 26;
            this.loadingCircle.ProgressColor = System.Drawing.Color.Teal;
            this.loadingCircle.ProgressWidth = 20;
            this.loadingCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadingCircle.Size = new System.Drawing.Size(39, 38);
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
            // btnSystemSettings
            // 
            this.btnSystemSettings.FlatAppearance.BorderSize = 0;
            this.btnSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemSettings.ForeColor = System.Drawing.Color.White;
            this.btnSystemSettings.Location = new System.Drawing.Point(0, 520);
            this.btnSystemSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSystemSettings.Name = "btnSystemSettings";
            this.btnSystemSettings.Size = new System.Drawing.Size(333, 49);
            this.btnSystemSettings.TabIndex = 3;
            this.btnSystemSettings.Text = "My Requests";
            this.btnSystemSettings.UseVisualStyleBackColor = true;
            // 
            // btnNotifications
            // 
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Location = new System.Drawing.Point(0, 464);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(333, 49);
            this.btnNotifications.TabIndex = 2;
            this.btnNotifications.Text = "Products";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 408);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(333, 49);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Teal;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 351);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(333, 49);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Black;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(363, 191);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(400, 160);
            this.btnProducts.TabIndex = 8;
            this.btnProducts.Text = "View Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.BackColor = System.Drawing.Color.Black;
            this.btnRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.ForeColor = System.Drawing.Color.White;
            this.btnRequests.Location = new System.Drawing.Point(787, 191);
            this.btnRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(400, 160);
            this.btnRequests.TabIndex = 9;
            this.btnRequests.Text = "Requests";
            this.btnRequests.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRequests.UseVisualStyleBackColor = false;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Black;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(1213, 191);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(400, 160);
            this.btnOrders.TabIndex = 10;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrders.UseVisualStyleBackColor = false;
            // 
            // productPic
            // 
            this.productPic.Image = ((System.Drawing.Image)(resources.GetObject("productPic.Image")));
            this.productPic.Location = new System.Drawing.Point(514, 210);
            this.productPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(93, 90);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPic.TabIndex = 12;
            this.productPic.TabStop = false;
            this.productPic.Tag = "";
            this.productPic.Click += new System.EventHandler(this.productPic_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(939, 210);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1369, 210);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(93, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
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
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.orderedproductsTableAdapter = null;
            this.tableAdapterManager.productDetailTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.stationeryrequestTableAdapter = null;
            this.tableAdapterManager.supplierorderTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.invoiceTableAdapter = null;
            this.tableAdapterManager1.orderedproductsTableAdapter = null;
            this.tableAdapterManager1.productDetailTableAdapter = null;
            this.tableAdapterManager1.productTableAdapter = null;
            this.tableAdapterManager1.stationeryrequestTableAdapter = null;
            this.tableAdapterManager1.supplierorderTableAdapter = null;
            this.tableAdapterManager1.supplierTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = this.usersTableAdapter1;
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
            // welcomeTxt
            // 
            this.welcomeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTxt.Location = new System.Drawing.Point(363, 36);
            this.welcomeTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.welcomeTxt.Name = "welcomeTxt";
            this.welcomeTxt.Size = new System.Drawing.Size(1145, 91);
            this.welcomeTxt.TabIndex = 15;
            this.welcomeTxt.Text = "Welcome [first name of user]";
            // 
            // btnStockLevel
            // 
            this.btnStockLevel.BackColor = System.Drawing.Color.Black;
            this.btnStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockLevel.ForeColor = System.Drawing.Color.White;
            this.btnStockLevel.Location = new System.Drawing.Point(1213, 400);
            this.btnStockLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStockLevel.Name = "btnStockLevel";
            this.btnStockLevel.Size = new System.Drawing.Size(400, 160);
            this.btnStockLevel.TabIndex = 16;
            this.btnStockLevel.Text = "Stock Levels";
            this.btnStockLevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStockLevel.UseVisualStyleBackColor = false;
            // 
            // stockPicture
            // 
            this.stockPicture.Image = ((System.Drawing.Image)(resources.GetObject("stockPicture.Image")));
            this.stockPicture.Location = new System.Drawing.Point(1369, 434);
            this.stockPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stockPicture.Name = "stockPicture";
            this.stockPicture.Size = new System.Drawing.Size(93, 84);
            this.stockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stockPicture.TabIndex = 17;
            this.stockPicture.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Black;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(363, 611);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(400, 160);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Text = "System Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // settingsPicture
            // 
            this.settingsPicture.Image = ((System.Drawing.Image)(resources.GetObject("settingsPicture.Image")));
            this.settingsPicture.Location = new System.Drawing.Point(515, 635);
            this.settingsPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsPicture.Name = "settingsPicture";
            this.settingsPicture.Size = new System.Drawing.Size(93, 90);
            this.settingsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsPicture.TabIndex = 19;
            this.settingsPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(932, 429);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnProfile2
            // 
            this.btnProfile2.BackColor = System.Drawing.Color.Black;
            this.btnProfile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile2.ForeColor = System.Drawing.Color.White;
            this.btnProfile2.Location = new System.Drawing.Point(787, 400);
            this.btnProfile2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfile2.Name = "btnProfile2";
            this.btnProfile2.Size = new System.Drawing.Size(400, 160);
            this.btnProfile2.TabIndex = 20;
            this.btnProfile2.Text = "View Profile";
            this.btnProfile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfile2.UseVisualStyleBackColor = false;
            this.btnProfile2.Click += new System.EventHandler(this.btnProfile2_Click);
            // 
            // okPicture
            // 
            this.okPicture.Image = ((System.Drawing.Image)(resources.GetObject("okPicture.Image")));
            this.okPicture.Location = new System.Drawing.Point(514, 429);
            this.okPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okPicture.Name = "okPicture";
            this.okPicture.Size = new System.Drawing.Size(93, 90);
            this.okPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.okPicture.TabIndex = 23;
            this.okPicture.TabStop = false;
            this.okPicture.Click += new System.EventHandler(this.okPicture_Click);
            // 
            // approveReqBtn
            // 
            this.approveReqBtn.BackColor = System.Drawing.Color.Black;
            this.approveReqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveReqBtn.ForeColor = System.Drawing.Color.White;
            this.approveReqBtn.Location = new System.Drawing.Point(363, 400);
            this.approveReqBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.approveReqBtn.Name = "approveReqBtn";
            this.approveReqBtn.Size = new System.Drawing.Size(400, 160);
            this.approveReqBtn.TabIndex = 22;
            this.approveReqBtn.Text = "Approve / Deny Requests";
            this.approveReqBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.approveReqBtn.UseVisualStyleBackColor = false;
            this.approveReqBtn.Click += new System.EventHandler(this.approveReqBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
            this.logOutBtn.Location = new System.Drawing.Point(1621, 16);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(67, 64);
            this.logOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutBtn.TabIndex = 25;
            this.logOutBtn.TabStop = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.okPicture);
            this.Controls.Add(this.approveReqBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProfile2);
            this.Controls.Add(this.settingsPicture);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.stockPicture);
            this.Controls.Add(this.btnStockLevel);
            this.Controls.Add(this.welcomeTxt);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.productPic);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProducts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).EndInit();
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
        private System.Windows.Forms.Button btnSystemSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.PictureBox productPic;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox welcomeTxt;
        private System.Windows.Forms.Button btnStockLevel;
        private System.Windows.Forms.PictureBox stockPicture;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox settingsPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProfile2;
        private System.Windows.Forms.PictureBox okPicture;
        private System.Windows.Forms.Button approveReqBtn;
        private System.Windows.Forms.PictureBox logOutBtn;
        private CircularProgressBar.CircularProgressBar loadingCircle;
    }
}