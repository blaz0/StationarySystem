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
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductsLbl = new System.Windows.Forms.Label();
            this.groupOrder = new System.Windows.Forms.GroupBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.totalPriceTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.productNameTxt = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSet = new StationarySystem.sepdbDataSet();
            this.submitBtn = new System.Windows.Forms.Button();
            this.productTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loadingCircle = new CircularProgressBar.CircularProgressBar();
            this.loadingCircle1 = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
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
            this.utsLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.utsLogo.Name = "utsLogo";
            this.utsLogo.Size = new System.Drawing.Size(200, 288);
            this.utsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.utsLogo.TabIndex = 4;
            this.utsLogo.TabStop = false;
            // 
            // btnSystemSettings
            // 
            this.btnSystemSettings.FlatAppearance.BorderSize = 0;
            this.btnSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemSettings.ForeColor = System.Drawing.Color.White;
            this.btnSystemSettings.Location = new System.Drawing.Point(0, 813);
            this.btnSystemSettings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSystemSettings.Name = "btnSystemSettings";
            this.btnSystemSettings.Size = new System.Drawing.Size(500, 77);
            this.btnSystemSettings.TabIndex = 3;
            this.btnSystemSettings.Text = "System Settings";
            this.btnSystemSettings.UseVisualStyleBackColor = true;
            // 
            // btnNotifications
            // 
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Location = new System.Drawing.Point(0, 725);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(500, 77);
            this.btnNotifications.TabIndex = 2;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 637);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(500, 77);
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
            this.btnHome.Location = new System.Drawing.Point(0, 548);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(500, 77);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.loadingCircle1);
            this.panel1.Controls.Add(this.utsLogo);
            this.panel1.Controls.Add(this.btnSystemSettings);
            this.panel1.Controls.Add(this.btnNotifications);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1399);
            this.panel1.TabIndex = 28;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Teal;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(1942, 856);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(474, 65);
            this.refreshBtn.TabIndex = 27;
            this.refreshBtn.Text = "Refresh Total Price";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2602, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.groupOrder.Controls.Add(this.descriptionTxt);
            this.groupOrder.Controls.Add(this.totalPriceTxt);
            this.groupOrder.Controls.Add(this.priceTxt);
            this.groupOrder.Controls.Add(this.label4);
            this.groupOrder.Controls.Add(this.label3);
            this.groupOrder.Controls.Add(this.label2);
            this.groupOrder.Controls.Add(this.qty);
            this.groupOrder.Controls.Add(this.productNameTxt);
            this.groupOrder.Location = new System.Drawing.Point(650, 281);
            this.groupOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupOrder.Name = "groupOrder";
            this.groupOrder.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupOrder.Size = new System.Drawing.Size(1766, 567);
            this.groupOrder.TabIndex = 29;
            this.groupOrder.TabStop = false;
            this.groupOrder.Text = "Your Order";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTxt.Location = new System.Drawing.Point(100, 223);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(420, 24);
            this.descriptionTxt.TabIndex = 9;
            this.descriptionTxt.Text = "product description";
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.BackColor = System.Drawing.SystemColors.Window;
            this.totalPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.totalPriceTxt.ForeColor = System.Drawing.Color.Black;
            this.totalPriceTxt.Location = new System.Drawing.Point(1496, 415);
            this.totalPriceTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.ReadOnly = true;
            this.totalPriceTxt.Size = new System.Drawing.Size(200, 73);
            this.totalPriceTxt.TabIndex = 7;
            this.totalPriceTxt.Text = "$0.00";
            // 
            // priceTxt
            // 
            this.priceTxt.BackColor = System.Drawing.SystemColors.Window;
            this.priceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.priceTxt.ForeColor = System.Drawing.Color.Black;
            this.priceTxt.Location = new System.Drawing.Point(1484, 137);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(220, 43);
            this.priceTxt.TabIndex = 6;
            this.priceTxt.Text = "priceperitem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(1144, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 73);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(1214, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price per item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qty:";
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(758, 135);
            this.qty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.qty.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(126, 44);
            this.qty.TabIndex = 2;
            this.qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productNameTxt
            // 
            this.productNameTxt.AutoSize = true;
            this.productNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "name", true));
            this.productNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTxt.Location = new System.Drawing.Point(90, 137);
            this.productNameTxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(286, 48);
            this.productNameTxt.TabIndex = 0;
            this.productNameTxt.Text = "Product Name";
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
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Teal;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(1942, 954);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(474, 65);
            this.submitBtn.TabIndex = 30;
            this.submitBtn.Text = "Submit Product Request";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
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
            this.loadingCircle.Location = new System.Drawing.Point(2439, 956);
            this.loadingCircle.MarqueeAnimationSpeed = 2000;
            this.loadingCircle.Name = "loadingCircle";
            this.loadingCircle.OuterColor = System.Drawing.Color.Gray;
            this.loadingCircle.OuterMargin = -35;
            this.loadingCircle.OuterWidth = 26;
            this.loadingCircle.ProgressColor = System.Drawing.Color.Teal;
            this.loadingCircle.ProgressWidth = 20;
            this.loadingCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadingCircle.Size = new System.Drawing.Size(59, 59);
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
            // 
            // loadingCircle1
            // 
            this.loadingCircle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingCircle1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.loadingCircle1.AnimationSpeed = 500;
            this.loadingCircle1.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.loadingCircle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadingCircle1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadingCircle1.InnerMargin = 2;
            this.loadingCircle1.InnerWidth = -1;
            this.loadingCircle1.Location = new System.Drawing.Point(414, 387);
            this.loadingCircle1.MarqueeAnimationSpeed = 2000;
            this.loadingCircle1.Name = "loadingCircle1";
            this.loadingCircle1.OuterColor = System.Drawing.Color.Gray;
            this.loadingCircle1.OuterMargin = -35;
            this.loadingCircle1.OuterWidth = 26;
            this.loadingCircle1.ProgressColor = System.Drawing.Color.Teal;
            this.loadingCircle1.ProgressWidth = 20;
            this.loadingCircle1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.loadingCircle1.Size = new System.Drawing.Size(59, 59);
            this.loadingCircle1.StartAngle = 270;
            this.loadingCircle1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingCircle1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingCircle1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.loadingCircle1.SubscriptText = "";
            this.loadingCircle1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.loadingCircle1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.loadingCircle1.SuperscriptText = "";
            this.loadingCircle1.TabIndex = 32;
            this.loadingCircle1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // CreateStationeryRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2564, 1399);
            this.Controls.Add(this.loadingCircle);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.groupOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductsLbl);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateStationeryRequestForm";
            this.Text = "CreateStationeryRequest";
            this.Load += new System.EventHandler(this.CreateStationeryRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupOrder.ResumeLayout(false);
            this.groupOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
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
        private System.Windows.Forms.Button btnSystemSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProductsLbl;
        private sepdbDataSetTableAdapters.productTableAdapter productTableAdapter;
        private sepdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sepdbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.GroupBox groupOrder;
        private System.Windows.Forms.TextBox totalPriceTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.Label productNameTxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox descriptionTxt;
        private CircularProgressBar.CircularProgressBar loadingCircle;
        private CircularProgressBar.CircularProgressBar loadingCircle1;
    }
}