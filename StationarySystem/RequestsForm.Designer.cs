namespace StationarySystem
{
    partial class RequestsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestsForm));
            this.ClearSearchBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.utsLogo = new System.Windows.Forms.PictureBox();
            this.BtnSystemSettings = new System.Windows.Forms.Button();
            this.BtnNotifications = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.PictureBox();
            this.LogOutBtn = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.RequestsLbl = new System.Windows.Forms.Label();
            this.requestDataGrid = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationeryrequestBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSet1 = new StationarySystem.sepdbDataSet();
            this.sepdbDataSet = new StationarySystem.sepdbDataSet();
            this.productTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.productTableAdapter();
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.stationeryrequestTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.stationeryrequestTableAdapter();
            this.EditBtn = new System.Windows.Forms.Button();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.stationeryrequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationeryrequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CancelLbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearSearchBtn
            // 
            this.ClearSearchBtn.BackColor = System.Drawing.Color.Teal;
            this.ClearSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ClearSearchBtn.ForeColor = System.Drawing.Color.White;
            this.ClearSearchBtn.Location = new System.Drawing.Point(1942, 227);
            this.ClearSearchBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClearSearchBtn.Name = "ClearSearchBtn";
            this.ClearSearchBtn.Size = new System.Drawing.Size(422, 65);
            this.ClearSearchBtn.TabIndex = 30;
            this.ClearSearchBtn.Text = "Clear Search";
            this.ClearSearchBtn.UseVisualStyleBackColor = false;
            this.ClearSearchBtn.Click += new System.EventHandler(this.ClearSearchBtn_Click);
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
            // BtnSystemSettings
            // 
            this.BtnSystemSettings.BackColor = System.Drawing.Color.Teal;
            this.BtnSystemSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSystemSettings.FlatAppearance.BorderSize = 0;
            this.BtnSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSystemSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSystemSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSystemSettings.Location = new System.Drawing.Point(0, 812);
            this.BtnSystemSettings.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSystemSettings.Name = "BtnSystemSettings";
            this.BtnSystemSettings.Size = new System.Drawing.Size(500, 77);
            this.BtnSystemSettings.TabIndex = 3;
            this.BtnSystemSettings.Text = "My Requests";
            this.BtnSystemSettings.UseVisualStyleBackColor = false;
            this.BtnSystemSettings.Click += new System.EventHandler(this.BtnSystemSettings_Click);
            // 
            // BtnNotifications
            // 
            this.BtnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNotifications.FlatAppearance.BorderSize = 0;
            this.BtnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotifications.ForeColor = System.Drawing.Color.White;
            this.BtnNotifications.Location = new System.Drawing.Point(0, 725);
            this.BtnNotifications.Margin = new System.Windows.Forms.Padding(6);
            this.BtnNotifications.Name = "BtnNotifications";
            this.BtnNotifications.Size = new System.Drawing.Size(500, 77);
            this.BtnNotifications.TabIndex = 2;
            this.BtnNotifications.Text = "Products";
            this.BtnNotifications.UseVisualStyleBackColor = true;
            this.BtnNotifications.Click += new System.EventHandler(this.BtnNotifications_Click);
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
            this.BtnHome.BackColor = System.Drawing.Color.Black;
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
            this.panel1.Controls.Add(this.utsLogo);
            this.panel1.Controls.Add(this.BtnSystemSettings);
            this.panel1.Controls.Add(this.BtnNotifications);
            this.panel1.Controls.Add(this.BtnProfile);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1399);
            this.panel1.TabIndex = 28;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Teal;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(1944, 1031);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(422, 65);
            this.CancelBtn.TabIndex = 27;
            this.CancelBtn.Text = "Cancel Request";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(1860, 231);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(54, 58);
            this.SearchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchBtn.TabIndex = 25;
            this.SearchBtn.TabStop = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.Image")));
            this.LogOutBtn.Location = new System.Drawing.Point(2260, 38);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(100, 100);
            this.LogOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOutBtn.TabIndex = 24;
            this.LogOutBtn.TabStop = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.AllowDrop = true;
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchBox.ForeColor = System.Drawing.Color.Gray;
            this.SearchBox.HideSelection = false;
            this.SearchBox.Location = new System.Drawing.Point(650, 231);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(1188, 53);
            this.SearchBox.TabIndex = 22;
            this.SearchBox.Text = "Search requests by product";
            // 
            // RequestsLbl
            // 
            this.RequestsLbl.AutoSize = true;
            this.RequestsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestsLbl.Location = new System.Drawing.Point(630, 69);
            this.RequestsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RequestsLbl.Name = "RequestsLbl";
            this.RequestsLbl.Size = new System.Drawing.Size(603, 108);
            this.RequestsLbl.TabIndex = 21;
            this.RequestsLbl.Text = "My Requests";
            // 
            // requestDataGrid
            // 
            this.requestDataGrid.AllowUserToAddRows = false;
            this.requestDataGrid.AllowUserToDeleteRows = false;
            this.requestDataGrid.AllowUserToResizeColumns = false;
            this.requestDataGrid.AllowUserToResizeRows = false;
            this.requestDataGrid.AutoGenerateColumns = false;
            this.requestDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.requestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.name,
            this.requestDateDataGridViewTextBoxColumn,
            this.quantity,
            this.totalPrice1,
            this.statusDataGridViewTextBoxColumn,
            this.price});
            this.requestDataGrid.DataSource = this.stationeryrequestBindingSource2;
            this.requestDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.requestDataGrid.Location = new System.Drawing.Point(650, 338);
            this.requestDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.requestDataGrid.Name = "requestDataGrid";
            this.requestDataGrid.ReadOnly = true;
            this.requestDataGrid.RowHeadersVisible = false;
            this.requestDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestDataGrid.Size = new System.Drawing.Size(1712, 663);
            this.requestDataGrid.TabIndex = 31;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "requestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "Request ID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Product Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "requestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "Request Date";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // totalPrice1
            // 
            this.totalPrice1.DataPropertyName = "totalPrice1";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.totalPrice1.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalPrice1.HeaderText = "Total Price";
            this.totalPrice1.Name = "totalPrice1";
            this.totalPrice1.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Product Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Visible = false;
            // 
            // stationeryrequestBindingSource2
            // 
            this.stationeryrequestBindingSource2.DataMember = "stationeryrequest";
            this.stationeryrequestBindingSource2.DataSource = this.sepdbDataSet1;
            // 
            // sepdbDataSet1
            // 
            this.sepdbDataSet1.DataSetName = "sepdbDataSet";
            this.sepdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepdbDataSet
            // 
            this.sepdbDataSet.DataSetName = "sepdbDataSet";
            this.sepdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // stationeryrequestTableAdapter
            // 
            this.stationeryrequestTableAdapter.ClearBeforeFill = true;
            // 
            // EditBtn
            // 
            this.EditBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Location = new System.Drawing.Point(1852, 1031);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(64, 65);
            this.EditBtn.TabIndex = 32;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.QuantityLbl.Location = new System.Drawing.Point(644, 1031);
            this.QuantityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(376, 46);
            this.QuantityLbl.TabIndex = 34;
            this.QuantityLbl.Text = "Enter New Quantity:";
            // 
            // Qty
            // 
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Qty.Location = new System.Drawing.Point(1026, 1031);
            this.Qty.Margin = new System.Windows.Forms.Padding(4);
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
            this.Qty.Size = new System.Drawing.Size(94, 44);
            this.Qty.TabIndex = 35;
            this.Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Teal;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(652, 1090);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(294, 65);
            this.SaveBtn.TabIndex = 36;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // stationeryrequestBindingSource
            // 
            this.stationeryrequestBindingSource.DataMember = "stationeryrequest";
            this.stationeryrequestBindingSource.DataSource = this.sepdbDataSet;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.sepdbDataSet;
            this.productBindingSource.Filter = "";
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
            // sepdbDataSetBindingSource
            // 
            this.sepdbDataSetBindingSource.DataSource = this.sepdbDataSet;
            this.sepdbDataSetBindingSource.Position = 0;
            // 
            // stationeryrequestBindingSource1
            // 
            this.stationeryrequestBindingSource1.DataMember = "stationeryrequest";
            this.stationeryrequestBindingSource1.DataSource = this.sepdbDataSet;
            // 
            // CancelLbl
            // 
            this.CancelLbl.AutoSize = true;
            this.CancelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CancelLbl.Location = new System.Drawing.Point(976, 1102);
            this.CancelLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CancelLbl.Name = "CancelLbl";
            this.CancelLbl.Size = new System.Drawing.Size(145, 46);
            this.CancelLbl.TabIndex = 38;
            this.CancelLbl.Text = "Cancel";
            this.CancelLbl.Click += new System.EventHandler(this.CancelLbl_Click);
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
            this.BackBtn.TabIndex = 40;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2564, 1399);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CancelLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.requestDataGrid);
            this.Controls.Add(this.ClearSearchBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.RequestsLbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RequestsForm";
            this.Text = "RequestsForm";
            this.Load += new System.EventHandler(this.RequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearSearchBtn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private sepdbDataSet sepdbDataSet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox utsLogo;
        private System.Windows.Forms.Button BtnSystemSettings;
        private System.Windows.Forms.Button BtnNotifications;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.PictureBox SearchBtn;
        private System.Windows.Forms.PictureBox LogOutBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label RequestsLbl;
        private sepdbDataSetTableAdapters.productTableAdapter productTableAdapter;
        private sepdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sepdbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.DataGridView requestDataGrid;
        private System.Windows.Forms.BindingSource stationeryrequestBindingSource;
        private System.Windows.Forms.BindingSource sepdbDataSetBindingSource;
        private System.Windows.Forms.Button EditBtn;
        public sepdbDataSetTableAdapters.stationeryrequestTableAdapter stationeryrequestTableAdapter;
        private System.Windows.Forms.BindingSource stationeryrequestBindingSource1;
        private sepdbDataSet sepdbDataSet1;
        private System.Windows.Forms.BindingSource stationeryrequestBindingSource2;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.NumericUpDown Qty;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label CancelLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button BackBtn;
    }
}