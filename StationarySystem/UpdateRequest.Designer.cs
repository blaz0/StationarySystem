namespace StationarySystem
{
    partial class UpdateRequest
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
            this.productIdLbl = new System.Windows.Forms.Label();
            this.oldQtyLbl = new System.Windows.Forms.Label();
            this.newQtyLbl = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // productIdLbl
            // 
            this.productIdLbl.AutoSize = true;
            this.productIdLbl.Location = new System.Drawing.Point(111, 52);
            this.productIdLbl.Name = "productIdLbl";
            this.productIdLbl.Size = new System.Drawing.Size(154, 25);
            this.productIdLbl.TabIndex = 0;
            this.productIdLbl.Text = "Product Name:";
            // 
            // oldQtyLbl
            // 
            this.oldQtyLbl.AutoSize = true;
            this.oldQtyLbl.Location = new System.Drawing.Point(111, 131);
            this.oldQtyLbl.Name = "oldQtyLbl";
            this.oldQtyLbl.Size = new System.Drawing.Size(137, 25);
            this.oldQtyLbl.TabIndex = 1;
            this.oldQtyLbl.Text = "Old Quantity:";
            // 
            // newQtyLbl
            // 
            this.newQtyLbl.AutoSize = true;
            this.newQtyLbl.Location = new System.Drawing.Point(111, 214);
            this.newQtyLbl.Name = "newQtyLbl";
            this.newQtyLbl.Size = new System.Drawing.Size(146, 25);
            this.newQtyLbl.TabIndex = 2;
            this.newQtyLbl.Text = "New Quantity:";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.BackColor = System.Drawing.SystemColors.Control;
            this.totalPriceLbl.Location = new System.Drawing.Point(111, 289);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(121, 25);
            this.totalPriceLbl.TabIndex = 3;
            this.totalPriceLbl.Text = "Total Price:";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Teal;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(324, 403);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(115, 50);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Teal;
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(100, 403);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 50);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update Details";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.Location = new System.Drawing.Point(329, 52);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(110, 25);
            this.productID.TabIndex = 7;
            this.productID.Text = "product iD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "current Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "total price";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(334, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 31);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "New Quantity";
            // 
            // UpdateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 529);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.newQtyLbl);
            this.Controls.Add(this.oldQtyLbl);
            this.Controls.Add(this.productIdLbl);
            this.Name = "UpdateRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product Request";
            this.Load += new System.EventHandler(this.UpdateRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productIdLbl;
        private System.Windows.Forms.Label oldQtyLbl;
        private System.Windows.Forms.Label newQtyLbl;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}