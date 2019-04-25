namespace ToyProject
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.label1 = new System.Windows.Forms.Label();
            this.newEmpBtn = new System.Windows.Forms.Button();
            this.updateEmpRecords = new System.Windows.Forms.Button();
            this.updateEmpSched = new System.Windows.Forms.Button();
            this.manageEmpSal = new System.Windows.Forms.Button();
            this.updateProf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Dashboard";
            // 
            // newEmpBtn
            // 
            this.newEmpBtn.Location = new System.Drawing.Point(108, 175);
            this.newEmpBtn.Name = "newEmpBtn";
            this.newEmpBtn.Size = new System.Drawing.Size(132, 52);
            this.newEmpBtn.TabIndex = 1;
            this.newEmpBtn.Text = "Register New Employee";
            this.newEmpBtn.UseVisualStyleBackColor = true;
            this.newEmpBtn.Click += new System.EventHandler(this.newEmpBtn_Click);
            // 
            // updateEmpRecords
            // 
            this.updateEmpRecords.Location = new System.Drawing.Point(416, 175);
            this.updateEmpRecords.Name = "updateEmpRecords";
            this.updateEmpRecords.Size = new System.Drawing.Size(132, 52);
            this.updateEmpRecords.TabIndex = 2;
            this.updateEmpRecords.Text = "Update Employee Records";
            this.updateEmpRecords.UseVisualStyleBackColor = true;
            this.updateEmpRecords.Click += new System.EventHandler(this.updateEmpRecords_Click);
            // 
            // updateEmpSched
            // 
            this.updateEmpSched.Location = new System.Drawing.Point(257, 175);
            this.updateEmpSched.Name = "updateEmpSched";
            this.updateEmpSched.Size = new System.Drawing.Size(132, 52);
            this.updateEmpSched.TabIndex = 3;
            this.updateEmpSched.Text = "Update Employee Schedule";
            this.updateEmpSched.UseVisualStyleBackColor = true;
            this.updateEmpSched.Click += new System.EventHandler(this.updateEmpSched_Click);
            // 
            // manageEmpSal
            // 
            this.manageEmpSal.Location = new System.Drawing.Point(574, 175);
            this.manageEmpSal.Name = "manageEmpSal";
            this.manageEmpSal.Size = new System.Drawing.Size(132, 52);
            this.manageEmpSal.TabIndex = 4;
            this.manageEmpSal.Text = "Manage Employee Salary";
            this.manageEmpSal.UseVisualStyleBackColor = true;
            this.manageEmpSal.Click += new System.EventHandler(this.manageEmpSal_Click);
            // 
            // updateProf
            // 
            this.updateProf.Location = new System.Drawing.Point(332, 254);
            this.updateProf.Name = "updateProf";
            this.updateProf.Size = new System.Drawing.Size(132, 52);
            this.updateProf.TabIndex = 5;
            this.updateProf.Text = "Update Profile";
            this.updateProf.UseVisualStyleBackColor = true;
            this.updateProf.Click += new System.EventHandler(this.updateEmpRecords_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "ManBackButton";
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateProf);
            this.Controls.Add(this.manageEmpSal);
            this.Controls.Add(this.updateEmpSched);
            this.Controls.Add(this.updateEmpRecords);
            this.Controls.Add(this.newEmpBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newEmpBtn;
        private System.Windows.Forms.Button updateEmpRecords;
        private System.Windows.Forms.Button updateEmpSched;
        private System.Windows.Forms.Button manageEmpSal;
        private System.Windows.Forms.Button updateProf;
        private System.Windows.Forms.Button button1;
    }
}