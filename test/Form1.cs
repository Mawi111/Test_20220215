using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        List<Kolecko> kolecka;
        public Form1()
        {
            InitializeComponent();
            kolecka = new List<Kolecko>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                Random random = new Random();
                Kolecko kolecko = new Kolecko((int)numericUpDown1.Value, barva1.BackColor, barva2.BackColor, barva3.BackColor, barva4.BackColor, barva5.BackColor, new Point(50, 50));
                kolecko.Lokace = new Point(random.Next(0, pictureBox1.Width), random.Next(0, pictureBox1.Height));
                kolecka.Add(kolecko);
                pictureBox1.Refresh();

            }
            else
            {
                Kolecko kolecko = new Kolecko((int)numericUpDown1.Value, barva1.BackColor, barva2.BackColor, barva3.BackColor, barva4.BackColor, barva5.BackColor, new Point(50, 50));
                kolecko.Lokace = new Point((int)numericUpDown2.Value, (int)numericUpDown3.Value);
                kolecka.Add(kolecko);
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var kolecko in kolecka)
            {
                kolecko.Draw(e.Graphics);
            }
        }

        private void barva1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = barva1.BackColor;
            colorDialog1.ShowDialog();
            barva1.BackColor = colorDialog1.Color;
        }

        private void barva2_Click(object sender, EventArgs e)
        {
            colorDialog2.Color = barva2.BackColor;
            colorDialog2.ShowDialog();
            barva2.BackColor = colorDialog2.Color;
        }

        private void barva3_Click(object sender, EventArgs e)
        {
            colorDialog3.Color = barva3.BackColor;
            colorDialog3.ShowDialog();
            barva3.BackColor = colorDialog3.Color;
        }

        private void barva4_Click(object sender, EventArgs e)
        {
            colorDialog4.Color = barva4.BackColor;
            colorDialog4.ShowDialog();
            barva4.BackColor = colorDialog4.Color;
        }

        private void barva5_Click(object sender, EventArgs e)
        {
            colorDialog5.Color = barva5.BackColor;
            colorDialog5.ShowDialog();
            barva5.BackColor = colorDialog5.Color;
        }
    }
}
