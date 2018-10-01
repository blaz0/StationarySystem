namespace StationarySystem
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductsLbl = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSet = new StationarySystem.sepdbDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.utsLogo = new System.Windows.Forms.PictureBox();
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.detailsDataGrid = new System.Windows.Forms.DataGridView();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.createRequestBtn = new System.Windows.Forms.Button();
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.productTableAdapter();
            this.productDetailTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.productDetailTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsLbl
            // 
            this.ProductsLbl.AutoSize = true;
            this.ProductsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLbl.Location = new System.Drawing.Point(618, 71);
            this.ProductsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProductsLbl.Name = "ProductsLbl";
            this.ProductsLbl.Size = new System.Drawing.Size(423, 108);
            this.ProductsLbl.TabIndex = 10;
            this.ProductsLbl.Text = "Products";
            // 
            // SearchBox
            // 
            this.SearchBox.AllowDrop = true;
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchBox.ForeColor = System.Drawing.Color.Gray;
            this.SearchBox.HideSelection = false;
            this.SearchBox.Location = new System.Drawing.Point(638, 231);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(1188, 53);
            this.SearchBox.TabIndex = 11;
            this.SearchBox.Text = "Search for products";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2420, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(1847, 231);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(60, 60);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 14;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowDrop = true;
            this.productDataGrid.AllowUserToAddRows = false;
            this.productDataGrid.AllowUserToDeleteRows = false;
            this.productDataGrid.AllowUserToResizeRows = false;
            this.productDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDataGrid.AutoGenerateColumns = false;
            this.productDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.productDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productDataGrid.CausesValidation = false;
            this.productDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.stockLevel,
            this.priceDataGridViewTextBoxColumn});
            this.productDataGrid.DataSource = this.productBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.productDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productDataGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.productDataGrid.Location = new System.Drawing.Point(638, 313);
            this.productDataGrid.Margin = new System.Windows.Forms.Padding(6);
            this.productDataGrid.MultiSelect = false;
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.ReadOnly = true;
            this.productDataGrid.RowHeadersVisible = false;
            this.productDataGrid.RowHeadersWidth = 10;
            this.productDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productDataGrid.RowTemplate.Height = 33;
            this.productDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGrid.Size = new System.Drawing.Size(1776, 401);
            this.productDataGrid.TabIndex = 15;
            this.productDataGrid.TabStop = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name of Product";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockLevel
            // 
            this.stockLevel.DataPropertyName = "stockLevel";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.stockLevel.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockLevel.HeaderText = "Number of Stock";
            this.stockLevel.Name = "stockLevel";
            this.stockLevel.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.utsLogo);
            this.panel1.Controls.Add(this.btnSystemSettings);
            this.panel1.Controls.Add(this.btnNotifications);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1399);
            this.panel1.TabIndex = 18;
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
            // btnSystemSettings
            // 
            this.btnSystemSettings.FlatAppearance.BorderSize = 0;
            this.btnSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemSettings.ForeColor = System.Drawing.Color.White;
            this.btnSystemSettings.Location = new System.Drawing.Point(0, 813);
            this.btnSystemSettings.Margin = new System.Windows.Forms.Padding(6);
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
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(6);
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
            this.btnProfile.Margin = new System.Windows.Forms.Padding(6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(500, 77);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Teal;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 548);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(500, 77);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // detailsDataGrid
            // 
            this.detailsDataGrid.AllowDrop = true;
            this.detailsDataGrid.AllowUserToAddRows = false;
            this.detailsDataGrid.AllowUserToDeleteRows = false;
            this.detailsDataGrid.AutoGenerateColumns = false;
            this.detailsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.detailsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailsDataGrid.CausesValidation = false;
            this.detailsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.detailsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.detailsDataGrid.DataSource = this.detailsBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailsDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.detailsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.detailsDataGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.detailsDataGrid.Location = new System.Drawing.Point(638, 855);
            this.detailsDataGrid.Margin = new System.Windows.Forms.Padding(6);
            this.detailsDataGrid.MultiSelect = false;
            this.detailsDataGrid.Name = "detailsDataGrid";
            this.detailsDataGrid.ReadOnly = true;
            this.detailsDataGrid.RowHeadersVisible = false;
            this.detailsDataGrid.RowHeadersWidth = 10;
            this.detailsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.detailsDataGrid.RowTemplate.Height = 33;
            this.detailsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsDataGrid.Size = new System.Drawing.Size(1776, 205);
            this.detailsDataGrid.TabIndex = 19;
            this.detailsDataGrid.TabStop = false;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "product_details_relation";
            this.detailsBindingSource.DataSource = this.productBindingSource;
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSearchBtn.BackColor = System.Drawing.Color.Teal;
            this.clearSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.clearSearchBtn.ForeColor = System.Drawing.Color.White;
            this.clearSearchBtn.Location = new System.Drawing.Point(1930, 226);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(484, 66);
            this.clearSearchBtn.TabIndex = 20;
            this.clearSearchBtn.Text = "Clear Search";
            this.clearSearchBtn.UseVisualStyleBackColor = false;
            this.clearSearchBtn.Click += new System.EventHandler(this.clearSearchBtn_Click);
            // 
            // createRequestBtn
            // 
            this.createRequestBtn.BackColor = System.Drawing.Color.Teal;
            this.createRequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createRequestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.createRequestBtn.ForeColor = System.Drawing.Color.White;
            this.createRequestBtn.Location = new System.Drawing.Point(638, 751);
            this.createRequestBtn.Name = "createRequestBtn";
            this.createRequestBtn.Size = new System.Drawing.Size(530, 66);
            this.createRequestBtn.TabIndex = 21;
            this.createRequestBtn.Text = "Create Stationery Request";
            this.createRequestBtn.UseVisualStyleBackColor = false;
            this.createRequestBtn.Click += new System.EventHandler(this.createRequestBtn_Click_1);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = this.sepdbDataSet;
            this.usersBindingSource.Position = 0;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.sepdbDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.productDetailTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.sepdbDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productDetailTableAdapter
            // 
            this.productDetailTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Product Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stockLevel";
            this.dataGridViewTextBoxColumn1.HeaderText = "Number of Stock";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2564, 1399);
            this.Controls.Add(this.createRequestBtn);
            this.Controls.Add(this.clearSearchBtn);
            this.Controls.Add(this.detailsDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ProductsLbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sepdbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private sepdbDataSet sepdbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private sepdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.Label ProductsLbl;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.BindingSource productBindingSource;
        private sepdbDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox utsLogo;
        private System.Windows.Forms.Button btnSystemSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView detailsDataGrid;
        private System.Windows.Forms.Button clearSearchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLevelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button createRequestBtn;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private sepdbDataSetTableAdapters.productDetailTableAdapter productDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
    }
}