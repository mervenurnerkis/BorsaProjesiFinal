using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesi
{
    public partial class YoneticiEkrani : Form
    {
        public YoneticiEkrani()
        {
            InitializeComponent();
        }
        //İşlemler ekranı açılır.
       
        
        private void listKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            TalepleriGuncelle();
        }
        private void YoneticiEkrani_Load(object sender, EventArgs e)
        {
            PanelGuncelle();
            GirilenVeriler.TalepKontrol();
        }
        private void btnIslemler_Click(object sender, EventArgs e)
        {
            new YapilanIslemler().ShowDialog();
        }
        void PanelGuncelle()
        {
            foreach (Kullanici kullanici in GirilenVeriler.kullanicilar)
            {
                listKullanicilar.Items.Add(kullanici.KullaniciAdi + " - " + kullanici.Ad + " " + kullanici.Soyad + " Bakiye: " + kullanici.Bakiye);
            }
        }

        //Kullanıcının üstüne tıklayarak talep onaylanır.
        void TalepleriGuncelle()
        {
            if (listKullanicilar.SelectedIndex>=0)
            {
                string nickname = listKullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici secilen = GirilenVeriler.kullaniciAra(nickname);
                listUrunTalep.Items.Clear();
                lbltalep.Text = secilen.BakiyeOnay.ToString()+" TL";
                foreach (Mahsul urun in secilen.Mahsuller )
                {
                    if (urun.Onay==false)
                    {
                        listUrunTalep.Items.Add("Ad :" + urun.Ad + " Miktar: " + urun.Miktar + " Fiyat: " + urun.Fiyat+" TL");
                    }
                }
            }
        }

        private void YoneticiEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            GirilenVeriler.TalepKontrol();
        }

        //Kullanıcılardan gelen tüm talepler onaylanır.
        private void btnTalep_Click(object sender, EventArgs e)
        {
            if (listKullanicilar.SelectedIndex>=0)
            {
                string nickname = listKullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici secilen = GirilenVeriler.kullaniciAra(nickname);
                foreach (Mahsul urun in secilen.Mahsuller)
                {
                    if (urun.Onay==false)
                    {
                        urun.Onay = true;
                    }
                }
            }
            TalepleriGuncelle();
            GirilenVeriler.TalepKontrol();
        }
        //Kullanıcıdan gelen bakiye isteği onaylanır.
        private void btnBakiyeOnay_Click(object sender, EventArgs e)
        {
            if (listKullanicilar.SelectedIndex >= 0)
            {
                string nickname = listKullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici secilen = GirilenVeriler.kullaniciAra(nickname);
                secilen.Bakiye += secilen.BakiyeOnay;
                secilen.BakiyeOnay = 0;
            }
            TalepleriGuncelle();
        }
        //istenilen tarihe göre döviz güncellenir.
        private void btnDovizGuncelle_Click(object sender, EventArgs e)
        {
            GirilenVeriler.dovizTarihi = dateTimeTarih.Value;
            MessageBox.Show("Güncelleme başarılı");
        }

       
    }
}
