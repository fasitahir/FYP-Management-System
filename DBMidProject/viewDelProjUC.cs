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
    public partial class viewDelProjUC : UserControl
    {
        int id = 0;
        public viewDelProjUC()
        {
            InitializeComponent();
            ShowCurrentData();
            searchBar.KeyDown += TextBox_KeyDown;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id,  Title, Description " +
                "FROM Project P " +
                "WHERE Id LIKE @searchText " +
                "OR LOWER(Description) LIKE LOWER(@searchText) " +
                "OR LOWER(Title) LIKE LOWER(@searchText) ", con);
            string searchText = searchBar.Text.ToString();

            cmd.Parameters.AddWithValue("@searchText", searchText);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            projectDataView.DataSource = dt;
            sizeset();
        }

        private void sizeset()
        {
            for (int i = 0; i < projectDataView.Columns.Count; i++)
            {
                projectDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void ShowCurrentData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id,  Title, Description " +
               "FROM Project P " +
               "WHERE Title NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            projectDataView.DataSource = dt;
            sizeset();
            noteLabel.Hide();
        }

        private void ShowAllData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id,  Title, Description " +
               "FROM Project P ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            projectDataView.DataSource = dt;
            sizeset();
            noteLabel.Show();
            noteLabel.BringToFront();
        }

        private void viewCurrent_btn_Click(object sender, EventArgs e)
        {
            ShowCurrentData();
            
        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            ShowAllData();
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                MessageBox.Show("Please select a row to delete it");
                return;
            }

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Project " +
                "SET Title = Title+'*' " +
                "WHERE Id = @Id", con);

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            ShowCurrentData();
        }

        private void projectDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = projectDataView.Rows[e.RowIndex];
                string idString = selectedRow.Cells["Id"].Value.ToString();
                if (!string.IsNullOrEmpty(idString))
                {
                    id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                }


            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

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
    }
}
