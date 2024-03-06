using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class viewDelGrp : UserControl
    {
        int groupId = 0;
        public viewDelGrp()
        {
            InitializeComponent();
            
        }




        private void sizeset()
        {
            for (int i = 0; i < grpDataView.Columns.Count; i++)
            {
                grpDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int searchStatus = 0;
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT GroupId, StudentId, RegistrationNo, L.Value AS Status, AssignmentDate, Created_On " +
                    "FROM GroupStudent " +
                    "JOIN Student S ON S.Id = StudentId " +
                    "JOIN [Group] G ON G.Id = GroupId " +
                    "JOIN Lookup L ON L.Id = Status " +
                    "WHERE Status LIKE @searchStatus OR GroupId LIKE @searchText OR " +
                    "StudentId LIKE @searchText OR RegistrationNo LIKE @searchText " +
                    "OR AssignmentDate LIKE @searchText OR Created_ON LIKE @searchText", con);
                string searchText = searchBar.Text.ToString();

                if (searchText.ToLower() == "active")
                {
                    searchStatus = 3;
                }
                else if (searchText.ToLower() == "inactive")
                {
                    searchStatus = 4;
                }

                cmd.Parameters.AddWithValue("@searchText", searchText);
                cmd.Parameters.AddWithValue("@searchStatus", searchStatus);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grpDataView.DataSource = dt;
                sizeset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            viewAllData();
        }

        private void viewCurrent_Click(object sender, EventArgs e)
        {
            viewCurrentData();
        }

        private void viewAllData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT GroupId, StudentId, RegistrationNo, L.Value AS Status ,AssignmentDate, Created_On " +
                "FROM GroupStudent " +
                "JOIN Student S ON S.Id = StudentId " +
                "JOIN [Group] G ON G.Id = GroupId " +
                "JOIN Lookup L ON L.Id = Status ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grpDataView.DataSource = dt;
            sizeset();
            noteLabel.Show();
        }

        public void viewCurrentData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT GroupId, StudentId, RegistrationNo, L.Value AS Status ,AssignmentDate, Created_On " +
                "FROM GroupStudent " +
                "JOIN Student S ON S.Id = StudentId " +
                "JOIN [Group] G ON G.Id = GroupId " +
                "JOIN Lookup L ON L.Id = Status " +
                "WHERE Status = 3 ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            grpDataView.DataSource = dt;
            sizeset();
            noteLabel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(groupId == 0)
            {
                MessageBox.Show("Please GroupId from Data Grid View to delete it");
                return;
            }
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE GroupStudent " +
                "SET Status = 4 " +
                "WHERE GroupId = @GroupId ", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");
            viewCurrentData();
        }


        private void grpDataView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = grpDataView.Rows[e.RowIndex];
                string grpIdStr = selectedRow.Cells["GroupId"].Value.ToString();

                if (string.IsNullOrWhiteSpace(grpIdStr))
                {
                    MessageBox.Show("Please select valid row");
                    return;
                }
                groupId = int.Parse(grpIdStr);
            }
        }
    }
}
