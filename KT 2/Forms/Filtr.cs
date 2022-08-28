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
    public partial class Filtr : Form
    {
        public Filtr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = textBox2.Text;
            if (textBox2.Text != "")
            {
                string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand comand = new SqlCommand(@"SELECT  [Student code], [Group code], [Full Name], [Tear birth], Male, [Semester grade]
 FROM Students WHERE [Tear birth] > '" + int.Parse(text) + "'", con);
                SqlDataReader reader = comand.ExecuteReader();
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = 6;
                dataGridView1.Rows[0].Cells[0].Value = "Student code";
                dataGridView1.Rows[0].Cells[1].Value = "Group code";
                dataGridView1.Rows[0].Cells[2].Value = "Full Name";
                dataGridView1.Rows[0].Cells[3].Value = "Tear birth";
                dataGridView1.Rows[0].Cells[4].Value = "Male";
                dataGridView1.Rows[0].Cells[5].Value = "Semester grade";
                int i = 0;
                while (reader.Read())
                {
                    i++;
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < 6; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = reader[j].ToString();
                    }
                }
                reader.Close();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT * FROM Classes WHERE [Profile] = '" + text + "'", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Rows[0].Cells[0].Value = "Group code";
            dataGridView1.Rows[0].Cells[1].Value = "Profile";
            dataGridView1.Rows[0].Cells[2].Value = "Teachers class name";
            dataGridView1.Rows[0].Cells[3].Value = "Number of class";
            int i = 0;
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = reader[j].ToString();
                }
            }
            reader.Close();
        }

        private void Filtr_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Begin newForm = new Begin();
            newForm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            string textp = textBox1.Text;
            if (textBox2.Text != "")
            {
                string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand comand = new SqlCommand(@"SELECT  Students.[Student code], Students.[Group code], Students.[Full Name], Students.[Tear birth], Students.Male, Students.[Semester grade], Classes.Profile FROM Students inner join Classes on Students.[Group code] = Classes.[Group code] WHERE [Tear birth] > '" + int.Parse(text) + "' and Classes.Profile = '" + textp + "'", con);
                SqlDataReader reader = comand.ExecuteReader();
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = 7;
                dataGridView1.Rows[0].Cells[0].Value = "Student code";
                dataGridView1.Rows[0].Cells[1].Value = "Group code";
                dataGridView1.Rows[0].Cells[2].Value = "Full Name";
                dataGridView1.Rows[0].Cells[3].Value = "Tear birth";
                dataGridView1.Rows[0].Cells[4].Value = "Male";
                dataGridView1.Rows[0].Cells[5].Value = "Semester grade";
                dataGridView1.Rows[0].Cells[6].Value = "Profile";
                int i = 0;
                while (reader.Read())
                {
                    i++;
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < 7; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = reader[j].ToString();
                    }
                }
                reader.Close();
            }
        }
    }
}
