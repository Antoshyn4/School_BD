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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT* FROM Classes ORDER BY [Class number] ASC", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 4;
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

        private void Sort_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT [Full name], [Class number], [For what], Amount FROM Duty JOIN Students on Duty.[Student code] = Students.[Student code] JOIN Classes ON Duty.[Group code] = Classes.[Group code] ORDER BY [Amount] DESC", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 4;

            dataGridView1.Rows[0].Cells[0].Value = "Full name";
            dataGridView1.Rows[0].Cells[1].Value = "Class number";
            dataGridView1.Rows[0].Cells[2].Value = "For what";
            dataGridView1.Rows[0].Cells[3].Value = "Amount";

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

        private void button1_Click(object sender, EventArgs e)
        {

            Begin newForm = new Begin();
            newForm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
