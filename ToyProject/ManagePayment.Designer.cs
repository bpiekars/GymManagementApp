namespace ToyProject
{
    partial class ManagePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePayment));
            this.label1 = new System.Windows.Forms.Label();
            this.pastPaymentsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changePayBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Payment";
            // 
            // pastPaymentsBox
            // 
            this.pastPaymentsBox.FormattingEnabled = true;
            this.pastPaymentsBox.Location = new System.Drawing.Point(451, 141);
            this.pastPaymentsBox.Name = "pastPaymentsBox";
            this.pastPaymentsBox.Size = new System.Drawing.Size(121, 21);
            this.pastPaymentsBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(266, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "View Past Payments";
            // 
            // changePayBtn
            // 
            this.changePayBtn.Location = new System.Drawing.Point(270, 178);
            this.changePayBtn.Name = "changePayBtn";
            this.changePayBtn.Size = new System.Drawing.Size(302, 94);
            this.changePayBtn.TabIndex = 3;
            this.changePayBtn.Text = "Change Payment Plan";
            this.changePayBtn.UseVisualStyleBackColor = true;
            this.changePayBtn.Click += new System.EventHandler(this.changePayBtn_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "ManBackButton";
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changePayBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pastPaymentsBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagePayment";
            this.Text = "ManagePayment";
            this.Load += new System.EventHandler(this.ManagePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pastPaymentsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changePayBtn;
        private System.Windows.Forms.Button button1;
    }
}