using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);
            double c = a + b;
            txt3.Text = c.ToString();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);
            double c = a - b;
            txt3.Text = c.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            KetQua = a * b;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double a, b, KetQua;
            a = double.Parse(txt1.Text);
            b = double.Parse(txt2.Text);
            KetQua = a * b;
        }
    }
}
