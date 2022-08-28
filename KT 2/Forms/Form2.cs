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

namespace KT_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void StatStudent_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT [Subject name],[Full name], [Grade for year], [Grade in 1st semester] FROM Magazine join Students ON Magazine.[Student code] = Students.[Student code] where [Full name] = '" + text + "'", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Rows[0].Cells[0].Value = "Subject name";
            dataGridView1.Rows[0].Cells[1].Value = "Full name";
            dataGridView1.Rows[0].Cells[2].Value = "Grade for year";
            dataGridView1.Rows[0].Cells[3].Value = "Grade in 1st semester";
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

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT [Name of subject],[Max level of Olympiad], [Full Name], [Class number] FROM Olympiads join Students ON Olympiads.[Student code] = Students.[Student code] 
join Classes ON Olympiads.[Group code] = Classes.[Group code] where [Full name] = '" + text + "'", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView3.RowCount = 2;
            dataGridView3.ColumnCount = 4;
            dataGridView3.Rows[0].Cells[0].Value = "Name of subject";
            dataGridView3.Rows[0].Cells[1].Value = "Max level of Olympiad";
            dataGridView3.Rows[0].Cells[2].Value = "Full Name";
            dataGridView3.Rows[0].Cells[3].Value = "Class number";
            int i = 0;
            while (reader.Read())
            {
                i++;
                dataGridView3.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = reader[j].ToString();
                }
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT [Full Name],[Class number], [For what], [Amount] FROM Duty join Students ON Duty.[Student code] = Students.[Student code] 
join Classes ON Duty.[Group code] = Classes.[Group code] where [Full name] = '" + text + "'", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView2.RowCount = 2;
            dataGridView2.ColumnCount = 4;
            dataGridView2.Rows[0].Cells[0].Value = "Full Name";
            dataGridView2.Rows[0].Cells[1].Value = "Class number";
            dataGridView2.Rows[0].Cells[2].Value = "For what";
            dataGridView2.Rows[0].Cells[3].Value = "Amount";
            int i = 0;
            while (reader.Read())
            {
                i++;
                dataGridView2.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = reader[j].ToString();
                }
            }
            reader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT        Classes.Profile, Students.[Full Name], Students.[Semester grade], Olympiads.[Had participation]
FROM            Classes  JOIN
                         Olympiads ON Classes.[Group code] = Olympiads.[Group code] JOIN
                         Students ON Classes.[Group code] = Students.[Group code]
WHERE        (Classes.Profile = '" + text + "')", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView4.RowCount = 2;
            dataGridView4.ColumnCount = 4;
            dataGridView4.Rows[0].Cells[0].Value = "Classes Profile";
            dataGridView4.Rows[0].Cells[1].Value = "Full Name";
            dataGridView4.Rows[0].Cells[2].Value = "Semester grade";
            dataGridView4.Rows[0].Cells[3].Value = "Had participation";
            int i = 0;
            while (reader.Read())
            {
                i++;
                dataGridView4.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView4.Rows[i].Cells[j].Value = reader[j].ToString();
                }
            }
            reader.Close();
        }
    }
}
