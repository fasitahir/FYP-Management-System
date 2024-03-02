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
        public ViewAdvisorUC()
        {
            InitializeComponent();
            searchBar.KeyDown += TextBox_KeyDown;
            
        }

        public void ShowCurrentData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id, Salary, Designation " +
                "FROM Advisor " +
                "WHERE Designation NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Add a new column for the string representation of Designation
            dt.Columns.Add("DesignationString", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                int designationValue = Convert.ToInt32(row["Designation"]);

                switch (designationValue)
                {
                    case 6:
                        row["DesignationString"] = "Professor";
                        break;
                    case 7:
                        row["DesignationString"] = "Associate Professor";
                        break;
                    case 8:
                        row["DesignationString"] = "Assistant Professor";
                        break;
                    case 9:
                        row["DesignationString"] = "Lecturer";
                        break;
                    case 10:
                        row["DesignationString"] = "Industrial Professional";
                        break;
                    default:
                        break;
                }
            }

            // Remove the original Designation column if you don't need it anymore
            dt.Columns.Remove("Designation");

            // Rename the new column to Designation
            dt.Columns["DesignationString"].ColumnName = "Designation";

            advisorDataView.DataSource = dt;
            sizeset();
            noteLabel.Hide();
        }


        private void ShowAllData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id, Salary, Designation " +
                "FROM Advisor", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Add a new column for the string representation of Designation
            dt.Columns.Add("DesignationString", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                int designationValue = Convert.ToInt32(row["Designation"]);

                switch (designationValue)
                {
                    case 6:
                        row["DesignationString"] = "Professor";
                        break;
                    case 7:
                        row["DesignationString"] = "Associate Professor";
                        break;
                    case 8:
                        row["DesignationString"] = "Assistant Professor";
                        break;
                    case 9:
                        row["DesignationString"] = "Lecturer";
                        break;

                    case 10:
                        row["DesignationString"] = "Industrial Professional";
                        break;
                    default:
                        break;
                }
            }

            // Remove the original Designation column if you don't need it anymore
            dt.Columns.Remove("Designation");

            // Rename the new column to Designation
            dt.Columns["DesignationString"].ColumnName = "Designation";

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
            
            SqlCommand cmd = new SqlCommand("SELECT Id, Designation, Salary " +
                "FROM Advisor " +
                "WHERE @SearchText LIKE Id OR " +
                "@SearchText LIKE Designation OR " +
                "@SearchText LIKE Salary " +
                "AND Designation NOT LIKE '%*'", con);

            cmd.Parameters.AddWithValue("@SearchText", search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Add a new column for the string representation of Designation
            dt.Columns.Add("DesignationString", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                int designationValue = Convert.ToInt32(row["Designation"]);

                switch (designationValue)
                {
                    case 6:
                        row["DesignationString"] = "Professor";
                        break;
                    case 7:
                        row["DesignationString"] = "Associate Professor";
                        break;
                    case 8:
                        row["DesignationString"] = "Assistant Professor";
                        break;
                    case 9:
                        row["DesignationString"] = "Lecturer";
                        break;
                    default:
                        break;
                }
            }

            // Remove the original Designation column if you don't need it anymore
            dt.Columns.Remove("Designation");

            // Rename the new column to Designation
            dt.Columns["DesignationString"].ColumnName = "Designation";

            advisorDataView.DataSource = dt;
            sizeset();
        }
    }
}
