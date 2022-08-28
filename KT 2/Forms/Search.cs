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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT * FROM Students WHERE [Full name] = '" + text + "'", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Rows[0].Cells[0].Value = "Student code";
            dataGridView1.Rows[0].Cells[1].Value = "Group code";
            dataGridView1.Rows[0].Cells[2].Value = "Full name";
            dataGridView1.Rows[0].Cells[3].Value = "year of birth";
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

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" )
            {

                string text = textBox2.Text;
                string text2 = textBox1.Text;
                string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand comand = new SqlCommand(@"SELECT [Student code], [Group code], [Full Name], [Tear birth], Male, [Semester grade] FROM Students
WHERE [Full Name] = '" + text2 + "'" + " and [Tear birth] = '" + text + "'", con);
                SqlDataReader reader = comand.ExecuteReader();
                dataGridView1.RowCount = 2;
                dataGridView1.ColumnCount = 6;
                dataGridView1.Rows[0].Cells[0].Value = "Student code";
                dataGridView1.Rows[0].Cells[1].Value = "Group code";
                dataGridView1.Rows[0].Cells[2].Value = "Full name";
                dataGridView1.Rows[0].Cells[3].Value = "year of birth";
                dataGridView1.Rows[0].Cells[4].Value = "Male";
                dataGridView1.Rows[0].Cells[5].Value = "Semester grade";

                dataGridView1.Rows[1].Cells[0].Value = "";
                dataGridView1.Rows[1].Cells[1].Value = "";
                dataGridView1.Rows[1].Cells[2].Value = "";
                dataGridView1.Rows[1].Cells[3].Value = "";
                dataGridView1.Rows[1].Cells[4].Value = "";
                dataGridView1.Rows[1].Cells[5].Value = "";
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

        private void button1_Click(object sender, EventArgs e)
        {

            Begin newForm = new Begin();
            newForm.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT * FROM Students WHERE [Tear birth] = '" + text + "'", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Rows[0].Cells[0].Value = "Student code";
            dataGridView1.Rows[0].Cells[1].Value = "Group code";
            dataGridView1.Rows[0].Cells[2].Value = "Full name";
            dataGridView1.Rows[0].Cells[3].Value = "year of birth";
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
}
