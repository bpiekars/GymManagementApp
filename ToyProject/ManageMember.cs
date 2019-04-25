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
    public partial class ManageMember : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public ManageMember()
        {
            // MySQL database details
            server = "group11.cu0mxv30vcyo.us-east-1.rds.amazonaws.com";
            database = "group11";
            uid = "group11";
            password = "mypassword";

            string connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};"; // default port is 3306

            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    string query = "select FleetName, FleetID from fleets";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Login");
                    membersBox.DisplayMember = "username";
                    membersBox.ValueMember = "account_type";
                    membersBox.DataSource = ds.Tables["Login"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // close this window
            var backpage = new Employee();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open Employee window
        }

        private void ManageMember_Load(object sender, EventArgs e)
        {

        }
    }
}
