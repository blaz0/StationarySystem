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
            this.StaffIDLbl.Location = new System.Drawing.Point(68, 47);
            this.StaffIDLbl.Name = "StaffIDLbl";
            this.StaffIDLbl.Size = new System.Drawing.Size(50, 13);
            this.StaffIDLbl.TabIndex = 0;
            this.StaffIDLbl.Text = "Staff ID#";
            this.StaffIDLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(68, 97);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.PasswordLbl.TabIndex = 1;
            this.PasswordLbl.Text = "Password";
            // 
            // StaffIDTF
            // 
            this.StaffIDTF.Location = new System.Drawing.Point(193, 40);
            this.StaffIDTF.Name = "StaffIDTF";
            this.StaffIDTF.Size = new System.Drawing.Size(100, 20);
            this.StaffIDTF.TabIndex = 2;
            // 
            // PasswordTF
            // 
            this.PasswordTF.Location = new System.Drawing.Point(193, 97);
            this.PasswordTF.Name = "PasswordTF";
            this.PasswordTF.Size = new System.Drawing.Size(100, 20);
            this.PasswordTF.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(193, 150);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 185);
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

        #endregion

        private System.Windows.Forms.Label StaffIDLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox StaffIDTF;
        private System.Windows.Forms.TextBox PasswordTF;
        private System.Windows.Forms.Button LoginBtn;
    }
}