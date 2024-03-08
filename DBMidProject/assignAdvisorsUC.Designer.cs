namespace DBMidProject
{
    partial class assignAdvisorsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.advRole_CB = new System.Windows.Forms.ComboBox();
            this.assignAdvBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.assignedDataView = new System.Windows.Forms.DataGridView();
            this.advisorDataView = new System.Windows.Forms.DataGridView();
            this.projectDataView = new System.Windows.Forms.DataGridView();
            this.showProjects = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.viewAdvisorsBtn = new System.Windows.Forms.Button();
            this.projectLabel = new System.Windows.Forms.Label();
            this.advisorLabel = new System.Windows.Forms.Label();
            this.viewAssigned = new System.Windows.Forms.Button();
            this.assignedLabel = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisorDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 102;
            this.label1.Text = "Advisor Role";
            // 
            // advRole_CB
            // 
            this.advRole_CB.FormattingEnabled = true;
            this.advRole_CB.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisor",
            "Industry Advisor"});
            this.advRole_CB.Location = new System.Drawing.Point(325, 74);
            this.advRole_CB.Name = "advRole_CB";
            this.advRole_CB.Size = new System.Drawing.Size(121, 21);
            this.advRole_CB.TabIndex = 101;
            // 
            // assignAdvBtn
            // 
            this.assignAdvBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.assignAdvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.assignAdvBtn.Location = new System.Drawing.Point(305, 146);
            this.assignAdvBtn.Name = "assignAdvBtn";
            this.assignAdvBtn.Size = new System.Drawing.Size(99, 21);
            this.assignAdvBtn.TabIndex = 100;
            this.assignAdvBtn.Text = "Assign Advisors";
            this.assignAdvBtn.UseVisualStyleBackColor = false;
            this.assignAdvBtn.Click += new System.EventHandler(this.assignAdvBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(273, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 32);
            this.label8.TabIndex = 99;
            this.label8.Text = "Assign Advisors";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.assignedDataView);
            this.panel6.Controls.Add(this.advisorDataView);
            this.panel6.Controls.Add(this.projectDataView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 325);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 182);
            this.panel6.TabIndex = 103;
            // 
            // assignedDataView
            // 
            this.assignedDataView.BackgroundColor = System.Drawing.Color.Gray;
            this.assignedDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedDataView.Location = new System.Drawing.Point(42, 14);
            this.assignedDataView.Name = "assignedDataView";
            this.assignedDataView.ReadOnly = true;
            this.assignedDataView.Size = new System.Drawing.Size(630, 165);
            this.assignedDataView.TabIndex = 2;
            // 
            // advisorDataView
            // 
            this.advisorDataView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.advisorDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorDataView.Location = new System.Drawing.Point(42, 3);
            this.advisorDataView.Name = "advisorDataView";
            this.advisorDataView.ReadOnly = true;
            this.advisorDataView.Size = new System.Drawing.Size(630, 165);
            this.advisorDataView.TabIndex = 1;
            // 
            // projectDataView
            // 
            this.projectDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataView.Location = new System.Drawing.Point(42, 14);
            this.projectDataView.Name = "projectDataView";
            this.projectDataView.ReadOnly = true;
            this.projectDataView.Size = new System.Drawing.Size(630, 165);
            this.projectDataView.TabIndex = 0;
            this.projectDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // showProjects
            // 
            this.showProjects.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.showProjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showProjects.Location = new System.Drawing.Point(133, 252);
            this.showProjects.Name = "showProjects";
            this.showProjects.Size = new System.Drawing.Size(92, 21);
            this.showProjects.TabIndex = 106;
            this.showProjects.Text = "View Projects";
            this.showProjects.UseVisualStyleBackColor = false;
            this.showProjects.Click += new System.EventHandler(this.showProjects_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(87, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "NOTE: For assigning advisor to project please select project and advisor from the" +
    " tables.";
            // 
            // viewAdvisorsBtn
            // 
            this.viewAdvisorsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewAdvisorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewAdvisorsBtn.Location = new System.Drawing.Point(478, 252);
            this.viewAdvisorsBtn.Name = "viewAdvisorsBtn";
            this.viewAdvisorsBtn.Size = new System.Drawing.Size(92, 21);
            this.viewAdvisorsBtn.TabIndex = 108;
            this.viewAdvisorsBtn.Text = "View Advisors";
            this.viewAdvisorsBtn.UseVisualStyleBackColor = false;
            this.viewAdvisorsBtn.Click += new System.EventHandler(this.viewAdvisorsBtn_Click);
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.Location = new System.Drawing.Point(297, 302);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(91, 20);
            this.projectLabel.TabIndex = 109;
            this.projectLabel.Text = "Project Data";
            // 
            // advisorLabel
            // 
            this.advisorLabel.AutoSize = true;
            this.advisorLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisorLabel.Location = new System.Drawing.Point(297, 302);
            this.advisorLabel.Name = "advisorLabel";
            this.advisorLabel.Size = new System.Drawing.Size(101, 20);
            this.advisorLabel.TabIndex = 110;
            this.advisorLabel.Text = "Advisors Data";
            // 
            // viewAssigned
            // 
            this.viewAssigned.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewAssigned.Location = new System.Drawing.Point(289, 199);
            this.viewAssigned.Name = "viewAssigned";
            this.viewAssigned.Size = new System.Drawing.Size(127, 21);
            this.viewAssigned.TabIndex = 111;
            this.viewAssigned.Text = "View Assigned Data";
            this.viewAssigned.UseVisualStyleBackColor = false;
            this.viewAssigned.Click += new System.EventHandler(this.viewAssigned_Click);
            // 
            // assignedLabel
            // 
            this.assignedLabel.AutoSize = true;
            this.assignedLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedLabel.Location = new System.Drawing.Point(299, 302);
            this.assignedLabel.Name = "assignedLabel";
            this.assignedLabel.Size = new System.Drawing.Size(105, 20);
            this.assignedLabel.TabIndex = 112;
            this.assignedLabel.Text = "Assigned Data";
            // 
            // assignAdvisorsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(211)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.assignedLabel);
            this.Controls.Add(this.viewAssigned);
            this.Controls.Add(this.advisorLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.viewAdvisorsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showProjects);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advRole_CB);
            this.Controls.Add(this.assignAdvBtn);
            this.Controls.Add(this.label8);
            this.Name = "assignAdvisorsUC";
            this.Size = new System.Drawing.Size(715, 507);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignedDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisorDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox advRole_CB;
        private System.Windows.Forms.Button assignAdvBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView projectDataView;
        private System.Windows.Forms.Button showProjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewAdvisorsBtn;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label advisorLabel;
        private System.Windows.Forms.DataGridView advisorDataView;
        private System.Windows.Forms.DataGridView assignedDataView;
        private System.Windows.Forms.Button viewAssigned;
        private System.Windows.Forms.Label assignedLabel;
    }
}
