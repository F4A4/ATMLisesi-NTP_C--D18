using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SayısalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public byte KacTaneBildi(byte t1, byte t2, byte t3, byte[] makine)
        {
                              
                   
            byte bilinen = 0;
            for (int i = 0; i < makine.Length; i++)
            {
                if (makine[i]==t1)
                    bilinen += 1;

                if (makine[i]==t2)
                    bilinen += 1;

                if (makine[i] == t3)
                    bilinen += 1;
            }
            return bilinen;
        }
        private void btnOyna_Click(object sender, EventArgs e)
        {
            
            byte tahmin1 = Byte.Parse(txtBirinciTahmin.Text);
            byte tahmin2 = Convert.ToByte(txtIkinciTahmin.Text);
            byte tahmin3 = Byte.Parse(txtUcuncuTahmin.Text);
            
            Random rnd = new Random();
            byte[] makineninTuttuguSayilar = new byte[3];

            tk:
            for (int i = 0; i < makineninTuttuguSayilar.Length; i++)
            {
                makineninTuttuguSayilar[i] = Byte.Parse(rnd.Next(1, 10).ToString());
            }
            if (makineninTuttuguSayilar[0] == makineninTuttuguSayilar[1] || makineninTuttuguSayilar[1] == makineninTuttuguSayilar[2] || makineninTuttuguSayilar[0] == makineninTuttuguSayilar[3])
            {
                goto tk;
            }

            txtBirinciMakine.Text = makineninTuttuguSayilar[0].ToString();
            txtIkinciMakine.Text = makineninTuttuguSayilar[1].ToString();
            txtUcuncuMakine.Text = makineninTuttuguSayilar[2].ToString();

            //MessageBox.Show(makineninTuttuguSayilar[0].ToString() + "-" + makineninTuttuguSayilar[1].ToString() + "-" + makineninTuttuguSayilar[2].ToString());

            byte bilinenMiktari = KacTaneBildi(tahmin1, tahmin2, tahmin3, makineninTuttuguSayilar);

            lblSonuc.Text = String.Format("{0} tane bildiniz", bilinenMiktari);

            if ((tahmin1 == tahmin2) || (tahmin2 == tahmin3) || (tahmin1 == tahmin3))
            {
                lblSonuc.Text = "2 VEYA 3 SAYI AYNI OLAMAZ";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
