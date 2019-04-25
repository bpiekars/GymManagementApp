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
    public partial class Login : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Login()
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

        public class UserDisplayName
        {
            public static string displayName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String error = "Error: One or more required fields missing"; // catch null or empty string arguments
            String username = textBox1.Text;
            String password = textBox2.Text;

            if (username == "")
            {
                MessageBox.Show("Please enter a valid username!", error);
            }
            else if (password == "")
            {
                MessageBox.Show("Please enter a valid password!", error);
            }
            else
            {
                IsLogin(username, password);

                if (IsLogin(username, password))
                {
                    conn.Open();
                    string typequery = $"SELECT account_type FROM login WHERE username='{username}' AND password='{password}';";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(typequery, conn);
                    myCommand.ExecuteNonQuery();
                    string type = Convert.ToString(myCommand.ExecuteScalar());
                    conn.Close();
                    MessageBox.Show($"Succesfully logged in as {username}! You are a {type}.");

                    if (type == "Member")
                    {
                        this.Hide(); // close login window
                        var mem = new Member();
                        mem.Closed += (s, args) => this.Close();
                        mem.Show(); // open member window
                    }
                    else if (type == "Employee")
                    {
                        this.Hide(); // close login window
                        var emp = new Employee();
                        emp.Closed += (s, args) => this.Close();
                        emp.Show(); // open employee window
                    }
                    else if (type == "Manager")
                    {
                        this.Hide(); // close login window
                        var manage = new Manager();
                        manage.Closed += (s, args) => this.Close();
                        manage.Show(); // open main window
                    }
                }
                else
                {
                    MessageBox.Show($"Couldn't login as {username}. Please ensure username and password are correct before trying again!");
                }
            }
        }

        public bool IsLogin(string username, string password)
        {
            string query = $"SELECT * FROM login WHERE username='{username}' AND password='{password}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // close login window
            var signup = new Signup();
            signup.Closed += (s, args) => this.Close();
            signup.Show(); // open signup window
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // exit program
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                    case 1045:
                        MessageBox.Show("Username or password inccorect!");
                        break;
                }
                return false;
            }
        }
    }
}