namespace DBMidProject
{
    partial class AddUpdate
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.proTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.proDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.projectDataView = new System.Windows.Forms.DataGridView();
            this.updateProBtn = new System.Windows.Forms.Button();
            this.addProBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(302, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 1);
            this.panel3.TabIndex = 69;
            // 
            // proTitle
            // 
            this.proTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(155)))));
            this.proTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proTitle.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proTitle.Location = new System.Drawing.Point(302, 158);
            this.proTitle.Name = "proTitle";
            this.proTitle.Size = new System.Drawing.Size(100, 16);
            this.proTitle.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 32);
            this.label8.TabIndex = 71;
            this.label8.Text = "Add/Update Project";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(303, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(101, 1);
            this.panel5.TabIndex = 74;
            // 
            // proDescription
            // 
            this.proDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(155)))));
            this.proDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proDescription.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proDescription.Location = new System.Drawing.Point(303, 124);
            this.proDescription.Name = "proDescription";
            this.proDescription.Size = new System.Drawing.Size(100, 16);
            this.proDescription.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Description";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.projectDataView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 282);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(665, 168);
            this.panel6.TabIndex = 75;
            // 
            // projectDataView
            // 
            this.projectDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectDataView.Location = new System.Drawing.Point(0, 0);
            this.projectDataView.Name = "projectDataView";
            this.projectDataView.ReadOnly = true;
            this.projectDataView.Size = new System.Drawing.Size(665, 168);
            this.projectDataView.TabIndex = 0;
            this.projectDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectDataView_CellClick);
            // 
            // updateProBtn
            // 
            this.updateProBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateProBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateProBtn.Location = new System.Drawing.Point(449, 210);
            this.updateProBtn.Name = "updateProBtn";
            this.updateProBtn.Size = new System.Drawing.Size(100, 23);
            this.updateProBtn.TabIndex = 76;
            this.updateProBtn.Text = "Update Project";
            this.updateProBtn.UseVisualStyleBackColor = false;
            this.updateProBtn.Click += new System.EventHandler(this.updateProBtn_Click);
            // 
            // addProBtn
            // 
            this.addProBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addProBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProBtn.Location = new System.Drawing.Point(157, 210);
            this.addProBtn.Name = "addProBtn";
            this.addProBtn.Size = new System.Drawing.Size(100, 23);
            this.addProBtn.TabIndex = 77;
            this.addProBtn.Text = "Add Project";
            this.addProBtn.UseVisualStyleBackColor = false;
            this.addProBtn.Click += new System.EventHandler(this.addProBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(449, 61);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(50, 21);
            this.searchBtn.TabIndex = 81;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(245, 81);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 1);
            this.panel7.TabIndex = 80;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(155)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(245, 66);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(183, 16);
            this.searchBar.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 79;
            this.label9.Text = "Search";
            // 
            // AddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(155)))));
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addProBtn);
            this.Controls.Add(this.updateProBtn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.proDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.proTitle);
            this.Controls.Add(this.label2);
            this.Name = "AddUpdate";
            this.Size = new System.Drawing.Size(665, 450);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox proTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox proDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView projectDataView;
        private System.Windows.Forms.Button updateProBtn;
        private System.Windows.Forms.Button addProBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label9;
    }
}
