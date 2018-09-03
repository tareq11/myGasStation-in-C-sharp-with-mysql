namespace myGasStation
{
    partial class Card
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
            this.customerGB = new System.Windows.Forms.GroupBox();
            this.showID = new System.Windows.Forms.Label();
            this.showPhone = new System.Windows.Forms.Label();
            this.showEmail = new System.Windows.Forms.Label();
            this.showAddress = new System.Windows.Forms.Label();
            this.showName = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.customerGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGB
            // 
            this.customerGB.Controls.Add(this.showID);
            this.customerGB.Controls.Add(this.showPhone);
            this.customerGB.Controls.Add(this.showEmail);
            this.customerGB.Controls.Add(this.showAddress);
            this.customerGB.Controls.Add(this.showName);
            this.customerGB.Controls.Add(this.IDLabel);
            this.customerGB.Controls.Add(this.phoneLabel);
            this.customerGB.Controls.Add(this.emailLabel);
            this.customerGB.Controls.Add(this.addressLabel);
            this.customerGB.Controls.Add(this.nameLabel);
            this.customerGB.Location = new System.Drawing.Point(31, 31);
            this.customerGB.Name = "customerGB";
            this.customerGB.Size = new System.Drawing.Size(329, 159);
            this.customerGB.TabIndex = 1;
            this.customerGB.TabStop = false;
            this.customerGB.Text = "Customer Details ";
            // 
            // showID
            // 
            this.showID.AutoSize = true;
            this.showID.Location = new System.Drawing.Point(94, 134);
            this.showID.Name = "showID";
            this.showID.Size = new System.Drawing.Size(10, 13);
            this.showID.TabIndex = 9;
            this.showID.Text = ".";
            // 
            // showPhone
            // 
            this.showPhone.AutoSize = true;
            this.showPhone.Location = new System.Drawing.Point(94, 105);
            this.showPhone.Name = "showPhone";
            this.showPhone.Size = new System.Drawing.Size(10, 13);
            this.showPhone.TabIndex = 8;
            this.showPhone.Text = ".";
            // 
            // showEmail
            // 
            this.showEmail.AutoSize = true;
            this.showEmail.Location = new System.Drawing.Point(94, 77);
            this.showEmail.Name = "showEmail";
            this.showEmail.Size = new System.Drawing.Size(10, 13);
            this.showEmail.TabIndex = 7;
            this.showEmail.Text = ".";
            // 
            // showAddress
            // 
            this.showAddress.AutoSize = true;
            this.showAddress.Location = new System.Drawing.Point(94, 49);
            this.showAddress.Name = "showAddress";
            this.showAddress.Size = new System.Drawing.Size(10, 13);
            this.showAddress.TabIndex = 6;
            this.showAddress.Text = ".";
            // 
            // showName
            // 
            this.showName.AutoSize = true;
            this.showName.Location = new System.Drawing.Point(94, 25);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(10, 13);
            this.showName.TabIndex = 5;
            this.showName.Text = ".";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(6, 134);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(31, 13);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "ID # ";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(6, 105);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 77);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(6, 49);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 236);
            this.Controls.Add(this.customerGB);
            this.Name = "Card";
            this.Text = "Card";
            this.Load += new System.EventHandler(this.Card_Load);
            this.customerGB.ResumeLayout(false);
            this.customerGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox customerGB;
        private System.Windows.Forms.Label showID;
        private System.Windows.Forms.Label showPhone;
        private System.Windows.Forms.Label showEmail;
        private System.Windows.Forms.Label showAddress;
        private System.Windows.Forms.Label showName;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}