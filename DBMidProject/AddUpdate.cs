using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class AddUpdate : UserControl
    {
        int id = 0;

        public AddUpdate()
        {
            InitializeComponent();
            ShowData();
        }

        private void addProBtn_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();


            SqlCommand cmd = new SqlCommand(
            "INSERT INTO Project (Description, Title) " +
            "VALUES (@Description, @Title)", con);



            string title = proTitle.Text;
            string description = proDescription.Text;

            if (!string.IsNullOrWhiteSpace(title))
            {
                cmd.Parameters.AddWithValue("@Title", title);
                if (string.IsNullOrWhiteSpace(description))
                {
                    cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Description", description);
                }
                cmd.ExecuteNonQuery();
                ShowData();
            }
            else
            {
                MessageBox.Show("Title can not be empty");
            }

        }

        private void ShowData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id, Description, Title " +
               "FROM Project P " +
               "WHERE Title NOT LIKE '%*'", con);
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id, Description, Title " +
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

        private void projectDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = projectDataView.Rows[e.RowIndex];
                string idString = selectedRow.Cells["Id"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();
                string title = selectedRow.Cells["Title"].Value.ToString();
                if (!string.IsNullOrEmpty(idString))
                {
                    id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                }

                proTitle.Text = title;
                proDescription.Text = description;
                
            }
        }

        private void updateProBtn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select a row from tabel to update record");
                return;
            }
            var con = Configuration.getInstance().getConnection();


            SqlCommand cmd = new SqlCommand(
            "UPDATE Project " +
            "SET Description = @Description, Title = @Title " +
            "WHERE @Id = Id", con);

            cmd.Parameters.AddWithValue("@Id", id);

            string title = proTitle.Text;
            string description = proDescription.Text;

            if (!string.IsNullOrWhiteSpace(title))
            {
                cmd.Parameters.AddWithValue("@Title", title);
                if (string.IsNullOrWhiteSpace(description))
                {
                    cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Description", description);
                }
                cmd.ExecuteNonQuery();
                ShowData();
            }
            else
            {
                MessageBox.Show("Title can not be empty");
            }
        }
    }
}
