namespace DBMidProject
{
    partial class AddAdvisor
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.addAdvBtn = new System.Windows.Forms.Button();
            this.advSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.designationAdv = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.advisorDataView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.advId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advisorDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 32);
            this.label8.TabIndex = 34;
            this.label8.Text = "Add Advisors";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(300, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 1);
            this.panel3.TabIndex = 31;
            // 
            // addAdvBtn
            // 
            this.addAdvBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addAdvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAdvBtn.Location = new System.Drawing.Point(295, 220);
            this.addAdvBtn.Name = "addAdvBtn";
            this.addAdvBtn.Size = new System.Drawing.Size(100, 23);
            this.addAdvBtn.TabIndex = 28;
            this.addAdvBtn.Text = "Add Advisor";
            this.addAdvBtn.UseVisualStyleBackColor = false;
            this.addAdvBtn.Click += new System.EventHandler(this.addStdBtn_Click);
            // 
            // advSalary
            // 
            this.advSalary.BackColor = System.Drawing.Color.Cornsilk;
            this.advSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advSalary.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advSalary.Location = new System.Drawing.Point(300, 129);
            this.advSalary.Name = "advSalary";
            this.advSalary.Size = new System.Drawing.Size(100, 16);
            this.advSalary.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Designation";
            // 
            // designationAdv
            // 
            this.designationAdv.FormattingEnabled = true;
            this.designationAdv.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.designationAdv.Location = new System.Drawing.Point(295, 165);
            this.designationAdv.Name = "designationAdv";
            this.designationAdv.Size = new System.Drawing.Size(121, 21);
            this.designationAdv.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.advisorDataView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 192);
            this.panel1.TabIndex = 35;
            // 
            // advisorDataView
            // 
            this.advisorDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.advisorDataView.Location = new System.Drawing.Point(0, 0);
            this.advisorDataView.Name = "advisorDataView";
            this.advisorDataView.Size = new System.Drawing.Size(665, 192);
            this.advisorDataView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(300, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 1);
            this.panel2.TabIndex = 38;
            // 
            // advId
            // 
            this.advId.BackColor = System.Drawing.Color.Cornsilk;
            this.advId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advId.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advId.Location = new System.Drawing.Point(300, 95);
            this.advId.Name = "advId";
            this.advId.Size = new System.Drawing.Size(100, 16);
            this.advId.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // AddAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.advId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.designationAdv);
            this.Controls.Add(this.addAdvBtn);
            this.Controls.Add(this.advSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "AddAdvisor";
            this.Size = new System.Drawing.Size(665, 447);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advisorDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addAdvBtn;
        private System.Windows.Forms.TextBox advSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox designationAdv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView advisorDataView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox advId;
        private System.Windows.Forms.Label label1;
    }
}
