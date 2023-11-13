using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GününSorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int Degerlendirme(int sayı)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 10);

            int Ksayi = Int32.Parse(textBox1.Text);
            int Ksayi2 = Int32.Parse(textBox2.Text);
            int Ksayi3 = Int32.Parse(textBox3.Text);

            textBox5.Text = sayi.ToString();
            
            if ((sayi == Ksayi) || (sayi == Ksayi2))
            {
                label5.Text = "YALNIZ BİR TAHMİNİNİZ DOĞRUDUR 5 TL KAZANDINIZ";
            }
            else if ((sayi == Ksayi2) || (sayi == Ksayi3))
            {
                label5.Text = "YALNIZ BİR TAHMİNİNİZ DOĞRUDUR 5 TL KAZANDINIZ ";
            }
            else if ((sayi == Ksayi) || (sayi == Ksayi3))
            {
                label5.Text = "YALNIZ BİR TAHMİNİNİZ DOĞRUDUR 5 TL KAZANDINIZ ";
            }
            else if ((sayi == Ksayi) && (sayi == Ksayi2))
            {
                label5.Text = "YALNIZ İKİ TAHMİNİNİZ DOĞRUDUR 10 TL KAZANDINIZ ";
            }
            else if ((sayi == Ksayi2) && (sayi == Ksayi3))
            {
                label5.Text = "YALNIZ İKİ TAHMİNİNİZ DOĞRUDUR 10 TL KAZANDINIZ";
            }
            else if ((sayi == Ksayi) && (sayi == Ksayi3))
            {
                label5.Text = "YALNIZ İKİ TAHMİNİNİZ DOĞRUDUR 10 TL KAZANDINIZ ";
            }
            else if ((sayi == Ksayi) && (sayi == Ksayi2) && (sayi == Ksayi3))
            {
                label5.Text = "TAHMİNİNİZ HEPSİ DOĞRUDUR 100 TL KAZANDINIZ ";
            }
            else
            {
                label5.Text = "TAHMİNİNİZ HEPSİ YANLIŞTIR 0 TL KAZANDINIZ ";
            }

            return sayi;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int sayi2 = rnd.Next(1, 10);
            int sonuç = Degerlendirme(sayi2);

            int sayi3= rnd.Next(1, 10);
            int sonuç2 = Degerlendirme(sayi3);

            textBox6.Text = sayi2.ToString();
            textBox7.Text = sayi3.ToString();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

       
    }
}
