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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manageMember = new ManageMember();
            manageMember.Closed += (s, args) => this.Close();
            manageMember.Show(); // open main window
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var valMembership = new ValidateMembership();
            valMembership.Closed += (s, args) => this.Close();
            valMembership.Show(); // open main window
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var updateProfile = new UpdateProfile();
            updateProfile.Closed += (s, args) => this.Close();
            updateProfile.Show(); // open main window
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var viewSched = new Schedule();
            viewSched.Closed += (s, args) => this.Close();
            viewSched.Show(); // open main window
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); // close employee window
            var backpage = new Login();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open login window
        }
    }
}
