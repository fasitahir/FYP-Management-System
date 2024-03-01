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

namespace DBMidProject
{
    public partial class UpdateStdUC : UserControl
    {
        private int id;
        public UpdateStdUC()
        {
            InitializeComponent();
            ShowData();
            stdFirstName.KeyDown += TextBox_KeyDown;
            stdLastName.KeyDown += TextBox_KeyDown;
            stdContact.KeyDown += TextBox_KeyDown;
            stdEmail.KeyDown += TextBox_KeyDown;
            stdDob.KeyDown += TextBox_KeyDown;
            stdGender.KeyDown += TextBox_KeyDown;
            stdRegNo.KeyDown += TextBox_KeyDown;
            searchBar.KeyDown += TextBox_KeyDown;
        }

        private void studentDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = studentDataView.Rows[e.RowIndex];
                string regNo = selectedRow.Cells["RegistrationNo"].Value.ToString();
                string fname = selectedRow.Cells["FirstName"].Value.ToString();
                string lname = selectedRow.Cells["LastName"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string dob = selectedRow.Cells["DateOfBirth"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                id = int.Parse(selectedRow.Cells["Id"].Value.ToString());

                stdRegNo.Text = regNo;
                stdContact.Text = contact;
                stdFirstName.Text = fname;
                stdLastName.Text = lname;
                stdEmail.Text = email;
                if (gender == "1")
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                stdGender.Text = gender;
                stdDob.Value = DateTime.Parse(dob);

            }
        }



        public void ShowData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select S.Id, RegistrationNo, FirstName, LastName, Contact, Email, DateOfBirth, Gender " +
                "FROM Student S " +
                "JOIN Person P ON P.Id = S.Id " +
                "WHERE RegistrationNo NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentDataView.DataSource = dt;
            sizeset();
        }


        private void sizeset()
        {
            for (int i = 0; i < studentDataView.Columns.Count; i++)
            {
                studentDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void updateStdBtn_Click(object sender, EventArgs e)
        {
            int gender;
            var con = Configuration.getInstance().getConnection();

            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegistrationNo = @NewRegistrationNo AND Id <> @Id", con);
            checkCmd.Parameters.AddWithValue("@NewRegistrationNo", stdRegNo.Text);
            checkCmd.Parameters.AddWithValue("@Id", id);

            int registrationCount = (int)checkCmd.ExecuteScalar();

            if (registrationCount > 0)
            {
                MessageBox.Show("RegistrationNo already exists. Please choose a different one.");
                return;  // Exit the method, preventing the update
            }

            SqlCommand cmd = new SqlCommand("UPDATE Person " +
            "SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email" +
            ", DateOfBirth = @DateOfBirth, Gender = @Gender " +
            "WHERE @Id = Id;" +
            "UPDATE Student " +
            "SET RegistrationNo = @RegistrationNo " +
            "WHERE @Id = Id", con);

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

            if (isfname && islname && iscontact && isregNo && isemail)
            {
                cmd.Parameters.AddWithValue("@FirstName", stdFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", stdLastName.Text);
                cmd.Parameters.AddWithValue("@Contact", stdContact.Text);
                cmd.Parameters.AddWithValue("@Email", stdEmail.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", stdDob.Value);
                cmd.Parameters.AddWithValue("@RegistrationNo", stdRegNo.Text);
                cmd.Parameters.AddWithValue("@Id", id);

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

            }

            ShowData();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT S.Id, RegistrationNo, FirstName, LastName, Contact, Email, DateOfBirth, Gender " +
                "FROM Student S " +
                "JOIN Person P ON P.Id = S.Id " +
                "WHERE @SearchText LIKE CONVERT(NVARCHAR(MAX), S.Id) OR @SearchText LIKE CONVERT(NVARCHAR(MAX), P.Id) " +
                "OR @SearchText LIKE LOWER(RegistrationNo) OR @SearchText LIKE LOWER(FirstName) " +
                "OR @SearchText LIKE LOWER(LastName) OR @SearchText LIKE Contact " +
                "OR @SearchText LIKE  LOWER(Email) OR @SearchText LIKE CONVERT(NVARCHAR(MAX),DateOfBirth) " +
                "OR @SearchText LIKE LOWER(Gender)", con);

            cmd.Parameters.AddWithValue("@SearchText", searchBar.Text.ToLower());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentDataView.DataSource = dt;
            sizeset();
        }

        private void showDataBtn_Click(object sender, EventArgs e)
        {
            ShowData();
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Check if the current textbox is the last one
                if (sender == searchBar)
                {
                    searchBtn.PerformClick();
                }
                if(sender == stdDob)
                {
                    updateStdBtn.PerformClick();
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
