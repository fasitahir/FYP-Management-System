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
    public partial class assignProjectUC : UserControl
    {
        int id = 0;
        public assignProjectUC()
        {
            InitializeComponent();

        }

        private void sizeset()
        {
            for (int i = 0; i < projectDataView.Columns.Count; i++)
            {
                projectDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void ShowProjectData()
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

        private void searchBtn_Click_1(object sender, EventArgs e)
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


        public void loadComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT GroupId " +
            "FROM GroupStudent " +
            "WHERE Status <> 4 " + 
            "GROUP BY GroupId " ,con);

            SqlDataReader reader = cmd.ExecuteReader();
            
            while(reader.Read())
            {
                groupId_CB.Items.Add(reader["GroupId"].ToString());  
            }
            reader.Close();
        }

        private void assignProjectBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(groupId_CB.Text))
            {
                MessageBox.Show("Please Select group id");
                return;
            }
            else if (id == 0)
            {
                MessageBox.Show("Please Select Poject from table");
                return;
            }

            var con = Configuration.getInstance().getConnection();
            SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM GroupProject WHERE ProjectId = @ProjectId", con);
            check.Parameters.AddWithValue("@ProjectId", id);
            int groupIdCheck = (int)check.ExecuteScalar();
            if (groupIdCheck > 0)
            {
                MessageBox.Show("Project already exist");
                return;
            }

            SqlCommand check2 = new SqlCommand("SELECT COUNT(*) FROM GroupProject WHERE GroupId = @GroupId", con);
            check2.Parameters.AddWithValue("@GroupId", int.Parse(groupId_CB.Text));
            int projectIdCheck = (int)check2.ExecuteScalar();
            if (projectIdCheck > 0)
            {
                MessageBox.Show("Group already exist");
                return;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO GroupProject " +
                "VALUES (@ProjectId, @GroupId, @AssignmentDate) ", con);
            
           
            cmd.Parameters.AddWithValue("@GroupId",int.Parse(groupId_CB.Text));
            cmd.Parameters.AddWithValue("@ProjectId", id);
            cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
            ShowAssignedProjects();
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

        public void ShowAssignedProjects()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT GP.GroupId, GP.ProjectId, P.Title, P.Description " +
               "FROM GroupProject GP " +
               "JOIN Project P ON P.Id = GP.ProjectId " +
               "WHERE P.Title NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sizeset();

        }
    }
}
