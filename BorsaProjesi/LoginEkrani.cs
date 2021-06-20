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
    public partial class LoginEkrani : Form
    {
        public LoginEkrani()
        {
            InitializeComponent();
        }
        //login ekranında kullanıcı kayıt oluşturur.
        private void btnKayıtOlustur_Click(object sender, EventArgs e)
        {
            Kullanici yeniKayit = new Kullanici(txtKAdi.Text, txtbxSifre.Text, mskTC.Text, txtAd.Text, txtSoyad.Text, mskTel.Text, txtEMail.Text, rchAdres.Text);
            if (GirilenVeriler.SignUp(yeniKayit))
            {
                MessageBox.Show("Kaydınız başarılı bir şekilde gerçekleşmiştir.");
            }
            else
            {
                MessageBox.Show("Kaydınız başarısız sonuçlanmıştır. Lütfen tekrar deneyiniz!");
            }
        }

        //login ekranında kullanıcı ya da admin giriş yapar.
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text=="admin"&&txtSifre.Text=="1234")
            {
                new YoneticiEkrani().ShowDialog();
            }
            else
            {
                Kullanici giris = GirilenVeriler.Login(txtKullaniciAdi.Text, txtSifre.Text);
                if (giris != null)
                {
                    new KullaniciEkrani(giris).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız veya şifreniz hatalı. Lütfen tekrar deneyiniz!");
                }
            }
        }

       
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
