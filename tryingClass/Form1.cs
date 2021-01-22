using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectPLCFX;
using System.IO.Ports;

namespace tryingClass
{
    public partial class Form1 : Form
    {
        ConnectPLCFX.ConnectPLCFX  connectPLCFX;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] w = new int[4];
            w[0] = int.Parse(textBoxw1.Text);
            w[1] = int.Parse(textBoxw2.Text);
            w[2] = int.Parse(textBoxw3.Text);
            w[3] = int.Parse(textBoxw4.Text);
            
            connectPLCFX.Write(w);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
          connectPLCFX = new ConnectPLCFX.ConnectPLCFX("COM1", 9600, 7, StopBits.One , Parity.Even);
          connectPLCFX.Connect();
          timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "";

            int[] r = new int[4];
            r = connectPLCFX.Read();
            if (r != null)
            {
                textBox1.Text = r[0].ToString() + "\r\n";
                textBox1.Text += r[1].ToString() + "\r\n";
                textBox1.Text += r[2].ToString() + "\r\n";
                textBox1.Text += r[3].ToString() + "\r\n";
            }

        }
    }
}
