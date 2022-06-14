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
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double xn = -2.4,
                xk = 4.4,
                xh = 0.4,
                a = 2,
                x,
                y,
                yMin = 0,
                yMax = 0;

            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 2;

            x = xn;
            while (x <= xk)
            {
                if (x <= 0)
                {
                    y = Math.Abs(Math.Pow((2 * x + 5) / (Math.Pow(x, 2) + 3), 1 / 3));
                }
                else if (x > 0 && x <= a)
                {
                    y = (5 * x + Math.Pow(x,2)) / (Math.Pow(x,3) + 3);
                }
                else
                {
                    y = Math.Pow(Math.Cos(Math.Pow(x,3) + Math.Sqrt(x)),2);
                }
                if (yMin > y)
                {
                    yMin = y;
                }
                if (yMax < y)
                {
                    yMax = y;
                }
                x = x + xh;
                dataGridView1.Rows.Add(x, y);
            }
            textBox5.Text = yMax.ToString();
            textBox6.Text = yMin.ToString();
        }
    }
}
