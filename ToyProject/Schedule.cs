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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            var scheduler = new UpdateEmployeeSchedule();
            if (scheduler.mon8to12 == true) { this.Mon8to12.Text = "Work__"; }
            if (scheduler.mon12to16 == true) { this.Mon12to16.Text = "Work__"; }
            if (scheduler.mon16to20 == true) { this.Mon16to20.Text = "Work__"; }
            if (scheduler.tue8to12 == true) { this.Tue8to12.Text = "Work__"; }
            if (scheduler.tue12to16 == true) { this.Tue12to16.Text = "Work__"; }
            if (scheduler.tue16to20 == true) { this.Tue16to20.Text = "Work__"; }
            if (scheduler.wed8to12 == true) { this.Wed8to12.Text = "Work__"; }
            if (scheduler.wed12to16 == true) { this.Wed12to16.Text = "Work__"; }
            if (scheduler.wed16to20 == true) { this.Wed16to20.Text = "Work__"; }
            if (scheduler.thu8to12 == true) { this.Thu8to12.Text = "Work__"; }
            if (scheduler.thu12to16 == true) { this.Thu12to16.Text = "Work__"; }
            if (scheduler.thu16to20 == true) { this.Thu16to20.Text = "Work__"; }
            if (scheduler.fri8to12 == true) { this.Fri8to12.Text = "Work__"; }
            if (scheduler.fri12to16 == true) { this.Fri12to16.Text = "Work__"; }
            if (scheduler.fri16to20 == true) { this.Fri16to20.Text = "Work__"; }
        }


        private void Schedule_Load(object sender, EventArgs e)
        {
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // close Schedule window
            var backpage = new Employee();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open employee window
        }

        private void Mon8to12_Click(object sender, EventArgs e)
        {

        }

        private void Wen8to12_Click(object sender, EventArgs e)
        {

        }
    }
}
