using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ToyProject
{
    public partial class RegisterNewEmployee : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public RegisterNewEmployee()
        {
            // MySQL database details
            server = "group11.cu0mxv30vcyo.us-east-1.rds.amazonaws.com";
            database = "group11";
            uid = "group11";
            password = "mypassword";

            string connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};"; // default port is 3306
            conn = new MySqlConnection(connString);

            InitializeComponent();
        }

        private void RegisterNewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String firstName = firstNameBox.Text;
            String lastName = lastNameBox.Text;
            String address = addressBox.Text;
            String phoneNo = phoneBox.Text;
            String salary = salaryBox.Text;
            String birthday = birthBox.Text;
            String schedule = null; // not done
            Random rnd = new Random();
            int employee_id = rnd.Next(); // generate a random employee id number

            HireEmployee(employee_id, firstName, lastName, address, phoneNo, salary, schedule, birthday);

            MessageBox.Show("Successfully registered new employee. Employee ID is " + employee_id);
            this.Hide();
            var manage = new Manager();
            manage.Closed += (s, args) => this.Close();
            manage.Show(); // open main window
        }

        public bool HireEmployee(int employee_id, string first_name, string last_name, string address, string phone_number, string salary, string schedule, string birthday)
        {
            string query = $"INSERT INTO Employee (idEmployee, first_name, last_name, address, phone_number, salary, schedule, birthday) VALUES ('{employee_id}', '{first_name}', '{last_name}', '{address}', '{phone_number}', '{salary}', '{schedule}', '{birthday}');";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed!");
                        break;
                }
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // close register new employee window
            var backpage = new Manager();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open manager window
        }
    }
}
