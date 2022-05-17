using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notpanda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);

            label2.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }
    }
}
