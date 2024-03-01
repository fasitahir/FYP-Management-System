namespace DBMidProject
{
    partial class ViewAllStdUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.allStdBtn = new System.Windows.Forms.Button();
            this.viewCurrent_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.studentDataView = new System.Windows.Forms.DataGridView();
            this.noteLabel = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentDataView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 199);
            this.panel1.TabIndex = 0;
            // 
            // allStdBtn
            // 
            this.allStdBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.allStdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allStdBtn.Location = new System.Drawing.Point(458, 191);
            this.allStdBtn.Name = "allStdBtn";
            this.allStdBtn.Size = new System.Drawing.Size(129, 23);
            this.allStdBtn.TabIndex = 29;
            this.allStdBtn.Text = "View All Students";
            this.allStdBtn.UseVisualStyleBackColor = false;
            this.allStdBtn.Click += new System.EventHandler(this.allStdBtn_Click);
            // 
            // viewCurrent_btn
            // 
            this.viewCurrent_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewCurrent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewCurrent_btn.Location = new System.Drawing.Point(51, 191);
            this.viewCurrent_btn.Name = "viewCurrent_btn";
            this.viewCurrent_btn.Size = new System.Drawing.Size(129, 23);
            this.viewCurrent_btn.TabIndex = 30;
            this.viewCurrent_btn.Text = "View Current Students";
            this.viewCurrent_btn.UseVisualStyleBackColor = false;
            this.viewCurrent_btn.Click += new System.EventHandler(this.viewCurrent_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Search and View Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Search";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(245, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 1);
            this.panel5.TabIndex = 35;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.Bisque;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(245, 97);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(183, 16);
            this.searchBar.TabIndex = 34;
            // 
            // studentDataView
            // 
            this.studentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentDataView.Location = new System.Drawing.Point(0, 0);
            this.studentDataView.Name = "studentDataView";
            this.studentDataView.Size = new System.Drawing.Size(665, 199);
            this.studentDataView.TabIndex = 0;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(163, 228);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(309, 17);
            this.noteLabel.TabIndex = 36;
            this.noteLabel.Text = "Note: Students with \'*\' at end of RegNo are deleted";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(270, 130);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 23);
            this.searchBtn.TabIndex = 37;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // ViewAllStdUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewCurrent_btn);
            this.Controls.Add(this.allStdBtn);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAllStdUC";
            this.Size = new System.Drawing.Size(665, 447);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button allStdBtn;
        private System.Windows.Forms.Button viewCurrent_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.DataGridView studentDataView;
        private System.Windows.Forms.Label noteLabel;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button searchBtn;
    }
}
