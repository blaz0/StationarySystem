namespace StationarySystem
{
    partial class LoginScreen
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
            this.UsernameLb = new System.Windows.Forms.Label();
            this.PasswordLb = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UsernameTF = new System.Windows.Forms.TextBox();
            this.PasswordTF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsernameLb
            // 
            this.UsernameLb.AutoSize = true;
            this.UsernameLb.Location = new System.Drawing.Point(60, 68);
            this.UsernameLb.Name = "UsernameLb";
            this.UsernameLb.Size = new System.Drawing.Size(58, 13);
            this.UsernameLb.TabIndex = 0;
            this.UsernameLb.Text = "Username:";
            this.UsernameLb.Click += new System.EventHandler(this.UsernameLb_Click);
            // 
            // PasswordLb
            // 
            this.PasswordLb.AutoSize = true;
            this.PasswordLb.Location = new System.Drawing.Point(60, 100);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.Size = new System.Drawing.Size(56, 13);
            this.PasswordLb.TabIndex = 1;
            this.PasswordLb.Text = "Password:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(144, 140);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(79, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // UsernameTF
            // 
            this.UsernameTF.Location = new System.Drawing.Point(134, 65);
            this.UsernameTF.Name = "UsernameTF";
            this.UsernameTF.Size = new System.Drawing.Size(100, 20);
            this.UsernameTF.TabIndex = 3;
            this.UsernameTF.TextChanged += new System.EventHandler(this.UsernameTF_TextChanged);
            // 
            // PasswordTF
            // 
            this.PasswordTF.Location = new System.Drawing.Point(134, 100);
            this.PasswordTF.Name = "PasswordTF";
            this.PasswordTF.Size = new System.Drawing.Size(100, 20);
            this.PasswordTF.TabIndex = 4;
            this.PasswordTF.TextChanged += new System.EventHandler(this.PasswordTF_TextChanged);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 204);
            this.Controls.Add(this.PasswordTF);
            this.Controls.Add(this.UsernameTF);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordLb);
            this.Controls.Add(this.UsernameLb);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLb;
        private System.Windows.Forms.Label PasswordLb;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox UsernameTF;
        private System.Windows.Forms.TextBox PasswordTF;
    }
}

