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
    public partial class ManagePayment : Form
    {
        public ManagePayment()
        {
            InitializeComponent();
        }

        private void ManagePayment_Load(object sender, EventArgs e)
        {

        }

        private void changePayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var changePayment = new MembershipOptions();
            changePayment.Closed += (s, args) => this.Close();
            changePayment.Show(); // open main window
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // close manage payment window
            var backpage = new Member();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open manager window
        }
    }
}
