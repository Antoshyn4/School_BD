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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Begin newForm = new Begin();
            newForm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StatDebt newForm = new StatDebt();
            newForm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatTop newForm = new StatTop();
            newForm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StatOly_p newForm = new StatOly_p();
            newForm.Show();
            this.Visible = false;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatStud newForm = new StatStud();
            newForm.Show();
            this.Visible = false;
        }
    }
}
