using System;
using System.Windows;
using System.Windows.Forms;

namespace StationarySystem
{
    partial class ProfileFormX
    {
        //public int userIDparam = 0;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileFormX));
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.TxtNickname = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sepdb_SQL = new StationarySystem.sepdbDataSet();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.LblCC = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblFullName = new System.Windows.Forms.Label();
            this.TxtPhoneNo = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtCC = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtFName = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new StationarySystem.sepdbDataSetTableAdapters.usersTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.utsLogo = new System.Windows.Forms.PictureBox();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdb_SQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.Location = new System.Drawing.Point(1360, 133);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(6);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(420, 419);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 5;
            this.ProfilePicture.TabStop = false;
            // 
            // TxtNickname
            // 
            this.TxtNickname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNickname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNickname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "nickname", true));
            this.TxtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtNickname.Location = new System.Drawing.Point(272, 9);
            this.TxtNickname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNickname.Name = "TxtNickname";
            this.TxtNickname.ReadOnly = true;
            this.TxtNickname.Size = new System.Drawing.Size(406, 37);
            this.TxtNickname.TabIndex = 8;
            this.TxtNickname.Text = "insert nickname here";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.sepdb_SQL;
            // 
            // sepdb_SQL
            // 
            this.sepdb_SQL.DataSetName = "sepdb_SQL";
            this.sepdb_SQL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.sepdb_SQL;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource2, "emailAddress", true));
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtEmail.Location = new System.Drawing.Point(272, 65);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(606, 37);
            this.TxtEmail.TabIndex = 8;
            this.TxtEmail.Text = "insert email here";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(68, 234);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(196, 37);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Cost Centre:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCC
            // 
            this.LblCC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCC.AutoSize = true;
            this.LblCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCC.Location = new System.Drawing.Point(83, 177);
            this.LblCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCC.Name = "LblCC";
            this.LblCC.Size = new System.Drawing.Size(181, 37);
            this.LblCC.TabIndex = 7;
            this.LblCC.Text = "ID Number:";
            this.LblCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblID
            // 
            this.LblID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(22, 121);
            this.LblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(242, 37);
            this.LblID.TabIndex = 5;
            this.LblID.Text = "Phone Number:";
            this.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(158, 65);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(106, 37);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email:";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblFullName
            // 
            this.LblFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblFullName.AutoSize = true;
            this.LblFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblFullName.Location = new System.Drawing.Point(95, 9);
            this.LblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(169, 37);
            this.LblFullName.TabIndex = 0;
            this.LblFullName.Text = "Nickname:";
            this.LblFullName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtPhoneNo
            // 
            this.TxtPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPhoneNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPhoneNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource2, "phoneNumber", true));
            this.TxtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtPhoneNo.Location = new System.Drawing.Point(272, 121);
            this.TxtPhoneNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPhoneNo.MaxLength = 10;
            this.TxtPhoneNo.Name = "TxtPhoneNo";
            this.TxtPhoneNo.ReadOnly = true;
            this.TxtPhoneNo.Size = new System.Drawing.Size(342, 37);
            this.TxtPhoneNo.TabIndex = 8;
            this.TxtPhoneNo.Text = "insert phone no. here";
            this.TxtPhoneNo.TextChanged += new System.EventHandler(this.TxtPhoneNo_TextChanged);
            // 
            // TxtID
            // 
            this.TxtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource2, "userId", true));
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtID.Location = new System.Drawing.Point(272, 177);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(304, 37);
            this.TxtID.TabIndex = 8;
            this.TxtID.Text = "insert ID no. here";
            // 
            // TxtCC
            // 
            this.TxtCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource2, "costCentre", true));
            this.TxtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtCC.Location = new System.Drawing.Point(272, 234);
            this.TxtCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.ReadOnly = true;
            this.TxtCC.Size = new System.Drawing.Size(406, 37);
            this.TxtCC.TabIndex = 8;
            this.TxtCC.Text = "insert cost centre here";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.11236F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.88764F));
            this.tableLayoutPanel1.Controls.Add(this.TxtCC, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtPhoneNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtEmail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtNickname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblCC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblFullName, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1306, 633);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 281);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtFName
            // 
            this.TxtFName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtFName.Location = new System.Drawing.Point(1250, 548);
            this.TxtFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFName.Name = "TxtFName";
            this.TxtFName.ReadOnly = true;
            this.TxtFName.Size = new System.Drawing.Size(656, 61);
            this.TxtFName.TabIndex = 6;
            this.TxtFName.Text = "txtFName";
            this.TxtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3355, 48);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Controls.Add(this.Button2);
            this.panel1.Controls.Add(this.utsLogo);
            this.panel1.Controls.Add(this.BtnProfile);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1052);
            this.panel1.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(0, 812);
            this.Button1.Margin = new System.Windows.Forms.Padding(6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(500, 77);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "My Requests";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(0, 725);
            this.Button2.Margin = new System.Windows.Forms.Padding(6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(500, 77);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Products";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
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
            // BtnProfile
            // 
            this.BtnProfile.BackColor = System.Drawing.Color.Teal;
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
            this.BtnProfile.UseVisualStyleBackColor = false;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(0, 548);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(500, 77);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditBtn.BackColor = System.Drawing.SystemColors.Window;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Location = new System.Drawing.Point(1792, 486);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(72, 66);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Teal;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(1395, 955);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(162, 52);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Teal;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(1581, 955);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(162, 52);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(2376, 40);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 14;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ProfileFormX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2560, 1052);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TxtFName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileFormX";
            this.Text = "My Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdb_SQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ProfilePicture;
        private TextBox TxtNickname;
        private TextBox TxtEmail;
        private Label Label1;
        private Label LblCC;
        private Label LblID;
        private Label LblEmail;
        private Label LblFullName;
        private TextBox TxtPhoneNo;
        private TextBox TxtID;
        private TextBox TxtCC;
        private TableLayoutPanel tableLayoutPanel1;
        private sepdbDataSet sepdb_SQL;
        private BindingSource usersBindingSource2;
        private sepdbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private TextBox TxtFName;
        private PictureBox pictureBox3;
        private BindingSource usersBindingSource;
        private Panel panel1;
        private Button Button1;
        private Button Button2;
        private PictureBox utsLogo;
        private Button BtnProfile;
        private Button BtnHome;
        private Button EditBtn;
        private Button CancelBtn;
        private Button SaveBtn;
        private PictureBox PictureBox1;
    }
    
}