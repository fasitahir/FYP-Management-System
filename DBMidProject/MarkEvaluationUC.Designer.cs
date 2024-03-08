namespace DBMidProject
{
    partial class MarkEvaluationUC
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.evaluationDataView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.obtainedMarksTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupId_CB = new System.Windows.Forms.ComboBox();
            this.markEvlBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showDataBtn = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(262, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 32);
            this.label8.TabIndex = 113;
            this.label8.Text = "Mark Evaluations";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.evaluationDataView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 309);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 198);
            this.panel6.TabIndex = 121;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(335, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 1);
            this.panel4.TabIndex = 132;
            // 
            // obtainedMarksTb
            // 
            this.obtainedMarksTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(157)))), ((int)(((byte)(230)))));
            this.obtainedMarksTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.obtainedMarksTb.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obtainedMarksTb.Location = new System.Drawing.Point(335, 114);
            this.obtainedMarksTb.Name = "obtainedMarksTb";
            this.obtainedMarksTb.Size = new System.Drawing.Size(121, 16);
            this.obtainedMarksTb.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 131;
            this.label3.Text = "Obtained Marks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 135;
            this.label1.Text = "Group Id";
            // 
            // groupId_CB
            // 
            this.groupId_CB.FormattingEnabled = true;
            this.groupId_CB.Location = new System.Drawing.Point(335, 150);
            this.groupId_CB.Name = "groupId_CB";
            this.groupId_CB.Size = new System.Drawing.Size(121, 21);
            this.groupId_CB.TabIndex = 134;
            // 
            // markEvlBtn
            // 
            this.markEvlBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.markEvlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.markEvlBtn.Location = new System.Drawing.Point(297, 205);
            this.markEvlBtn.Name = "markEvlBtn";
            this.markEvlBtn.Size = new System.Drawing.Size(99, 21);
            this.markEvlBtn.TabIndex = 133;
            this.markEvlBtn.Text = "Evaluate";
            this.markEvlBtn.UseVisualStyleBackColor = false;
            this.markEvlBtn.Click += new System.EventHandler(this.markEvlBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(575, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 21);
            this.button1.TabIndex = 136;
            this.button1.Text = "Show Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showDataBtn
            // 
            this.showDataBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.showDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showDataBtn.Location = new System.Drawing.Point(53, 282);
            this.showDataBtn.Name = "showDataBtn";
            this.showDataBtn.Size = new System.Drawing.Size(106, 21);
            this.showDataBtn.TabIndex = 137;
            this.showDataBtn.Text = "Show Evaluations";
            this.showDataBtn.UseVisualStyleBackColor = false;
            this.showDataBtn.Click += new System.EventHandler(this.showDataBtn_Click);
            // 
            // MarkEvaluationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(157)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.showDataBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupId_CB);
            this.Controls.Add(this.markEvlBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.obtainedMarksTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label8);
            this.Name = "MarkEvaluationUC";
            this.Size = new System.Drawing.Size(715, 507);
            this.Load += new System.EventHandler(this.MarkEvaluationUC_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.evaluationDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView evaluationDataView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox obtainedMarksTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupId_CB;
        private System.Windows.Forms.Button markEvlBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showDataBtn;
    }
}
