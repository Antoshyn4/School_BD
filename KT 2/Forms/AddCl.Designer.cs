
namespace KT_2
{
    partial class AddCl
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
            this.dataGridViewClasses = new System.Windows.Forms.DataGridView();
            this.groupCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTeachersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.for_kursDataSet = new KT_2.For_kursDataSet();
            this.classesTableAdapter = new KT_2.For_kursDataSetTableAdapters.ClassesTableAdapter();
            this.Delete = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dutyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dutyTableAdapter = new KT_2.For_kursDataSetTableAdapters.DutyTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new KT_2.For_kursDataSetTableAdapters.StudentsTableAdapter();
            this.magazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazineTableAdapter = new KT_2.For_kursDataSetTableAdapters.MagazineTableAdapter();
            this.olympiadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olympiadsTableAdapter = new KT_2.For_kursDataSetTableAdapters.OlympiadsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.for_kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympiadsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewClasses
            // 
            this.dataGridViewClasses.AutoGenerateColumns = false;
            this.dataGridViewClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupCodeDataGridViewTextBoxColumn,
            this.profileDataGridViewTextBoxColumn,
            this.classTeachersNameDataGridViewTextBoxColumn,
            this.classNumberDataGridViewTextBoxColumn});
            this.dataGridViewClasses.DataSource = this.classesBindingSource;
            this.dataGridViewClasses.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewClasses.Name = "dataGridViewClasses";
            this.dataGridViewClasses.Size = new System.Drawing.Size(470, 245);
            this.dataGridViewClasses.TabIndex = 26;
            this.dataGridViewClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClasses_CellContentClick);
            this.dataGridViewClasses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewClasses_KeyPress);
            // 
            // groupCodeDataGridViewTextBoxColumn
            // 
            this.groupCodeDataGridViewTextBoxColumn.DataPropertyName = "Group code";
            this.groupCodeDataGridViewTextBoxColumn.HeaderText = "Group code";
            this.groupCodeDataGridViewTextBoxColumn.Name = "groupCodeDataGridViewTextBoxColumn";
            this.groupCodeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // for_kursDataSet
            // 
            this.for_kursDataSet.DataSetName = "For_kursDataSet";
            this.for_kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(11, 307);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(109, 20);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 307);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 28;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            // olympiadsBindingSource
            // 
            this.olympiadsBindingSource.DataMember = "Olympiads";
            this.olympiadsBindingSource.DataSource = this.for_kursDataSet;
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
            // AddCl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridViewClasses);
            this.Controls.Add(this.button1);
            this.Name = "AddCl";
            this.Text = "AddCl";
            this.Load += new System.EventHandler(this.AddCl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.for_kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympiadsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewClasses;
        private For_kursDataSet for_kursDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private For_kursDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource dutyBindingSource;
        private For_kursDataSetTableAdapters.DutyTableAdapter dutyTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private For_kursDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource magazineBindingSource;
        private For_kursDataSetTableAdapters.MagazineTableAdapter magazineTableAdapter;
        private System.Windows.Forms.BindingSource olympiadsBindingSource;
        private For_kursDataSetTableAdapters.OlympiadsTableAdapter olympiadsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classTeachersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}