using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SautinSoft.Document;
using Color = SautinSoft.Document.Color;
using HorizontalAlignment = SautinSoft.Document.HorizontalAlignment;

namespace KT_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.for_kursDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Olympiads". При необходимости она может быть перемещена или удалена.
            this.olympiadsTableAdapter.Fill(this.for_kursDataSet.Olympiads);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Duty". При необходимости она может быть перемещена или удалена.
            this.dutyTableAdapter.Fill(this.for_kursDataSet.Duty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.for_kursDataSet.Classes);
            this.magazineTableAdapter.Fill(this.for_kursDataSet.Magazine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.olympiadsTableAdapter.Update(this.for_kursDataSet.Olympiads);
            this.dutyTableAdapter.Update(this.for_kursDataSet.Duty);
            this.classesTableAdapter.Update(this.for_kursDataSet.Classes);
            this.studentsTableAdapter.Update(this.for_kursDataSet.Students);
            this.magazineTableAdapter.Update(this.for_kursDataSet.Magazine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigator1_ItemRemoved(object sender, ToolStripItemEventArgs e)
        {
            //DataRow[] dr = for_kursDataSet.Olympiads.Select("Student code ='" + dataGridViewStudents.SelectedRows + "'");
            //if (dr.Count() > 0)
            //{
            //    foreach (DataRow item in for_kursDataSet.Olympiads.Rows)
            //    {
            //        if (item["Student code"] == dr)
            //        {
            //            item.Delete();
            //        }
            //    }
            //    olympiadsTableAdapter.Update(for_kursDataSet.Olympiads);
            //}
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }


    }
}
