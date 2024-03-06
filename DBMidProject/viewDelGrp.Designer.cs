namespace DBMidProject
{
    partial class viewDelGrp
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
            this.grpDataView = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.viewAll = new System.Windows.Forms.Button();
            this.viewCurrent = new System.Windows.Forms.Button();
            this.noteLabel = new System.Windows.Forms.Label();
            this.updGrpBtn = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grpDataView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 293);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(665, 157);
            this.panel6.TabIndex = 64;
            // 
            // grpDataView
            // 
            this.grpDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpDataView.Location = new System.Drawing.Point(0, 3);
            this.grpDataView.Name = "grpDataView";
            this.grpDataView.Size = new System.Drawing.Size(665, 154);
            this.grpDataView.TabIndex = 0;
            this.grpDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpDataView_CellClick_1);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(414, 104);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(50, 25);
            this.searchBtn.TabIndex = 73;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(223, 128);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 1);
            this.panel7.TabIndex = 72;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(223, 113);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(183, 16);
            this.searchBar.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 32);
            this.label8.TabIndex = 69;
            this.label8.Text = "Create/Update Groups";
            // 
            // viewAll
            // 
            this.viewAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewAll.Location = new System.Drawing.Point(90, 226);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(119, 23);
            this.viewAll.TabIndex = 75;
            this.viewAll.Text = "View All Groups";
            this.viewAll.UseVisualStyleBackColor = false;
            this.viewAll.Click += new System.EventHandler(this.viewAll_Click);
            // 
            // viewCurrent
            // 
            this.viewCurrent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewCurrent.Location = new System.Drawing.Point(438, 226);
            this.viewCurrent.Name = "viewCurrent";
            this.viewCurrent.Size = new System.Drawing.Size(119, 23);
            this.viewCurrent.TabIndex = 74;
            this.viewCurrent.Text = "View Current Groups";
            this.viewCurrent.UseVisualStyleBackColor = false;
            this.viewCurrent.Click += new System.EventHandler(this.viewCurrent_Click);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.noteLabel.Location = new System.Drawing.Point(190, 275);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(276, 15);
            this.noteLabel.TabIndex = 76;
            this.noteLabel.Text = "NOTE: Groups with all inactive students are deleted";
            // 
            // updGrpBtn
            // 
            this.updGrpBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updGrpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updGrpBtn.Location = new System.Drawing.Point(261, 171);
            this.updGrpBtn.Name = "updGrpBtn";
            this.updGrpBtn.Size = new System.Drawing.Size(126, 23);
            this.updGrpBtn.TabIndex = 77;
            this.updGrpBtn.Text = "Delete Selected Group";
            this.updGrpBtn.UseVisualStyleBackColor = false;
            this.updGrpBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewDelGrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.Controls.Add(this.updGrpBtn);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.viewCurrent);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Name = "viewDelGrp";
            this.Size = new System.Drawing.Size(665, 450);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView grpDataView;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button viewAll;
        private System.Windows.Forms.Button viewCurrent;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Button updGrpBtn;
    }
}
