using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyProject
{
    public partial class UpdateEmployeeSchedule : Form
    {
        public bool mon8to12, mon12to16, mon16to20, tue8to12, tue12to16, tue16to20, wed8to12, wed12to16, wed16to20, thu8to12, thu12to16, thu16to20, fri8to12, fri12to16, fri16to20 = false;

        private void checkBoxMon16to20_CheckedChanged(object sender, EventArgs e)
        {
            mon16to20 = true;
        }

        private void checkBoxTue16to20_CheckedChanged(object sender, EventArgs e)
        {
            tue16to20 = true;
        }

        private void checkBoxWed16to20_CheckedChanged(object sender, EventArgs e)
        {
            wed16to20 = true;
        }

        private void checkBoxThu16to20_CheckedChanged(object sender, EventArgs e)
        {
            thu16to20 = true;
        }

        private void checkBoxFri16to20_CheckedChanged(object sender, EventArgs e)
        {
            fri16to20 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // close this window
            var backpage = new Manager();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open manager window
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pickEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFri12to16_CheckedChanged(object sender, EventArgs e)
        {
            fri12to16 = true;
        }

        private void checkBoxThu12to16_CheckedChanged(object sender, EventArgs e)
        {
            thu12to16 = true;
        }

        private void checkBoxWed12to16_CheckedChanged(object sender, EventArgs e)
        {
            wed12to16 = true;
        }

        private void checkBoxTue12to16_CheckedChanged(object sender, EventArgs e)
        {
            tue12to16 = true;
        }

        private void checkBoxMon12to16_CheckedChanged(object sender, EventArgs e)
        {
            mon12to16 = true;
        }

        private void checkBoxFri8to12_CheckedChanged(object sender, EventArgs e)
        {
            fri8to12 = true;
        }

        private void checkBoxThu8to12_CheckedChanged(object sender, EventArgs e)
        {
            thu8to12 = true;
        }

        private void checkBoxTue8to12_CheckedChanged(object sender, EventArgs e)
        {
            tue8to12 = true;
        }

        private void checkBoxWed8to12_CheckedChanged(object sender, EventArgs e)
        {
            wed8to12 = true;
        }
        
        private void checkBoxMon8to12_CheckedChanged(object sender, EventArgs e)
        {
            mon8to12 = true;
        }
        
        public UpdateEmployeeSchedule()
        {
            InitializeComponent();

        }

        private void UpdateEmployeeSchedule_Load(object sender, EventArgs e)
        { }
            

        private void button1_Click(object sender, EventArgs e)
        {
            var backpage = new Schedule();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open schedule window
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // close login window
            var emp = new Schedule();
            emp.Closed += (s, args) => this.Close();
            emp.Show(); // open main window

        }
            
    }
}
