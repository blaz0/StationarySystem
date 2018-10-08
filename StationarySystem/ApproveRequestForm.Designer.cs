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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSet = new StationarySystem.sepdbDataSet();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.productTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.productTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductsLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.utsLogo = new System.Windows.Forms.PictureBox();
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.approveBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rejectBtn = new System.Windows.Forms.Button();
            this.requestDataGrid = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationeryrequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationeryrequestTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.stationeryrequestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.sepdbDataSet;
            // 
            // sepdbDataSet
            // 
            this.sepdbDataSet.DataSetName = "sepdbDataSet";
            this.sepdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1743, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // ProductsLbl
            // 
            this.ProductsLbl.AutoSize = true;
            this.ProductsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLbl.Location = new System.Drawing.Point(428, 45);
            this.ProductsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductsLbl.Name = "ProductsLbl";
            this.ProductsLbl.Size = new System.Drawing.Size(776, 69);
            this.ProductsLbl.TabIndex = 31;
            this.ProductsLbl.Text = "Approve Stationery Request";
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
            this.panel1.Size = new System.Drawing.Size(333, 675);
            this.panel1.TabIndex = 34;
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
            // approveBtn
            // 
            this.approveBtn.BackColor = System.Drawing.Color.Teal;
            this.approveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.approveBtn.ForeColor = System.Drawing.Color.White;
            this.approveBtn.Location = new System.Drawing.Point(1424, 649);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(200, 42);
            this.approveBtn.TabIndex = 33;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = false;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rejectBtn
            // 
            this.rejectBtn.BackColor = System.Drawing.Color.Teal;
            this.rejectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rejectBtn.ForeColor = System.Drawing.Color.White;
            this.rejectBtn.Location = new System.Drawing.Point(1219, 649);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(200, 42);
            this.rejectBtn.TabIndex = 36;
            this.rejectBtn.Text = "Reject";
            this.rejectBtn.UseVisualStyleBackColor = false;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
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
            this.quantity,
            this.totalPrice,
            this.requestDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.requestDataGrid.DataSource = this.stationeryrequestBindingSource;
            this.requestDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.requestDataGrid.Location = new System.Drawing.Point(440, 137);
            this.requestDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.requestDataGrid.Name = "requestDataGrid";
            this.requestDataGrid.ReadOnly = true;
            this.requestDataGrid.RowHeadersVisible = false;
            this.requestDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestDataGrid.Size = new System.Drawing.Size(1184, 478);
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
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "totalPrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.totalPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
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
            // stationeryrequestBindingSource
            // 
            this.stationeryrequestBindingSource.DataMember = "stationeryrequest";
            this.stationeryrequestBindingSource.DataSource = this.sepdbDataSet;
            // 
            // stationeryrequestTableAdapter
            // 
            this.stationeryrequestTableAdapter.ClearBeforeFill = true;
            // 
            // ApproveRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.requestDataGrid);
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductsLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.approveBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ApproveRequestForm";
            this.Text = "ApproveRequestForm";
            this.Load += new System.EventHandler(this.ApproveRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryrequestBindingSource)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProductsLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox utsLogo;
        private System.Windows.Forms.Button btnSystemSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button rejectBtn;
        private System.Windows.Forms.DataGridView requestDataGrid;
        private System.Windows.Forms.BindingSource stationeryrequestBindingSource;
        private sepdbDataSetTableAdapters.stationeryrequestTableAdapter stationeryrequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}