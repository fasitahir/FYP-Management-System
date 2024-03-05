namespace DBMidProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManageStd = new System.Windows.Forms.Button();
            this.stdSubMenu = new System.Windows.Forms.Panel();
            this.deleteStd_btn = new System.Windows.Forms.Button();
            this.updateStd_btn = new System.Windows.Forms.Button();
            this.addStd_btn = new System.Windows.Forms.Button();
            this.viewStd_btn = new System.Windows.Forms.Button();
            this.sidemenu_panel = new System.Windows.Forms.Panel();
            this.advSubmenu = new System.Windows.Forms.Panel();
            this.updateAdvBtn = new System.Windows.Forms.Button();
            this.addAdvBtn = new System.Windows.Forms.Button();
            this.viewAdvBtn = new System.Windows.Forms.Button();
            this.manageAdvBtn = new System.Windows.Forms.Button();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.updateAdvUC1 = new DBMidProject.UpdateAdvUC();
            this.viewAdvisorUC1 = new DBMidProject.ViewAdvisorUC();
            this.addAdvisor1 = new DBMidProject.AddAdvisor();
            this.updateStdUC1 = new DBMidProject.UpdateStdUC();
            this.viewAllStdUC1 = new DBMidProject.ViewAllStdUC();
            this.deleteStdUC1 = new DBMidProject.DeleteStdUC();
            this.manageStd1 = new DBMidProject.AddStd();
            this.manageProjBtn = new System.Windows.Forms.Button();
            this.projectSubmenu = new System.Windows.Forms.Panel();
            this.viewDelBtn = new System.Windows.Forms.Button();
            this.addUptBtn = new System.Windows.Forms.Button();
            this.addUpdate1 = new DBMidProject.AddUpdate();
            this.stdSubMenu.SuspendLayout();
            this.sidemenu_panel.SuspendLayout();
            this.advSubmenu.SuspendLayout();
            this.projectSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageStd
            // 
            this.ManageStd.BackColor = System.Drawing.Color.Linen;
            this.ManageStd.FlatAppearance.BorderSize = 0;
            this.ManageStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageStd.Location = new System.Drawing.Point(3, 122);
            this.ManageStd.Name = "ManageStd";
            this.ManageStd.Size = new System.Drawing.Size(150, 29);
            this.ManageStd.TabIndex = 0;
            this.ManageStd.Text = "Manage Student";
            this.ManageStd.UseVisualStyleBackColor = false;
            this.ManageStd.Click += new System.EventHandler(this.ManageStd_Click);
            this.ManageStd.MouseEnter += new System.EventHandler(this.ManageStd_MouseEnter);
            this.ManageStd.MouseLeave += new System.EventHandler(this.ManageStd_MouseLeave);
            // 
            // stdSubMenu
            // 
            this.stdSubMenu.BackColor = System.Drawing.Color.Gray;
            this.stdSubMenu.Controls.Add(this.deleteStd_btn);
            this.stdSubMenu.Controls.Add(this.updateStd_btn);
            this.stdSubMenu.Controls.Add(this.addStd_btn);
            this.stdSubMenu.Controls.Add(this.viewStd_btn);
            this.stdSubMenu.Location = new System.Drawing.Point(92, 148);
            this.stdSubMenu.Name = "stdSubMenu";
            this.stdSubMenu.Size = new System.Drawing.Size(61, 115);
            this.stdSubMenu.TabIndex = 1;
            // 
            // deleteStd_btn
            // 
            this.deleteStd_btn.BackColor = System.Drawing.Color.Linen;
            this.deleteStd_btn.FlatAppearance.BorderSize = 0;
            this.deleteStd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStd_btn.Location = new System.Drawing.Point(2, 90);
            this.deleteStd_btn.Name = "deleteStd_btn";
            this.deleteStd_btn.Size = new System.Drawing.Size(56, 23);
            this.deleteStd_btn.TabIndex = 5;
            this.deleteStd_btn.Text = "Delete";
            this.deleteStd_btn.UseVisualStyleBackColor = false;
            this.deleteStd_btn.Click += new System.EventHandler(this.deleteStd_btn_Click);
            // 
            // updateStd_btn
            // 
            this.updateStd_btn.BackColor = System.Drawing.Color.Linen;
            this.updateStd_btn.FlatAppearance.BorderSize = 0;
            this.updateStd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStd_btn.Location = new System.Drawing.Point(3, 61);
            this.updateStd_btn.Name = "updateStd_btn";
            this.updateStd_btn.Size = new System.Drawing.Size(56, 23);
            this.updateStd_btn.TabIndex = 4;
            this.updateStd_btn.Text = "Update";
            this.updateStd_btn.UseVisualStyleBackColor = false;
            this.updateStd_btn.Click += new System.EventHandler(this.updateStd_btn_Click);
            // 
            // addStd_btn
            // 
            this.addStd_btn.BackColor = System.Drawing.Color.Linen;
            this.addStd_btn.FlatAppearance.BorderSize = 0;
            this.addStd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStd_btn.Location = new System.Drawing.Point(3, 3);
            this.addStd_btn.Name = "addStd_btn";
            this.addStd_btn.Size = new System.Drawing.Size(56, 23);
            this.addStd_btn.TabIndex = 2;
            this.addStd_btn.Text = "Add";
            this.addStd_btn.UseVisualStyleBackColor = false;
            this.addStd_btn.Click += new System.EventHandler(this.addStd_btn_Click);
            // 
            // viewStd_btn
            // 
            this.viewStd_btn.BackColor = System.Drawing.Color.Linen;
            this.viewStd_btn.FlatAppearance.BorderSize = 0;
            this.viewStd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewStd_btn.Location = new System.Drawing.Point(3, 32);
            this.viewStd_btn.Name = "viewStd_btn";
            this.viewStd_btn.Size = new System.Drawing.Size(56, 23);
            this.viewStd_btn.TabIndex = 3;
            this.viewStd_btn.Text = "View";
            this.viewStd_btn.UseVisualStyleBackColor = false;
            this.viewStd_btn.Click += new System.EventHandler(this.viewStd_btn_Click);
            // 
            // sidemenu_panel
            // 
            this.sidemenu_panel.Controls.Add(this.projectSubmenu);
            this.sidemenu_panel.Controls.Add(this.manageProjBtn);
            this.sidemenu_panel.Controls.Add(this.manageAdvBtn);
            this.sidemenu_panel.Controls.Add(this.logo_panel);
            this.sidemenu_panel.Controls.Add(this.ManageStd);
            this.sidemenu_panel.Controls.Add(this.stdSubMenu);
            this.sidemenu_panel.Controls.Add(this.advSubmenu);
            this.sidemenu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu_panel.Location = new System.Drawing.Point(0, 0);
            this.sidemenu_panel.Name = "sidemenu_panel";
            this.sidemenu_panel.Size = new System.Drawing.Size(153, 450);
            this.sidemenu_panel.TabIndex = 3;
            this.sidemenu_panel.Click += new System.EventHandler(this.sidemenu_panel_Click);
            // 
            // advSubmenu
            // 
            this.advSubmenu.BackColor = System.Drawing.Color.Gray;
            this.advSubmenu.Controls.Add(this.updateAdvBtn);
            this.advSubmenu.Controls.Add(this.addAdvBtn);
            this.advSubmenu.Controls.Add(this.viewAdvBtn);
            this.advSubmenu.Location = new System.Drawing.Point(80, 186);
            this.advSubmenu.Name = "advSubmenu";
            this.advSubmenu.Size = new System.Drawing.Size(70, 88);
            this.advSubmenu.TabIndex = 6;
            // 
            // updateAdvBtn
            // 
            this.updateAdvBtn.BackColor = System.Drawing.Color.Linen;
            this.updateAdvBtn.FlatAppearance.BorderSize = 0;
            this.updateAdvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateAdvBtn.Location = new System.Drawing.Point(3, 61);
            this.updateAdvBtn.Name = "updateAdvBtn";
            this.updateAdvBtn.Size = new System.Drawing.Size(67, 23);
            this.updateAdvBtn.TabIndex = 4;
            this.updateAdvBtn.Text = "Update";
            this.updateAdvBtn.UseVisualStyleBackColor = false;
            this.updateAdvBtn.Click += new System.EventHandler(this.updateAdvBtn_Click);
            // 
            // addAdvBtn
            // 
            this.addAdvBtn.BackColor = System.Drawing.Color.Linen;
            this.addAdvBtn.FlatAppearance.BorderSize = 0;
            this.addAdvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAdvBtn.Location = new System.Drawing.Point(3, 3);
            this.addAdvBtn.Name = "addAdvBtn";
            this.addAdvBtn.Size = new System.Drawing.Size(67, 23);
            this.addAdvBtn.TabIndex = 2;
            this.addAdvBtn.Text = "Add";
            this.addAdvBtn.UseVisualStyleBackColor = false;
            this.addAdvBtn.Click += new System.EventHandler(this.addAdvBtn_Click);
            // 
            // viewAdvBtn
            // 
            this.viewAdvBtn.BackColor = System.Drawing.Color.Linen;
            this.viewAdvBtn.FlatAppearance.BorderSize = 0;
            this.viewAdvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAdvBtn.Location = new System.Drawing.Point(3, 32);
            this.viewAdvBtn.Name = "viewAdvBtn";
            this.viewAdvBtn.Size = new System.Drawing.Size(67, 23);
            this.viewAdvBtn.TabIndex = 3;
            this.viewAdvBtn.Text = "View\\Del";
            this.viewAdvBtn.UseVisualStyleBackColor = false;
            this.viewAdvBtn.Click += new System.EventHandler(this.viewAdvBtn_Click);
            // 
            // manageAdvBtn
            // 
            this.manageAdvBtn.BackColor = System.Drawing.Color.Linen;
            this.manageAdvBtn.FlatAppearance.BorderSize = 0;
            this.manageAdvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageAdvBtn.Location = new System.Drawing.Point(3, 157);
            this.manageAdvBtn.Name = "manageAdvBtn";
            this.manageAdvBtn.Size = new System.Drawing.Size(150, 29);
            this.manageAdvBtn.TabIndex = 3;
            this.manageAdvBtn.Text = "Manage Advisor";
            this.manageAdvBtn.UseVisualStyleBackColor = false;
            this.manageAdvBtn.Click += new System.EventHandler(this.manageAdvBtn_Click);
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.Transparent;
            this.logo_panel.BackgroundImage = global::DBMidProject.Properties.Resources.cs_logo;
            this.logo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(153, 100);
            this.logo_panel.TabIndex = 2;
            this.logo_panel.Click += new System.EventHandler(this.logo_panel_Click);
            // 
            // updateAdvUC1
            // 
            this.updateAdvUC1.BackColor = System.Drawing.Color.Snow;
            this.updateAdvUC1.Location = new System.Drawing.Point(153, 0);
            this.updateAdvUC1.Name = "updateAdvUC1";
            this.updateAdvUC1.Size = new System.Drawing.Size(665, 450);
            this.updateAdvUC1.TabIndex = 9;
            // 
            // viewAdvisorUC1
            // 
            this.viewAdvisorUC1.BackColor = System.Drawing.Color.PapayaWhip;
            this.viewAdvisorUC1.Location = new System.Drawing.Point(153, 0);
            this.viewAdvisorUC1.Name = "viewAdvisorUC1";
            this.viewAdvisorUC1.Size = new System.Drawing.Size(665, 450);
            this.viewAdvisorUC1.TabIndex = 8;
            // 
            // addAdvisor1
            // 
            this.addAdvisor1.BackColor = System.Drawing.Color.Cornsilk;
            this.addAdvisor1.Location = new System.Drawing.Point(153, 0);
            this.addAdvisor1.Name = "addAdvisor1";
            this.addAdvisor1.Size = new System.Drawing.Size(665, 447);
            this.addAdvisor1.TabIndex = 7;
            // 
            // updateStdUC1
            // 
            this.updateStdUC1.BackColor = System.Drawing.Color.MistyRose;
            this.updateStdUC1.Location = new System.Drawing.Point(153, 2);
            this.updateStdUC1.Name = "updateStdUC1";
            this.updateStdUC1.Size = new System.Drawing.Size(665, 447);
            this.updateStdUC1.TabIndex = 6;
            // 
            // viewAllStdUC1
            // 
            this.viewAllStdUC1.BackColor = System.Drawing.Color.Bisque;
            this.viewAllStdUC1.Location = new System.Drawing.Point(153, 0);
            this.viewAllStdUC1.Name = "viewAllStdUC1";
            this.viewAllStdUC1.Size = new System.Drawing.Size(665, 447);
            this.viewAllStdUC1.TabIndex = 5;
            // 
            // deleteStdUC1
            // 
            this.deleteStdUC1.BackColor = System.Drawing.Color.Thistle;
            this.deleteStdUC1.Location = new System.Drawing.Point(153, 2);
            this.deleteStdUC1.Name = "deleteStdUC1";
            this.deleteStdUC1.Size = new System.Drawing.Size(665, 447);
            this.deleteStdUC1.TabIndex = 4;
            // 
            // manageStd1
            // 
            this.manageStd1.BackColor = System.Drawing.Color.Wheat;
            this.manageStd1.Location = new System.Drawing.Point(153, 2);
            this.manageStd1.Name = "manageStd1";
            this.manageStd1.Size = new System.Drawing.Size(665, 447);
            this.manageStd1.TabIndex = 2;
            // 
            // manageProjBtn
            // 
            this.manageProjBtn.BackColor = System.Drawing.Color.Linen;
            this.manageProjBtn.FlatAppearance.BorderSize = 0;
            this.manageProjBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageProjBtn.Location = new System.Drawing.Point(1, 192);
            this.manageProjBtn.Name = "manageProjBtn";
            this.manageProjBtn.Size = new System.Drawing.Size(150, 29);
            this.manageProjBtn.TabIndex = 7;
            this.manageProjBtn.Text = "Manage Project";
            this.manageProjBtn.UseVisualStyleBackColor = false;
            this.manageProjBtn.Click += new System.EventHandler(this.manageProjBtn_Click);
            // 
            // projectSubmenu
            // 
            this.projectSubmenu.BackColor = System.Drawing.Color.Gray;
            this.projectSubmenu.Controls.Add(this.viewDelBtn);
            this.projectSubmenu.Controls.Add(this.addUptBtn);
            this.projectSubmenu.Location = new System.Drawing.Point(80, 221);
            this.projectSubmenu.Name = "projectSubmenu";
            this.projectSubmenu.Size = new System.Drawing.Size(70, 59);
            this.projectSubmenu.TabIndex = 7;
            // 
            // viewDelBtn
            // 
            this.viewDelBtn.BackColor = System.Drawing.Color.Linen;
            this.viewDelBtn.FlatAppearance.BorderSize = 0;
            this.viewDelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDelBtn.Location = new System.Drawing.Point(0, 30);
            this.viewDelBtn.Name = "viewDelBtn";
            this.viewDelBtn.Size = new System.Drawing.Size(67, 23);
            this.viewDelBtn.TabIndex = 4;
            this.viewDelBtn.Text = "Update";
            this.viewDelBtn.UseVisualStyleBackColor = false;
            // 
            // addUptBtn
            // 
            this.addUptBtn.BackColor = System.Drawing.Color.Linen;
            this.addUptBtn.FlatAppearance.BorderSize = 0;
            this.addUptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUptBtn.Location = new System.Drawing.Point(0, 3);
            this.addUptBtn.Name = "addUptBtn";
            this.addUptBtn.Size = new System.Drawing.Size(67, 21);
            this.addUptBtn.TabIndex = 2;
            this.addUptBtn.Text = "Add";
            this.addUptBtn.UseVisualStyleBackColor = false;
            this.addUptBtn.Click += new System.EventHandler(this.addUptBtn_Click);
            // 
            // addUpdate1
            // 
            this.addUpdate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(155)))));
            this.addUpdate1.Location = new System.Drawing.Point(153, 0);
            this.addUpdate1.Name = "addUpdate1";
            this.addUpdate1.Size = new System.Drawing.Size(665, 450);
            this.addUpdate1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.addUpdate1);
            this.Controls.Add(this.updateAdvUC1);
            this.Controls.Add(this.viewAdvisorUC1);
            this.Controls.Add(this.addAdvisor1);
            this.Controls.Add(this.updateStdUC1);
            this.Controls.Add(this.viewAllStdUC1);
            this.Controls.Add(this.deleteStdUC1);
            this.Controls.Add(this.sidemenu_panel);
            this.Controls.Add(this.manageStd1);
            this.MinimumSize = new System.Drawing.Size(718, 437);
            this.Name = "Form1";
            this.Text = "Form1";
            this.stdSubMenu.ResumeLayout(false);
            this.sidemenu_panel.ResumeLayout(false);
            this.advSubmenu.ResumeLayout(false);
            this.projectSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageStd;
        private System.Windows.Forms.Panel stdSubMenu;
        private System.Windows.Forms.Button updateStd_btn;
        private System.Windows.Forms.Button addStd_btn;
        private System.Windows.Forms.Button viewStd_btn;
        private AddStd manageStd1;
        private System.Windows.Forms.Panel sidemenu_panel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Button deleteStd_btn;
        private DeleteStdUC deleteStdUC1;
        private ViewAllStdUC viewAllStdUC1;
        private UpdateStdUC updateStdUC1;
        private AddAdvisor addAdvisor1;
        private System.Windows.Forms.Panel advSubmenu;
        private System.Windows.Forms.Button updateAdvBtn;
        private System.Windows.Forms.Button addAdvBtn;
        private System.Windows.Forms.Button viewAdvBtn;
        private System.Windows.Forms.Button manageAdvBtn;
        private ViewAdvisorUC viewAdvisorUC1;
        private UpdateAdvUC updateAdvUC1;
        private System.Windows.Forms.Button manageProjBtn;
        private System.Windows.Forms.Panel projectSubmenu;
        private System.Windows.Forms.Button viewDelBtn;
        private System.Windows.Forms.Button addUptBtn;
        private AddUpdate addUpdate1;
    }
}

