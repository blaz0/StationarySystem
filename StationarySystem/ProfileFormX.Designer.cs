﻿using System;
using System.Windows;
using System.Windows.Forms;

namespace StationarySystem
{
    partial class ProfileFormX
    {
        public int userIDparam = 0;

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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.utsLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sepdb_SQL = new StationarySystem.sepdb_SQL();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new StationarySystem.sepdb_SQLTableAdapters.usersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdb_SQL)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 335);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(250, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfile.BackColor = System.Drawing.Color.Teal;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 381);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(250, 40);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.utsLogo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 737);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // utsLogo
            // 
            this.utsLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.utsLogo.Image = ((System.Drawing.Image)(resources.GetObject("utsLogo.Image")));
            this.utsLogo.Location = new System.Drawing.Point(75, 132);
            this.utsLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.utsLogo.Name = "utsLogo";
            this.utsLogo.Size = new System.Drawing.Size(100, 150);
            this.utsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.utsLogo.TabIndex = 4;
            this.utsLogo.TabStop = false;
            this.utsLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(737, 53);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtNickname
            // 
            this.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNickname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource2, "nickname", true));
            this.txtNickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickname.Location = new System.Drawing.Point(202, 2);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNickname.Multiline = true;
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.ReadOnly = true;
            this.txtNickname.Size = new System.Drawing.Size(196, 36);
            this.txtNickname.TabIndex = 8;
            this.txtNickname.Text = "insert nickname here";
            this.txtNickname.TextChanged += new System.EventHandler(this.txtNickname_TextChanged_1);
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.sepdb_SQL;
            // 
            // sepdb_SQL
            // 
            this.sepdb_SQL.DataSetName = "sepdb_SQL";
            this.sepdb_SQL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource2, "emailAddress", true));
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(202, 42);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(196, 36);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "insert email here";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(2, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cost Centre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCC.Location = new System.Drawing.Point(2, 120);
            this.lblCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(196, 40);
            this.lblCC.TabIndex = 7;
            this.lblCC.Text = "ID Number:";
            this.lblCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblID.Location = new System.Drawing.Point(2, 80);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(196, 40);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Phone Number:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblEmail.Location = new System.Drawing.Point(2, 40);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(196, 40);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblFullName.Location = new System.Drawing.Point(2, 0);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(196, 40);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Nickname:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource2, "phoneNumber", true));
            this.txtPhoneNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(202, 82);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNo.Multiline = true;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.ReadOnly = true;
            this.txtPhoneNo.Size = new System.Drawing.Size(196, 36);
            this.txtPhoneNo.TabIndex = 8;
            this.txtPhoneNo.Text = "insert phone no. here";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource2, "userId", true));
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(202, 122);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(196, 36);
            this.txtID.TabIndex = 8;
            this.txtID.Text = "insert ID no. here";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged_1);
            // 
            // txtCC
            // 
            this.txtCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource2, "costCentre", true));
            this.txtCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.Location = new System.Drawing.Point(202, 162);
            this.txtCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCC.Multiline = true;
            this.txtCC.Name = "txtCC";
            this.txtCC.ReadOnly = true;
            this.txtCC.Size = new System.Drawing.Size(196, 36);
            this.txtCC.TabIndex = 8;
            this.txtCC.Text = "insert cost centre here";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtCC, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNickname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFullName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(636, 381);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtFName.Location = new System.Drawing.Point(774, 283);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(126, 38);
            this.txtFName.TabIndex = 6;
            this.txtFName.Text = "txtFName";
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged_1);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "System Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Notifications";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1297, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ProfileFormX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1358, 737);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProfileFormX";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepdb_SQL)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox utsLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private TextBox txtNickname;
        private TextBox txtEmail;
        private Label label1;
        private Label lblCC;
        private Label lblID;
        private Label lblEmail;
        private Label lblFullName;
        private TextBox txtPhoneNo;
        private TextBox txtID;
        private TextBox txtCC;
        private TableLayoutPanel tableLayoutPanel1;
        private sepdb_SQL sepdb_SQL;
        private BindingSource usersBindingSource2;
        private sepdb_SQLTableAdapters.usersTableAdapter usersTableAdapter;
        private TextBox txtFName;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
    
}