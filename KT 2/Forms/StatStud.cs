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
    public partial class StatStud : Form
    {
        public StatStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistics newForm = new Statistics();
            newForm.Show();
            this.Visible = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT   top 5   Students.[Semester grade], Students.[Full Name], Classes.[Class number]
FROM            Students INNER JOIN
                         Classes ON Students.[Group code] = Classes.[Group code]
ORDER BY Students.[Semester grade] DESC", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Rows[0].Cells[0].Value = "Grade";
            dataGridView1.Rows[0].Cells[1].Value = "Full Name";
            dataGridView1.Rows[0].Cells[2].Value = "Class number";
            int i = 0;
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = reader[j].ToString();
                }
            }
            reader.Close();
        }

        private void StatStud_Load(object sender, EventArgs e)
        {

        }
    }
}
