using StringMetody;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStringLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstupniRetezec = textBox1.Text;
            MessageBox.Show(Metody.VymazDiakritiku(vstupniRetezec).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vstupniRetezec = textBox1.Text;
            int pocetCisel = 0;
            int pocetJinych = 0;
            int pocetVelkych = 0;
            label2.Text = "Počet malých písmen: " + Metody.PocetZnaku(vstupniRetezec, out pocetVelkych, out pocetCisel, out pocetJinych).ToString();
            label3.Text = "Počet velkých písmen: " + pocetVelkych;
            label4.Text = "Počet čísel: " + pocetCisel;
            label5.Text = "Počet jiných znaků: " + pocetJinych;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Metody.PasswordGen();
        }
    }
}
