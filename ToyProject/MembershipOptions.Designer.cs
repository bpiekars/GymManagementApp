namespace ToyProject
{
    partial class MembershipOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipOptions));
            this.label1 = new System.Windows.Forms.Label();
            this.memBox = new System.Windows.Forms.ComboBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.payMethod = new System.Windows.Forms.ComboBox();
            this.profPicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cardNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.expirDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cvcNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.postalCode = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Membership Plan";
            // 
            // memBox
            // 
            this.memBox.FormattingEnabled = true;
            this.memBox.Items.AddRange(new object[] {
            "Standard - 30 Days",
            "Standard - 6 Months",
            "Standard - 12 Months",
            "VIP - 30 Days",
            "VIP - 6 Months",
            "VIP - 12 Months",
            "Lifetime"});
            this.memBox.Location = new System.Drawing.Point(289, 12);
            this.memBox.Name = "memBox";
            this.memBox.Size = new System.Drawing.Size(137, 21);
            this.memBox.TabIndex = 1;
            this.memBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(289, 64);
            this.costBox.Name = "costBox";
            this.costBox.ReadOnly = true;
            this.costBox.Size = new System.Drawing.Size(124, 20);
            this.costBox.TabIndex = 2;
            this.costBox.TextChanged += new System.EventHandler(this.costBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(210, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(215, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax";
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(289, 116);
            this.taxBox.Name = "taxBox";
            this.taxBox.ReadOnly = true;
            this.taxBox.Size = new System.Drawing.Size(124, 20);
            this.taxBox.TabIndex = 5;
            this.taxBox.TextChanged += new System.EventHandler(this.taxBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(203, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(289, 156);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(124, 20);
            this.totalBox.TabIndex = 7;
            this.totalBox.TextChanged += new System.EventHandler(this.totalBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Choose Payment Method";
            // 
            // payMethod
            // 
            this.payMethod.FormattingEnabled = true;
            this.payMethod.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card"});
            this.payMethod.Location = new System.Drawing.Point(289, 208);
            this.payMethod.Name = "payMethod";
            this.payMethod.Size = new System.Drawing.Size(137, 21);
            this.payMethod.TabIndex = 9;
            this.payMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // profPicture
            // 
            this.profPicture.Location = new System.Drawing.Point(552, 37);
            this.profPicture.Name = "profPicture";
            this.profPicture.Size = new System.Drawing.Size(236, 217);
            this.profPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profPicture.TabIndex = 10;
            this.profPicture.TabStop = false;
            this.profPicture.Click += new System.EventHandler(this.profPicture_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(550, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Upload a Profile Picture";
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(579, 271);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(180, 52);
            this.uploadButton.TabIndex = 12;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(1, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enter 16 digit card number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cardNumber
            // 
            this.cardNumber.Location = new System.Drawing.Point(289, 252);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(137, 20);
            this.cardNumber.TabIndex = 14;
            this.cardNumber.TextChanged += new System.EventHandler(this.cardNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(104, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Expiration Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // expirDate
            // 
            this.expirDate.Location = new System.Drawing.Point(289, 303);
            this.expirDate.Name = "expirDate";
            this.expirDate.Size = new System.Drawing.Size(70, 20);
            this.expirDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cornsilk;
            this.label9.Location = new System.Drawing.Point(365, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "CVC";
            // 
            // cvcNumber
            // 
            this.cvcNumber.Location = new System.Drawing.Point(427, 302);
            this.cvcNumber.Name = "cvcNumber";
            this.cvcNumber.Size = new System.Drawing.Size(70, 20);
            this.cvcNumber.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Cornsilk;
            this.label10.Location = new System.Drawing.Point(137, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Postal Code";
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(289, 345);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(87, 20);
            this.postalCode.TabIndex = 20;
            // 
            // countryBox
            // 
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Items.AddRange(new object[] {
            "Standard - 30 Days",
            "Standard - 6 Months",
            "Standard - 12 Months",
            "VIP - 30 Days",
            "VIP - 6 Months",
            "VIP - 12 Months",
            "Lifetime"});
            this.countryBox.Location = new System.Drawing.Point(403, 344);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(145, 21);
            this.countryBox.TabIndex = 21;
            this.countryBox.Text = "United States of America";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitButton.Location = new System.Drawing.Point(289, 396);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(124, 42);
            this.submitButton.TabIndex = 22;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MembershipOptions
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cvcNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.expirDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cardNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.profPicture);
            this.Controls.Add(this.payMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.memBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MembershipOptions";
            this.Text = "Choose Membership Options";
            this.Load += new System.EventHandler(this.MembershipOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox memBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox payMethod;
        private System.Windows.Forms.PictureBox profPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cardNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox expirDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cvcNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox postalCode;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button1;
    }
}