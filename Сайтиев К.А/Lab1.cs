using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaVariant
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            About FA = new About();
            FA.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            double y;
            x = Convert.ToInt32(textBox1.Text);
            y = Math.Pow((6 * x - Math.Pow(x, 2) + 1), 1/5);
            textBox2.Text = y.ToString();
        }
    }
}
