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
    public partial class ViewAdvisorUC : UserControl
    {
        int id = 0;
        public ViewAdvisorUC()
        {
            InitializeComponent();
            searchBar.KeyDown += TextBox_KeyDown;
            
        }

        public void ShowCurrentData()
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
            noteLabel.Hide();
        }


        private void ShowAllData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select A.Id, L.Value AS Designation, Salary, " +
                "FirstName, LastName, Contact, Email, DateOfBirth, Gender " +
               "FROM Advisor A " +
               "JOIN Person P ON P.Id = A.Id " +
               "JOIN Lookup L ON L.Id = A.Designation ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            advisorDataView.DataSource = dt;
            sizeset();
            noteLabel.Show();
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




        private void sizeset()
        {
            for (int i = 0; i < advisorDataView.Columns.Count; i++)
            {
                advisorDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void viewCurrent_btn_Click(object sender, EventArgs e)
        {
            ShowCurrentData();
        }

        private void allStdBtn_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string searchText =   searchBar.Text.ToLower();
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

        private void deleteAdvBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select tupple which you want to delete");
                return;
            }

            var con = Configuration.getInstance().getConnection();
            SqlCommand delete_cmd = new SqlCommand("UPDATE Person " +
                "SET FirstName = FirstName + '*' " +
                "FROM Person P " +
                "JOIN Advisor A ON P.Id = A.Id " +
                "WHERE A.Id = @Id", con);

            delete_cmd.Parameters.AddWithValue("@Id", id);

            delete_cmd.ExecuteNonQuery();
            ShowCurrentData();
        }

        private void advisorDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = advisorDataView.Rows[e.RowIndex];
                string idString = selectedRow.Cells["Id"].Value.ToString();

                id = int.Parse(idString);
            }
        }
    }
}
