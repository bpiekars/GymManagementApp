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
    public partial class UpdateEmployeeRecords : Form
    {
        public UpdateEmployeeRecords()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // close upload employee records window
            var backpage = new Manager();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open manager window
        }

        private void UpdateEmployeeRecords_Load(object sender, EventArgs e)
        {

        }
    }
}
