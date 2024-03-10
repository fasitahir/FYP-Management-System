namespace DBMidProject
{
    partial class viewDelProjUC
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
            this.noteLabel = new System.Windows.Forms.Label();
            this.viewCurrent_btn = new System.Windows.Forms.Button();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.projectDataView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 284);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 223);
            this.panel6.TabIndex = 76;
            // 
            // projectDataView
            // 
            this.projectDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectDataView.Location = new System.Drawing.Point(0, 3);
            this.projectDataView.Name = "projectDataView";
            this.projectDataView.ReadOnly = true;
            this.projectDataView.Size = new System.Drawing.Size(715, 220);
            this.projectDataView.TabIndex = 0;
            this.projectDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectDataView_CellClick);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(462, 77);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(50, 21);
            this.searchBtn.TabIndex = 86;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(258, 97);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 1);
            this.panel7.TabIndex = 85;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(200)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(258, 82);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(183, 16);
            this.searchBar.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(199, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 84;
            this.label9.Text = "Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(252, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 32);
            this.label8.TabIndex = 82;
            this.label8.Text = "View/Delete Project";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(227, 244);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(302, 17);
            this.noteLabel.TabIndex = 89;
            this.noteLabel.Text = "Note: Projects with \' * \' at end of Titles are deleted";
            // 
            // viewCurrent_btn
            // 
            this.viewCurrent_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewCurrent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewCurrent_btn.Location = new System.Drawing.Point(90, 148);
            this.viewCurrent_btn.Name = "viewCurrent_btn";
            this.viewCurrent_btn.Size = new System.Drawing.Size(129, 23);
            this.viewCurrent_btn.TabIndex = 88;
            this.viewCurrent_btn.Text = "View Current Projects";
            this.viewCurrent_btn.UseVisualStyleBackColor = false;
            this.viewCurrent_btn.Click += new System.EventHandler(this.viewCurrent_btn_Click);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewAllBtn.Location = new System.Drawing.Point(501, 148);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(129, 23);
            this.viewAllBtn.TabIndex = 87;
            this.viewAllBtn.Text = "View All Projects";
            this.viewAllBtn.UseVisualStyleBackColor = false;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Location = new System.Drawing.Point(289, 204);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(129, 23);
            this.deleteBtn.TabIndex = 90;
            this.deleteBtn.Text = "Delete Projects";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // viewDelProjUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.viewCurrent_btn);
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Name = "viewDelProjUC";
            this.Size = new System.Drawing.Size(715, 507);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).EndInit();
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
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Button viewCurrent_btn;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}
