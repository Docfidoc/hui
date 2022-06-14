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
using System.IO;


namespace PracticaVariant
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
            tabControl1.Dock = DockStyle.None;
        }

        public static string NameFile;

        private void ExittoolStripTextBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ColortoolStripTextBox_Click(object sender, EventArgs e)
        {
            ColorDialog1.ShowDialog();
            chart1.Series[0].Color = ColorDialog1.Color;
        }

        private void BackColortoolStripTextBox_Click(object sender, EventArgs e)
        {
            ColorDialog1.ShowDialog();
            chart1.BackColor = ColorDialog1.Color;
        }

        private void FonttoolStripTextBox_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            dataGridView1.Font = fontDialog1.Font;
        }

        private void FontColortoolStripTextBox_Click(object sender, EventArgs e)
        {
            ColorDialog1.ShowDialog();
            dataGridView1.ForeColor = ColorDialog1.Color;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About FA = new About();
            FA.Show();
        }

        private void InfoToolStripButton_Click(object sender, EventArgs e)
        {
            About FA = new About();
            FA.Show();
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Текстовый документ | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                NameFile = saveFileDialog1.FileName;
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if (NameFile != null)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine("X Y");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + " " + dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
                sw.Close();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Текстовый документ | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine("X Y");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + " " + dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
                sw.Close();
            }
        }

        private void ExecuteStripButton1_Click(object sender, EventArgs e)
        {
            double xn = Convert.ToDouble(textBox1.Text),
                xk = Convert.ToDouble(textBox2.Text),
                xh = Convert.ToDouble(textBox3.Text),
                x,
                y,
                yMin = 0,
                yMax = 0;

            chart1.Series[0].Points.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 2;

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

                if (yMin > y)
                {
                    yMin = y;
                }
                if (yMax < y)
                {
                    yMax = y;
                }
                x = x + xh;
                chart1.Series[0].Points.AddXY(x, y);
                dataGridView1.Rows.Add(x, y);
            }
            textBox5.Text = yMax.ToString();
            textBox6.Text = yMin.ToString();
        }
    }
}
