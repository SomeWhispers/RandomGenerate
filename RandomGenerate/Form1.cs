using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            textBox1.Text += "x\ty\tLabel\r\n";

            for (int i = 0; i < 50; i++)
            {
                double x = r.NextSingle();
                double y = r.NextSingle();
                int c;
                if (x < y) c = 0; else c = 1;

                textBox1.Text += String.Format("{0:f}\t{1:f}\t{2:d}\r\n", x, y, c);
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Text\Sample.txt";
            string text = textBox1.Text;

            StreamWriter sw = new StreamWriter(filePath);
            sw.Write(text);
            sw.Close();
            button2.Enabled = false;
        }
        
    }
}