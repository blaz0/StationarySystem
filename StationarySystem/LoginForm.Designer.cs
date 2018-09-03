﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace StationarySystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.StaffIDLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.StaffIDTF = new System.Windows.Forms.TextBox();
            this.PasswordTF = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffIDLbl
            // 
            this.StaffIDLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffIDLbl.AutoSize = true;
            this.StaffIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIDLbl.Location = new System.Drawing.Point(111, 166);
            this.StaffIDLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StaffIDLbl.Name = "StaffIDLbl";
            this.StaffIDLbl.Size = new System.Drawing.Size(141, 37);
            this.StaffIDLbl.TabIndex = 0;
            this.StaffIDLbl.Text = "Staff ID#";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(103, 261);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(158, 37);
            this.PasswordLbl.TabIndex = 1;
            this.PasswordLbl.Text = "Password";
            // 
            // StaffIDTF
            // 
            this.StaffIDTF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffIDTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIDTF.Location = new System.Drawing.Point(295, 166);
            this.StaffIDTF.Margin = new System.Windows.Forms.Padding(6);
            this.StaffIDTF.MaxLength = 8;
            this.StaffIDTF.Name = "StaffIDTF";
            this.StaffIDTF.Size = new System.Drawing.Size(304, 44);
            this.StaffIDTF.TabIndex = 2;
            this.StaffIDTF.TextChanged += new System.EventHandler(this.StaffIDTF_TextChanged);
            // 
            // PasswordTF
            // 
            this.PasswordTF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTF.Location = new System.Drawing.Point(295, 261);
            this.PasswordTF.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordTF.Name = "PasswordTF";
            this.PasswordTF.PasswordChar = '*';
            this.PasswordTF.Size = new System.Drawing.Size(304, 44);
            this.PasswordTF.TabIndex = 3;
            this.PasswordTF.TextChanged += new System.EventHandler(this.PasswordTF_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(295, 361);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(6);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(200, 77);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label1.Location = new System.Drawing.Point(273, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 85);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTF);
            this.Controls.Add(this.StaffIDTF);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.StaffIDLbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTS: Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //ensure that the maximised screen still displays the toolbar/taskbar
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            //int boundWidth = Screen.PrimaryScreen.Bounds.Width;
            //int boundHeight = Screen.PrimaryScreen.Bounds.Height;
            //int x = boundWidth - this.Width;
            //int y = boundHeight - this.Height;
            //this.Location = new Point(x / 2, y / 2);

        }

        private void StaffIDTF_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label StaffIDLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordTF;
        private System.Windows.Forms.Button LoginBtn;
        public System.Windows.Forms.TextBox StaffIDTF;
        private Label label1;
        private PictureBox pictureBox1;
    }
}