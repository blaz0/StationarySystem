namespace StationarySystem
{
    partial class ApproveRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveRequestForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogOutBtn = new System.Windows.Forms.PictureBox();
            this.ProductsLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadingCircle1 = new CircularProgressBar.CircularProgressBar();
            this.UtsLogo = new System.Windows.Forms.PictureBox();
            this.BtnRequests = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.ApproveBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RejectBtn = new System.Windows.Forms.Button();
            this.requestDataGrid = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationeryrequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSet = new StationarySystem.sepdbDataSet();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.productTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.productTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationeryrequestTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.stationeryrequestTableAdapter();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UtsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.Image")));
            this.LogOutBtn.Location = new System.Drawing.Point(2260, 38);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(100, 100);
            this.LogOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOutBtn.TabIndex = 32;
            this.LogOutBtn.TabStop = false;
            this.LogOutBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ProductsLbl
            // 
            this.ProductsLbl.AutoSize = true;
            this.ProductsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLbl.Location = new System.Drawing.Point(642, 69);
            this.ProductsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProductsLbl.Name = "ProductsLbl";
            this.ProductsLbl.Size = new System.Drawing.Size(1240, 108);
            this.ProductsLbl.TabIndex = 31;
            this.ProductsLbl.Text = "Approve Stationery Request";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LoadingCircle1);
            this.panel1.Controls.Add(this.UtsLogo);
            this.panel1.Controls.Add(this.BtnRequests);
            this.panel1.Controls.Add(this.BtnProducts);
            this.panel1.Controls.Add(this.BtnProfile);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1253);
            this.panel1.TabIndex = 34;
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
            this.LoadingCircle1.Location = new System.Drawing.Point(430, 408);
            this.LoadingCircle1.Margin = new System.Windows.Forms.Padding(2);
            this.LoadingCircle1.MarqueeAnimationSpeed = 2000;
            this.LoadingCircle1.Name = "LoadingCircle1";
            this.LoadingCircle1.OuterColor = System.Drawing.Color.Gray;
            this.LoadingCircle1.OuterMargin = -35;
            this.LoadingCircle1.OuterWidth = 26;
            this.LoadingCircle1.ProgressColor = System.Drawing.Color.Teal;
            this.LoadingCircle1.ProgressWidth = 20;
            this.LoadingCircle1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LoadingCircle1.Size = new System.Drawing.Size(40, 38);
            this.LoadingCircle1.StartAngle = 270;
            this.LoadingCircle1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingCircle1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoadingCircle1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.LoadingCircle1.SubscriptText = "";
            this.LoadingCircle1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoadingCircle1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.LoadingCircle1.SuperscriptText = "";
            this.LoadingCircle1.TabIndex = 33;
            this.LoadingCircle1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoadingCircle1.Value = 68;
            // 
            // UtsLogo
            // 
            this.UtsLogo.Image = ((System.Drawing.Image)(resources.GetObject("UtsLogo.Image")));
            this.UtsLogo.Location = new System.Drawing.Point(150, 158);
            this.UtsLogo.Margin = new System.Windows.Forms.Padding(6);
            this.UtsLogo.Name = "UtsLogo";
            this.UtsLogo.Size = new System.Drawing.Size(200, 288);
            this.UtsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UtsLogo.TabIndex = 4;
            this.UtsLogo.TabStop = false;
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
            this.BtnRequests.Click += new System.EventHandler(this.btnSystemSettings_Click);
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
            this.BtnProducts.Click += new System.EventHandler(this.btnNotifications_Click);
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
            // ApproveBtn
            // 
            this.ApproveBtn.BackColor = System.Drawing.Color.Teal;
            this.ApproveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApproveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ApproveBtn.ForeColor = System.Drawing.Color.White;
            this.ApproveBtn.Location = new System.Drawing.Point(2060, 1015);
            this.ApproveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(300, 65);
            this.ApproveBtn.TabIndex = 33;
            this.ApproveBtn.Text = "Approve";
            this.ApproveBtn.UseVisualStyleBackColor = false;
            this.ApproveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RejectBtn
            // 
            this.RejectBtn.BackColor = System.Drawing.Color.Teal;
            this.RejectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RejectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RejectBtn.ForeColor = System.Drawing.Color.White;
            this.RejectBtn.Location = new System.Drawing.Point(1754, 1015);
            this.RejectBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RejectBtn.Name = "RejectBtn";
            this.RejectBtn.Size = new System.Drawing.Size(300, 65);
            this.RejectBtn.TabIndex = 36;
            this.RejectBtn.Text = "Reject";
            this.RejectBtn.UseVisualStyleBackColor = false;
            this.RejectBtn.Click += new System.EventHandler(this.RejectBtn_Click);
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
            this.quantity,
            this.totalPrice1,
            this.requestDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.stock});
            this.requestDataGrid.DataSource = this.stationeryrequestBindingSource;
            this.requestDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.requestDataGrid.Location = new System.Drawing.Point(660, 213);
            this.requestDataGrid.Margin = new System.Windows.Forms.Padding(6);
            this.requestDataGrid.Name = "requestDataGrid";
            this.requestDataGrid.ReadOnly = true;
            this.requestDataGrid.RowHeadersVisible = false;
            this.requestDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestDataGrid.Size = new System.Drawing.Size(1700, 746);
            this.requestDataGrid.TabIndex = 37;
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
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Product Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
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
            dataGridViewCellStyle2.Format = "C2";
            this.totalPrice1.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalPrice1.HeaderText = "Total Price";
            this.totalPrice1.Name = "totalPrice1";
            this.totalPrice1.ReadOnly = true;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "requestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "Request Date";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // stationeryrequestBindingSource
            // 
            this.stationeryrequestBindingSource.DataMember = "stationeryrequest";
            this.stationeryrequestBindingSource.DataSource = this.sepdbDataSet;
            // 
            // sepdbDataSet
            // 
            this.sepdbDataSet.DataSetName = "sepdbDataSet";
            this.sepdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.sepdbDataSet;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.sepdbDataSet;
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
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.sepdbDataSet;
            this.productBindingSource.Filter = "";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = this.sepdbDataSet;
            this.usersBindingSource.Position = 0;
            // 
            // stationeryrequestTableAdapter
            // 
            this.stationeryrequestTableAdapter.ClearBeforeFill = true;
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
            this.BackBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ApproveRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2564, 1253);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.requestDataGrid);
            this.Controls.Add(this.RejectBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ProductsLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ApproveBtn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ApproveRequestForm";
            this.Text = "ApproveRequestForm";
            this.Load += new System.EventHandler(this.ApproveRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogOutBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UtsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource1;
        private sepdbDataSet sepdbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private sepdbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private sepdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sepdbDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.PictureBox LogOutBtn;
        private System.Windows.Forms.Label ProductsLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox UtsLogo;
        private System.Windows.Forms.Button BtnRequests;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button ApproveBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button RejectBtn;
        private System.Windows.Forms.DataGridView requestDataGrid;
        private System.Windows.Forms.BindingSource stationeryrequestBindingSource;
        private sepdbDataSetTableAdapters.stationeryrequestTableAdapter stationeryrequestTableAdapter;
        private CircularProgressBar.CircularProgressBar LoadingCircle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Button BackBtn;
    }
}