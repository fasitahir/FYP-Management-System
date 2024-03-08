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
    public partial class MarkEvaluationUC : UserControl
    {
        int evaluationId, totalMarks = 0;

        public MarkEvaluationUC()
        {
            InitializeComponent();
            showdata();
        }

        private void MarkEvaluationUC_Load(object sender, EventArgs e)
        {

        }

        public void loadComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT GroupId " +
            "FROM GroupStudent " +
            "WHERE Status <> 4 " +
            "GROUP BY GroupId ", con);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                groupId_CB.Items.Add(reader["GroupId"].ToString());
            }
            reader.Close();
        }

        private void showdata()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * " +
                "FROM Evaluation " +
                "WHERE Name NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            evaluationDataView.DataSource = dt;
            sizeSet();

        }

        private void sizeSet()
        {
            for (int i = 0; i < evaluationDataView.Columns.Count; i++)
            {
                evaluationDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void markEvlBtn_Click(object sender, EventArgs e)
        {
            if (evaluationId == 0)
            {
                MessageBox.Show("Please select an evaluation id from the table");
                return;
            }
            try
            {
                var con = Configuration.getInstance().getConnection();
          
                SqlCommand cmd = new SqlCommand("INSERT INTO GroupEvaluation " +
                    "VALUES (@GroupId, @EvaluationId, @ObtainedMarks, @EvaluationDate)", con);
                string groupIdString = groupId_CB.Text.Trim();
                string obtainedMarksString = obtainedMarksTb.Text.Trim();

                if (string.IsNullOrWhiteSpace(groupIdString) && !Validation.IntValidation(groupIdString))
                {
                    MessageBox.Show("Please select a valid group id");
                    return;
                }
                if (string.IsNullOrWhiteSpace(obtainedMarksString) && !Validation.IntValidation(obtainedMarksString))
                {
                    MessageBox.Show("Please enter valid obtained marks");
                    return;
                }

                int obtainedMarks = int.Parse(obtainedMarksString);

                if (obtainedMarks < 0)
                {
                    MessageBox.Show("Obtained marks can not be negative");
                    return;
                }

                if (obtainedMarks > totalMarks)
                {
                    MessageBox.Show("Obtained marks can not be greater than total marks");
                    return;
                }

                cmd.Parameters.AddWithValue("@GroupId", int.Parse(groupIdString));
                cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@ObtainedMarks", obtainedMarks);
                cmd.Parameters.AddWithValue("@EvaluationId", evaluationId);

                SqlCommand check = new SqlCommand("SELECT COUNT(*) " +
                    "FROM GroupEvaluation " +
                    "WHERE @EvaluationId = EvaluationId AND @GroupId = GroupId ", con);
                check.Parameters.AddWithValue("@GroupId", int.Parse(groupIdString));
                check.Parameters.AddWithValue("@EvaluationId", evaluationId);

                int checkCount = (int)check.ExecuteScalar();
                if(checkCount > 0)
                {
                    MessageBox.Show("You can not mark same evaluation against same group more than 1 time");
                    return;
                }
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex) 
            {
                MessageBox.Show("" + ex);
            }
        }
        private void evaluationDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = evaluationDataView.Rows[e.RowIndex];
                string idString = selectedRow.Cells["Id"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string marksString = selectedRow.Cells["TotalMarks"].Value.ToString();
                string weightage = selectedRow.Cells["TotalWeightage"].Value.ToString();

                if (!string.IsNullOrWhiteSpace(idString))
                {
                    evaluationId = int.Parse(idString);
                }
                
                totalMarks = int.Parse(marksString);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showResult();
        }

        private void showDataBtn_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void showResult()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT GroupId, Name, TotalMarks, TotalWeightage, ObtainedMarks, EvaluationDate " +
                "FROM Evaluation " +
                "JOIN GroupEvaluation GV ON GV.EvaluationId = Id " +
                "WHERE Name NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            evaluationDataView.DataSource = dt;
            sizeSet();

        }
    }
}
