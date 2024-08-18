namespace GPA_Calculator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSub1 = new System.Windows.Forms.TextBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSub2 = new System.Windows.Forms.TextBox();
            this.txtSub3 = new System.Windows.Forms.TextBox();
            this.txtSub4 = new System.Windows.Forms.TextBox();
            this.txtSub5 = new System.Windows.Forms.TextBox();
            this.txtSub6 = new System.Windows.Forms.TextBox();
            this.txtSub7 = new System.Windows.Forms.TextBox();
            this.txtSub8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCredit1 = new System.Windows.Forms.TextBox();
            this.txtCredit2 = new System.Windows.Forms.TextBox();
            this.txtCredit3 = new System.Windows.Forms.TextBox();
            this.txtCredit4 = new System.Windows.Forms.TextBox();
            this.txtCredit5 = new System.Windows.Forms.TextBox();
            this.txtCredit6 = new System.Windows.Forms.TextBox();
            this.txtCredit7 = new System.Windows.Forms.TextBox();
            this.txtCredit8 = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbResult1 = new System.Windows.Forms.ComboBox();
            this.cbResult2 = new System.Windows.Forms.ComboBox();
            this.cbResult3 = new System.Windows.Forms.ComboBox();
            this.cbResult4 = new System.Windows.Forms.ComboBox();
            this.cbResult5 = new System.Windows.Forms.ComboBox();
            this.cbResult6 = new System.Windows.Forms.ComboBox();
            this.cbResult7 = new System.Windows.Forms.ComboBox();
            this.cbResult8 = new System.Windows.Forms.ComboBox();
            this.cbWeight = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(28, 40);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(135, 25);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Suject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resalt";
            // 
            // txtSub1
            // 
            this.txtSub1.Location = new System.Drawing.Point(15, 80);
            this.txtSub1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(279, 27);
            this.txtSub1.TabIndex = 2;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectName,
            this.result,
            this.credit,
            this.gpa,
            this.weight});
            this.dgvTable.Location = new System.Drawing.Point(770, 40);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(657, 566);
            this.dgvTable.TabIndex = 3;
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "Subject Name";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            this.subjectName.Width = 125;
            // 
            // result
            // 
            this.result.HeaderText = "Result";
            this.result.MinimumWidth = 6;
            this.result.Name = "result";
            this.result.Width = 125;
            // 
            // credit
            // 
            this.credit.HeaderText = "Credit";
            this.credit.MinimumWidth = 6;
            this.credit.Name = "credit";
            this.credit.Width = 125;
            // 
            // gpa
            // 
            this.gpa.HeaderText = "GPA";
            this.gpa.MinimumWidth = 6;
            this.gpa.Name = "gpa";
            this.gpa.Width = 125;
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.Width = 125;
            // 
            // txtSub2
            // 
            this.txtSub2.Location = new System.Drawing.Point(15, 115);
            this.txtSub2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.Size = new System.Drawing.Size(279, 27);
            this.txtSub2.TabIndex = 2;
            // 
            // txtSub3
            // 
            this.txtSub3.Location = new System.Drawing.Point(15, 150);
            this.txtSub3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub3.Name = "txtSub3";
            this.txtSub3.Size = new System.Drawing.Size(279, 27);
            this.txtSub3.TabIndex = 2;
            // 
            // txtSub4
            // 
            this.txtSub4.Location = new System.Drawing.Point(15, 185);
            this.txtSub4.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub4.Name = "txtSub4";
            this.txtSub4.Size = new System.Drawing.Size(279, 27);
            this.txtSub4.TabIndex = 2;
            // 
            // txtSub5
            // 
            this.txtSub5.Location = new System.Drawing.Point(15, 220);
            this.txtSub5.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub5.Name = "txtSub5";
            this.txtSub5.Size = new System.Drawing.Size(279, 27);
            this.txtSub5.TabIndex = 2;
            this.txtSub5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSub6
            // 
            this.txtSub6.Location = new System.Drawing.Point(15, 255);
            this.txtSub6.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub6.Name = "txtSub6";
            this.txtSub6.Size = new System.Drawing.Size(279, 27);
            this.txtSub6.TabIndex = 2;
            // 
            // txtSub7
            // 
            this.txtSub7.Location = new System.Drawing.Point(15, 290);
            this.txtSub7.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub7.Name = "txtSub7";
            this.txtSub7.Size = new System.Drawing.Size(279, 27);
            this.txtSub7.TabIndex = 2;
            // 
            // txtSub8
            // 
            this.txtSub8.Location = new System.Drawing.Point(15, 325);
            this.txtSub8.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub8.Name = "txtSub8";
            this.txtSub8.Size = new System.Drawing.Size(279, 27);
            this.txtSub8.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit";
            // 
            // txtCredit1
            // 
            this.txtCredit1.Location = new System.Drawing.Point(489, 80);
            this.txtCredit1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit1.Name = "txtCredit1";
            this.txtCredit1.Size = new System.Drawing.Size(124, 27);
            this.txtCredit1.TabIndex = 2;
            // 
            // txtCredit2
            // 
            this.txtCredit2.Location = new System.Drawing.Point(489, 115);
            this.txtCredit2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit2.Name = "txtCredit2";
            this.txtCredit2.Size = new System.Drawing.Size(124, 27);
            this.txtCredit2.TabIndex = 2;
            // 
            // txtCredit3
            // 
            this.txtCredit3.Location = new System.Drawing.Point(489, 150);
            this.txtCredit3.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit3.Name = "txtCredit3";
            this.txtCredit3.Size = new System.Drawing.Size(124, 27);
            this.txtCredit3.TabIndex = 2;
            // 
            // txtCredit4
            // 
            this.txtCredit4.Location = new System.Drawing.Point(489, 185);
            this.txtCredit4.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit4.Name = "txtCredit4";
            this.txtCredit4.Size = new System.Drawing.Size(124, 27);
            this.txtCredit4.TabIndex = 2;
            // 
            // txtCredit5
            // 
            this.txtCredit5.Location = new System.Drawing.Point(489, 220);
            this.txtCredit5.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit5.Name = "txtCredit5";
            this.txtCredit5.Size = new System.Drawing.Size(124, 27);
            this.txtCredit5.TabIndex = 2;
            // 
            // txtCredit6
            // 
            this.txtCredit6.Location = new System.Drawing.Point(489, 255);
            this.txtCredit6.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit6.Name = "txtCredit6";
            this.txtCredit6.Size = new System.Drawing.Size(124, 27);
            this.txtCredit6.TabIndex = 2;
            // 
            // txtCredit7
            // 
            this.txtCredit7.Location = new System.Drawing.Point(489, 290);
            this.txtCredit7.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit7.Name = "txtCredit7";
            this.txtCredit7.Size = new System.Drawing.Size(124, 27);
            this.txtCredit7.TabIndex = 2;
            // 
            // txtCredit8
            // 
            this.txtCredit8.Location = new System.Drawing.Point(489, 325);
            this.txtCredit8.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredit8.Name = "txtCredit8";
            this.txtCredit8.Size = new System.Drawing.Size(124, 27);
            this.txtCredit8.TabIndex = 2;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(655, 40);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 25);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(948, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Credit";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(438, 544);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 51);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(603, 544);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 51);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbResult1
            // 
            this.cbResult1.FormattingEnabled = true;
            this.cbResult1.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E"});
            this.cbResult1.Location = new System.Drawing.Point(336, 82);
            this.cbResult1.Name = "cbResult1";
            this.cbResult1.Size = new System.Drawing.Size(121, 28);
            this.cbResult1.TabIndex = 6;
            // 
            // cbResult2
            // 
            this.cbResult2.FormattingEnabled = true;
            this.cbResult2.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E"});
            this.cbResult2.Location = new System.Drawing.Point(336, 116);
            this.cbResult2.Name = "cbResult2";
            this.cbResult2.Size = new System.Drawing.Size(121, 28);
            this.cbResult2.TabIndex = 6;
            // 
            // cbResult3
            // 
            this.cbResult3.FormattingEnabled = true;
            this.cbResult3.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E"});
            this.cbResult3.Location = new System.Drawing.Point(336, 150);
            this.cbResult3.Name = "cbResult3";
            this.cbResult3.Size = new System.Drawing.Size(121, 28);
            this.cbResult3.TabIndex = 6;
            // 
            // cbResult4
            // 
            this.cbResult4.FormattingEnabled = true;
            this.cbResult4.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E"});
            this.cbResult4.Location = new System.Drawing.Point(336, 185);
            this.cbResult4.Name = "cbResult4";
            this.cbResult4.Size = new System.Drawing.Size(121, 28);
            this.cbResult4.TabIndex = 6;
            // 
            // cbResult5
            // 
            this.cbResult5.FormattingEnabled = true;
            this.cbResult5.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E"});
            this.cbResult5.Location = new System.Drawing.Point(336, 220);
            this.cbResult5.Name = "cbResult5";
            this.cbResult5.Size = new System.Drawing.Size(121, 28);
            this.cbResult5.TabIndex = 6;
            // 
            // cbResult6
            // 
            this.cbResult6.FormattingEnabled = true;
            this.cbResult6.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E"});
            this.cbResult6.Location = new System.Drawing.Point(336, 254);
            this.cbResult6.Name = "cbResult6";
            this.cbResult6.Size = new System.Drawing.Size(121, 28);
            this.cbResult6.TabIndex = 6;
            // 
            // cbResult7
            // 
            this.cbResult7.FormattingEnabled = true;
            this.cbResult7.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E"});
            this.cbResult7.Location = new System.Drawing.Point(336, 288);
            this.cbResult7.Name = "cbResult7";
            this.cbResult7.Size = new System.Drawing.Size(121, 28);
            this.cbResult7.TabIndex = 6;
            // 
            // cbResult8
            // 
            this.cbResult8.FormattingEnabled = true;
            this.cbResult8.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E"});
            this.cbResult8.Location = new System.Drawing.Point(336, 325);
            this.cbResult8.Name = "cbResult8";
            this.cbResult8.Size = new System.Drawing.Size(121, 28);
            this.cbResult8.TabIndex = 6;
            this.cbResult8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // cbWeight
            // 
            this.cbWeight.FormattingEnabled = true;
            this.cbWeight.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbWeight.Location = new System.Drawing.Point(620, 82);
            this.cbWeight.Name = "cbWeight";
            this.cbWeight.Size = new System.Drawing.Size(121, 28);
            this.cbWeight.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 621);
            this.Controls.Add(this.cbResult8);
            this.Controls.Add(this.cbResult7);
            this.Controls.Add(this.cbResult6);
            this.Controls.Add(this.cbResult5);
            this.Controls.Add(this.cbResult4);
            this.Controls.Add(this.cbResult3);
            this.Controls.Add(this.cbResult2);
            this.Controls.Add(this.cbWeight);
            this.Controls.Add(this.cbResult1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.txtCredit8);
            this.Controls.Add(this.txtCredit7);
            this.Controls.Add(this.txtSub8);
            this.Controls.Add(this.txtCredit6);
            this.Controls.Add(this.txtSub7);
            this.Controls.Add(this.txtCredit5);
            this.Controls.Add(this.txtSub6);
            this.Controls.Add(this.txtCredit4);
            this.Controls.Add(this.txtSub5);
            this.Controls.Add(this.txtCredit3);
            this.Controls.Add(this.txtSub4);
            this.Controls.Add(this.txtCredit2);
            this.Controls.Add(this.txtSub3);
            this.Controls.Add(this.txtCredit1);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSub1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSub1;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TextBox txtSub2;
        private System.Windows.Forms.TextBox txtSub3;
        private System.Windows.Forms.TextBox txtSub4;
        private System.Windows.Forms.TextBox txtSub5;
        private System.Windows.Forms.TextBox txtSub6;
        private System.Windows.Forms.TextBox txtSub7;
        private System.Windows.Forms.TextBox txtSub8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCredit1;
        private System.Windows.Forms.TextBox txtCredit2;
        private System.Windows.Forms.TextBox txtCredit3;
        private System.Windows.Forms.TextBox txtCredit4;
        private System.Windows.Forms.TextBox txtCredit5;
        private System.Windows.Forms.TextBox txtCredit6;
        private System.Windows.Forms.TextBox txtCredit7;
        private System.Windows.Forms.TextBox txtCredit8;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.ComboBox cbResult1;
        private System.Windows.Forms.ComboBox cbResult2;
        private System.Windows.Forms.ComboBox cbResult3;
        private System.Windows.Forms.ComboBox cbResult4;
        private System.Windows.Forms.ComboBox cbResult5;
        private System.Windows.Forms.ComboBox cbResult6;
        private System.Windows.Forms.ComboBox cbResult7;
        private System.Windows.Forms.ComboBox cbResult8;
        private System.Windows.Forms.ComboBox cbWeight;
    }
}

