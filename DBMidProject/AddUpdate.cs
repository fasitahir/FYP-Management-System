using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class AddUpdate : UserControl
    {
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

            MessageBox.Show(title);
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
    }
}
