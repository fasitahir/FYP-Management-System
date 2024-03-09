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
    public partial class reportsUC : UserControl
    {
        public reportsUC()
        {
            InitializeComponent();
        }

        private void genRepBtn_Click(object sender, EventArgs e)
        {
            if(reportsCb.Text.ToLower() == "project and advisory board")
            {
                report1();
            }
            else if(reportsCb.Text.ToLower() == "marks sheet")
            {
                report2();
            }
            else if(reportsCb.Text.ToLower() == "students who left more than 1 group")
            {
                report3();
            }
            else if(reportsCb.Text.ToLower() == "advisors with count of their projects")
            {
                report4();
            }
            else if(reportsCb.Text.ToLower() == "maximum marks in each evaluation")
            {
                report5();
            }
            else
            {
                MessageBox.Show("Please select a report you want to generate");
            }
        
        }

        private void report1()
        {
            var con = Configuration.getInstance().getConnection();
            string query = @"
                SELECT RegistrationNo, P.FirstName + ' ' + P.LastName As 'Student Name', P.Email As 'Student Email' , Proj.Title AS 'Project Title', P2.FirstName +' '+ P2.LastName AS 'Advisor Name', P2.Email AS 'Advisor Email'
                FROM Student S
                JOIN Person P ON S.Id = P.Id 
                JOIN GroupStudent GS ON GS.StudentId = S.Id
                JOIN [Group] G ON G.Id = GS.GroupId
                JOIN GroupProject GP ON GP.GroupId = G.Id
                JOIN Project Proj ON GP.ProjectId = Proj.Id
                JOIN ProjectAdvisor PA ON PA.ProjectId = Proj.Id
                JOIN Advisor A ON A.Id = PA.AdvisorId
                JOIN Person P2 ON P2.Id = A.Id
                JOIN Lookup L1 ON L1.Id = AdvisorRole
                WHERE RegistrationNo NOT LIKE '%*' AND Title NOT LIKE '%*'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            reportDataView.DataSource = dt;
            sizeset();
            da.Fill(dt);

            AdvancedPdfGenerator.GeneratePdf(dt, "List of projects along with advisory board and list of students");

        }


        private void report2()
        {
            var con = Configuration.getInstance().getConnection();
            string query = @"
                SELECT RegistrationNo, P.FirstName As 'Student Name', Proj.Title AS 'Project Title', E.Name As 'Evaluation Name', E.TotalMarks, E.TotalWeightage, GE.ObtainedMarks, ((CAST(ObtainedMarks AS float)/CAST(TotalMarks AS float)) * CAST(TotalWeightage AS FLOAT)) AS Result
                FROM Evaluation E
                JOIN GroupEvaluation GE ON GE.EvaluationId = E.Id
                JOIN [Group] G ON G.Id = GE.GroupId
                JOIN GroupProject GP ON GP.GroupId = G.Id
                JOIN Project Proj ON Proj.Id = GP.ProjectId
                JOIN GroupStudent GS ON GS.GroupId = G.Id
                JOIN Student S ON S.Id = GS.StudentId
                JOIN Person P ON P.Id = S.Id
                WHERE S.RegistrationNo NOT LIKE '%*' AND GS.Status = 3 AND Proj.Title NOT LIKE '%*'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            reportDataView.DataSource = dt;
            sizeset();
            da.Fill(dt);

            AdvancedPdfGenerator.GeneratePdf(dt, "Marks sheet of projects that shows the marks in each evaluation against each student and project");

        }

        private void report3()
        {
            var con = Configuration.getInstance().getConnection();
            string query = @"
                SELECT DISTINCT FirstName AS Name, RegistrationNo, Email, L.Value, DateOfBirth, Contact
                FROM GroupStudent GS
                JOIN Student S ON GS.StudentId = S.Id
                JOIN Person P ON P.Id = S.Id
                JOIN Lookup L ON L.Id = Gender
                WHERE S.RegistrationNo NOT LIKE '%*' AND GS.StudentId IN (
                    SELECT GS2.StudentId
                    FROM GroupStudent GS2
                    GROUP BY GS2.StudentId
                    HAVING COUNT(GS2.GroupId) >= 2
                )";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            reportDataView.DataSource = dt;
            sizeset();
            da.Fill(dt);

            AdvancedPdfGenerator.GeneratePdf(dt, "Students who changed group more than 1 times");

        }

        private void report4()
        {
            var con = Configuration.getInstance().getConnection();
            string query = @"
                SELECT P2.FirstName AS 'Advisor Name', P2.Email AS 'Advisor Email', COUNT(DISTINCT PA.ProjectId) AS 'Number of Projects Advised'
                FROM Advisor A
                JOIN Person P2 ON P2.Id = A.Id
                JOIN ProjectAdvisor PA ON PA.AdvisorId = A.Id
                JOIN Project P ON P.Id = PA.ProjectId
                WHERE Title NOT LIKE '%*'
                GROUP BY P2.FirstName, P2.LastName, P2.Email";


            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            reportDataView.DataSource = dt;
            sizeset();
            da.Fill(dt);

            AdvancedPdfGenerator.GeneratePdf(dt, "Advisors with number of project they are supervising");

        }

        private void report5()
        {
            var con = Configuration.getInstance().getConnection();
            string query = @"
                SELECT E.Name, E.TotalMarks, GE.ObtainedMarks, G.Id AS GroupID
                FROM Evaluation E
                JOIN GroupEvaluation GE ON E.Id = GE.EvaluationId
                JOIN [Group] G ON G.Id = GE.GroupId
                WHERE ObtainedMarks = (SELECT MAX(ObtainedMarks) 
                    FROM GroupEvaluation GE2 
                    WHERE GE2.EvaluationId = E.Id
                    GROUP BY GE2.EvaluationId)";


            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            reportDataView.DataSource = dt;
            sizeset();
            da.Fill(dt);

            AdvancedPdfGenerator.GeneratePdf(dt, "Group Which obtained highest marks in each evaluation");

        }

        private void sizeset()
        {
            for (int i = 0; i < reportDataView.Columns.Count; i++)
            {
                reportDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        
    }
}
