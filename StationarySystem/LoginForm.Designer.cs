using System;

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
            this.StaffIDLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.StaffIDTF = new System.Windows.Forms.TextBox();
            this.PasswordTF = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffIDLbl
            // 
            this.StaffIDLbl.AutoSize = true;
            this.StaffIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIDLbl.Location = new System.Drawing.Point(52, 47);
            this.StaffIDLbl.Name = "StaffIDLbl";
            this.StaffIDLbl.Size = new System.Drawing.Size(74, 20);
            this.StaffIDLbl.TabIndex = 0;
            this.StaffIDLbl.Text = "Staff ID#";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(48, 96);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(78, 20);
            this.PasswordLbl.TabIndex = 1;
            this.PasswordLbl.Text = "Password";
            // 
            // StaffIDTF
            // 
            this.StaffIDTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIDTF.Location = new System.Drawing.Point(144, 47);
            this.StaffIDTF.MaxLength = 8;
            this.StaffIDTF.Name = "StaffIDTF";
            this.StaffIDTF.Size = new System.Drawing.Size(154, 26);
            this.StaffIDTF.TabIndex = 2;
            this.StaffIDTF.TextChanged += new System.EventHandler(this.StaffIDTF_TextChanged);
            // 
            // PasswordTF
            // 
            this.PasswordTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTF.Location = new System.Drawing.Point(144, 96);
            this.PasswordTF.Name = "PasswordTF";
            this.PasswordTF.PasswordChar = '*';
            this.PasswordTF.Size = new System.Drawing.Size(154, 26);
            this.PasswordTF.TabIndex = 3;
            this.PasswordTF.TextChanged += new System.EventHandler(this.PasswordTF_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(144, 148);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(100, 40);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTF);
            this.Controls.Add(this.StaffIDTF);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.StaffIDLbl);
            this.Name = "LoginForm";
            this.Text = "UTS: Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
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
    }
}