using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_2
{
    public partial class AddDep : Form
    {
        public AddDep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add newForm = new Add();
            newForm.Show();
            this.Visible = false;
        }

        private void AddDep_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Magazine". При необходимости она может быть перемещена или удалена.
            this.magazineTableAdapter.Fill(this.for_kursDataSet.Magazine);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Olympiads". При необходимости она может быть перемещена или удалена.
            this.olympiadsTableAdapter.Fill(this.for_kursDataSet.Olympiads);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.for_kursDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.for_kursDataSet.Classes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Duty". При необходимости она может быть перемещена или удалена.
            this.dutyTableAdapter.Fill(this.for_kursDataSet.Duty);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                DataRow[] dr1 = for_kursDataSet.Duty.Select("[Duty code] =" + textBox3.Text);
                if (dr1.Count() > 0)
                {
                    foreach (DataRow item in for_kursDataSet.Duty.Rows)
                    {
                        if (item["Duty code"].ToString() == textBox3.Text)
                        {
                            item.Delete();
                        }
                    }
                    dutyTableAdapter.Update(for_kursDataSet.Duty);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.olympiadsTableAdapter.Update(this.for_kursDataSet.Olympiads);
            this.dutyTableAdapter.Update(this.for_kursDataSet.Duty);
            this.classesTableAdapter.Update(this.for_kursDataSet.Classes);
            this.studentsTableAdapter.Update(this.for_kursDataSet.Students);
            this.magazineTableAdapter.Update(this.for_kursDataSet.Magazine);
        }
    }
}
