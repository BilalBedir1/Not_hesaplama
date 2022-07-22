using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_Double_Sınav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname;
            int ex1, ex2, project;
            double average;
            name = textBox1.Text;
            surname = textBox2.Text;
            ex1=Convert.ToInt16(textBox3.Text);
            ex2=Convert.ToInt16(textBox4.Text);
            project = Convert.ToInt16(textBox5.Text);
            average = (ex1 + ex2 + project) / 3;
            listBox1.Items.Add(name+" "+surname+" Ortalama: "+average);

        }
    }
}
