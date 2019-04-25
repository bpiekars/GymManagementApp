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
    public partial class Signup : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Signup()
        {
            server = "group11.cu0mxv30vcyo.us-east-1.rds.amazonaws.com";
            database = "group11";
            uid = "group11";
            password = "mypassword";

            // connect to sql server
            string connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};"; // default port is 3306
            conn = new MySqlConnection(connString);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = firstNameBox.Text;
            String lastName = lastNameBox.Text;
            String username = usernameBox.Text;
            String password = passwordBox.Text;
            String password_conf = passwordConfBox.Text;
            String email = emailBox.Text;
            String email_conf = emailConfBox.Text;
            String type = accountBox.Text;
            String gender = genderBox.Text;
            String phoneNo = phoneBox.Text;
            String address = addressBox.Text;
            Random rnd = new Random();
            int user_id = rnd.Next(); // generate a random user id number

            Register(user_id, username, password, email, type, firstName, lastName, gender, phoneNo, address);

            String error = "Error: One or more required fields missing"; // catch null or empty string arguments

            if (firstName == "")
            {
                MessageBox.Show("Please enter a first name", error);
            }
            else if (lastName == "")
            {
                MessageBox.Show("Please enter a last name", error);
            }
            else if (username == "")
            {
                MessageBox.Show("Please enter a username", error);
            }
            else if (password == "")
            {
                MessageBox.Show("Please enter a password", error);
            }
            else if ((password_conf == "") || (password != password_conf))
            {
                MessageBox.Show("Passwords don't match", error);
            }
            else if (type == "")
            {
                MessageBox.Show("Please select an account type", error);
            }
            else
            {
                this.Hide(); // close login window
                MessageBox.Show("Account created succesfully!", "Success");
                if (type == "Member") // depending on selected account type open different dashboard
                {
                    var dashboard = new MembershipOptions();
                    dashboard.Closed += (s, args) => this.Close();
                    dashboard.Show(); // open main window
                }
                else if (type == "Employee")
                {
                    var dashboard = new Employee();
                    dashboard.Closed += (s, args) => this.Close();
                    dashboard.Show(); // open main window
                }
                else if (type == "Manager")
                {
                    var dashboard = new Manager();
                    dashboard.Closed += (s, args) => this.Close();
                    dashboard.Show(); // open main window
                }
            }
        }

        public bool Register(int id, string username, string password, string email_address, string account_type, string first_name, string last_name, string gender, string phone_number, string address)
        {
            string query = $"INSERT INTO login (id, username, password, email_address, account_type, first_name, last_name, gender, phone_number, address) VALUES ('{id}', '{username}', '{password}', '{email_address}', '{account_type}', '{first_name}', '{last_name}', '{gender}', '{phone_number}', '{address}');";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // close login window
            var backpage = new Login();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open signup window
        }

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
