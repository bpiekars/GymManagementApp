namespace ToyProject
{
    partial class UpdateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProfile));
            this.updateProfLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.TextBox();
            this.memBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateProfLbl
            // 
            this.updateProfLbl.AutoSize = true;
            this.updateProfLbl.BackColor = System.Drawing.Color.Transparent;
            this.updateProfLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfLbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.updateProfLbl.Location = new System.Drawing.Point(326, 60);
            this.updateProfLbl.Name = "updateProfLbl";
            this.updateProfLbl.Size = new System.Drawing.Size(148, 25);
            this.updateProfLbl.TabIndex = 0;
            this.updateProfLbl.Text = "Update Profile";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 47;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitButton.Location = new System.Drawing.Point(331, 349);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(124, 42);
            this.submitButton.TabIndex = 46;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(414, 284);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(137, 20);
            this.totalBox.TabIndex = 31;
            this.totalBox.TextChanged += new System.EventHandler(this.totalBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(328, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Total";
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(414, 239);
            this.taxBox.Name = "taxBox";
            this.taxBox.ReadOnly = true;
            this.taxBox.Size = new System.Drawing.Size(137, 20);
            this.taxBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(340, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(335, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Price";
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(414, 186);
            this.costBox.Name = "costBox";
            this.costBox.ReadOnly = true;
            this.costBox.Size = new System.Drawing.Size(137, 20);
            this.costBox.TabIndex = 26;
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
            this.memBox.Location = new System.Drawing.Point(414, 134);
            this.memBox.Name = "memBox";
            this.memBox.Size = new System.Drawing.Size(137, 21);
            this.memBox.TabIndex = 25;
            this.memBox.SelectedIndexChanged += new System.EventHandler(this.memBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(137, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Choose Membership Plan";
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.memBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateProfLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateProfile";
            this.Text = "UpdateProfile";
            this.Load += new System.EventHandler(this.UpdateProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateProfLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.ComboBox memBox;
        private System.Windows.Forms.Label label1;
    }
}