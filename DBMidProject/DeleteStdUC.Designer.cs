namespace DBMidProject
{
    partial class DeleteStdUC
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteStdBtn = new System.Windows.Forms.Button();
            this.stdRegNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentDataView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(265, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 32);
            this.label8.TabIndex = 34;
            this.label8.Text = "Delete Student";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(358, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(101, 1);
            this.panel5.TabIndex = 33;
            // 
            // deleteStdBtn
            // 
            this.deleteStdBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteStdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteStdBtn.Location = new System.Drawing.Point(308, 188);
            this.deleteStdBtn.Name = "deleteStdBtn";
            this.deleteStdBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteStdBtn.TabIndex = 28;
            this.deleteStdBtn.Text = "Delete Student";
            this.deleteStdBtn.UseVisualStyleBackColor = false;
            this.deleteStdBtn.Click += new System.EventHandler(this.deleteStdBtn_Click);
            // 
            // stdRegNo
            // 
            this.stdRegNo.BackColor = System.Drawing.Color.Thistle;
            this.stdRegNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdRegNo.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdRegNo.Location = new System.Drawing.Point(358, 126);
            this.stdRegNo.Name = "stdRegNo";
            this.stdRegNo.Size = new System.Drawing.Size(100, 16);
            this.stdRegNo.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Registration Number";
            // 
            // studentDataView
            // 
            this.studentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentDataView.Location = new System.Drawing.Point(0, 3);
            this.studentDataView.Name = "studentDataView";
            this.studentDataView.Size = new System.Drawing.Size(715, 231);
            this.studentDataView.TabIndex = 35;
            this.studentDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentDataView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 234);
            this.panel1.TabIndex = 36;
            // 
            // DeleteStdUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.deleteStdBtn);
            this.Controls.Add(this.stdRegNo);
            this.Controls.Add(this.label7);
            this.Name = "DeleteStdUC";
            this.Size = new System.Drawing.Size(715, 507);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button deleteStdBtn;
        private System.Windows.Forms.TextBox stdRegNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView studentDataView;
        private System.Windows.Forms.Panel panel1;
    }
}
