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
    public partial class UpdateProfile : Form
    {
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private void memBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String memPlan = memBox.Text;
            String salesTax = costBox.Text;
            float memCost, totalTax, totalCost;

            if (memPlan == "Standard - 30 Days")
            {
                costBox.Text = "39.99";
                costBox.Refresh();
            }
            else if (memPlan == "Standard - 6 Months")
            {
                costBox.Text = "249.99";
                costBox.Refresh();
            }
            else if (memPlan == "Standard - 12 Months")
            {
                costBox.Text = "499.99";
                costBox.Refresh();
            }
            else if (memPlan == "VIP - 30 Days")
            {
                costBox.Text = "59.99";
                costBox.Refresh();
            }
            else if (memPlan == "VIP - 6 Months")
            {
                costBox.Text = "349.99";
                costBox.Refresh();
            }
            else if (memPlan == "VIP - 12 Months")
            {
                costBox.Text = "649.99";
                costBox.Refresh();
            }
            else if (memPlan == "Lifetime")
            {
                costBox.Text = "1999.99";
                costBox.Refresh();
            }

            memCost = float.Parse(costBox.Text);
            totalTax = memCost * 0.045f; // 4.5% sales tax
            totalCost = memCost + totalTax; // total cost is the membership cost plus tax
            taxBox.Text = totalTax.ToString("c2"); // c2 - currency format with 2 decimal points and $
            totalBox.Text = totalCost.ToString("c2"); // c2 - currency format with 2 decimal points and $
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile updated! Membership options succesfully changed."); // not connected to database, so not really
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var member = new Member();
            member.Closed += (s, args) => this.Close();
            member.Show(); // go back
            // Note: this doesn't work the way it's supposed to, since every account type (member, employee, manager) has access to update profile page should go back to whatever
            // account type was logged in's dashboard page but didn't have time to finish
        }
    }
}
