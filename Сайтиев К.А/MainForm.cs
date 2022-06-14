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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab1 FL1 = new Lab1();
            FL1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab2 FL2 = new Lab2();
            FL2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab3 FL3 = new Lab3();
            FL3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab4 FL4 = new Lab4();
            FL4.Show();
        }
    }
}
