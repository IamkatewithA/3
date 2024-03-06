using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a1 = textBox1.Text;
                string b1 = textBox2.Text;
                string c1 = textBox4.Text;
                double x = Convert.ToDouble(a1);
                double y = Convert.ToDouble(b1);
                double z = Convert.ToDouble(c1);
                Class1 Class = new Class1();
                Array results = Class.F(x, y, z);
                StringBuilder sb = new StringBuilder();
                foreach (double result in results)
                {
                    sb.AppendLine(result.ToString());
                }

                textBox3.Text = sb.ToString();
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
