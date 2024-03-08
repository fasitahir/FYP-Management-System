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
    public partial class assignAdvisorsUC : UserControl
    {
        int projectId, advisorId =0;

        public assignAdvisorsUC()
        {
            InitializeComponent();
            advisorDataView.CellClick += advisorDataView_CellClick;
        }


        private void sizesetProject()
        {
            for (int i = 0; i < projectDataView.Columns.Count; i++)
            {
                projectDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void sizesetAdvisor()
        {
            for (int i = 0; i < projectDataView.Columns.Count; i++)
            {
                advisorDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void sizesetAssigned()
        {
            for (int i = 0; i < projectDataView.Columns.Count; i++)
            {
                assignedDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void showProjectsData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id, Description, Title " +
               "FROM Project P " +
               "WHERE Title NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            projectDataView.DataSource = dt;
            sizesetProject();
            projectLabel.Show();
            advisorLabel.Hide();
            assignedLabel.Hide();
            assignedDataView.Hide();
            projectDataView.Show();
            advisorDataView.Hide();
            projectDataView.BringToFront();
        }

        private void showProjects_Click(object sender, EventArgs e)
        {
            showProjectsData();
        }

        private void viewAdvisorsBtn_Click(object sender, EventArgs e)
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
            sizesetAdvisor();
            projectLabel.Hide();
            advisorLabel.Show();
            projectDataView.Hide();
            assignedLabel.Hide();
            assignedDataView.Hide();
            advisorDataView.Show();
            advisorDataView.BringToFront();

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = projectDataView.Rows[e.RowIndex];
                string idString = selectedRow.Cells["Id"].Value.ToString();
                if(!string.IsNullOrWhiteSpace(idString))
                {
                    projectId = int.Parse(idString);
                }
            }
        }


        private void advisorDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = advisorDataView.Rows[e.RowIndex];
                string idString = selectedRow.Cells["Id"].Value.ToString();
                if (!string.IsNullOrWhiteSpace(idString))
                {
                    advisorId = int.Parse(idString);
                }
            }
        }


        private void viewAssigned_Click(object sender, EventArgs e)
        {
            showAssignedData();
        }

        public void showAssignedData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select L.Value AS Designation, " +
               "FirstName, LastName, Title, L2.Value AS AdvisorRole " +
               "FROM Advisor A " +
               "JOIN Person P ON P.Id = A.Id " +
               "JOIN Lookup L ON L.Id = A.Designation " +
               "JOIN ProjectAdvisor PA ON PA.AdvisorId = A.Id " +
               "JOIN Project Proj ON Proj.Id = PA.ProjectId " +
               "JOIN Lookup L2 ON L2.Id = AdvisorRole " +
               "WHERE FirstName NOT LIKE '%*' OR Title NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            assignedDataView.DataSource = dt;
            sizesetAssigned();
            projectLabel.Hide();
            advisorLabel.Hide();
            projectDataView.Hide();
            advisorDataView.Hide();
            assignedLabel.Show();
            assignedDataView.Show();
            assignedDataView.BringToFront();
        }

        private void assignAdvBtn_Click(object sender, EventArgs e)
        {
            string roleString = advRole_CB.Text.ToLower();
            int role = 0;
            try
            {


                var con = Configuration.getInstance().getConnection();
                SqlCommand check = new SqlCommand("SELECT COUNT(*) " +
                    "FROM ProjectAdvisor " +
                    "WHERE @AdvisorId = AdvisorId AND @ProjectId = ProjectId", con);
                check.Parameters.AddWithValue("@AdvisorId", advisorId);
                check.Parameters.AddWithValue("@ProjectId", projectId);

                int checkId = (int)check.ExecuteScalar();
                if (checkId > 0)
                {
                    MessageBox.Show("Advisors can not be assign same advisor to same project more than one time");
                    return;
                }

                if (roleString == "main advisor")
                {
                    role = 11;
                }
                else if (roleString == "co-advisor")
                {
                    role = 12;
                }
                else if (roleString == "industry advisor")
                {
                    role = 13;
                }
                else
                {
                    MessageBox.Show("Please select a valid advisor role");
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO ProjectAdvisor " +
                    "VALUES (@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate) ", con);

                if (projectId == 0)
                {
                    MessageBox.Show("Please select a project from the table");
                    return;
                }
                if (advisorId == 0)
                {
                    MessageBox.Show("Please select a advisor from the table");
                    return;
                }
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                cmd.Parameters.AddWithValue("@AdvisorId", advisorId);
                cmd.Parameters.AddWithValue("@AdvisorRole", role);

                cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }


    }
}
