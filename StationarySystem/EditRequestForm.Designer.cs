﻿namespace StationarySystem
{
    partial class EditRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRequestForm));
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sepdbDataSet = new StationarySystem.sepdbDataSet();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new StationarySystem.sepdbDataSetTableAdapters.TableAdapterManager();
            this.productTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.productTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.totalPriceTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductsLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.productNameTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.utsLogo = new System.Windows.Forms.PictureBox();
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupOrder = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            this.groupOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.tableAdapterManager.requestedstationeryTableAdapter = null;
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
            // descriptionTxt
            // 
            this.descriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTxt.Location = new System.Drawing.Point(50, 116);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(210, 13);
            this.descriptionTxt.TabIndex = 9;
            this.descriptionTxt.Text = "product description";
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.BackColor = System.Drawing.SystemColors.Window;
            this.totalPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.totalPriceTxt.ForeColor = System.Drawing.Color.Black;
            this.totalPriceTxt.Location = new System.Drawing.Point(748, 216);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.ReadOnly = true;
            this.totalPriceTxt.Size = new System.Drawing.Size(100, 37);
            this.totalPriceTxt.TabIndex = 7;
            this.totalPriceTxt.Text = "$0.00";
            // 
            // priceTxt
            // 
            this.priceTxt.BackColor = System.Drawing.SystemColors.Window;
            this.priceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.priceTxt.ForeColor = System.Drawing.Color.Black;
            this.priceTxt.Location = new System.Drawing.Point(742, 71);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(110, 22);
            this.priceTxt.TabIndex = 6;
            this.priceTxt.Text = "priceperitem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1307, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // ProductsLbl
            // 
            this.ProductsLbl.AutoSize = true;
            this.ProductsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLbl.Location = new System.Drawing.Point(321, 37);
            this.ProductsLbl.Name = "ProductsLbl";
            this.ProductsLbl.Size = new System.Drawing.Size(528, 55);
            this.ProductsLbl.TabIndex = 31;
            this.ProductsLbl.Text = "Edit Stationery Request";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(572, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(607, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price per item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qty:";
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(379, 70);
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
            this.qty.Size = new System.Drawing.Size(63, 26);
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
            this.productNameTxt.Location = new System.Drawing.Point(45, 71);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(148, 25);
            this.productNameTxt.TabIndex = 0;
            this.productNameTxt.Text = "Product Name";
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 741);
            this.panel1.TabIndex = 34;
            // 
            // utsLogo
            // 
            this.utsLogo.Image = ((System.Drawing.Image)(resources.GetObject("utsLogo.Image")));
            this.utsLogo.Location = new System.Drawing.Point(75, 82);
            this.utsLogo.Name = "utsLogo";
            this.utsLogo.Size = new System.Drawing.Size(100, 150);
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
            this.btnSystemSettings.Location = new System.Drawing.Point(0, 423);
            this.btnSystemSettings.Name = "btnSystemSettings";
            this.btnSystemSettings.Size = new System.Drawing.Size(250, 40);
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
            this.btnNotifications.Location = new System.Drawing.Point(0, 377);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(250, 40);
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
            this.btnProfile.Location = new System.Drawing.Point(0, 331);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(250, 40);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Teal;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 285);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(250, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Teal;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(1064, 446);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(150, 34);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
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
            this.groupOrder.Location = new System.Drawing.Point(331, 146);
            this.groupOrder.Name = "groupOrder";
            this.groupOrder.Size = new System.Drawing.Size(883, 295);
            this.groupOrder.TabIndex = 35;
            this.groupOrder.TabStop = false;
            this.groupOrder.Text = "Your Order";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cancelLbl
            // 
            this.cancelLbl.AutoSize = true;
            this.cancelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelLbl.Location = new System.Drawing.Point(963, 451);
            this.cancelLbl.Name = "cancelLbl";
            this.cancelLbl.Size = new System.Drawing.Size(79, 25);
            this.cancelLbl.TabIndex = 38;
            this.cancelLbl.Text = "Cancel";
            // 
            // EditRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.cancelLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductsLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupOrder);
            this.Name = "EditRequestForm";
            this.Text = "EditRequestForm";
            this.Load += new System.EventHandler(this.EditRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            this.groupOrder.ResumeLayout(false);
            this.groupOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox totalPriceTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProductsLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.Label productNameTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox utsLogo;
        private System.Windows.Forms.Button btnSystemSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupOrder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label cancelLbl;
    }
}