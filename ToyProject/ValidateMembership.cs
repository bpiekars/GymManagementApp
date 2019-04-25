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
    public partial class ValidateMembership : Form
    {
        public ValidateMembership()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // close this window
            var backpage = new Employee();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open Emp window
        }
    }
}
