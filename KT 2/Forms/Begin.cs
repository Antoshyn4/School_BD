using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_2
{
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add newForm = new Add();
            newForm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Statistics newForm = new Statistics();
            newForm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports newForm = new Reports();
            newForm.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OLympiads newForm = new OLympiads();
            newForm.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sort newForm = new Sort();
            newForm.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Filtr newForm = new Filtr();
            newForm.Show();
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Search newForm = new Search();
            newForm.Show();
            this.Visible = false;
        }
    }
}
