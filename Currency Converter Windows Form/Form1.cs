using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, to;
            from = (string)comboBox1.SelectedItem;
            to = (string)comboBox2.SelectedItem;
            if (textBox1.Text == "")
            {               
                textBox1.BackColor = Color.IndianRed;
                MessageBox.Show("Вы не ввели количество валюты для перевода!");
            }
            else if (from == to)
                MessageBox.Show("Выберите разные валюты!");
            else webBrowser1.Navigate("https://www.google.ru/search?q=" + textBox1.Text + " " + from +
            "%D0%B2" + to);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.BackColor == Color.IndianRed)
                textBox1.BackColor = Color.White;
        }
    }
}
