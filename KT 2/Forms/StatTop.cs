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
    public partial class StatTop : Form
    {
        public StatTop()
        {
            InitializeComponent();
        }

        private void StatTop_Load(object sender, EventArgs e)
        {

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
            SqlCommand comand = new SqlCommand(@"SELECT        [Max level of Olympiad], COUNT([Max level of Olympiad]) AS count
FROM            Olympiads
GROUP BY [Max level of Olympiad]", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Rows[0].Cells[0].Value = "Max Level";
            dataGridView1.Rows[0].Cells[1].Value = "Count";
            int i = 0;
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add();
                for (int j = 0; j < 2; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = reader[j].ToString();
                }
            }
            reader.Close();
        }
    }
}
