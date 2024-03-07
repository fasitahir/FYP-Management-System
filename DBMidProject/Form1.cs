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
            hideItems();
        }

        private void hideItems()
        {
            stdSubMenu.Hide();
            advSubmenu.Hide();
            manageStd1.Hide();
            deleteStdUC1.Hide();
            viewAllStdUC1.Hide();
            updateStdUC1.Hide();
            addAdvisor1.Hide();
            viewAdvisorUC1.Hide();
            updateAdvUC1.Hide();
            projectSubmenu.Hide();
            addUpdate1.Hide();
            viewDelProjUC1.Hide();
            createUpdateGrp1.Hide();
            groupSidemenu.Hide();
            viewDelGrp1.Hide();
            assignProjectUC1.Hide();
        }
        
        private void sidemenu_panel_Click(object sender, EventArgs e)
        {
            stdSubMenu.Hide();
            advSubmenu.Hide();
            projectSubmenu.Hide();
            groupSidemenu.Hide();

        }

        private void ManageStd_Click(object sender, EventArgs e)
        {
            advSubmenu.Hide();
            projectSubmenu.Hide();
            stdSubMenu.Show();
            groupSidemenu.Hide();
            stdSubMenu.BringToFront();
        }

        private void addStd_btn_Click(object sender, EventArgs e)
        {
            hideItems();
            manageStd1.Show();
            manageStd1.BringToFront();
        }

        private void logo_panel_Click(object sender, EventArgs e)
        {
            hideItems();
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
            deleteStdUC1.showData();
        }

        private void viewStd_btn_Click(object sender, EventArgs e)
        {
            hideItems();
            viewAllStdUC1.Show();
            viewAllStdUC1.BringToFront();
            viewAllStdUC1.ShowCurrentStudents();
        }

        private void updateStd_btn_Click(object sender, EventArgs e)
        {
            hideItems();
            updateStdUC1.Show();
            updateStdUC1.BringToFront();
            updateStdUC1.ShowData();
        }

        private void addAdvBtn_Click(object sender, EventArgs e)
        {
            hideItems();
            addAdvisor1.Show();
            addAdvisor1.BringToFront();
        }

        private void manageAdvBtn_Click(object sender, EventArgs e)
        {
            stdSubMenu.Hide();
            groupSidemenu.Hide();
            projectSubmenu.Hide();
            advSubmenu.Show();
            advSubmenu.BringToFront();
        }

        private void viewAdvBtn_Click(object sender, EventArgs e)
        {
            hideItems();
            viewAdvisorUC1.Show();
            viewAdvisorUC1.BringToFront();
            viewAdvisorUC1.ShowCurrentData();
        }

        private void updateAdvBtn_Click(object sender, EventArgs e)
        {
            advSubmenu.Hide();
            updateAdvUC1.Show();
            updateAdvUC1.BringToFront();
            updateAdvUC1.ShowData();
        }

        private void manageProjBtn_Click(object sender, EventArgs e)
        {
            advSubmenu.Hide();
            stdSubMenu.Hide();
            groupSidemenu.Hide();
            projectSubmenu.Show();
            projectSubmenu.BringToFront();
        }

        private void addUptBtn_Click(object sender, EventArgs e)
        {
            hideItems();
            addUpdate1.Show();
            addUpdate1.BringToFront();
        }

        private void viewDelBtn_Click(object sender, EventArgs e)
        {
            hideItems();
            viewDelProjUC1.Show();
            viewDelProjUC1.BringToFront();
            viewDelProjUC1.ShowCurrentData();
        }

        private void manageGrp_Click_1(object sender, EventArgs e)
        {
            advSubmenu.Hide();
            stdSubMenu.Hide();
            projectSubmenu.Hide();
            groupSidemenu.Show();
            groupSidemenu.BringToFront();
        }

        private void addUptGrp_Click(object sender, EventArgs e)
        {
            hideItems();
            createUpdateGrp1.ShowData();
            createUpdateGrp1.Show();
            createUpdateGrp1.BringToFront();
        }

        private void viewDelGrp_Click(object sender, EventArgs e)
        {
            hideItems();
            viewDelGrp1.viewCurrentData();
            viewDelGrp1.Show();
            viewDelGrp1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideItems();
            assignProjectUC1.Show();
            assignProjectUC1.BringToFront();
            assignProjectUC1.ShowProjectData();
            assignProjectUC1.ShowAssignedProjects();

            assignProjectUC1.loadComboBox();
        }
    }
}
