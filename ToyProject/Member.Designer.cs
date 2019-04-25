namespace ToyProject
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.label1 = new System.Windows.Forms.Label();
            this.mngPymentBtn = new System.Windows.Forms.Button();
            this.updtProfBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mngPymentBtn
            // 
            this.mngPymentBtn.Location = new System.Drawing.Point(271, 128);
            this.mngPymentBtn.Name = "mngPymentBtn";
            this.mngPymentBtn.Size = new System.Drawing.Size(139, 70);
            this.mngPymentBtn.TabIndex = 1;
            this.mngPymentBtn.Text = "Manage Payment";
            this.mngPymentBtn.UseVisualStyleBackColor = true;
            this.mngPymentBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updtProfBtn
            // 
            this.updtProfBtn.Location = new System.Drawing.Point(271, 246);
            this.updtProfBtn.Name = "updtProfBtn";
            this.updtProfBtn.Size = new System.Drawing.Size(139, 70);
            this.updtProfBtn.TabIndex = 2;
            this.updtProfBtn.Text = "Update Profile";
            this.updtProfBtn.UseVisualStyleBackColor = true;
            this.updtProfBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Member
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updtProfBtn);
            this.Controls.Add(this.mngPymentBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Member";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mngPymentBtn;
        private System.Windows.Forms.Button updtProfBtn;
        private System.Windows.Forms.Button button1;
    }
}