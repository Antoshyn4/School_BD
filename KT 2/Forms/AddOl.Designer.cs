
namespace KT_2
{
    partial class AddOl
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridViewClasses = new System.Windows.Forms.DataGridView();
            this.olympiadCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelOfOlympiadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLevelOfOlympiadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hadParticipationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympiadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.forkursDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.for_kursDataSet = new KT_2.For_kursDataSet();
            this.olympiadsTableAdapter = new KT_2.For_kursDataSetTableAdapters.OlympiadsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dutyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dutyTableAdapter = new KT_2.For_kursDataSetTableAdapters.DutyTableAdapter();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new KT_2.For_kursDataSetTableAdapters.ClassesTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new KT_2.For_kursDataSetTableAdapters.StudentsTableAdapter();
            this.magazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazineTableAdapter = new KT_2.For_kursDataSetTableAdapters.MagazineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympiadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forkursDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.for_kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 34;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(13, 331);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(109, 20);
            this.Delete.TabIndex = 33;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridViewClasses
            // 
            this.dataGridViewClasses.AutoGenerateColumns = false;
            this.dataGridViewClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.olympiadCodeDataGridViewTextBoxColumn,
            this.studentCodeDataGridViewTextBoxColumn,
            this.groupCodeDataGridViewTextBoxColumn,
            this.levelOfOlympiadDataGridViewTextBoxColumn,
            this.maxLevelOfOlympiadDataGridViewTextBoxColumn,
            this.hadParticipationDataGridViewTextBoxColumn,
            this.nameOfSubjectDataGridViewTextBoxColumn});
            this.dataGridViewClasses.DataSource = this.olympiadsBindingSource;
            this.dataGridViewClasses.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewClasses.Name = "dataGridViewClasses";
            this.dataGridViewClasses.Size = new System.Drawing.Size(752, 284);
            this.dataGridViewClasses.TabIndex = 32;
            // 
            // olympiadCodeDataGridViewTextBoxColumn
            // 
            this.olympiadCodeDataGridViewTextBoxColumn.DataPropertyName = "Olympiad code";
            this.olympiadCodeDataGridViewTextBoxColumn.HeaderText = "Olympiad code";
            this.olympiadCodeDataGridViewTextBoxColumn.Name = "olympiadCodeDataGridViewTextBoxColumn";
            this.olympiadCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentCodeDataGridViewTextBoxColumn
            // 
            this.studentCodeDataGridViewTextBoxColumn.DataPropertyName = "Student code";
            this.studentCodeDataGridViewTextBoxColumn.HeaderText = "Student code";
            this.studentCodeDataGridViewTextBoxColumn.Name = "studentCodeDataGridViewTextBoxColumn";
            // 
            // groupCodeDataGridViewTextBoxColumn
            // 
            this.groupCodeDataGridViewTextBoxColumn.DataPropertyName = "Group code";
            this.groupCodeDataGridViewTextBoxColumn.HeaderText = "Group code";
            this.groupCodeDataGridViewTextBoxColumn.Name = "groupCodeDataGridViewTextBoxColumn";
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
            this.olympiadsBindingSource.DataSource = this.forkursDataSetBindingSource;
            // 
            // forkursDataSetBindingSource
            // 
            this.forkursDataSetBindingSource.DataSource = this.for_kursDataSet;
            this.forkursDataSetBindingSource.Position = 0;
            // 
            // for_kursDataSet
            // 
            this.for_kursDataSet.DataSetName = "For_kursDataSet";
            this.for_kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // olympiadsTableAdapter
            // 
            this.olympiadsTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dutyBindingSource
            // 
            this.dutyBindingSource.DataMember = "Duty";
            this.dutyBindingSource.DataSource = this.for_kursDataSet;
            // 
            // dutyTableAdapter
            // 
            this.dutyTableAdapter.ClearBeforeFill = true;
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
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.for_kursDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // magazineBindingSource
            // 
            this.magazineBindingSource.DataMember = "Magazine";
            this.magazineBindingSource.DataSource = this.for_kursDataSet;
            // 
            // magazineTableAdapter
            // 
            this.magazineTableAdapter.ClearBeforeFill = true;
            // 
            // AddOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridViewClasses);
            this.Controls.Add(this.button1);
            this.Name = "AddOl";
            this.Text = "AddOl";
            this.Load += new System.EventHandler(this.AddOl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympiadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forkursDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.for_kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridViewClasses;
        private System.Windows.Forms.BindingSource forkursDataSetBindingSource;
        private For_kursDataSet for_kursDataSet;
        private System.Windows.Forms.BindingSource olympiadsBindingSource;
        private For_kursDataSetTableAdapters.OlympiadsTableAdapter olympiadsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympiadCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelOfOlympiadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLevelOfOlympiadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hadParticipationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource dutyBindingSource;
        private For_kursDataSetTableAdapters.DutyTableAdapter dutyTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private For_kursDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private For_kursDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource magazineBindingSource;
        private For_kursDataSetTableAdapters.MagazineTableAdapter magazineTableAdapter;
    }
}