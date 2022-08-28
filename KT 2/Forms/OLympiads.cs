using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = SautinSoft.Document.Color;
using HorizontalAlignment = SautinSoft.Document.HorizontalAlignment;

namespace KT_2
{
    public partial class OLympiads : Form
    {
        public OLympiads()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 1;
            //int i = 11;
            //if (comboBox1.SelectedIndex != -1)
            //{
            //    i = int.Parse(comboBox1.SelectedItem.ToString());
            //}
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT [Full Name], [Class number], [Semester grade] 
FROM Students JOIN Classes ON Students.[Group code] = Classes.[Group code] JOIN Olympiads ON Students.[Student code] = Olympiads.[Student code] 
WHERE        (Olympiads.[Had participation] = 'Yes') AND (Students.[Semester grade] >= (SELECT AVG([Semester grade]) FROM Students AS Students_1))", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Rows[0].Cells[0].Value = "Full Name";
            dataGridView1.Rows[0].Cells[1].Value = "Class number";
            dataGridView1.Rows[0].Cells[2].Value = "Semester grade";
            int z = 0;
            while (reader.Read())
            {
                z++;
                dataGridView1.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[z].Cells[j].Value = reader[j].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 1;
            int i = 11;
            if (comboBox1.SelectedIndex != -1)
            {
                i = int.Parse(comboBox1.SelectedItem.ToString());
            }
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT [Full Name], [Class number], [Semester grade] FROM Students JOIN Classes ON Students.[Group code] = Classes.[Group code] JOIN Olympiads ON Students.[Student code] = Olympiads.[Student code] WHERE        (Olympiads.[Had participation] = 'Yes') AND (Classes.[Class number] = '" + i + "') AND (Students.[Semester grade] >= (SELECT AVG([Semester grade]) FROM Students AS Students_1))", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Rows[0].Cells[0].Value = "Full Name";
            dataGridView1.Rows[0].Cells[1].Value = "Class number";
            dataGridView1.Rows[0].Cells[2].Value = "Semester grade";
            int z = 0;
            while (reader.Read())
            {
                z++;
                dataGridView1.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[z].Cells[j].Value = reader[j].ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Begin newForm = new Begin();
            newForm.Show();
            this.Visible = false;
        }
    }
}
