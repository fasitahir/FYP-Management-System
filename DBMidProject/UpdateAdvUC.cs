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
    public partial class UpdateAdvUC : UserControl
    {
        int id = 0;
        public UpdateAdvUC()
        {
            InitializeComponent();
            ShowData();
            advSalary.KeyDown += TextBox_KeyDown;
            designationAdv.KeyDown += TextBox_KeyDown;
            advFirstName.KeyDown += TextBox_KeyDown;
            advLastName.KeyDown += TextBox_KeyDown;
            advContact.KeyDown += TextBox_KeyDown;
            advEmail.KeyDown += TextBox_KeyDown;
            advDob.KeyDown += TextBox_KeyDown;
            advGender.KeyDown += TextBox_KeyDown;
        }




        public void ShowData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select A.Id, L.Value AS Designation, Salary, " +
                "FirstName, LastName, Contact, Email, DateOfBirth, Gender " +
               "FROM Advisor A " +
               "JOIN Person P ON P.Id = A.Id " +
               "JOIN Lookup L ON L.Id = A.Designation " +
               "WHERE FirstName NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            advisorDataView.DataSource = dt;
            sizeset();
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
                    searchBtn.Focus();
                    searchBtn.PerformClick();
                }
                if(sender == designationAdv)
                {
                    updateAdvBtn.Focus();
                    updateAdvBtn.PerformClick();
                }
                else
                {
                    // Move to the next control in the tab index order
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }




        private void sizeset()
        {
            for (int i = 0; i < advisorDataView.Columns.Count; i++)
            {
                advisorDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void advisorDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = advisorDataView.Rows[e.RowIndex];
                string idString = selectedRow.Cells["Id"].Value.ToString();
                string salary = selectedRow.Cells["Salary"].Value.ToString();
                string fname = selectedRow.Cells["FirstName"].Value.ToString();
                string lname = selectedRow.Cells["LastName"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string dob = selectedRow.Cells["DateOfBirth"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string designation = selectedRow.Cells["Designation"].Value.ToString();
                id = int.Parse(selectedRow.Cells["Id"].Value.ToString());

                advSalary.Text = salary;
                advContact.Text = contact;
                advFirstName.Text = fname;
                advLastName.Text = lname;
                advEmail.Text = email;

                if (gender == "1")
                {
                    gender = "Male";
                }
                else if (gender == "2")
                {
                    gender = "Female";
                }
                else
                {
                    gender = null;
                }
                advGender.Text = gender;

                designationAdv.Text = designation;

                if (!string.IsNullOrWhiteSpace(dob))
                {

                    advDob.Value = DateTime.Parse(dob);
                }
                else
                {
                    advDob.Value = DateTime.Now;
                }



            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string searchText = searchBar.Text.ToLower();
            int search = 0;

            if (searchText.ToLower() == "professor")
            {
                search = 6;
            }
            else if (searchText.ToLower() == "associate professor")
            {
                search = 7;
            }
            else if (searchText.ToLower() == "assisstant professor")
            {
                search = 8;
            }
            else if (searchText.ToLower() == "lecturer")
            {
                search = 9;
            }
            else if (searchText.ToLower() == "industry professional")
            {
                search = 10;
            }

            SqlCommand cmd = new SqlCommand("Select A.Id, L.Value AS Designation, Salary, " +
                "FirstName, LastName, Contact, Email, DateOfBirth, Gender " +
                "FROM Advisor A " +
                "JOIN Person P ON P.Id = A.Id " +
                "JOIN Lookup L ON L.Id = A.Designation " +
                "WHERE @SearchText LIKE A.Id OR " +
                "@SearchDesignation LIKE Designation OR " +
                "@SearchText LIKE Salary OR @SearchText LIKE LOWER(FirstName) " +
                "OR @SearchText LIKE LOWER(LastName) OR @SearchText LIKE Contact " +
                "OR @SearchText LIKE  LOWER(Email) " +
                "OR @SearchText LIKE CONVERT(NVARCHAR(MAX),DateOfBirth) " +
                "OR @SearchText LIKE LOWER(Gender)", con);

            cmd.Parameters.AddWithValue("@SearchText", searchText);
            cmd.Parameters.AddWithValue("@SearchDesignation", search);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            advisorDataView.DataSource = dt;
            sizeset();
        }

        private void updateAdvBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please Select a row from table to update it");
                return;
            }

            int gender, designation;
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("UPDATE Person " +
            "SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email" +
            ", DateOfBirth = @DateOfBirth, Gender = @Gender " +
            "WHERE @Id = Id;" +
            "UPDATE Advisor " +
            "SET Designation = @Designation, Salary = @Salary " +
            "WHERE @Id = Id", con);

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
                if (advDob.Value.Date < DateTime.Now.Date)
                {
                    cmd.Parameters.AddWithValue("@DateOfBirth", advDob.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
                }
                if (string.IsNullOrWhiteSpace(salary))
                {
                    cmd.Parameters.AddWithValue("@Salary", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Salary", float.Parse(salary));
                }
                cmd.Parameters.AddWithValue("@Designation", designation);
                
                cmd.Parameters.AddWithValue("@Id", id);


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
                else if (!islname && !string.IsNullOrWhiteSpace(lname))
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

            ShowData();
        }
    }
}
