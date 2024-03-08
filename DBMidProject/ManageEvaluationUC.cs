using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class ManageEvaluationUC : UserControl
    {
        int evaluationId = 0;
        public ManageEvaluationUC()
        {
            InitializeComponent();
            ShowData();
        }


        private void addEvlBtn_Click(object sender, EventArgs e)
        {

            string name = nameTb.Text;
            string marksString = totalMarksTb.Text;
            string weightageString = weightageTb.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter name of the evaluation");
                return;
            }
            else if (!Validation.IntValidation(marksString))
            {
                MessageBox.Show("Marks can only be of integer type");
                return;
            }
            else if (!Validation.IntValidation(weightageString))
            {
                MessageBox.Show("Weightage can only be of integer type");
                return;
            }

            int weightage = int.Parse(weightageString);
            int marks = int.Parse(marksString);

            if (weightage < 0 && weightage > 100)
            {
                MessageBox.Show("Weightage can only be between 0 and 100");
                return;
            }
            else if (marks < 0)
            {
                MessageBox.Show("Marks can not be negative");
                return;
            }

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Evaluation " +
                "VALUES (@Name, @TotalMarks, @TotalWeightage)", con);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@TotalMarks", marks);
            cmd.Parameters.AddWithValue("@TotalWeightage", weightage);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");
            ShowData();
        }


        private void ShowData()
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
                nameTb.Text = name;
                totalMarksTb.Text = marksString;
                weightageTb.Text = weightage;
            }
        }

        private void updateEvlBtn_Click(object sender, EventArgs e)
        {
            if (evaluationId == 0)
            {
                MessageBox.Show("Please select a valid row to update");
                return;
            }

            string name = nameTb.Text;
            string marksString = totalMarksTb.Text;
            string weightageString = weightageTb.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter name of the evaluation");
                return;
            }
            else if (!Validation.IntValidation(marksString))
            {
                MessageBox.Show("Marks can only be of integer type");
                return;
            }
            else if (!Validation.IntValidation(weightageString))
            {
                MessageBox.Show("Weightage can only be of integer type");
                return;
            }

            int weightage = int.Parse(weightageString);
            int marks = int.Parse(marksString);

            if (weightage < 0 && weightage > 100)
            {
                MessageBox.Show("Weightage can only be between 0 and 100");
                return;
            }
            else if (marks < 0)
            {
                MessageBox.Show("Marks can not be negative");
                return;
            }

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Evaluation " +
                "SET Name = @Name, TotalMarks = @TotalMarks, TotalWeightage =  @TotalWeightage " +
                "WHERE Id = @Id ", con);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@TotalMarks", marks);
            cmd.Parameters.AddWithValue("@TotalWeightage", weightage);
            cmd.Parameters.AddWithValue("@Id", evaluationId);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");
            ShowData();
        }

        private void deleteEvlBtn_Click(object sender, EventArgs e)
        {
            if (evaluationId == 0)
            {
                MessageBox.Show("Please select a valid row to update");
                return;
            }

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Evaluation " +
                "SET Name = Name + '*' " +
                "WHERE Id = @Id ", con);

            cmd.Parameters.AddWithValue("@Id", evaluationId);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");
            ShowData();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchBar.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter text to search");
                return;
            }
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * " +
            "FROM Evaluation " +
            "WHERE (Name LIKE @searchText OR TotalMarks LIKE @searchText " +
            "OR Id like @searchText OR TotalWeightage like @searchText) AND Name NOT LIKE '%*'", con);

            cmd.Parameters.AddWithValue("@searchText", searchText);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            evaluationDataView.DataSource = dt;
            sizeSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
