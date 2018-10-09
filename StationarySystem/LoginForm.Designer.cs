using System;
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
            this.loadingCircle = new CircularProgressBar.CircularProgressBar();
            this.closeLbl = new System.Windows.Forms.Label();
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
            this.LoginBtn.BackColor = System.Drawing.Color.Teal;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
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
            this.loadingCircle.Location = new System.Drawing.Point(511, 54);
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
            this.loadingCircle.TabIndex = 7;
            this.loadingCircle.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.loadingCircle.Value = 68;
            // 
            // closeLbl
            // 
            this.closeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeLbl.AutoSize = true;
            this.closeLbl.Location = new System.Drawing.Point(520, 393);
            this.closeLbl.Name = "closeLbl";
            this.closeLbl.Size = new System.Drawing.Size(67, 25);
            this.closeLbl.TabIndex = 9;
            this.closeLbl.Text = "Close";
            this.closeLbl.Click += new System.EventHandler(this.closeLbl_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 513);
            this.Controls.Add(this.closeLbl);
            this.Controls.Add(this.loadingCircle);
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
            LoginBtn.Enabled = false;
            loadingCircle.Visible = false;
        }
        //void calculate()
        //{
        //    LoginBtn.Enabled = (StaffIDTF.Text != "" && PasswordTF.Text != "");
        //}

        private void StaffIDTF_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException
            
        }

        #endregion

        private System.Windows.Forms.Label StaffIDLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordTF;
        private System.Windows.Forms.Button LoginBtn;
        public System.Windows.Forms.TextBox StaffIDTF;
        private Label label1;
        private PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar loadingCircle;
        private Label closeLbl;
    }
}