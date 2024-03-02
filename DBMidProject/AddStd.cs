using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMidProject
{
    public partial class AddStd : UserControl
    {
        public AddStd()
        {
            InitializeComponent();
            stdFirstName.KeyDown += TextBox_KeyDown;
            stdLastName.KeyDown += TextBox_KeyDown;
            stdContact.KeyDown += TextBox_KeyDown;
            stdEmail.KeyDown += TextBox_KeyDown;
            stdDob.KeyDown += TextBox_KeyDown;
            stdGender.KeyDown += TextBox_KeyDown;
            stdRegNo.KeyDown += TextBox_KeyDown;

        }

        private void ManageStd_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Check if the current textbox is the last one
                if (sender == stdRegNo)
                {
                    addStdBtn.PerformClick();
                }
                
               else 
               {
                    // Move to the next control in the tab index order
                    SelectNextControl((Control)sender, true, true, true, true);
               }
            }
        }

        private void addStdBtn_Click(object sender, EventArgs e)
        {
            int gender;
            var con = Configuration.getInstance().getConnection();

            SqlCommand check = new SqlCommand("SELECT COUNT(RegistrationNo) FROM Student WHERE LOWER(RegistrationNo) = LOWER(@RegistrationNo)", con);
            check.Parameters.AddWithValue("@RegistrationNo", stdRegNo.Text);
            int checkRegNo = (int)check.ExecuteScalar();

            if (checkRegNo == 0)
            {
                SqlCommand cmd = new SqlCommand(
                "INSERT INTO Person " +
                "VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender)" +
                "INSERT INTO Student (Id, RegistrationNo) VALUES ((SELECT MAX(Id) FROM Person), @RegistrationNo)",
                con);

                string selectedGender = stdGender.Text;

                if (selectedGender.ToLower() == "male")
                {
                    gender = 1;
                }
                else if (selectedGender.ToLower() == "female")
                {
                    gender = 2;
                }
                else
                {
                    gender = 0;
                }

                string fname = stdFirstName.Text;
                string lname = stdLastName.Text;
                string contact = stdContact.Text;
                string email = stdEmail.Text;
                string regNo = stdRegNo.Text;

                bool isfname = Validation.NameValidation(fname);
                bool islname = Validation.NameValidation(lname);
                bool iscontact = Validation.IntValidation(contact);
                bool isregNo = !string.IsNullOrWhiteSpace(regNo);
                bool isemail = !string.IsNullOrWhiteSpace(email);

                if (isfname && islname && iscontact && isregNo && isemail && gender != 0)
                {
                    cmd.Parameters.AddWithValue("@FirstName", stdFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", stdLastName.Text);
                    cmd.Parameters.AddWithValue("@Contact", stdContact.Text);
                    cmd.Parameters.AddWithValue("@Email", stdEmail.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@DateOfBirth", stdDob.Value);
                    cmd.Parameters.AddWithValue("@RegistrationNo", stdRegNo.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully saved");
                }

                else
                {
                    if (!isfname || !islname)
                    {
                        MessageBox.Show("Name can not have digits or symbol and it can not be empty");
                    }
                    else if (!iscontact)
                    {
                        MessageBox.Show("Contact can not have alphabets or symbol and it can not be empty");
                    }
                    else if (!isregNo && !isemail)
                    {
                        MessageBox.Show("You can not leave any field empty");
                    }
                    else if(gender == 0)
                    {
                        MessageBox.Show("Please select Gender");
                    }
                }
            }

            else
            {
                MessageBox.Show("Stuent with this registration number already exist");
            }
            

        }
    }
}
