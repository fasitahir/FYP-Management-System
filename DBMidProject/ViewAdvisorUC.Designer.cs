namespace DBMidProject
{
    partial class ViewAdvisorUC
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.noteLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewCurrent_btn = new System.Windows.Forms.Button();
            this.allStdBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.advisorDataView = new System.Windows.Forms.DataGridView();
            this.deleteAdvBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advisorDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(296, 105);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 23);
            this.searchBtn.TabIndex = 46;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(248, 279);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(211, 17);
            this.noteLabel.TabIndex = 45;
            this.noteLabel.Text = "Note: Advisors with \'*\'  are deleted";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(271, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 1);
            this.panel5.TabIndex = 44;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.PapayaWhip;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(271, 72);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(183, 16);
            this.searchBar.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 41;
            this.label1.Text = "Search and View Advisors";
            // 
            // viewCurrent_btn
            // 
            this.viewCurrent_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewCurrent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewCurrent_btn.Location = new System.Drawing.Point(96, 187);
            this.viewCurrent_btn.Name = "viewCurrent_btn";
            this.viewCurrent_btn.Size = new System.Drawing.Size(129, 23);
            this.viewCurrent_btn.TabIndex = 40;
            this.viewCurrent_btn.Text = "View Current Advisors";
            this.viewCurrent_btn.UseVisualStyleBackColor = false;
            this.viewCurrent_btn.Click += new System.EventHandler(this.viewCurrent_btn_Click);
            // 
            // allStdBtn
            // 
            this.allStdBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.allStdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allStdBtn.Location = new System.Drawing.Point(502, 187);
            this.allStdBtn.Name = "allStdBtn";
            this.allStdBtn.Size = new System.Drawing.Size(129, 23);
            this.allStdBtn.TabIndex = 39;
            this.allStdBtn.Text = "View All Advisors";
            this.allStdBtn.UseVisualStyleBackColor = false;
            this.allStdBtn.Click += new System.EventHandler(this.allStdBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.advisorDataView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 199);
            this.panel1.TabIndex = 38;
            // 
            // advisorDataView
            // 
            this.advisorDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.advisorDataView.Location = new System.Drawing.Point(0, 0);
            this.advisorDataView.Name = "advisorDataView";
            this.advisorDataView.Size = new System.Drawing.Size(715, 199);
            this.advisorDataView.TabIndex = 0;
            this.advisorDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advisorDataView_CellClick);
            // 
            // deleteAdvBtn
            // 
            this.deleteAdvBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteAdvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAdvBtn.Location = new System.Drawing.Point(292, 244);
            this.deleteAdvBtn.Name = "deleteAdvBtn";
            this.deleteAdvBtn.Size = new System.Drawing.Size(129, 23);
            this.deleteAdvBtn.TabIndex = 47;
            this.deleteAdvBtn.Text = "Delete Advisor";
            this.deleteAdvBtn.UseVisualStyleBackColor = false;
            this.deleteAdvBtn.Click += new System.EventHandler(this.deleteAdvBtn_Click);
            // 
            // ViewAdvisorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.deleteAdvBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewCurrent_btn);
            this.Controls.Add(this.allStdBtn);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAdvisorUC";
            this.Size = new System.Drawing.Size(715, 507);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advisorDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewCurrent_btn;
        private System.Windows.Forms.Button allStdBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView advisorDataView;
        private System.Windows.Forms.Button deleteAdvBtn;
    }
}
