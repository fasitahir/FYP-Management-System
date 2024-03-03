using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class AddAdvisor : UserControl
    {
        public AddAdvisor()
        {
            InitializeComponent();
            advSalary.KeyDown += TextBox_KeyDown;
            designationAdv.KeyDown += TextBox_KeyDown;
            advFirstName.KeyDown += TextBox_KeyDown;
            advLastName.KeyDown += TextBox_KeyDown;
            advContact.KeyDown += TextBox_KeyDown;
            advEmail.KeyDown += TextBox_KeyDown;
            advDob.KeyDown += TextBox_KeyDown;
            advGender.KeyDown += TextBox_KeyDown;
        }

        private void addStdBtn_Click(object sender, EventArgs e)
        {
            int designation;
            int gender;
            var con = Configuration.getInstance().getConnection();


            SqlCommand cmd = new SqlCommand(
            "INSERT INTO Person " +
            "VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender)" +
            "INSERT INTO Advisor " +
            "VALUES ((SELECT MAX(Id) FROM Person), @Designation, @Salary) ", con);

            string selectedDesignation = designationAdv.Text;

            if (selectedDesignation.ToLower() == "professor")
            {
                designation = 6;
            }
            else if (selectedDesignation.ToLower() == "associate professor")
            {
                designation = 7;
            }
            else if (selectedDesignation.ToLower() == "assisstant professor")
            {
                designation = 8;
            }
            else if (selectedDesignation.ToLower() == "lecturer")
            {
                designation = 9;
            }
            else if (selectedDesignation.ToLower() == "industry professional")
            {
                designation = 10;
            }
            else
            {
                designation = 0;
            }

            string selectedGender = advGender.Text;

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

            string fname = advFirstName.Text;
            string lname = advLastName.Text;
            string contact = advContact.Text;
            string email = advEmail.Text;
            string salary = advSalary.Text;

            bool isfname = Validation.NameValidation(fname);
            bool islname = Validation.NameValidation(lname);
            bool iscontact = Validation.IntValidation(contact);
            bool isemail = !string.IsNullOrWhiteSpace(email);
            bool isSalary = Validation.DoubleValidation(salary);




            if (isfname && (islname || string.IsNullOrWhiteSpace(lname))
                && (iscontact || string.IsNullOrWhiteSpace(contact)) && isemail 
                && (isSalary || string.IsNullOrWhiteSpace(salary)) && designation != 0)
            {
                cmd.Parameters.AddWithValue("@FirstName", fname);

                //Add Last Name and Allow Null value
                if (string.IsNullOrWhiteSpace(lname))
                {
                    cmd.Parameters.AddWithValue("@LastName", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@LastName", lname);
                }

                //Add Contact and Allow Null value
                if (string.IsNullOrWhiteSpace(contact))
                {

                    cmd.Parameters.AddWithValue("@Contact", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Contact", contact);
                }

                cmd.Parameters.AddWithValue("@Email", email);

                //Add Gender and Allow Null value
                
                if (gender == 0)
                {
                    cmd.Parameters.AddWithValue("@Gender", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Gender", gender);
                }

                //Add Date of birth and alow null value
                if (advDob.Value.Date >= DateTime.Now.Date)
                {
                    cmd.Parameters.AddWithValue("@DateOfBirth", advDob.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
                }
                if(string.IsNullOrWhiteSpace(salary))
                {
                    cmd.Parameters.AddWithValue("@Salary", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Salary", float.Parse(salary));
                }
                cmd.Parameters.AddWithValue("@Designation", designation);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");
            }
            //Show error messages
            else
            {
                if (!isfname)
                {
                    MessageBox.Show("Name can not have digits or symbol and it can not be empty");
                }
                else if(!islname && !string.IsNullOrWhiteSpace(lname))
                {
                    MessageBox.Show("Last Name can not have digits or symbol");
                }
                else if (!iscontact && !string.IsNullOrWhiteSpace(contact))
                {
                    MessageBox.Show("Contact can not have alphabets or symbol");
                }
                else if (!isemail)
                {
                    MessageBox.Show("You can not leave email empty");
                }
                else if (!isSalary && !string.IsNullOrWhiteSpace(salary))
                {
                    MessageBox.Show("Salary can not have alphabets or symbol and it can not be empty");
                }
                else if (designation == 0)
                {
                    MessageBox.Show("Please Select Designation");
                }
            }
            
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Check if the current textbox is the last one
                if (sender == designationAdv)
                {
                    addAdvBtn.PerformClick();
                }

                else
                {
                    // Move to the next control in the tab index order
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

    }
}
