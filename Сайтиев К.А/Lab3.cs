using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PracticaVariant
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xn = Convert.ToDouble(textBox1.Text),
                xk = Convert.ToDouble(textBox2.Text),
                xh = Convert.ToDouble(textBox3.Text),
                x,
                y;

            chart1.Series[0].Points.Clear();

            x = xn;
            while (x <= xk)
            {

                if (x <= 0)
                {
                    y = Math.Abs(Math.Pow((2 * x + 5) / (Math.Pow(x, 2) + 3), 1 / 3));
                }
                else if (x > 0 && x <= 5)
                {
                    y = (5 * x + Math.Pow(x, 2)) / (Math.Pow(x, 3) + 3);
                }
                else
                {
                    y = Math.Pow(Math.Cos(Math.Pow(x, 3) + Math.Sqrt(x)), 2);
                }
                x = x + xh;
                chart1.Series[0].Points.AddXY(x, y);
            }

            if (radioButton1.Checked == true)
            {
                chart1.Series[0].Color = Color.Red;
            }
            else if (radioButton2.Checked == true)
            {
                chart1.Series[0].Color = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                chart1.Series[0].Color = Color.Black;
            }
            else if (radioButton4.Checked == true)
            {
                chart1.Series[0].Color = Color.Green;
            }

            if (radioButton5.Checked == true)
            {
                chart1.Series[0].ChartType = SeriesChartType.Spline;
            }
            else if (radioButton6.Checked == true)
            {
                chart1.Series[0].ChartType = SeriesChartType.Line;
            }
            else if (radioButton7.Checked == true)
            {
                chart1.Series[0].ChartType = SeriesChartType.Column;
            }
        }
    }
}
