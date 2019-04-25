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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void updateEmpSched_Click(object sender, EventArgs e)
        {
            this.Hide();
            var schedule = new UpdateEmployeeSchedule();
            schedule.Closed += (s, args) => this.Close();
            schedule.Show(); // open main window
        }

        private void updateProf_Click(object sender, EventArgs e)
        {
            this.Hide();
            var updateProfile = new UpdateProfile();
            updateProfile.Closed += (s, args) => this.Close();
            updateProfile.Show(); // open main window
        }

        private void manageEmpSal_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manageSal = new ManageEmployeeSalary();
            manageSal.Closed += (s, args) => this.Close();
            manageSal.Show(); // open main window
        }

        private void newEmpBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // close login window
            var newEmp = new RegisterNewEmployee();
            newEmp.Closed += (s, args) => this.Close();
            newEmp.Show(); // open main window
        }

        private void updateEmpRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            var updateRecords = new UpdateEmployeeRecords();
            updateRecords.Closed += (s, args) => this.Close();
            updateRecords.Show(); // open main window
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // close manager window
            var backpage = new Login();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open login window
        }
    }
}
