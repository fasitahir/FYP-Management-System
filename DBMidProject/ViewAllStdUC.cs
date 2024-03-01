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
    public partial class ViewAllStdUC : UserControl
    {
        public ViewAllStdUC()
        {
            InitializeComponent();
            ShowCurrentStudents();
            noteLabel.Hide();
            searchBar.KeyDown += TextBox_KeyDown;
        }

        private void sizeset()
        {
            for (int i = 0; i < studentDataView.Columns.Count; i++)
            {
                studentDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
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

                else
                {
                    // Move to the next control in the tab index order
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void allStdBtn_Click(object sender, EventArgs e)
        {
            ShowAllStudents();
            noteLabel.Show();
            noteLabel.BringToFront();
        }

        private void viewCurrent_btn_Click(object sender, EventArgs e)
        {
            ShowCurrentStudents();
        }

        private void ShowAllStudents()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select S.Id, RegistrationNo, FirstName, LastName, Contact, Email, DateOfBirth, Gender " +
                "FROM Student S " +
                "JOIN Person P ON P.Id = S.Id ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentDataView.DataSource = dt;
            sizeset();

        }

        public void ShowCurrentStudents()
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
    }
}
