using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stdSubMenu.Hide();
            manageStd1.Hide();
            deleteStdUC1.Hide();
        }

        private void ManageStd_Click(object sender, EventArgs e)
        {
            stdSubMenu.Show();
            stdSubMenu.BringToFront();
        }

        private void addStd_btn_Click(object sender, EventArgs e)
        {
            hideItems();
            manageStd1.Show();
            manageStd1.BringToFront();
        }

        private void sidemenu_panel_Click(object sender, EventArgs e)
        {
            stdSubMenu.Hide();
        }


        private void logo_panel_Click(object sender, EventArgs e)
        {
            hideItems();
        }

        private void hideItems()
        {
            stdSubMenu.Hide();
            manageStd1.Hide();
            deleteStdUC1.Hide();
        }

        private void ManageStd_MouseEnter(object sender, EventArgs e)
        {
            ManageStd.BackColor = Color.SeaGreen;
        }

        private void ManageStd_MouseLeave(object sender, EventArgs e)
        {
            ManageStd.BackColor = Color.Linen;
        }

        private void deleteStd_btn_Click(object sender, EventArgs e)
        {
            hideItems();
            deleteStdUC1.Show();
            deleteStdUC1.BringToFront();
        }
    }
}
