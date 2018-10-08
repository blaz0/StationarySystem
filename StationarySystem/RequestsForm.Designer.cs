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
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.utsLogo = new System.Windows.Forms.PictureBox();
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.logOutBtn = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.RequestsLbl = new System.Windows.Forms.Label();
            this.requestDataGrid = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationeryrequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSet = new StationarySystem.sepdbDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stationeryrequestTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.stationeryrequestTableAdapter();
            this.sepdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.BackColor = System.Drawing.Color.Teal;
            this.clearSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.clearSearchBtn.ForeColor = System.Drawing.Color.White;
            this.clearSearchBtn.Location = new System.Drawing.Point(1295, 145);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(323, 42);
            this.clearSearchBtn.TabIndex = 30;
            this.clearSearchBtn.Text = "Clear Search";
            this.clearSearchBtn.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 654);
            this.panel1.TabIndex = 28;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(1295, 607);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(323, 42);
            this.cancelBtn.TabIndex = 27;
            this.cancelBtn.Text = "Cancel Request";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(1240, 148);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(37, 37);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 25;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
            this.logOutBtn.Location = new System.Drawing.Point(1621, 16);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(67, 64);
            this.logOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutBtn.TabIndex = 24;
            this.logOutBtn.TabStop = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.AllowDrop = true;
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchBox.ForeColor = System.Drawing.Color.Gray;
            this.SearchBox.HideSelection = false;
            this.SearchBox.Location = new System.Drawing.Point(433, 148);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(793, 36);
            this.SearchBox.TabIndex = 22;
            this.SearchBox.Text = "Search requests by product";
            // 
            // RequestsLbl
            // 
            this.RequestsLbl.AutoSize = true;
            this.RequestsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestsLbl.Location = new System.Drawing.Point(420, 45);
            this.RequestsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RequestsLbl.Name = "RequestsLbl";
            this.RequestsLbl.Size = new System.Drawing.Size(378, 69);
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
            this.requestDateDataGridViewTextBoxColumn,
            this.quantity,
            this.totalPrice,
            this.statusDataGridViewTextBoxColumn});
            this.requestDataGrid.DataSource = this.stationeryrequestBindingSource;
            this.requestDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.requestDataGrid.Location = new System.Drawing.Point(433, 216);
            this.requestDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.requestDataGrid.Name = "requestDataGrid";
            this.requestDataGrid.RowHeadersVisible = false;
            this.requestDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestDataGrid.Size = new System.Drawing.Size(1184, 376);
            this.requestDataGrid.TabIndex = 31;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "requestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "Request ID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "requestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "Request Date";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "totalPrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.totalPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.sepdbDataSet;
            this.productBindingSource.Filter = "";
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
            // stationeryrequestTableAdapter
            // 
            this.stationeryrequestTableAdapter.ClearBeforeFill = true;
            // 
            // sepdbDataSetBindingSource
            // 
            this.sepdbDataSetBindingSource.DataSource = this.sepdbDataSet;
            this.sepdbDataSetBindingSource.Position = 0;
            // 
            // editBtn
            // 
            this.editBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBtn.BackgroundImage")));
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editBtn.Location = new System.Drawing.Point(1233, 607);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(43, 42);
            this.editBtn.TabIndex = 32;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.requestDataGrid);
            this.Controls.Add(this.clearSearchBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.RequestsLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RequestsForm";
            this.Text = "RequestsForm";
            this.Load += new System.EventHandler(this.RequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearSearchBtn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private sepdbDataSet sepdbDataSet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox utsLogo;
        private System.Windows.Forms.Button btnSystemSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.PictureBox logOutBtn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Button editBtn;
        public sepdbDataSetTableAdapters.stationeryrequestTableAdapter stationeryrequestTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}