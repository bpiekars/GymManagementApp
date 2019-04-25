namespace ToyProject
{
    partial class UpdateEmployeeSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeSchedule));
            this.label1 = new System.Windows.Forms.Label();
            this.pickEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fri12to14 = new System.Windows.Forms.Label();
            this.Thu12to14 = new System.Windows.Forms.Label();
            this.Wed12to14 = new System.Windows.Forms.Label();
            this.Tue12to14 = new System.Windows.Forms.Label();
            this.Mon12to14 = new System.Windows.Forms.Label();
            this.Fri10to12 = new System.Windows.Forms.Label();
            this.Thu10to12 = new System.Windows.Forms.Label();
            this.Wed10to12 = new System.Windows.Forms.Label();
            this.Tue10to12 = new System.Windows.Forms.Label();
            this.Mon10to12 = new System.Windows.Forms.Label();
            this.Fri8to10 = new System.Windows.Forms.Label();
            this.Thu8to10 = new System.Windows.Forms.Label();
            this.Wen8to10 = new System.Windows.Forms.Label();
            this.Tue8to10 = new System.Windows.Forms.Label();
            this.Mon8to10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxMon8to12 = new System.Windows.Forms.CheckBox();
            this.checkBoxTue8to12 = new System.Windows.Forms.CheckBox();
            this.checkBoxWed8to12 = new System.Windows.Forms.CheckBox();
            this.checkBoxThu8to12 = new System.Windows.Forms.CheckBox();
            this.checkBoxFri8to12 = new System.Windows.Forms.CheckBox();
            this.checkBoxFri12to16 = new System.Windows.Forms.CheckBox();
            this.checkBoxThu12to16 = new System.Windows.Forms.CheckBox();
            this.checkBoxWed12to16 = new System.Windows.Forms.CheckBox();
            this.checkBoxTue12to16 = new System.Windows.Forms.CheckBox();
            this.checkBoxMon12to16 = new System.Windows.Forms.CheckBox();
            this.checkBoxFri16to20 = new System.Windows.Forms.CheckBox();
            this.checkBoxThu16to20 = new System.Windows.Forms.CheckBox();
            this.checkBoxWed16to20 = new System.Windows.Forms.CheckBox();
            this.checkBoxTue16to20 = new System.Windows.Forms.CheckBox();
            this.checkBoxMon16to20 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Employee Schedule";
            // 
            // pickEmployee
            // 
            this.pickEmployee.FormattingEnabled = true;
            this.pickEmployee.Items.AddRange(new object[] {
            "Member",
            "Employee",
            "Manager"});
            this.pickEmployee.Location = new System.Drawing.Point(477, 70);
            this.pickEmployee.Name = "pickEmployee";
            this.pickEmployee.Size = new System.Drawing.Size(189, 21);
            this.pickEmployee.TabIndex = 24;
            this.pickEmployee.SelectedIndexChanged += new System.EventHandler(this.pickEmployee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(204, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Please Select Employee:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Fri12to14
            // 
            this.Fri12to14.AutoSize = true;
            this.Fri12to14.BackColor = System.Drawing.Color.Transparent;
            this.Fri12to14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fri12to14.ForeColor = System.Drawing.SystemColors.Control;
            this.Fri12to14.Location = new System.Drawing.Point(666, 315);
            this.Fri12to14.Name = "Fri12to14";
            this.Fri12to14.Size = new System.Drawing.Size(0, 25);
            this.Fri12to14.TabIndex = 75;
            // 
            // Thu12to14
            // 
            this.Thu12to14.AutoSize = true;
            this.Thu12to14.BackColor = System.Drawing.Color.Transparent;
            this.Thu12to14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu12to14.ForeColor = System.Drawing.SystemColors.Control;
            this.Thu12to14.Location = new System.Drawing.Point(542, 315);
            this.Thu12to14.Name = "Thu12to14";
            this.Thu12to14.Size = new System.Drawing.Size(0, 25);
            this.Thu12to14.TabIndex = 74;
            // 
            // Wed12to14
            // 
            this.Wed12to14.AutoSize = true;
            this.Wed12to14.BackColor = System.Drawing.Color.Transparent;
            this.Wed12to14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wed12to14.ForeColor = System.Drawing.SystemColors.Control;
            this.Wed12to14.Location = new System.Drawing.Point(421, 315);
            this.Wed12to14.Name = "Wed12to14";
            this.Wed12to14.Size = new System.Drawing.Size(0, 25);
            this.Wed12to14.TabIndex = 73;
            // 
            // Tue12to14
            // 
            this.Tue12to14.AutoSize = true;
            this.Tue12to14.BackColor = System.Drawing.Color.Transparent;
            this.Tue12to14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tue12to14.ForeColor = System.Drawing.SystemColors.Control;
            this.Tue12to14.Location = new System.Drawing.Point(304, 315);
            this.Tue12to14.Name = "Tue12to14";
            this.Tue12to14.Size = new System.Drawing.Size(0, 25);
            this.Tue12to14.TabIndex = 72;
            // 
            // Mon12to14
            // 
            this.Mon12to14.AutoSize = true;
            this.Mon12to14.BackColor = System.Drawing.Color.Transparent;
            this.Mon12to14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mon12to14.ForeColor = System.Drawing.SystemColors.Control;
            this.Mon12to14.Location = new System.Drawing.Point(186, 315);
            this.Mon12to14.Name = "Mon12to14";
            this.Mon12to14.Size = new System.Drawing.Size(0, 25);
            this.Mon12to14.TabIndex = 71;
            // 
            // Fri10to12
            // 
            this.Fri10to12.AutoSize = true;
            this.Fri10to12.BackColor = System.Drawing.Color.Transparent;
            this.Fri10to12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fri10to12.ForeColor = System.Drawing.SystemColors.Control;
            this.Fri10to12.Location = new System.Drawing.Point(666, 237);
            this.Fri10to12.Name = "Fri10to12";
            this.Fri10to12.Size = new System.Drawing.Size(0, 25);
            this.Fri10to12.TabIndex = 70;
            // 
            // Thu10to12
            // 
            this.Thu10to12.AutoSize = true;
            this.Thu10to12.BackColor = System.Drawing.Color.Transparent;
            this.Thu10to12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu10to12.ForeColor = System.Drawing.SystemColors.Control;
            this.Thu10to12.Location = new System.Drawing.Point(542, 237);
            this.Thu10to12.Name = "Thu10to12";
            this.Thu10to12.Size = new System.Drawing.Size(0, 25);
            this.Thu10to12.TabIndex = 69;
            // 
            // Wed10to12
            // 
            this.Wed10to12.AutoSize = true;
            this.Wed10to12.BackColor = System.Drawing.Color.Transparent;
            this.Wed10to12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wed10to12.ForeColor = System.Drawing.SystemColors.Control;
            this.Wed10to12.Location = new System.Drawing.Point(421, 237);
            this.Wed10to12.Name = "Wed10to12";
            this.Wed10to12.Size = new System.Drawing.Size(0, 25);
            this.Wed10to12.TabIndex = 68;
            // 
            // Tue10to12
            // 
            this.Tue10to12.AutoSize = true;
            this.Tue10to12.BackColor = System.Drawing.Color.Transparent;
            this.Tue10to12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tue10to12.ForeColor = System.Drawing.SystemColors.Control;
            this.Tue10to12.Location = new System.Drawing.Point(304, 237);
            this.Tue10to12.Name = "Tue10to12";
            this.Tue10to12.Size = new System.Drawing.Size(0, 25);
            this.Tue10to12.TabIndex = 67;
            // 
            // Mon10to12
            // 
            this.Mon10to12.AutoSize = true;
            this.Mon10to12.BackColor = System.Drawing.Color.Transparent;
            this.Mon10to12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mon10to12.ForeColor = System.Drawing.SystemColors.Control;
            this.Mon10to12.Location = new System.Drawing.Point(186, 237);
            this.Mon10to12.Name = "Mon10to12";
            this.Mon10to12.Size = new System.Drawing.Size(0, 25);
            this.Mon10to12.TabIndex = 66;
            // 
            // Fri8to10
            // 
            this.Fri8to10.AutoSize = true;
            this.Fri8to10.BackColor = System.Drawing.Color.Transparent;
            this.Fri8to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fri8to10.ForeColor = System.Drawing.SystemColors.Control;
            this.Fri8to10.Location = new System.Drawing.Point(666, 175);
            this.Fri8to10.Name = "Fri8to10";
            this.Fri8to10.Size = new System.Drawing.Size(0, 25);
            this.Fri8to10.TabIndex = 65;
            // 
            // Thu8to10
            // 
            this.Thu8to10.AutoSize = true;
            this.Thu8to10.BackColor = System.Drawing.Color.Transparent;
            this.Thu8to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu8to10.ForeColor = System.Drawing.SystemColors.Control;
            this.Thu8to10.Location = new System.Drawing.Point(542, 175);
            this.Thu8to10.Name = "Thu8to10";
            this.Thu8to10.Size = new System.Drawing.Size(0, 25);
            this.Thu8to10.TabIndex = 64;
            // 
            // Wen8to10
            // 
            this.Wen8to10.AutoSize = true;
            this.Wen8to10.BackColor = System.Drawing.Color.Transparent;
            this.Wen8to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wen8to10.ForeColor = System.Drawing.SystemColors.Control;
            this.Wen8to10.Location = new System.Drawing.Point(421, 175);
            this.Wen8to10.Name = "Wen8to10";
            this.Wen8to10.Size = new System.Drawing.Size(0, 25);
            this.Wen8to10.TabIndex = 63;
            // 
            // Tue8to10
            // 
            this.Tue8to10.AutoSize = true;
            this.Tue8to10.BackColor = System.Drawing.Color.Transparent;
            this.Tue8to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tue8to10.ForeColor = System.Drawing.SystemColors.Control;
            this.Tue8to10.Location = new System.Drawing.Point(304, 167);
            this.Tue8to10.Name = "Tue8to10";
            this.Tue8to10.Size = new System.Drawing.Size(0, 25);
            this.Tue8to10.TabIndex = 62;
            // 
            // Mon8to10
            // 
            this.Mon8to10.AutoSize = true;
            this.Mon8to10.BackColor = System.Drawing.Color.Transparent;
            this.Mon8to10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mon8to10.ForeColor = System.Drawing.SystemColors.Control;
            this.Mon8to10.Location = new System.Drawing.Point(186, 167);
            this.Mon8to10.Name = "Mon8to10";
            this.Mon8to10.Size = new System.Drawing.Size(0, 25);
            this.Mon8to10.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "16:00-20:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "12:00-16:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "8:00-12:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(684, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Fri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Wed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Tue";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(204, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 25);
            this.label13.TabIndex = 50;
            this.label13.Text = "Mon";
            // 
            // checkBoxMon8to12
            // 
            this.checkBoxMon8to12.AutoSize = true;
            this.checkBoxMon8to12.Location = new System.Drawing.Point(206, 175);
            this.checkBoxMon8to12.Name = "checkBoxMon8to12";
            this.checkBoxMon8to12.Size = new System.Drawing.Size(52, 17);
            this.checkBoxMon8to12.TabIndex = 91;
            this.checkBoxMon8to12.Text = "Work";
            this.checkBoxMon8to12.UseVisualStyleBackColor = true;
            this.checkBoxMon8to12.CheckedChanged += new System.EventHandler(this.checkBoxMon8to12_CheckedChanged);
            // 
            // checkBoxTue8to12
            // 
            this.checkBoxTue8to12.AutoSize = true;
            this.checkBoxTue8to12.Location = new System.Drawing.Point(327, 175);
            this.checkBoxTue8to12.Name = "checkBoxTue8to12";
            this.checkBoxTue8to12.Size = new System.Drawing.Size(52, 17);
            this.checkBoxTue8to12.TabIndex = 92;
            this.checkBoxTue8to12.Text = "Work";
            this.checkBoxTue8to12.UseVisualStyleBackColor = true;
            this.checkBoxTue8to12.CheckedChanged += new System.EventHandler(this.checkBoxTue8to12_CheckedChanged);
            // 
            // checkBoxWed8to12
            // 
            this.checkBoxWed8to12.AutoSize = true;
            this.checkBoxWed8to12.Location = new System.Drawing.Point(444, 175);
            this.checkBoxWed8to12.Name = "checkBoxWed8to12";
            this.checkBoxWed8to12.Size = new System.Drawing.Size(52, 17);
            this.checkBoxWed8to12.TabIndex = 93;
            this.checkBoxWed8to12.Text = "Work";
            this.checkBoxWed8to12.UseVisualStyleBackColor = true;
            this.checkBoxWed8to12.CheckedChanged += new System.EventHandler(this.checkBoxWed8to12_CheckedChanged);
            // 
            // checkBoxThu8to12
            // 
            this.checkBoxThu8to12.AutoSize = true;
            this.checkBoxThu8to12.Location = new System.Drawing.Point(565, 175);
            this.checkBoxThu8to12.Name = "checkBoxThu8to12";
            this.checkBoxThu8to12.Size = new System.Drawing.Size(52, 17);
            this.checkBoxThu8to12.TabIndex = 94;
            this.checkBoxThu8to12.Text = "Work";
            this.checkBoxThu8to12.UseVisualStyleBackColor = true;
            this.checkBoxThu8to12.CheckedChanged += new System.EventHandler(this.checkBoxThu8to12_CheckedChanged);
            // 
            // checkBoxFri8to12
            // 
            this.checkBoxFri8to12.AutoSize = true;
            this.checkBoxFri8to12.Location = new System.Drawing.Point(689, 175);
            this.checkBoxFri8to12.Name = "checkBoxFri8to12";
            this.checkBoxFri8to12.Size = new System.Drawing.Size(52, 17);
            this.checkBoxFri8to12.TabIndex = 95;
            this.checkBoxFri8to12.Text = "Work";
            this.checkBoxFri8to12.UseVisualStyleBackColor = true;
            this.checkBoxFri8to12.CheckedChanged += new System.EventHandler(this.checkBoxFri8to12_CheckedChanged);
            // 
            // checkBoxFri12to16
            // 
            this.checkBoxFri12to16.AutoSize = true;
            this.checkBoxFri12to16.Location = new System.Drawing.Point(689, 245);
            this.checkBoxFri12to16.Name = "checkBoxFri12to16";
            this.checkBoxFri12to16.Size = new System.Drawing.Size(52, 17);
            this.checkBoxFri12to16.TabIndex = 100;
            this.checkBoxFri12to16.Text = "Work";
            this.checkBoxFri12to16.UseVisualStyleBackColor = true;
            this.checkBoxFri12to16.CheckedChanged += new System.EventHandler(this.checkBoxFri12to16_CheckedChanged);
            // 
            // checkBoxThu12to16
            // 
            this.checkBoxThu12to16.AutoSize = true;
            this.checkBoxThu12to16.Location = new System.Drawing.Point(565, 245);
            this.checkBoxThu12to16.Name = "checkBoxThu12to16";
            this.checkBoxThu12to16.Size = new System.Drawing.Size(52, 17);
            this.checkBoxThu12to16.TabIndex = 99;
            this.checkBoxThu12to16.Text = "Work";
            this.checkBoxThu12to16.UseVisualStyleBackColor = true;
            this.checkBoxThu12to16.CheckedChanged += new System.EventHandler(this.checkBoxThu12to16_CheckedChanged);
            // 
            // checkBoxWed12to16
            // 
            this.checkBoxWed12to16.AutoSize = true;
            this.checkBoxWed12to16.Location = new System.Drawing.Point(444, 245);
            this.checkBoxWed12to16.Name = "checkBoxWed12to16";
            this.checkBoxWed12to16.Size = new System.Drawing.Size(52, 17);
            this.checkBoxWed12to16.TabIndex = 98;
            this.checkBoxWed12to16.Text = "Work";
            this.checkBoxWed12to16.UseVisualStyleBackColor = true;
            this.checkBoxWed12to16.CheckedChanged += new System.EventHandler(this.checkBoxWed12to16_CheckedChanged);
            // 
            // checkBoxTue12to16
            // 
            this.checkBoxTue12to16.AutoSize = true;
            this.checkBoxTue12to16.Location = new System.Drawing.Point(327, 245);
            this.checkBoxTue12to16.Name = "checkBoxTue12to16";
            this.checkBoxTue12to16.Size = new System.Drawing.Size(52, 17);
            this.checkBoxTue12to16.TabIndex = 97;
            this.checkBoxTue12to16.Text = "Work";
            this.checkBoxTue12to16.UseVisualStyleBackColor = true;
            this.checkBoxTue12to16.CheckedChanged += new System.EventHandler(this.checkBoxTue12to16_CheckedChanged);
            // 
            // checkBoxMon12to16
            // 
            this.checkBoxMon12to16.AutoSize = true;
            this.checkBoxMon12to16.Location = new System.Drawing.Point(206, 245);
            this.checkBoxMon12to16.Name = "checkBoxMon12to16";
            this.checkBoxMon12to16.Size = new System.Drawing.Size(52, 17);
            this.checkBoxMon12to16.TabIndex = 96;
            this.checkBoxMon12to16.Text = "Work";
            this.checkBoxMon12to16.UseVisualStyleBackColor = true;
            this.checkBoxMon12to16.CheckedChanged += new System.EventHandler(this.checkBoxMon12to16_CheckedChanged);
            // 
            // checkBoxFri16to20
            // 
            this.checkBoxFri16to20.AutoSize = true;
            this.checkBoxFri16to20.Location = new System.Drawing.Point(689, 323);
            this.checkBoxFri16to20.Name = "checkBoxFri16to20";
            this.checkBoxFri16to20.Size = new System.Drawing.Size(52, 17);
            this.checkBoxFri16to20.TabIndex = 105;
            this.checkBoxFri16to20.Text = "Work";
            this.checkBoxFri16to20.UseVisualStyleBackColor = true;
            this.checkBoxFri16to20.CheckedChanged += new System.EventHandler(this.checkBoxFri16to20_CheckedChanged);
            // 
            // checkBoxThu16to20
            // 
            this.checkBoxThu16to20.AutoSize = true;
            this.checkBoxThu16to20.Location = new System.Drawing.Point(565, 323);
            this.checkBoxThu16to20.Name = "checkBoxThu16to20";
            this.checkBoxThu16to20.Size = new System.Drawing.Size(52, 17);
            this.checkBoxThu16to20.TabIndex = 104;
            this.checkBoxThu16to20.Text = "Work";
            this.checkBoxThu16to20.UseVisualStyleBackColor = true;
            this.checkBoxThu16to20.CheckedChanged += new System.EventHandler(this.checkBoxThu16to20_CheckedChanged);
            // 
            // checkBoxWed16to20
            // 
            this.checkBoxWed16to20.AutoSize = true;
            this.checkBoxWed16to20.Location = new System.Drawing.Point(444, 323);
            this.checkBoxWed16to20.Name = "checkBoxWed16to20";
            this.checkBoxWed16to20.Size = new System.Drawing.Size(52, 17);
            this.checkBoxWed16to20.TabIndex = 103;
            this.checkBoxWed16to20.Text = "Work";
            this.checkBoxWed16to20.UseVisualStyleBackColor = true;
            this.checkBoxWed16to20.CheckedChanged += new System.EventHandler(this.checkBoxWed16to20_CheckedChanged);
            // 
            // checkBoxTue16to20
            // 
            this.checkBoxTue16to20.AutoSize = true;
            this.checkBoxTue16to20.Location = new System.Drawing.Point(327, 323);
            this.checkBoxTue16to20.Name = "checkBoxTue16to20";
            this.checkBoxTue16to20.Size = new System.Drawing.Size(52, 17);
            this.checkBoxTue16to20.TabIndex = 102;
            this.checkBoxTue16to20.Text = "Work";
            this.checkBoxTue16to20.UseVisualStyleBackColor = true;
            this.checkBoxTue16to20.CheckedChanged += new System.EventHandler(this.checkBoxTue16to20_CheckedChanged);
            // 
            // checkBoxMon16to20
            // 
            this.checkBoxMon16to20.AutoSize = true;
            this.checkBoxMon16to20.Location = new System.Drawing.Point(206, 323);
            this.checkBoxMon16to20.Name = "checkBoxMon16to20";
            this.checkBoxMon16to20.Size = new System.Drawing.Size(52, 17);
            this.checkBoxMon16to20.TabIndex = 101;
            this.checkBoxMon16to20.Text = "Work";
            this.checkBoxMon16to20.UseVisualStyleBackColor = true;
            this.checkBoxMon16to20.CheckedChanged += new System.EventHandler(this.checkBoxMon16to20_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(686, 415);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 121;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 122;
            this.button1.Text = "Check Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 123;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // UpdateEmployeeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBoxFri16to20);
            this.Controls.Add(this.checkBoxThu16to20);
            this.Controls.Add(this.checkBoxWed16to20);
            this.Controls.Add(this.checkBoxTue16to20);
            this.Controls.Add(this.checkBoxMon16to20);
            this.Controls.Add(this.checkBoxFri12to16);
            this.Controls.Add(this.checkBoxThu12to16);
            this.Controls.Add(this.checkBoxWed12to16);
            this.Controls.Add(this.checkBoxTue12to16);
            this.Controls.Add(this.checkBoxMon12to16);
            this.Controls.Add(this.checkBoxFri8to12);
            this.Controls.Add(this.checkBoxThu8to12);
            this.Controls.Add(this.checkBoxWed8to12);
            this.Controls.Add(this.checkBoxTue8to12);
            this.Controls.Add(this.checkBoxMon8to12);
            this.Controls.Add(this.Fri12to14);
            this.Controls.Add(this.Thu12to14);
            this.Controls.Add(this.Wed12to14);
            this.Controls.Add(this.Tue12to14);
            this.Controls.Add(this.Mon12to14);
            this.Controls.Add(this.Fri10to12);
            this.Controls.Add(this.Thu10to12);
            this.Controls.Add(this.Wed10to12);
            this.Controls.Add(this.Tue10to12);
            this.Controls.Add(this.Mon10to12);
            this.Controls.Add(this.Fri8to10);
            this.Controls.Add(this.Thu8to10);
            this.Controls.Add(this.Wen8to10);
            this.Controls.Add(this.Tue8to10);
            this.Controls.Add(this.Mon8to10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickEmployee);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateEmployeeSchedule";
            this.Text = "UpdateEmployeeSchedule";
            this.Load += new System.EventHandler(this.UpdateEmployeeSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pickEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Fri12to14;
        private System.Windows.Forms.Label Thu12to14;
        private System.Windows.Forms.Label Wed12to14;
        private System.Windows.Forms.Label Tue12to14;
        private System.Windows.Forms.Label Mon12to14;
        private System.Windows.Forms.Label Fri10to12;
        private System.Windows.Forms.Label Thu10to12;
        private System.Windows.Forms.Label Wed10to12;
        private System.Windows.Forms.Label Tue10to12;
        private System.Windows.Forms.Label Mon10to12;
        private System.Windows.Forms.Label Fri8to10;
        private System.Windows.Forms.Label Thu8to10;
        private System.Windows.Forms.Label Wen8to10;
        private System.Windows.Forms.Label Tue8to10;
        private System.Windows.Forms.Label Mon8to10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxMon8to12;
        private System.Windows.Forms.CheckBox checkBoxTue8to12;
        private System.Windows.Forms.CheckBox checkBoxWed8to12;
        private System.Windows.Forms.CheckBox checkBoxThu8to12;
        private System.Windows.Forms.CheckBox checkBoxFri8to12;
        private System.Windows.Forms.CheckBox checkBoxFri12to16;
        private System.Windows.Forms.CheckBox checkBoxThu12to16;
        private System.Windows.Forms.CheckBox checkBoxWed12to16;
        private System.Windows.Forms.CheckBox checkBoxTue12to16;
        private System.Windows.Forms.CheckBox checkBoxMon12to16;
        private System.Windows.Forms.CheckBox checkBoxFri16to20;
        private System.Windows.Forms.CheckBox checkBoxThu16to20;
        private System.Windows.Forms.CheckBox checkBoxWed16to20;
        private System.Windows.Forms.CheckBox checkBoxTue16to20;
        private System.Windows.Forms.CheckBox checkBoxMon16to20;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}