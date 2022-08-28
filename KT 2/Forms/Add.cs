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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Begin newForm = new Begin();
            newForm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSt newForm = new AddSt();
            newForm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCl newForm = new AddCl();
            newForm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddOl newForm = new AddOl();
            newForm.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDep newForm = new AddDep();
            newForm.Show();
            this.Visible = false;
        }
    }
}
