/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:
** ÖĞRENCİ ADI............:Berat    
** ÖĞRENCİ NUMARASI.......:b191200008
** DERSİN ALINDIĞI GRUP...:A 
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeratClk
{
    public partial class Form1 : Form
    {
        int kasa,pantsayac,penyesayac;
        // Buton basımlarında sıkntı olmasın diye sayaç ve kasa değişkenlerini burada giriyorum.
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPantal_Click(object sender, EventArgs e)
        {
            // Burada stoğumuzun ne kadar kaldığını gösteriyoruz.
            int pantstok = Convert.ToInt32(lblpantstok.Text);

            if (txtpantadet.Text == string.Empty)
            {
                MessageBox.Show("Adet Giriniz");
            }
            else
            {


                int pantolon;
                pantolon = Convert.ToInt32(txtpantadet.Text);
                pantsayac += pantolon;
                
                pantstok = 100 - pantsayac;
                if (pantstok < -1)
                {
                    MessageBox.Show("Stok Kalmamıştır");

                    pantstok += pantsayac;
                    pantsayac -= pantolon;
                }
                else
                {
                    //Pantolondan kazandığım paranın hesabını yapıyorum.
                    lblpantstok.Text = pantstok.ToString();
                    lblpantsayac.Text = pantsayac.ToString();
                    kasa += pantolon * 60;
                    lblkasa.Text = kasa.ToString() + " TL";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int penyestok = Convert.ToInt32(lblpenstok.Text);
            if (txtpenyeadet.Text == string.Empty)
            {
                MessageBox.Show("Adet Giriniz");
            }
            else
            {

                int penye;
                penye = Convert.ToInt32(txtpenyeadet.Text);
                penyesayac += penye;
                penyestok = 100 - penyesayac;
                if (penyestok < -1)
                {
                    MessageBox.Show("Stok Kalmamıştır");

                    penyestok += pantsayac;
                    pantsayac -= penye;
                }
                else
                {

                    lblpenyesyc.Text = penyesayac.ToString();
                    lblpenstok.Text = penyestok.ToString();
                    kasa += penye * 30;
                    lblkasa.Text = kasa.ToString() + " TL";
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
