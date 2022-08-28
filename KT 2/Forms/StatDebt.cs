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
    public partial class StatDebt : Form
    {
        public StatDebt()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand comand = new SqlCommand(@"SELECT        SUM(Duty.Amount) AS [Amount of Debt], Classes.[Class number]
FROM            Duty INNER JOIN
Classes ON Duty.[Group code] = Classes.[Group code]
GROUP BY Classes.[Class number]
ORDER BY [Amount of Debt] DESC", con);
            SqlDataReader reader = comand.ExecuteReader();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Rows[0].Cells[0].Value = "Total debt";
            dataGridView1.Rows[0].Cells[1].Value = "Class number";
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

        private void StatDebt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistics newForm = new Statistics();
            newForm.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
