﻿using System;
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
    public partial class DeleteStdUC : UserControl
    {
        public DeleteStdUC()
        {
            InitializeComponent();
            showData();
            stdRegNo.KeyDown += TextBox_KeyDown;
        }

        private void deleteStdBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand delete_cmd = new SqlCommand("UPDATE Student " +
                "SET RegistrationNo = @RegNoNew " +
                "WHERE RegistrationNo = @RegNoPre; " +
                "UPDATE GroupStudent " +
                "SET Status = 4 " +
                "FROM GroupStudent GS " +
                "JOIN Student S ON S.Id = StudentId " +
                "WHERE RegistrationNo LIKE '%*' ", con);

            string regNo = stdRegNo.Text;
            delete_cmd.Parameters.AddWithValue("@RegNoPre", regNo);
            delete_cmd.Parameters.AddWithValue("@RegNoNew", regNo+"*");
            
            delete_cmd.ExecuteNonQuery();
            showData();
        }


        public void showData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select S.Id, RegistrationNo, FirstName, LastName, Contact, Email, DateOfBirth, Gender " +
                "FROM Student S " +
                "JOIN Person P ON P.Id = S.Id " +
                "WHERE RegistrationNo NOT LIKE '%*'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentDataView.DataSource = dt;
            sizeset();
        }


        private void sizeset()
        {
            for (int i = 0; i < studentDataView.Columns.Count; i++)
            {
                studentDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void studentDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = studentDataView.Rows[e.RowIndex];
                string regNo = selectedRow.Cells["RegistrationNo"].Value.ToString();
                
                stdRegNo.Text = regNo;
                
            }
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Check if the current textbox is the last one
                if (sender == stdRegNo)
                {
                    deleteStdBtn.PerformClick();
                }

                else
                {
                    // Move to the next control in the tab index order
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }
    }
}
