using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urok__6
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Старт";
            button2.Text = "Выход";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pct.Left = pct.Left + 20;
            button1.Text = "Стоп";
            pct.Left += 20;
            if (pct.Right >= this.Width - 30)
            {
                button1.Text = "Старт";
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 != 0)
            {
                pct.Location = new Point(12, 12);
                timer1.Start();
            }
            if (counter % 2 == 0)
            {
                timer1.Stop();
                button1.Text = "Старт";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
