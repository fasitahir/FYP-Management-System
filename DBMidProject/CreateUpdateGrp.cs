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
    public partial class CreateUpdateGrp : UserControl
    {
        public CreateUpdateGrp()
        {
            InitializeComponent();
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
            if(assignment > DateTime.Now)
            {
                MessageBox.Show("Please select correct assignment date");
                return;
            }

            string statusString = grpStatus.Text;

            if(statusString.ToLower() == "active")
            {
                status = 3;
            }
            else if(statusString.ToLower() == "inactive")
            {
                status = 4;
            }
            else
            {
                status = 0;
            }

            if(status == 0)
            {
                MessageBox.Show("Please Select a valid status");
                return;
            }

            int checkCount = 0;
            var con = Configuration.getInstance().getConnection();
            for(int i =0;  i < regNos.Length; i++)
            {
                SqlCommand check_cmd = new SqlCommand("Select COUNT(Id) " +
                    "FROM Student " +
                    "WHERE LOWER(RegistrationNo) = LOWER(@RegNo) ", con);

                check_cmd.Parameters.AddWithValue("@RegNo", regNos[i].Trim());
                checkCount = (int)check_cmd.ExecuteScalar();
                
                if(checkCount == 0)
                {
                    MessageBox.Show("Not all registrations numbers are valid");
                    return;
                }
            }

            for(int i = 0; i < regNos.Length; i++)
            {
                SqlCommand check = new SqlCommand("SELECT COUNT(StudentId) " +
                    "FROM GroupStudent GS " +
                    "JOIN Student S ON GS.StudentId = S.Id " +
                    "Where S.RegistrationNo = @RegistrationNo", con);

                check.Parameters.AddWithValue("@RegistrationNo", regNos[i]);
                int checkRegNo = (int)check.ExecuteScalar();
                if(checkRegNo > 0)
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

            MessageBox.Show("Saved Successfully");
        }
    }
}
