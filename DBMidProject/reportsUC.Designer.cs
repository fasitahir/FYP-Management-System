namespace DBMidProject
{
    partial class reportsUC
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
            this.genRepBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reportDataView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.reportsCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // genRepBtn
            // 
            this.genRepBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.genRepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genRepBtn.Location = new System.Drawing.Point(297, 219);
            this.genRepBtn.Name = "genRepBtn";
            this.genRepBtn.Size = new System.Drawing.Size(99, 21);
            this.genRepBtn.TabIndex = 93;
            this.genRepBtn.Text = "Generate";
            this.genRepBtn.UseVisualStyleBackColor = false;
            this.genRepBtn.Click += new System.EventHandler(this.genRepBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.reportDataView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 311);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 196);
            this.panel6.TabIndex = 94;
            // 
            // reportDataView
            // 
            this.reportDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportDataView.Location = new System.Drawing.Point(0, 3);
            this.reportDataView.Name = "reportDataView";
            this.reportDataView.Size = new System.Drawing.Size(715, 193);
            this.reportDataView.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 32);
            this.label8.TabIndex = 95;
            this.label8.Text = "Generate Reports";
            // 
            // reportsCb
            // 
            this.reportsCb.FormattingEnabled = true;
            this.reportsCb.Items.AddRange(new object[] {
            "Project and advisory board",
            "Marks Sheet",
            "Students who left more than 1 group",
            "Advisors with count of their projects",
            "Maximum marks in each evaluation"});
            this.reportsCb.Location = new System.Drawing.Point(297, 132);
            this.reportsCb.Name = "reportsCb";
            this.reportsCb.Size = new System.Drawing.Size(181, 21);
            this.reportsCb.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 97;
            this.label6.Text = "Reports";
            // 
            // reportsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportsCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.genRepBtn);
            this.Name = "reportsUC";
            this.Size = new System.Drawing.Size(715, 507);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genRepBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView reportDataView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox reportsCb;
        private System.Windows.Forms.Label label6;
    }
}
