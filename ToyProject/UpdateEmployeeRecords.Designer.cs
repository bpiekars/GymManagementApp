namespace ToyProject
{
    partial class UpdateEmployeeRecords
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
            System.Windows.Forms.Label birthLbl;
            System.Windows.Forms.Label salaryLbl;
            System.Windows.Forms.Label addressLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeRecords));
            this.label1 = new System.Windows.Forms.Label();
            this.employeeList = new System.Windows.Forms.ComboBox();
            this.selectEmpLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.birthBox = new System.Windows.Forms.TextBox();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empFirst = new System.Windows.Forms.Label();
            birthLbl = new System.Windows.Forms.Label();
            salaryLbl = new System.Windows.Forms.Label();
            addressLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birthLbl
            // 
            birthLbl.AutoSize = true;
            birthLbl.BackColor = System.Drawing.Color.Transparent;
            birthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthLbl.ForeColor = System.Drawing.Color.Cornsilk;
            birthLbl.Location = new System.Drawing.Point(98, 342);
            birthLbl.Name = "birthLbl";
            birthLbl.Size = new System.Drawing.Size(91, 25);
            birthLbl.TabIndex = 24;
            birthLbl.Text = "Birthday";
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.BackColor = System.Drawing.Color.Transparent;
            salaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaryLbl.ForeColor = System.Drawing.Color.Cornsilk;
            salaryLbl.Location = new System.Drawing.Point(116, 290);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new System.Drawing.Size(73, 25);
            salaryLbl.TabIndex = 23;
            salaryLbl.Text = "Salary";
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.BackColor = System.Drawing.Color.Transparent;
            addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLbl.ForeColor = System.Drawing.Color.Cornsilk;
            addressLbl.Location = new System.Drawing.Point(98, 195);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new System.Drawing.Size(91, 25);
            addressLbl.TabIndex = 19;
            addressLbl.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Employee Records";
            // 
            // employeeList
            // 
            this.employeeList.FormattingEnabled = true;
            this.employeeList.Location = new System.Drawing.Point(207, 46);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(100, 21);
            this.employeeList.TabIndex = 1;
            // 
            // selectEmpLabel
            // 
            this.selectEmpLabel.AutoSize = true;
            this.selectEmpLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectEmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectEmpLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.selectEmpLabel.Location = new System.Drawing.Point(19, 46);
            this.selectEmpLabel.Name = "selectEmpLabel";
            this.selectEmpLabel.Size = new System.Drawing.Size(171, 25);
            this.selectEmpLabel.TabIndex = 2;
            this.selectEmpLabel.Text = "Select employee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(195, 394);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(112, 42);
            this.submitBtn.TabIndex = 27;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // birthBox
            // 
            this.birthBox.Location = new System.Drawing.Point(207, 342);
            this.birthBox.Name = "birthBox";
            this.birthBox.Size = new System.Drawing.Size(100, 20);
            this.birthBox.TabIndex = 26;
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(207, 295);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(100, 20);
            this.salaryBox.TabIndex = 25;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(207, 251);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 22;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(207, 200);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 20);
            this.addressBox.TabIndex = 21;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.phoneLbl.Location = new System.Drawing.Point(37, 246);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(152, 25);
            this.phoneLbl.TabIndex = 20;
            this.phoneLbl.Text = "Phone number";
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(207, 149);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(100, 20);
            this.lastBox.TabIndex = 18;
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(207, 99);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(100, 20);
            this.firstBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(77, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last name";
            // 
            // empFirst
            // 
            this.empFirst.AutoSize = true;
            this.empFirst.BackColor = System.Drawing.Color.Transparent;
            this.empFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empFirst.ForeColor = System.Drawing.Color.Cornsilk;
            this.empFirst.Location = new System.Drawing.Point(77, 93);
            this.empFirst.Name = "empFirst";
            this.empFirst.Size = new System.Drawing.Size(113, 25);
            this.empFirst.TabIndex = 15;
            this.empFirst.Text = "First name";
            // 
            // UpdateEmployeeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.birthBox);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(birthLbl);
            this.Controls.Add(salaryLbl);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(addressLbl);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empFirst);
            this.Controls.Add(this.selectEmpLabel);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateEmployeeRecords";
            this.Text = "UpdateEmployeeRecords";
            this.Load += new System.EventHandler(this.UpdateEmployeeRecords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox employeeList;
        private System.Windows.Forms.Label selectEmpLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox birthBox;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label empFirst;
    }
}