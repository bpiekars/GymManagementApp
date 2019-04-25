using System;
using System.Windows.Forms;

namespace ToyProject
{
    public partial class MembershipOptions : Form
    {
        public MembershipOptions()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            String fileLocation = ""; // default value
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*"; // only allow .jpg or .png image files

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileLocation = dialog.FileName;
                    profPicture.ImageLocation = fileLocation;
                }
            } catch (Exception) {
                MessageBox.Show("File failed to upload, please try again", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void profPicture_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String memPlan = memBox.Text;
            String cost = totalBox.Text;
            String paymentType = payMethod.Text;
            String creditCardNum = cardNumber.Text;
            String expirationDate = expirDate.Text;
            String CVC = cvcNumber.Text;
            String zipcode = postalCode.Text;
            String country = countryBox.Text;

            long test = 0; // test long
            bool canConvert = long.TryParse(creditCardNum, out test); // check if string is in long form
            if ((creditCardNum.Length == 16) && (canConvert)) // 16 is the length for most credit card numbers
            {
                MessageBox.Show("Payment successfully processed!", "Success");
                this.Hide(); // close membership options window
                var dashboard = new Member();
                dashboard.Closed += (s, args) => this.Close();
                dashboard.Show(); // open membership dashboard
            }
            else
            {
                MessageBox.Show("Please enter a 16 digit credit card number with no spaces or dashes", "Error");
                cardNumber.Text = ""; // clear the text box
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String memPlan = memBox.Text;
            String salesTax = costBox.Text;
            float memCost, totalTax, totalCost;

            if (memPlan == "Standard - 30 Days") {
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

        private void MembershipOptions_Load(object sender, EventArgs e)
        {

        }

        private void costBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void taxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // close membership options window
            var backpage = new Login();
            backpage.Closed += (s, args) => this.Close();
            backpage.Show(); // open login window
        }
    }
}
