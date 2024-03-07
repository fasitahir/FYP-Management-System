namespace DBMidProject
{
    partial class assignProjectUC
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.projectDataView = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.assignProjectBtn = new System.Windows.Forms.Button();
            this.groupId_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.projectDataView);
            this.panel6.Location = new System.Drawing.Point(0, 233);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(322, 214);
            this.panel6.TabIndex = 77;
            // 
            // projectDataView
            // 
            this.projectDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectDataView.Location = new System.Drawing.Point(0, 3);
            this.projectDataView.Name = "projectDataView";
            this.projectDataView.ReadOnly = true;
            this.projectDataView.Size = new System.Drawing.Size(322, 211);
            this.projectDataView.TabIndex = 0;
            this.projectDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectDataView_CellClick);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(435, 66);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(50, 21);
            this.searchBtn.TabIndex = 90;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(231, 86);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 1);
            this.panel7.TabIndex = 89;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(245)))), ((int)(((byte)(207)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(231, 71);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(183, 16);
            this.searchBar.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 32);
            this.label8.TabIndex = 91;
            this.label8.Text = "Assign Project";
            // 
            // assignProjectBtn
            // 
            this.assignProjectBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.assignProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.assignProjectBtn.Location = new System.Drawing.Point(290, 166);
            this.assignProjectBtn.Name = "assignProjectBtn";
            this.assignProjectBtn.Size = new System.Drawing.Size(99, 21);
            this.assignProjectBtn.TabIndex = 92;
            this.assignProjectBtn.Text = "Assign Project";
            this.assignProjectBtn.UseVisualStyleBackColor = false;
            this.assignProjectBtn.Click += new System.EventHandler(this.assignProjectBtn_Click);
            // 
            // groupId_CB
            // 
            this.groupId_CB.FormattingEnabled = true;
            this.groupId_CB.Location = new System.Drawing.Point(290, 115);
            this.groupId_CB.Name = "groupId_CB";
            this.groupId_CB.Size = new System.Drawing.Size(121, 21);
            this.groupId_CB.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Group Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(325, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 214);
            this.panel1.TabIndex = 78;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(337, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 95;
            this.label2.Text = "All Projects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 30);
            this.label3.TabIndex = 96;
            this.label3.Text = "Assigned Projects";
            // 
            // assignProjectUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(245)))), ((int)(((byte)(207)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupId_CB);
            this.Controls.Add(this.assignProjectBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel6);
            this.Name = "assignProjectUC";
            this.Size = new System.Drawing.Size(665, 447);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView projectDataView;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button assignProjectBtn;
        private System.Windows.Forms.ComboBox groupId_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
