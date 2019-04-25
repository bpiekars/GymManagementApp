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
    public partial class Member : Form
    {
        private void Member_Load(object sender, EventArgs e)
        {

        }
  
        public Member(string username) : this()
        {
            MessageBox.Show("Welcome back, " + username + "!");
        }

        public Member()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var updateProfile = new UpdateProfile();
            updateProfile.Closed += (s, args) => this.Close();
            updateProfile.Show(); // open main window
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var managePayment = new ManagePayment();
            managePayment.Closed += (s, args) => this.Close();
            managePayment.Show(); // open main window
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // close member window
            var backpage = new Login();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open mambership options window
        }
    }
}
