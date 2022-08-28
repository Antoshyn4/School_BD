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
    public partial class StatOly_p : Form
    {
        public StatOly_p()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT        [Class number], COUNT([Student code]) AS [Count of Olympiads], [Max level of Olympiad]
FROM            Olympiads inner join Classes on Olympiads.[Group code] = Classes.[Group code]
GROUP BY [Class number], [Max level of Olympiad]
ORDER BY [Count of Olympiads] DESC", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Rows[0].Cells[0].Value = "Classes number";
            dataGridView1.Rows[0].Cells[1].Value = "Total olympiads count ";
            dataGridView1.Rows[0].Cells[2].Value = "Max level";
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

        private void StatOly_p_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistics newForm = new Statistics();
            newForm.Show();
            this.Visible = false;
        }
    }
}
