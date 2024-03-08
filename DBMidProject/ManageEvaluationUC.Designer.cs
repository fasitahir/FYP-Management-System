namespace DBMidProject
{
    partial class ManageEvaluationUC
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
            this.updateEvlBtn = new System.Windows.Forms.Button();
            this.addEvlBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.evaluationDataView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weightageTb = new System.Windows.Forms.TextBox();
            this.totalMarksTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteEvlBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateEvlBtn
            // 
            this.updateEvlBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateEvlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateEvlBtn.Location = new System.Drawing.Point(319, 244);
            this.updateEvlBtn.Name = "updateEvlBtn";
            this.updateEvlBtn.Size = new System.Drawing.Size(108, 21);
            this.updateEvlBtn.TabIndex = 118;
            this.updateEvlBtn.Text = "Update Evaluation";
            this.updateEvlBtn.UseVisualStyleBackColor = false;
            this.updateEvlBtn.Click += new System.EventHandler(this.updateEvlBtn_Click);
            // 
            // addEvlBtn
            // 
            this.addEvlBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addEvlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEvlBtn.Location = new System.Drawing.Point(319, 217);
            this.addEvlBtn.Name = "addEvlBtn";
            this.addEvlBtn.Size = new System.Drawing.Size(108, 21);
            this.addEvlBtn.TabIndex = 116;
            this.addEvlBtn.Text = "Add Evaluation";
            this.addEvlBtn.UseVisualStyleBackColor = false;
            this.addEvlBtn.Click += new System.EventHandler(this.addEvlBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 32);
            this.label8.TabIndex = 112;
            this.label8.Text = "Manage Evaluations";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.evaluationDataView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 309);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 198);
            this.panel6.TabIndex = 120;
            // 
            // evaluationDataView
            // 
            this.evaluationDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evaluationDataView.Location = new System.Drawing.Point(35, 15);
            this.evaluationDataView.Name = "evaluationDataView";
            this.evaluationDataView.ReadOnly = true;
            this.evaluationDataView.Size = new System.Drawing.Size(648, 165);
            this.evaluationDataView.TabIndex = 0;
            this.evaluationDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evaluationDataView_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(349, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 1);
            this.panel3.TabIndex = 128;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(349, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 1);
            this.panel4.TabIndex = 129;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(349, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 1);
            this.panel1.TabIndex = 127;
            // 
            // weightageTb
            // 
            this.weightageTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.weightageTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weightageTb.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightageTb.Location = new System.Drawing.Point(349, 181);
            this.weightageTb.Name = "weightageTb";
            this.weightageTb.Size = new System.Drawing.Size(100, 16);
            this.weightageTb.TabIndex = 125;
            // 
            // totalMarksTb
            // 
            this.totalMarksTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.totalMarksTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalMarksTb.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMarksTb.Location = new System.Drawing.Point(349, 140);
            this.totalMarksTb.Name = "totalMarksTb";
            this.totalMarksTb.Size = new System.Drawing.Size(100, 16);
            this.totalMarksTb.TabIndex = 123;
            // 
            // nameTb
            // 
            this.nameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTb.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(349, 105);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 16);
            this.nameTb.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 126;
            this.label2.Text = "Total Weightage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 124;
            this.label3.Text = "Total Marks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "Name";
            // 
            // deleteEvlBtn
            // 
            this.deleteEvlBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteEvlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteEvlBtn.Location = new System.Drawing.Point(319, 271);
            this.deleteEvlBtn.Name = "deleteEvlBtn";
            this.deleteEvlBtn.Size = new System.Drawing.Size(108, 21);
            this.deleteEvlBtn.TabIndex = 130;
            this.deleteEvlBtn.Text = "Delete Evaluation";
            this.deleteEvlBtn.UseVisualStyleBackColor = false;
            this.deleteEvlBtn.Click += new System.EventHandler(this.deleteEvlBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(477, 50);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(50, 21);
            this.searchBtn.TabIndex = 134;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(273, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 1);
            this.panel7.TabIndex = 133;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(273, 55);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(183, 16);
            this.searchBar.TabIndex = 131;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 132;
            this.label9.Text = "Search";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(591, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 21);
            this.button1.TabIndex = 135;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageEvaluationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteEvlBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.weightageTb);
            this.Controls.Add(this.totalMarksTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.updateEvlBtn);
            this.Controls.Add(this.addEvlBtn);
            this.Controls.Add(this.label8);
            this.Name = "ManageEvaluationUC";
            this.Size = new System.Drawing.Size(715, 507);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.evaluationDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateEvlBtn;
        private System.Windows.Forms.Button addEvlBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView evaluationDataView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox weightageTb;
        private System.Windows.Forms.TextBox totalMarksTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteEvlBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}
