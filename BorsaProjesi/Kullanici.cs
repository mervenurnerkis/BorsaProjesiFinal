using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    public class Kullanici
    {
        private string ad;
        private string soyad;
        private string Tc;
        private string telefon;
        private string email;
        private string adres;

        private string kullaniciAdi;
        private string parola;

        private List<Mahsul> mahsuller;
        private double bakiye;
        private double bakiyeOnay;

        public void MahsulEkle(Mahsul mahsul)
        {
            if (mahsuller.Contains(mahsul) == false)
            {
                mahsuller.Add(mahsul);
            }
        }
        public Kullanici(string kullaniciAdi, string parola, string Tc, string ad, string soyad, string telefon, string email, string adres)
        {
            Ad = ad;
            Soyad = soyad;
            TC = Tc;
            KullaniciAdi = kullaniciAdi;
            Parola = parola;
            Telefon = telefon;
            Email = email;
            Adres = adres;
            Bakiye = 0;
            BakiyeOnay = 0;
            Mahsuller = new List<Mahsul>();
        }
       
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string TC { get => Tc; set => Tc = value; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Parola { get => parola; set => parola = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string Adres { get => adres; set => adres = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        public double BakiyeOnay { get => bakiyeOnay; set => bakiyeOnay = value; }
        internal List<Mahsul> Mahsuller { get => mahsuller; set => mahsuller = value; }

    }
}
