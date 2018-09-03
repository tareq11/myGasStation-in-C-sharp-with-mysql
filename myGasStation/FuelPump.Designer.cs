namespace myGasStation
{
    partial class FuelPump
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
            this.pumpLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fuelNISTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.litersTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fuelRadio = new System.Windows.Forms.RadioButton();
            this.gasRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gasNISTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gasUnitsTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Pay = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Pay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pumpLabel
            // 
            this.pumpLabel.AutoSize = true;
            this.pumpLabel.Location = new System.Drawing.Point(12, 9);
            this.pumpLabel.Name = "pumpLabel";
            this.pumpLabel.Size = new System.Drawing.Size(68, 13);
            this.pumpLabel.TabIndex = 0;
            this.pumpLabel.Text = "First Pump .1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fuelNISTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.litersTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel Details";
            this.groupBox1.Visible = false;
            // 
            // fuelNISTxt
            // 
            this.fuelNISTxt.Location = new System.Drawing.Point(9, 112);
            this.fuelNISTxt.Name = "fuelNISTxt";
            this.fuelNISTxt.Size = new System.Drawing.Size(100, 20);
            this.fuelNISTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "insert the ammount in NIS:";
            // 
            // litersTxt
            // 
            this.litersTxt.Location = new System.Drawing.Point(9, 62);
            this.litersTxt.Name = "litersTxt";
            this.litersTxt.Size = new System.Drawing.Size(100, 20);
            this.litersTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "insert the ammount in liters:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fuelRadio);
            this.groupBox2.Controls.Add(this.gasRadio);
            this.groupBox2.Location = new System.Drawing.Point(148, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 75);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "choose the kind of fuel";
            // 
            // fuelRadio
            // 
            this.fuelRadio.AutoSize = true;
            this.fuelRadio.Location = new System.Drawing.Point(6, 52);
            this.fuelRadio.Name = "fuelRadio";
            this.fuelRadio.Size = new System.Drawing.Size(45, 17);
            this.fuelRadio.TabIndex = 1;
            this.fuelRadio.TabStop = true;
            this.fuelRadio.Text = "Fuel";
            this.fuelRadio.UseVisualStyleBackColor = true;
            this.fuelRadio.CheckedChanged += new System.EventHandler(this.fuelRadio_CheckedChanged);
            // 
            // gasRadio
            // 
            this.gasRadio.AutoSize = true;
            this.gasRadio.Location = new System.Drawing.Point(6, 29);
            this.gasRadio.Name = "gasRadio";
            this.gasRadio.Size = new System.Drawing.Size(44, 17);
            this.gasRadio.TabIndex = 0;
            this.gasRadio.TabStop = true;
            this.gasRadio.Text = "Gas";
            this.gasRadio.UseVisualStyleBackColor = true;
            this.gasRadio.CheckedChanged += new System.EventHandler(this.gasRadio_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gasNISTxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.gasUnitsTxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(258, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 147);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gas Details";
            this.groupBox3.Visible = false;
            // 
            // gasNISTxt
            // 
            this.gasNISTxt.Location = new System.Drawing.Point(9, 112);
            this.gasNISTxt.Name = "gasNISTxt";
            this.gasNISTxt.Size = new System.Drawing.Size(100, 20);
            this.gasNISTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "insert the ammount in NIS:";
            // 
            // gasUnitsTxt
            // 
            this.gasUnitsTxt.Location = new System.Drawing.Point(9, 62);
            this.gasUnitsTxt.Name = "gasUnitsTxt";
            this.gasUnitsTxt.Size = new System.Drawing.Size(100, 20);
            this.gasUnitsTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "insert the ammount in units:";
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(24, 251);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(75, 23);
            this.payBtn.TabIndex = 4;
            this.payBtn.Text = "Pay1";
            this.payBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(449, 261);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(21, 38);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(62, 13);
            this.ID.TabIndex = 7;
            this.ID.Text = "licenseNum";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
            this.comboBox1.Location = new System.Drawing.Point(54, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Pay
            // 
            this.Pay.Controls.Add(this.comboBox1);
            this.Pay.Location = new System.Drawing.Point(167, 243);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(200, 100);
            this.Pay.TabIndex = 10;
            this.Pay.TabStop = false;
            this.Pay.Text = "Pay";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date";
            // 
            // FuelPump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(614, 370);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pumpLabel);
            this.Name = "FuelPump";
            this.Text = "FuelPump";
            this.Load += new System.EventHandler(this.FuelPump_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Pay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pumpLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fuelNISTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox litersTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton fuelRadio;
        private System.Windows.Forms.RadioButton gasRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox gasNISTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gasUnitsTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Button closeBtn;
        public System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox Pay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}