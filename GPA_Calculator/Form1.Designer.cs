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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cbWeight = new System.Windows.Forms.ComboBox();
            this.cbSubject1 = new System.Windows.Forms.ComboBox();
            this.cbSubject2 = new System.Windows.Forms.ComboBox();
            this.cbSubject3 = new System.Windows.Forms.ComboBox();
            this.cbSubject4 = new System.Windows.Forms.ComboBox();
            this.cbSubject5 = new System.Windows.Forms.ComboBox();
            this.cbSubject6 = new System.Windows.Forms.ComboBox();
            this.cbSubject7 = new System.Windows.Forms.ComboBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.cbCredit1 = new System.Windows.Forms.ComboBox();
            this.cbCredit2 = new System.Windows.Forms.ComboBox();
            this.cbCredit3 = new System.Windows.Forms.ComboBox();
            this.cbCredit4 = new System.Windows.Forms.ComboBox();
            this.cbCredit5 = new System.Windows.Forms.ComboBox();
            this.cbCredit6 = new System.Windows.Forms.ComboBox();
            this.cbCredit7 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.Navy;
            this.lblSubject.Location = new System.Drawing.Point(25, 36);
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
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(338, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resalt";
            // 
            // dgvTable
            // 
            this.dgvTable.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectName,
            this.result,
            this.subCredit,
            this.credit,
            this.gpa,
            this.weight});
            this.dgvTable.Location = new System.Drawing.Point(673, 36);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(591, 357);
            this.dgvTable.TabIndex = 3;
            // 
            // subjectName
            // 
            this.subjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectName.HeaderText = "Subject Name";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            // 
            // result
            // 
            this.result.HeaderText = "Result";
            this.result.MinimumWidth = 6;
            this.result.Name = "result";
            this.result.Width = 70;
            // 
            // subCredit
            // 
            this.subCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.subCredit.HeaderText = "SubCredit";
            this.subCredit.MinimumWidth = 6;
            this.subCredit.Name = "subCredit";
            this.subCredit.Width = 102;
            // 
            // credit
            // 
            this.credit.HeaderText = "Credit";
            this.credit.MinimumWidth = 6;
            this.credit.Name = "credit";
            this.credit.Width = 70;
            // 
            // gpa
            // 
            this.gpa.HeaderText = "GPA";
            this.gpa.MinimumWidth = 6;
            this.gpa.Name = "gpa";
            this.gpa.Width = 70;
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.Visible = false;
            this.weight.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(482, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Navy;
            this.lblWeight.Location = new System.Drawing.Point(590, 36);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 25);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Credit";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.YellowGreen;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(195, 324);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 46);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(313, 324);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 46);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
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
            "E"});
            this.cbResult1.Location = new System.Drawing.Point(330, 74);
            this.cbResult1.Name = "cbResult1";
            this.cbResult1.Size = new System.Drawing.Size(81, 26);
            this.cbResult1.TabIndex = 6;
            this.cbResult1.SelectedIndexChanged += new System.EventHandler(this.cbResult1_SelectedIndexChanged);
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
            "E"});
            this.cbResult2.Location = new System.Drawing.Point(330, 104);
            this.cbResult2.Name = "cbResult2";
            this.cbResult2.Size = new System.Drawing.Size(81, 26);
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
            "E"});
            this.cbResult3.Location = new System.Drawing.Point(330, 135);
            this.cbResult3.Name = "cbResult3";
            this.cbResult3.Size = new System.Drawing.Size(81, 26);
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
            "E"});
            this.cbResult4.Location = new System.Drawing.Point(330, 166);
            this.cbResult4.Name = "cbResult4";
            this.cbResult4.Size = new System.Drawing.Size(81, 26);
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
            "E"});
            this.cbResult5.Location = new System.Drawing.Point(330, 198);
            this.cbResult5.Name = "cbResult5";
            this.cbResult5.Size = new System.Drawing.Size(81, 26);
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
            "E"});
            this.cbResult6.Location = new System.Drawing.Point(330, 229);
            this.cbResult6.Name = "cbResult6";
            this.cbResult6.Size = new System.Drawing.Size(81, 26);
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
            "E"});
            this.cbResult7.Location = new System.Drawing.Point(330, 259);
            this.cbResult7.Name = "cbResult7";
            this.cbResult7.Size = new System.Drawing.Size(81, 26);
            this.cbResult7.TabIndex = 6;
            // 
            // cbWeight
            // 
            this.cbWeight.FormattingEnabled = true;
            this.cbWeight.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbWeight.Location = new System.Drawing.Point(595, 74);
            this.cbWeight.Name = "cbWeight";
            this.cbWeight.Size = new System.Drawing.Size(72, 26);
            this.cbWeight.TabIndex = 6;
            // 
            // cbSubject1
            // 
            this.cbSubject1.FormattingEnabled = true;
            this.cbSubject1.Items.AddRange(new object[] {
            "Principles Of Management ",
            "Introduction To Information Technology",
            "Business Mathematics",
            "Business English I",
            "Microeconomics",
            "Basic Tamil I",
            "Basic Sinhala I",
            "Human Resource Management ",
            "Financial Accounting ",
            "Business Statistics",
            "Business English II",
            "Marketing Management",
            "Basic Tamil II",
            "Basic Sinhala II",
            "Microeconomic",
            "Cost and Management Accounting ",
            "Management Information System",
            "Business Skill I",
            "BusinessLaw",
            "Career Guidance",
            "Operations Management ",
            "Financial Managment ",
            "Business Skill II",
            "Enterpreneurship and Innovation",
            "Fundamental Sociology and Phychology",
            "Peace and Social Harmony ",
            "Basic Science ",
            "Organizational Buhavior",
            "Operational Reserch",
            "Total Quality Management",
            "Organizational Development ",
            "Labor Law and Relations ",
            "Micro Finance ",
            "Project Manegment ",
            "Managerial Economics",
            "Reserch Methods",
            "Strategic Management ",
            "Contempory Issues in Management ",
            "Disaster Management ",
            "Computer Based Data Analysis",
            "Development Economics",
            "Service Management",
            "International Business",
            "E-Commerce ",
            "Independent Research in Business Management ",
            "Internship in Business Management ",
            "Service Marketing ",
            "Sales Manegement and Retail Marketing ",
            "Marketing Research",
            "Integarated Marketing Communication",
            "Brand Management ",
            "Performance Appraisal",
            "Human Resource Planing ",
            "Human Resource Development ",
            "Strategic Human Resource Managment ",
            "International Human Resource Management ",
            "Human Resource Information System",
            "Human resource Accounting ",
            "Investment and Portfolio Management",
            "Advance Financial Accounting",
            "Auditing ",
            "Computer Based Accounting ",
            "Taxation",
            "Advance Accounting Theory",
            "Public sector Accounting ",
            "Programming Concepts",
            "Systems Analysis and Design",
            "Data Communication and Computer Networks",
            "Professional Ethics and Responsibility",
            "Software Engineering ",
            "Object Oriented Programming ",
            "Web Development ",
            "Enterprise Resource Planning Sysytem",
            "Software Quality Assurance",
            "DataBase Management System"});
            this.cbSubject1.Location = new System.Drawing.Point(30, 74);
            this.cbSubject1.Name = "cbSubject1";
            this.cbSubject1.Size = new System.Drawing.Size(256, 26);
            this.cbSubject1.TabIndex = 7;
            this.cbSubject1.SelectedIndexChanged += new System.EventHandler(this.cbSubject1_SelectedIndexChanged);
            // 
            // cbSubject2
            // 
            this.cbSubject2.FormattingEnabled = true;
            this.cbSubject2.Items.AddRange(new object[] {
            "Principles Of Management ",
            "Introduction To Information Technology",
            "Business Mathematics",
            "Business English I",
            "Microeconomics",
            "Basic Tamil I",
            "Basic Sinhala I",
            "Human Resource Management ",
            "Financial Accounting ",
            "Business Statistics",
            "Business English II",
            "Marketing Management",
            "Basic Tamil II",
            "Basic Sinhala II",
            "Microeconomic",
            "Cost and Management Accounting ",
            "Management Information System",
            "Business Skill I",
            "BusinessLaw",
            "Career Guidance",
            "Operations Management ",
            "Financial Managment ",
            "Business Skill II",
            "Enterpreneurship and Innovation",
            "Fundamental Sociology and Phychology",
            "Peace and Social Harmony ",
            "Basic Science ",
            "Organizational Buhavior",
            "Operational Reserch",
            "Total Quality Management",
            "Organizational Development ",
            "Labor Law and Relations ",
            "Micro Finance ",
            "Project Manegment ",
            "Managerial Economics",
            "Reserch Methods",
            "Strategic Management ",
            "Contempory Issues in Management ",
            "Disaster Management ",
            "Computer Based Data Analysis",
            "Development Economics",
            "Service Management",
            "International Business",
            "E-Commerce ",
            "Independent Research in Business Management ",
            "Internship in Business Management ",
            "Service Marketing ",
            "Sales Manegement and Retail Marketing ",
            "Marketing Research",
            "Integarated Marketing Communication",
            "Brand Management ",
            "Performance Appraisal",
            "Human Resource Planing ",
            "Human Resource Development ",
            "Strategic Human Resource Managment ",
            "International Human Resource Management ",
            "Human Resource Information System",
            "Human resource Accounting ",
            "Investment and Portfolio Management",
            "Advance Financial Accounting",
            "Auditing ",
            "Computer Based Accounting ",
            "Taxation",
            "Advance Accounting Theory",
            "Public sector Accounting ",
            "Programming Concepts",
            "Systems Analysis and Design",
            "Data Communication and Computer Networks",
            "Professional Ethics and Responsibility",
            "Software Engineering ",
            "Object Oriented Programming ",
            "Web Development ",
            "Enterprise Resource Planning Sysytem",
            "Software Quality Assurance",
            "DataBase Management System"});
            this.cbSubject2.Location = new System.Drawing.Point(30, 103);
            this.cbSubject2.Name = "cbSubject2";
            this.cbSubject2.Size = new System.Drawing.Size(256, 26);
            this.cbSubject2.TabIndex = 7;
            // 
            // cbSubject3
            // 
            this.cbSubject3.FormattingEnabled = true;
            this.cbSubject3.Items.AddRange(new object[] {
            "Principles Of Management ",
            "Introduction To Information Technology",
            "Business Mathematics",
            "Business English I",
            "Microeconomics",
            "Basic Tamil I",
            "Basic Sinhala I",
            "Human Resource Management ",
            "Financial Accounting ",
            "Business Statistics",
            "Business English II",
            "Marketing Management",
            "Basic Tamil II",
            "Basic Sinhala II",
            "Microeconomic",
            "Cost and Management Accounting ",
            "Management Information System",
            "Business Skill I",
            "BusinessLaw",
            "Career Guidance",
            "Operations Management ",
            "Financial Managment ",
            "Business Skill II",
            "Enterpreneurship and Innovation",
            "Fundamental Sociology and Phychology",
            "Peace and Social Harmony ",
            "Basic Science ",
            "Organizational Buhavior",
            "Operational Reserch",
            "Total Quality Management",
            "Organizational Development ",
            "Labor Law and Relations ",
            "Micro Finance ",
            "Project Manegment ",
            "Managerial Economics",
            "Reserch Methods",
            "Strategic Management ",
            "Contempory Issues in Management ",
            "Disaster Management ",
            "Computer Based Data Analysis",
            "Development Economics",
            "Service Management",
            "International Business",
            "E-Commerce ",
            "Independent Research in Business Management ",
            "Internship in Business Management ",
            "Service Marketing ",
            "Sales Manegement and Retail Marketing ",
            "Marketing Research",
            "Integarated Marketing Communication",
            "Brand Management ",
            "Performance Appraisal",
            "Human Resource Planing ",
            "Human Resource Development ",
            "Strategic Human Resource Managment ",
            "International Human Resource Management ",
            "Human Resource Information System",
            "Human resource Accounting ",
            "Investment and Portfolio Management",
            "Advance Financial Accounting",
            "Auditing ",
            "Computer Based Accounting ",
            "Taxation",
            "Advance Accounting Theory",
            "Public sector Accounting ",
            "Programming Concepts",
            "Systems Analysis and Design",
            "Data Communication and Computer Networks",
            "Professional Ethics and Responsibility",
            "Software Engineering ",
            "Object Oriented Programming ",
            "Web Development ",
            "Enterprise Resource Planning Sysytem",
            "Software Quality Assurance",
            "DataBase Management System"});
            this.cbSubject3.Location = new System.Drawing.Point(30, 135);
            this.cbSubject3.Name = "cbSubject3";
            this.cbSubject3.Size = new System.Drawing.Size(256, 26);
            this.cbSubject3.TabIndex = 7;
            // 
            // cbSubject4
            // 
            this.cbSubject4.FormattingEnabled = true;
            this.cbSubject4.Items.AddRange(new object[] {
            "Principles Of Management ",
            "Introduction To Information Technology",
            "Business Mathematics",
            "Business English I",
            "Microeconomics",
            "Basic Tamil I",
            "Basic Sinhala I",
            "Human Resource Management ",
            "Financial Accounting ",
            "Business Statistics",
            "Business English II",
            "Marketing Management",
            "Basic Tamil II",
            "Basic Sinhala II",
            "Microeconomic",
            "Cost and Management Accounting ",
            "Management Information System",
            "Business Skill I",
            "BusinessLaw",
            "Career Guidance",
            "Operations Management ",
            "Financial Managment ",
            "Business Skill II",
            "Enterpreneurship and Innovation",
            "Fundamental Sociology and Phychology",
            "Peace and Social Harmony ",
            "Basic Science ",
            "Organizational Buhavior",
            "Operational Reserch",
            "Total Quality Management",
            "Organizational Development ",
            "Labor Law and Relations ",
            "Micro Finance ",
            "Project Manegment ",
            "Managerial Economics",
            "Reserch Methods",
            "Strategic Management ",
            "Contempory Issues in Management ",
            "Disaster Management ",
            "Computer Based Data Analysis",
            "Development Economics",
            "Service Management",
            "International Business",
            "E-Commerce ",
            "Independent Research in Business Management ",
            "Internship in Business Management ",
            "Service Marketing ",
            "Sales Manegement and Retail Marketing ",
            "Marketing Research",
            "Integarated Marketing Communication",
            "Brand Management ",
            "Performance Appraisal",
            "Human Resource Planing ",
            "Human Resource Development ",
            "Strategic Human Resource Managment ",
            "International Human Resource Management ",
            "Human Resource Information System",
            "Human resource Accounting ",
            "Investment and Portfolio Management",
            "Advance Financial Accounting",
            "Auditing ",
            "Computer Based Accounting ",
            "Taxation",
            "Advance Accounting Theory",
            "Public sector Accounting ",
            "Programming Concepts",
            "Systems Analysis and Design",
            "Data Communication and Computer Networks",
            "Professional Ethics and Responsibility",
            "Software Engineering ",
            "Object Oriented Programming ",
            "Web Development ",
            "Enterprise Resource Planning Sysytem",
            "Software Quality Assurance",
            "DataBase Management System"});
            this.cbSubject4.Location = new System.Drawing.Point(30, 166);
            this.cbSubject4.Name = "cbSubject4";
            this.cbSubject4.Size = new System.Drawing.Size(256, 26);
            this.cbSubject4.TabIndex = 7;
            // 
            // cbSubject5
            // 
            this.cbSubject5.FormattingEnabled = true;
            this.cbSubject5.Items.AddRange(new object[] {
            "Principles Of Management ",
            "Introduction To Information Technology",
            "Business Mathematics",
            "Business English I",
            "Microeconomics",
            "Basic Tamil I",
            "Basic Sinhala I",
            "Human Resource Management ",
            "Financial Accounting ",
            "Business Statistics",
            "Business English II",
            "Marketing Management",
            "Basic Tamil II",
            "Basic Sinhala II",
            "Microeconomic",
            "Cost and Management Accounting ",
            "Management Information System",
            "Business Skill I",
            "BusinessLaw",
            "Career Guidance",
            "Operations Management ",
            "Financial Managment ",
            "Business Skill II",
            "Enterpreneurship and Innovation",
            "Fundamental Sociology and Phychology",
            "Peace and Social Harmony ",
            "Basic Science ",
            "Organizational Buhavior",
            "Operational Reserch",
            "Total Quality Management",
            "Organizational Development ",
            "Labor Law and Relations ",
            "Micro Finance ",
            "Project Manegment ",
            "Managerial Economics",
            "Reserch Methods",
            "Strategic Management ",
            "Contempory Issues in Management ",
            "Disaster Management ",
            "Computer Based Data Analysis",
            "Development Economics",
            "Service Management",
            "International Business",
            "E-Commerce ",
            "Independent Research in Business Management ",
            "Internship in Business Management ",
            "Service Marketing ",
            "Sales Manegement and Retail Marketing ",
            "Marketing Research",
            "Integarated Marketing Communication",
            "Brand Management ",
            "Performance Appraisal",
            "Human Resource Planing ",
            "Human Resource Development ",
            "Strategic Human Resource Managment ",
            "International Human Resource Management ",
            "Human Resource Information System",
            "Human resource Accounting ",
            "Investment and Portfolio Management",
            "Advance Financial Accounting",
            "Auditing ",
            "Computer Based Accounting ",
            "Taxation",
            "Advance Accounting Theory",
            "Public sector Accounting ",
            "Programming Concepts",
            "Systems Analysis and Design",
            "Data Communication and Computer Networks",
            "Professional Ethics and Responsibility",
            "Software Engineering ",
            "Object Oriented Programming ",
            "Web Development ",
            "Enterprise Resource Planning Sysytem",
            "Software Quality Assurance",
            "DataBase Management System"});
            this.cbSubject5.Location = new System.Drawing.Point(30, 198);
            this.cbSubject5.Name = "cbSubject5";
            this.cbSubject5.Size = new System.Drawing.Size(256, 26);
            this.cbSubject5.TabIndex = 7;
            // 
            // cbSubject6
            // 
            this.cbSubject6.FormattingEnabled = true;
            this.cbSubject6.Items.AddRange(new object[] {
            "Principles Of Management ",
            "Introduction To Information Technology",
            "Business Mathematics",
            "Business English I",
            "Microeconomics",
            "Basic Tamil I",
            "Basic Sinhala I",
            "Human Resource Management ",
            "Financial Accounting ",
            "Business Statistics",
            "Business English II",
            "Marketing Management",
            "Basic Tamil II",
            "Basic Sinhala II",
            "Microeconomic",
            "Cost and Management Accounting ",
            "Management Information System",
            "Business Skill I",
            "BusinessLaw",
            "Career Guidance",
            "Operations Management ",
            "Financial Managment ",
            "Business Skill II",
            "Enterpreneurship and Innovation",
            "Fundamental Sociology and Phychology",
            "Peace and Social Harmony ",
            "Basic Science ",
            "Organizational Buhavior",
            "Operational Reserch",
            "Total Quality Management",
            "Organizational Development ",
            "Labor Law and Relations ",
            "Micro Finance ",
            "Project Manegment ",
            "Managerial Economics",
            "Reserch Methods",
            "Strategic Management ",
            "Contempory Issues in Management ",
            "Disaster Management ",
            "Computer Based Data Analysis",
            "Development Economics",
            "Service Management",
            "International Business",
            "E-Commerce ",
            "Independent Research in Business Management ",
            "Internship in Business Management ",
            "Service Marketing ",
            "Sales Manegement and Retail Marketing ",
            "Marketing Research",
            "Integarated Marketing Communication",
            "Brand Management ",
            "Performance Appraisal",
            "Human Resource Planing ",
            "Human Resource Development ",
            "Strategic Human Resource Managment ",
            "International Human Resource Management ",
            "Human Resource Information System",
            "Human resource Accounting ",
            "Investment and Portfolio Management",
            "Advance Financial Accounting",
            "Auditing ",
            "Computer Based Accounting ",
            "Taxation",
            "Advance Accounting Theory",
            "Public sector Accounting ",
            "Programming Concepts",
            "Systems Analysis and Design",
            "Data Communication and Computer Networks",
            "Professional Ethics and Responsibility",
            "Software Engineering ",
            "Object Oriented Programming ",
            "Web Development ",
            "Enterprise Resource Planning Sysytem",
            "Software Quality Assurance",
            "DataBase Management System"});
            this.cbSubject6.Location = new System.Drawing.Point(30, 230);
            this.cbSubject6.Name = "cbSubject6";
            this.cbSubject6.Size = new System.Drawing.Size(256, 26);
            this.cbSubject6.TabIndex = 7;
            // 
            // cbSubject7
            // 
            this.cbSubject7.FormattingEnabled = true;
            this.cbSubject7.Items.AddRange(new object[] {
            "Principles Of Management ",
            "Introduction To Information Technology",
            "Business Mathematics",
            "Business English I",
            "Microeconomics",
            "Basic Tamil I",
            "Basic Sinhala I",
            "Human Resource Management ",
            "Financial Accounting ",
            "Business Statistics",
            "Business English II",
            "Marketing Management",
            "Basic Tamil II",
            "Basic Sinhala II",
            "Microeconomic",
            "Cost and Management Accounting ",
            "Management Information System",
            "Business Skill I",
            "BusinessLaw",
            "Career Guidance",
            "Operations Management ",
            "Financial Managment ",
            "Business Skill II",
            "Enterpreneurship and Innovation",
            "Fundamental Sociology and Phychology",
            "Peace and Social Harmony ",
            "Basic Science ",
            "Organizational Buhavior",
            "Operational Reserch",
            "Total Quality Management",
            "Organizational Development ",
            "Labor Law and Relations ",
            "Micro Finance ",
            "Project Manegment ",
            "Managerial Economics",
            "Reserch Methods",
            "Strategic Management ",
            "Contempory Issues in Management ",
            "Disaster Management ",
            "Computer Based Data Analysis",
            "Development Economics",
            "Service Management",
            "International Business",
            "E-Commerce ",
            "Independent Research in Business Management ",
            "Internship in Business Management ",
            "Service Marketing ",
            "Sales Manegement and Retail Marketing ",
            "Marketing Research",
            "Integarated Marketing Communication",
            "Brand Management ",
            "Performance Appraisal",
            "Human Resource Planing ",
            "Human Resource Development ",
            "Strategic Human Resource Managment ",
            "International Human Resource Management ",
            "Human Resource Information System",
            "Human resource Accounting ",
            "Investment and Portfolio Management",
            "Advance Financial Accounting",
            "Auditing ",
            "Computer Based Accounting ",
            "Taxation",
            "Advance Accounting Theory",
            "Public sector Accounting ",
            "Programming Concepts",
            "Systems Analysis and Design",
            "Data Communication and Computer Networks",
            "Professional Ethics and Responsibility",
            "Software Engineering ",
            "Object Oriented Programming ",
            "Web Development ",
            "Enterprise Resource Planning Sysytem",
            "Software Quality Assurance",
            "DataBase Management System"});
            this.cbSubject7.Location = new System.Drawing.Point(30, 261);
            this.cbSubject7.Name = "cbSubject7";
            this.cbSubject7.Size = new System.Drawing.Size(256, 26);
            this.cbSubject7.TabIndex = 7;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.YellowGreen;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(440, 324);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(127, 46);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Total GPA";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // cbCredit1
            // 
            this.cbCredit1.FormattingEnabled = true;
            this.cbCredit1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCredit1.Location = new System.Drawing.Point(471, 74);
            this.cbCredit1.Name = "cbCredit1";
            this.cbCredit1.Size = new System.Drawing.Size(81, 26);
            this.cbCredit1.TabIndex = 6;
            this.cbCredit1.SelectedIndexChanged += new System.EventHandler(this.cbCredit1_SelectedIndexChanged);
            // 
            // cbCredit2
            // 
            this.cbCredit2.FormattingEnabled = true;
            this.cbCredit2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCredit2.Location = new System.Drawing.Point(471, 104);
            this.cbCredit2.Name = "cbCredit2";
            this.cbCredit2.Size = new System.Drawing.Size(81, 26);
            this.cbCredit2.TabIndex = 6;
            this.cbCredit2.SelectedIndexChanged += new System.EventHandler(this.cbCredit2_SelectedIndexChanged);
            // 
            // cbCredit3
            // 
            this.cbCredit3.FormattingEnabled = true;
            this.cbCredit3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCredit3.Location = new System.Drawing.Point(471, 135);
            this.cbCredit3.Name = "cbCredit3";
            this.cbCredit3.Size = new System.Drawing.Size(81, 26);
            this.cbCredit3.TabIndex = 6;
            this.cbCredit3.SelectedIndexChanged += new System.EventHandler(this.cbCredit3_SelectedIndexChanged);
            // 
            // cbCredit4
            // 
            this.cbCredit4.FormattingEnabled = true;
            this.cbCredit4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCredit4.Location = new System.Drawing.Point(471, 166);
            this.cbCredit4.Name = "cbCredit4";
            this.cbCredit4.Size = new System.Drawing.Size(81, 26);
            this.cbCredit4.TabIndex = 6;
            this.cbCredit4.SelectedIndexChanged += new System.EventHandler(this.cbCredit4_SelectedIndexChanged);
            // 
            // cbCredit5
            // 
            this.cbCredit5.FormattingEnabled = true;
            this.cbCredit5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCredit5.Location = new System.Drawing.Point(471, 198);
            this.cbCredit5.Name = "cbCredit5";
            this.cbCredit5.Size = new System.Drawing.Size(81, 26);
            this.cbCredit5.TabIndex = 6;
            this.cbCredit5.SelectedIndexChanged += new System.EventHandler(this.cbCredit5_SelectedIndexChanged);
            // 
            // cbCredit6
            // 
            this.cbCredit6.FormattingEnabled = true;
            this.cbCredit6.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCredit6.Location = new System.Drawing.Point(471, 229);
            this.cbCredit6.Name = "cbCredit6";
            this.cbCredit6.Size = new System.Drawing.Size(81, 26);
            this.cbCredit6.TabIndex = 6;
            this.cbCredit6.SelectedIndexChanged += new System.EventHandler(this.cbCredit6_SelectedIndexChanged);
            // 
            // cbCredit7
            // 
            this.cbCredit7.FormattingEnabled = true;
            this.cbCredit7.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCredit7.Location = new System.Drawing.Point(471, 259);
            this.cbCredit7.Name = "cbCredit7";
            this.cbCredit7.Size = new System.Drawing.Size(81, 26);
            this.cbCredit7.TabIndex = 6;
            this.cbCredit7.SelectedIndexChanged += new System.EventHandler(this.cbCredit7_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1092, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "SP Software Solution ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1288, 406);
            this.Controls.Add(this.cbSubject7);
            this.Controls.Add(this.cbSubject6);
            this.Controls.Add(this.cbSubject5);
            this.Controls.Add(this.cbSubject4);
            this.Controls.Add(this.cbSubject3);
            this.Controls.Add(this.cbSubject2);
            this.Controls.Add(this.cbSubject1);
            this.Controls.Add(this.cbCredit7);
            this.Controls.Add(this.cbCredit6);
            this.Controls.Add(this.cbResult7);
            this.Controls.Add(this.cbCredit5);
            this.Controls.Add(this.cbResult6);
            this.Controls.Add(this.cbCredit4);
            this.Controls.Add(this.cbResult5);
            this.Controls.Add(this.cbCredit3);
            this.Controls.Add(this.cbResult4);
            this.Controls.Add(this.cbCredit2);
            this.Controls.Add(this.cbResult3);
            this.Controls.Add(this.cbResult2);
            this.Controls.Add(this.cbCredit1);
            this.Controls.Add(this.cbWeight);
            this.Controls.Add(this.cbResult1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trincomale Campus GPA Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbResult1;
        private System.Windows.Forms.ComboBox cbResult2;
        private System.Windows.Forms.ComboBox cbResult3;
        private System.Windows.Forms.ComboBox cbResult4;
        private System.Windows.Forms.ComboBox cbResult5;
        private System.Windows.Forms.ComboBox cbResult6;
        private System.Windows.Forms.ComboBox cbResult7;
        private System.Windows.Forms.ComboBox cbWeight;
        private System.Windows.Forms.ComboBox cbSubject1;
        private System.Windows.Forms.ComboBox cbSubject2;
        private System.Windows.Forms.ComboBox cbSubject3;
        private System.Windows.Forms.ComboBox cbSubject4;
        private System.Windows.Forms.ComboBox cbSubject5;
        private System.Windows.Forms.ComboBox cbSubject6;
        private System.Windows.Forms.ComboBox cbSubject7;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.ComboBox cbCredit1;
        private System.Windows.Forms.ComboBox cbCredit2;
        private System.Windows.Forms.ComboBox cbCredit3;
        private System.Windows.Forms.ComboBox cbCredit4;
        private System.Windows.Forms.ComboBox cbCredit5;
        private System.Windows.Forms.ComboBox cbCredit6;
        private System.Windows.Forms.ComboBox cbCredit7;
        private System.Windows.Forms.Label label3;
    }
}

