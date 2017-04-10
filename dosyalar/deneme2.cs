using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesapmakinesidouble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sayı2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, toplam;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);

            toplam = sayı1 + sayı2;
            label4.Text = toplam.ToString();


        }
    }
}
