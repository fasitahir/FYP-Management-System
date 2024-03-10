namespace DBMidProject
{
    partial class CreateUpdateGrp
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grpDataView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grpStatus = new System.Windows.Forms.ComboBox();
            this.updateStdBtn = new System.Windows.Forms.Button();
            this.stdRegNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createGrpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(437, 56);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(50, 25);
            this.searchBtn.TabIndex = 68;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(246, 80);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 1);
            this.panel7.TabIndex = 67;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(246, 65);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(183, 16);
            this.searchBar.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(187, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Search";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grpDataView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 336);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 171);
            this.panel6.TabIndex = 63;
            // 
            // grpDataView
            // 
            this.grpDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpDataView.Location = new System.Drawing.Point(0, 3);
            this.grpDataView.Name = "grpDataView";
            this.grpDataView.Size = new System.Drawing.Size(715, 168);
            this.grpDataView.TabIndex = 0;
            this.grpDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpDataView_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 32);
            this.label8.TabIndex = 62;
            this.label8.Text = "Create/Update Groups";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(295, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(101, 1);
            this.panel5.TabIndex = 61;
            // 
            // grpStatus
            // 
            this.grpStatus.FormattingEnabled = true;
            this.grpStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.grpStatus.Location = new System.Drawing.Point(289, 204);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(121, 21);
            this.grpStatus.TabIndex = 48;
            // 
            // updateStdBtn
            // 
            this.updateStdBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateStdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateStdBtn.Location = new System.Drawing.Point(465, 269);
            this.updateStdBtn.Name = "updateStdBtn";
            this.updateStdBtn.Size = new System.Drawing.Size(100, 23);
            this.updateStdBtn.TabIndex = 56;
            this.updateStdBtn.Text = "Update Group";
            this.updateStdBtn.UseVisualStyleBackColor = false;
            this.updateStdBtn.Click += new System.EventHandler(this.updateStdBtn_Click);
            // 
            // stdRegNo
            // 
            this.stdRegNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.stdRegNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdRegNo.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdRegNo.Location = new System.Drawing.Point(295, 131);
            this.stdRegNo.Name = "stdRegNo";
            this.stdRegNo.Size = new System.Drawing.Size(100, 16);
            this.stdRegNo.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Registration Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Status";
            // 
            // createGrpBtn
            // 
            this.createGrpBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createGrpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createGrpBtn.Location = new System.Drawing.Point(124, 269);
            this.createGrpBtn.Name = "createGrpBtn";
            this.createGrpBtn.Size = new System.Drawing.Size(100, 23);
            this.createGrpBtn.TabIndex = 69;
            this.createGrpBtn.Text = "Create Group";
            this.createGrpBtn.UseVisualStyleBackColor = false;
            this.createGrpBtn.Click += new System.EventHandler(this.createGrpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(172, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "For adding students put their regNo in comma separated pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(160, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 15);
            this.label2.TabIndex = 71;
            this.label2.Text = "NOTE: Minimum students in a group can be 3 and maximum can be 5";
            // 
            // CreateUpdateGrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createGrpBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.updateStdBtn);
            this.Controls.Add(this.stdRegNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "CreateUpdateGrp";
            this.Size = new System.Drawing.Size(715, 507);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView grpDataView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox grpStatus;
        private System.Windows.Forms.Button updateStdBtn;
        private System.Windows.Forms.TextBox stdRegNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createGrpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
