
namespace KT_2
{
    partial class AddSt
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
            this.button2 = new System.Windows.Forms.Button();
            this.for_kursDataSet = new KT_2.For_kursDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new KT_2.For_kursDataSetTableAdapters.StudentsTableAdapter();
            this.dutyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dutyTableAdapter = new KT_2.For_kursDataSetTableAdapters.DutyTableAdapter();
            this.olympiadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olympiadsTableAdapter = new KT_2.For_kursDataSetTableAdapters.OlympiadsTableAdapter();
            this.magazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazineTableAdapter = new KT_2.For_kursDataSetTableAdapters.MagazineTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tearBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new KT_2.For_kursDataSetTableAdapters.ClassesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.for_kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympiadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 20);
            this.button2.TabIndex = 25;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // for_kursDataSet
            // 
            this.for_kursDataSet.DataSetName = "For_kursDataSet";
            this.for_kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dutyBindingSource
            // 
            this.dutyBindingSource.DataMember = "Duty";
            this.dutyBindingSource.DataSource = this.for_kursDataSet;
            // 
            // dutyTableAdapter
            // 
            this.dutyTableAdapter.ClearBeforeFill = true;
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
            // magazineBindingSource
            // 
            this.magazineBindingSource.DataMember = "Magazine";
            this.magazineBindingSource.DataSource = this.for_kursDataSet;
            // 
            // magazineTableAdapter
            // 
            this.magazineTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 320);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentCodeDataGridViewTextBoxColumn,
            this.groupCodeDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.tearBirthDataGridViewTextBoxColumn,
            this.maleDataGridViewTextBoxColumn,
            this.semesterGradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 271);
            this.dataGridView1.TabIndex = 30;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // AddSt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddSt";
            this.Text = "AddSt";
            this.Load += new System.EventHandler(this.AddSt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.for_kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympiadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private For_kursDataSet for_kursDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private For_kursDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource dutyBindingSource;
        private For_kursDataSetTableAdapters.DutyTableAdapter dutyTableAdapter;
        private System.Windows.Forms.BindingSource olympiadsBindingSource;
        private For_kursDataSetTableAdapters.OlympiadsTableAdapter olympiadsTableAdapter;
        private System.Windows.Forms.BindingSource magazineBindingSource;
        private For_kursDataSetTableAdapters.MagazineTableAdapter magazineTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tearBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private For_kursDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
    }
}