using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace For_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            listBox1.Items.Add("1");
            listBox1.Items.Add("2");
            listBox1.Items.Add("3");
            for (i=0; i<10 ; i++)
            {
                listBox1.Items.Add(i);

        }
    }
}
