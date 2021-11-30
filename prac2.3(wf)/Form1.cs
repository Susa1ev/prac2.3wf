using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac2._3_wf_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
        void Main()
        {
            if (Int32.TryParse(textBox1.Text, out a) && Int32.TryParse(textBox2.Text, out b) && a < b)
            {
                label4.Text = string.Empty;
                label4.Text += "Через For:\t\t";
                for (int i = a; i < b; i++)
                {
                    if (i % 3 == 0)
                    {
                        label4.Text += i + " ";
                    }
                }
                label4.Text += "\nЧерез While:\t\t";
                int wi = a;
                while (wi < b)
                {
                    if (wi % 3 == 0)
                    {
                        label4.Text += wi + " ";
                    }
                    wi++;
                }
                label4.Text += "\nЧерез do...While:\t";
                int dwi = a;
                do
                {
                    if (dwi % 3 == 0)
                    {
                        label4.Text += dwi + " ";
                    }
                    dwi++;
                } while (dwi < b);
            }
            else
            {
                MessageBox.Show("Вы ввели что-то не то");
            }

        }
    }
}
