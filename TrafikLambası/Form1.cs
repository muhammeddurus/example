using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikLambası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int kırmızı;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.BackColor = Color.Red;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int green = Convert.ToInt32(label1.Text);
            green++;

            label1.Text = green.ToString();
            if (green==30)
            {
                button2.BackColor = Color.Yellow;

               
            }
            if (green==40)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Green;
            }
            if (green==70)
            {
                green = 0;
                label1.Text = green.ToString();
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Gray;

            }
        }
    }
}
