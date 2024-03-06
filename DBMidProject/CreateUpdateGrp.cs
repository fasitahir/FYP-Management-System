using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMidProject
{
    public partial class CreateUpdateGrp : UserControl
    {
        int groupId = 0;
        int stdId = 0;

        public CreateUpdateGrp()
        {
            InitializeComponent();
            ShowData();
        }

        private void createGrpBtn_Click(object sender, EventArgs e)
        {
            int status;

            string regNoString = stdRegNo.Text.ToString();
            string[] regNos = regNoString.Split(',');
            if (regNos.Length < 3 || regNos.Length > 5)
            {
                MessageBox.Show("There can be minimum students of 3 or maximum of 5 in a group");
                return;
            }

            DateTime assignment = assignmentDate.Value;
            if (assignment > DateTime.Now)
            {
                MessageBox.Show("Please select correct assignment date");
                return;
            }

            string statusString = grpStatus.Text;

            if (statusString.ToLower() == "active")
            {
                status = 3;
            }
            else if (statusString.ToLower() == "inactive")
            {
                status = 4;
            }
            else
            {
                status = 0;
            }

            if (status == 0)
            {
                MessageBox.Show("Please Select a valid status");
                return;
            }

            int checkCount = 0;
            var con = Configuration.getInstance().getConnection();
            for (int i = 0; i < regNos.Length; i++)
            {
                SqlCommand check_cmd = new SqlCommand("Select COUNT(Id) " +
                    "FROM Student " +
                    "WHERE LOWER(RegistrationNo) = LOWER(@RegNo) ", con);

                check_cmd.Parameters.AddWithValue("@RegNo", regNos[i].Trim());
                checkCount = (int)check_cmd.ExecuteScalar();

                if (checkCount == 0)
                {
                    MessageBox.Show("Not all registrations numbers are valid");
                    return;
                }
            }

            for (int i = 0; i < regNos.Length; i++)
            {
                SqlCommand check = new SqlCommand("SELECT COUNT(StudentId) " +
                    "FROM GroupStudent GS " +
                    "JOIN Student S ON GS.StudentId = S.Id " +
                    "Where S.RegistrationNo = @RegistrationNo", con);

                check.Parameters.AddWithValue("@RegistrationNo", regNos[i]);
                int checkRegNo = (int)check.ExecuteScalar();
                if (checkRegNo > 0)
                {
                    MessageBox.Show("Student of this registration number has already been added");
                    return;
                }
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO [Group] " +
                "Values (@Created_On)", con);
            cmd.Parameters.AddWithValue("@Created_On", DateTime.Now);
            cmd.ExecuteNonQuery();

            for (int i = 0; i < regNos.Length; i++)
            {
                SqlCommand cmd2 = new SqlCommand(
                    "INSERT INTO GroupStudent " +
                    "Values ((SELECT MAX(Id) FROM [Group]), " +
                    "(Select Id FROM Student WHERE LOWER(RegistrationNo) = LOWER(@RegNo))," +
                    "@Status, @AssignmentDate)", con);

                cmd2.Parameters.AddWithValue("@RegNo", regNos[i].Trim());
                cmd2.Parameters.AddWithValue("@Status", status);
                cmd2.Parameters.AddWithValue("@AssignmentDate", assignment);
                cmd2.ExecuteNonQuery();
            }

            ShowData();
            MessageBox.Show("Saved Successfully");
        }


        public void ShowData()
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


        }

        private void sizeset()
        {
            for (int i = 0; i < grpDataView.Columns.Count; i++)
            {
                grpDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void grpDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = grpDataView.Rows[e.RowIndex];
                string regNo = selectedRow.Cells["RegistrationNo"].Value.ToString();
                string grpIdStr = selectedRow.Cells["GroupId"].Value.ToString();
                string stdIdStr = selectedRow.Cells["StudentId"].Value.ToString();
                string assignment = selectedRow.Cells["AssignmentDate"].Value.ToString();
                string status = selectedRow.Cells["Status"].Value.ToString();
               
                if(string.IsNullOrWhiteSpace(grpIdStr) || string.IsNullOrWhiteSpace(stdIdStr))
                {
                    MessageBox.Show("Please select valid row");
                    return;
                }
                groupId = int.Parse(grpIdStr);
                stdId = int.Parse(selectedRow.Cells["StudentId"].Value.ToString());

                stdRegNo.Text = regNo;
                assignmentDate.Value = DateTime.Parse(assignment);
                grpStatus.Text = status;

            }
        }

        private void updateStdBtn_Click(object sender, EventArgs e)
        {
            int status;
            if(groupId == 0 || stdId == 0)
            {
                MessageBox.Show("Please select a row of specific group to update the student or add student in that group");
                return;
            }

            string regNoString = stdRegNo.Text.ToString();
            string[] regNos = regNoString.Split(',');


            DateTime assignment = assignmentDate.Value;
            if (assignment > DateTime.Now)
            {
                MessageBox.Show("Please select correct assignment date");
                return;
            }

            string statusString = grpStatus.Text;

            if (statusString.ToLower() == "active")
            {
                status = 3;
            }
            else if (statusString.ToLower() == "inactive")
            {
                status = 4;
            }
            else
            {
                status = 0;
            }

            if (status == 0)
            {
                MessageBox.Show("Please Select a valid status");
                return;
            }

            int checkCount = 0;
            var con = Configuration.getInstance().getConnection();
            for (int i = 0; i < regNos.Length; i++)
            {
                SqlCommand check_cmd = new SqlCommand("Select COUNT(Id) " +
                    "FROM Student " +
                    "WHERE LOWER(RegistrationNo) = LOWER(@RegNo) ", con);

                check_cmd.Parameters.AddWithValue("@RegNo", regNos[i].Trim());
                checkCount = (int)check_cmd.ExecuteScalar();

                if (checkCount == 0)
                {
                    MessageBox.Show("Not all registrations numbers are valid");
                    return;
                }
            }

            //For updating
            for (int i = 0; i < regNos.Length; i++)
            {
                SqlCommand check = new SqlCommand("SELECT COUNT(StudentId) " +
                    "FROM GroupStudent GS " +
                    "JOIN Student S ON GS.StudentId = S.Id " +
                    "Where S.RegistrationNo = @RegistrationNo AND Status = 3", con);

                check.Parameters.AddWithValue("@RegistrationNo", regNos[i]);
                int checkRegNo = (int)check.ExecuteScalar();
                if (checkRegNo > 0)
                {
                    UpdateGroupStudent(status);
                    return;
                }
            }

            //If the registration number is not present it will add it in the group

            SqlCommand checkGrpCount = new SqlCommand("SELECT COUNT(GroupId) " +
                "FROM GroupStudent " +
                "GROUP BY GroupId " ,con);

            int grpStdCount = (int)checkGrpCount.ExecuteScalar();

            if (grpStdCount+regNos.Length <= 5)
            {
                
                for (int i = 0; i < regNos.Length; i++)
                {
                    SqlCommand cmd2 = new SqlCommand(
                        "INSERT INTO GroupStudent " +
                        "Values (@GroupId, " +
                        "(Select Id FROM Student WHERE LOWER(RegistrationNo) = LOWER(@RegNo))," +
                        "@Status, @AssignmentDate)", con);

                    cmd2.Parameters.AddWithValue("@RegNo", regNos[i].Trim());
                    cmd2.Parameters.AddWithValue("@Status", status);
                    cmd2.Parameters.AddWithValue("@AssignmentDate", assignment);
                    cmd2.Parameters.AddWithValue("@GroupId", groupId);
                    cmd2.ExecuteNonQuery();
                }

                ShowData();
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Group has maximum number of students");
            }
        }


        private void UpdateGroupStudent(int status)
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("UPDATE GroupStudent " +
                "SET Status = @Status " +
                "WHERE GroupId = @GroupId  AND StudentId = @StudentId; " , con);

            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@StudentId", stdId);

            cmd.ExecuteNonQuery();
            ShowData();

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
            catch(Exception ex) 
            {
                MessageBox.Show(ex + "");
            }
            
        }
    }
}
