using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = double.Parse(textBox1.Text);
            sayi2 = double.Parse(textBox2.Text);

            if (checkBox1.Checked) 
            {
                sonuc = sayi1 + sayi2;
            }
            else if (checkBox2.Checked) 
            {
                sonuc = sayi1 - sayi2;
            }
            else if (checkBox3.Checked) 
            {
                sonuc = (sayi1 * sayi2);
            }
            else if (checkBox4.Checked) 
            {
                sonuc = (sayi1/sayi2);
            }
            else if (checkBox5.Checked) 
            {
                sonuc = Math.Pow(sayi1,sayi2);
            }
            else if (checkBox6.Checked)
            {
                sonuc = Math.Sqrt(sayi1);
            }
            lbl3.Text = sonuc.ToString();

            MessageBox.Show(sonuc.ToString());
        }
    }
}
      


