using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class AddAdvisor : UserControl
    {
        public AddAdvisor()
        {
            InitializeComponent();
            ShowData();
            advSalary.KeyDown += TextBox_KeyDown;
            designationAdv.KeyDown += TextBox_KeyDown;
            advId.KeyDown += TextBox_KeyDown;
        }

        private void addStdBtn_Click(object sender, EventArgs e)
        {
            int designation;
            var con = Configuration.getInstance().getConnection();
            
            string id = advId.Text;

            bool isId = Validation.IntValidation(id);
            if (!isId)
            {
                MessageBox.Show("Id can only have integers");
                return;
            }

            SqlCommand check = new SqlCommand("SELECT COUNT(Id) FROM Advisor WHERE Id = @Id", con);
            check.Parameters.AddWithValue("@Id", int.Parse(advId.Text));
            
            int checkId = (int)check.ExecuteScalar();

            if (checkId == 0)
            {


                SqlCommand cmd = new SqlCommand(
                "INSERT INTO Advisor " +
                "VALUES (@Id, @Designation, @Salary)", con);

                string selectedDesignation = designationAdv.Text;

                if (selectedDesignation.ToLower() == "professor")
                {
                    designation = 6;
                }
                else if (selectedDesignation.ToLower() == "associate professor")
                {
                    designation = 7;
                }
                else if (selectedDesignation.ToLower() == "assisstant professor")
                {
                    designation = 8;
                }
                else if (selectedDesignation.ToLower() == "lecturer")
                {
                    designation = 9;
                }
                else if (selectedDesignation.ToLower() == "industry professional")
                {
                    designation = 10;
                }
                else
                {
                    designation = 0;
                }

                string salary = advSalary.Text;
                bool isSalary = Validation.DoubleValidation(salary);
                
                if (isSalary && designation != 0)
                {

                    cmd.Parameters.AddWithValue("@Salary", float.Parse(advSalary.Text));
                    cmd.Parameters.AddWithValue("@Designation", designation);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(advId.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully saved");
                    ShowData();
                }

                else
                {

                    if (!isSalary)
                    {
                        MessageBox.Show("Salary can not have alphabets or symbol and it can not be empty");
                    }
                    else if (designation == 0)
                    {
                        MessageBox.Show("Please Select Designation");
                    }
                }
            }
            else
            {
                MessageBox.Show("Advisor with same Id already exist");
            }

        }


        private void ShowData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id, Salary, Designation " +
                "FROM Advisor " +
                "WHERE Designation NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Add a new column for the string representation of Designation
            dt.Columns.Add("DesignationString", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                int designationValue = Convert.ToInt32(row["Designation"]);

                switch (designationValue)
                {
                    case 6:
                        row["DesignationString"] = "Professor";
                        break;
                    case 7:
                        row["DesignationString"] = "Associate Professor";
                        break;
                    case 8:
                        row["DesignationString"] = "Assistant Professor";
                        break;
                    case 9:
                        row["DesignationString"] = "Lecturer";
                        break;
                    case 10:
                        row["DesignationString"] = "Industrial Professional";
                        break;
                    default:
                        break;
                }
            }

            // Remove the original Designation column if you don't need it anymore
            dt.Columns.Remove("Designation");

            // Rename the new column to Designation
            dt.Columns["DesignationString"].ColumnName = "Designation";

            advisorDataView.DataSource = dt;
            sizeset();
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Check if the current textbox is the last one
                if (sender == designationAdv)
                {
                    addAdvBtn.PerformClick();
                }

                else
                {
                    // Move to the next control in the tab index order
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }




        private void sizeset()
        {
            for (int i = 0; i < advisorDataView.Columns.Count; i++)
            {
                advisorDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
