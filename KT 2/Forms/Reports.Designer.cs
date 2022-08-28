
namespace KT_2
{
    partial class Reports
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tearBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.for_kursDataSet = new KT_2.For_kursDataSet();
            this.studentsTableAdapter = new KT_2.For_kursDataSetTableAdapters.StudentsTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTeachersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new KT_2.For_kursDataSetTableAdapters.ClassesTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.olympiadCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCodeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelOfOlympiadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLevelOfOlympiadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hadParticipationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympiadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olympiadsTableAdapter = new KT_2.For_kursDataSetTableAdapters.OlympiadsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.for_kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympiadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentCodeDataGridViewTextBoxColumn,
            this.groupCodeDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.tearBirthDataGridViewTextBoxColumn,
            this.maleDataGridViewTextBoxColumn,
            this.semesterGradeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.studentsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 355);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(644, 242);
            this.dataGridView2.TabIndex = 3;
            // 
            // studentCodeDataGridViewTextBoxColumn
            // 
            this.studentCodeDataGridViewTextBoxColumn.DataPropertyName = "Student code";
            this.studentCodeDataGridViewTextBoxColumn.HeaderText = "Student code";
            this.studentCodeDataGridViewTextBoxColumn.Name = "studentCodeDataGridViewTextBoxColumn";
            this.studentCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupCodeDataGridViewTextBoxColumn
            // 
            this.groupCodeDataGridViewTextBoxColumn.DataPropertyName = "Group code";
            this.groupCodeDataGridViewTextBoxColumn.HeaderText = "Group code";
            this.groupCodeDataGridViewTextBoxColumn.Name = "groupCodeDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // tearBirthDataGridViewTextBoxColumn
            // 
            this.tearBirthDataGridViewTextBoxColumn.DataPropertyName = "Tear birth";
            this.tearBirthDataGridViewTextBoxColumn.HeaderText = "Tear birth";
            this.tearBirthDataGridViewTextBoxColumn.Name = "tearBirthDataGridViewTextBoxColumn";
            // 
            // maleDataGridViewTextBoxColumn
            // 
            this.maleDataGridViewTextBoxColumn.DataPropertyName = "Male";
            this.maleDataGridViewTextBoxColumn.HeaderText = "Male";
            this.maleDataGridViewTextBoxColumn.Name = "maleDataGridViewTextBoxColumn";
            // 
            // semesterGradeDataGridViewTextBoxColumn
            // 
            this.semesterGradeDataGridViewTextBoxColumn.DataPropertyName = "Semester grade";
            this.semesterGradeDataGridViewTextBoxColumn.HeaderText = "Semester grade";
            this.semesterGradeDataGridViewTextBoxColumn.Name = "semesterGradeDataGridViewTextBoxColumn";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.for_kursDataSet;
            // 
            // for_kursDataSet
            // 
            this.for_kursDataSet.DataSetName = "For_kursDataSet";
            this.for_kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupCodeDataGridViewTextBoxColumn1,
            this.profileDataGridViewTextBoxColumn,
            this.classTeachersNameDataGridViewTextBoxColumn,
            this.classNumberDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.classesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(663, 355);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(443, 242);
            this.dataGridView3.TabIndex = 4;
            // 
            // groupCodeDataGridViewTextBoxColumn1
            // 
            this.groupCodeDataGridViewTextBoxColumn1.DataPropertyName = "Group code";
            this.groupCodeDataGridViewTextBoxColumn1.HeaderText = "Group code";
            this.groupCodeDataGridViewTextBoxColumn1.Name = "groupCodeDataGridViewTextBoxColumn1";
            this.groupCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // profileDataGridViewTextBoxColumn
            // 
            this.profileDataGridViewTextBoxColumn.DataPropertyName = "Profile";
            this.profileDataGridViewTextBoxColumn.HeaderText = "Profile";
            this.profileDataGridViewTextBoxColumn.Name = "profileDataGridViewTextBoxColumn";
            // 
            // classTeachersNameDataGridViewTextBoxColumn
            // 
            this.classTeachersNameDataGridViewTextBoxColumn.DataPropertyName = "Class Teachers Name";
            this.classTeachersNameDataGridViewTextBoxColumn.HeaderText = "Class Teachers Name";
            this.classTeachersNameDataGridViewTextBoxColumn.Name = "classTeachersNameDataGridViewTextBoxColumn";
            // 
            // classNumberDataGridViewTextBoxColumn
            // 
            this.classNumberDataGridViewTextBoxColumn.DataPropertyName = "Class number";
            this.classNumberDataGridViewTextBoxColumn.HeaderText = "Class number";
            this.classNumberDataGridViewTextBoxColumn.Name = "classNumberDataGridViewTextBoxColumn";
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.for_kursDataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.olympiadCodeDataGridViewTextBoxColumn,
            this.studentCodeDataGridViewTextBoxColumn1,
            this.groupCodeDataGridViewTextBoxColumn2,
            this.levelOfOlympiadDataGridViewTextBoxColumn,
            this.maxLevelOfOlympiadDataGridViewTextBoxColumn,
            this.hadParticipationDataGridViewTextBoxColumn,
            this.nameOfSubjectDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.olympiadsBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(1112, 355);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(746, 150);
            this.dataGridView4.TabIndex = 6;
            // 
            // olympiadCodeDataGridViewTextBoxColumn
            // 
            this.olympiadCodeDataGridViewTextBoxColumn.DataPropertyName = "Olympiad code";
            this.olympiadCodeDataGridViewTextBoxColumn.HeaderText = "Olympiad code";
            this.olympiadCodeDataGridViewTextBoxColumn.Name = "olympiadCodeDataGridViewTextBoxColumn";
            this.olympiadCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentCodeDataGridViewTextBoxColumn1
            // 
            this.studentCodeDataGridViewTextBoxColumn1.DataPropertyName = "Student code";
            this.studentCodeDataGridViewTextBoxColumn1.HeaderText = "Student code";
            this.studentCodeDataGridViewTextBoxColumn1.Name = "studentCodeDataGridViewTextBoxColumn1";
            // 
            // groupCodeDataGridViewTextBoxColumn2
            // 
            this.groupCodeDataGridViewTextBoxColumn2.DataPropertyName = "Group code";
            this.groupCodeDataGridViewTextBoxColumn2.HeaderText = "Group code";
            this.groupCodeDataGridViewTextBoxColumn2.Name = "groupCodeDataGridViewTextBoxColumn2";
            // 
            // levelOfOlympiadDataGridViewTextBoxColumn
            // 
            this.levelOfOlympiadDataGridViewTextBoxColumn.DataPropertyName = "Level of Olympiad";
            this.levelOfOlympiadDataGridViewTextBoxColumn.HeaderText = "Level of Olympiad";
            this.levelOfOlympiadDataGridViewTextBoxColumn.Name = "levelOfOlympiadDataGridViewTextBoxColumn";
            // 
            // maxLevelOfOlympiadDataGridViewTextBoxColumn
            // 
            this.maxLevelOfOlympiadDataGridViewTextBoxColumn.DataPropertyName = "Max level of Olympiad";
            this.maxLevelOfOlympiadDataGridViewTextBoxColumn.HeaderText = "Max level of Olympiad";
            this.maxLevelOfOlympiadDataGridViewTextBoxColumn.Name = "maxLevelOfOlympiadDataGridViewTextBoxColumn";
            // 
            // hadParticipationDataGridViewTextBoxColumn
            // 
            this.hadParticipationDataGridViewTextBoxColumn.DataPropertyName = "Had participation";
            this.hadParticipationDataGridViewTextBoxColumn.HeaderText = "Had participation";
            this.hadParticipationDataGridViewTextBoxColumn.Name = "hadParticipationDataGridViewTextBoxColumn";
            // 
            // nameOfSubjectDataGridViewTextBoxColumn
            // 
            this.nameOfSubjectDataGridViewTextBoxColumn.DataPropertyName = "Name of subject";
            this.nameOfSubjectDataGridViewTextBoxColumn.HeaderText = "Name of subject";
            this.nameOfSubjectDataGridViewTextBoxColumn.Name = "nameOfSubjectDataGridViewTextBoxColumn";
            // 
            // olympiadsBindingSource
            // 
            this.olympiadsBindingSource.DataMember = "Olympiads";
            this.olympiadsBindingSource.DataSource = this.for_kursDataSet;
            // 
            // olympiadsTableAdapter
            // 
            this.olympiadsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 170);
            this.button3.TabIndex = 8;
            this.button3.Text = "Debt document";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 170);
            this.button4.TabIndex = 9;
            this.button4.Text = "List of olympiads";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(663, 658);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(240, 150);
            this.dataGridView5.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Reports";
            this.Text = "Задача Автоматизации";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.for_kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympiadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private For_kursDataSet for_kursDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private For_kursDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tearBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private For_kursDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classTeachersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource olympiadsBindingSource;
        private For_kursDataSetTableAdapters.OlympiadsTableAdapter olympiadsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympiadCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCodeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelOfOlympiadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLevelOfOlympiadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hadParticipationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button1;
    }
}