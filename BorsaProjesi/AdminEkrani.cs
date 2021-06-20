using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    class AdminEkrani : Kullanici
    {
        //Admin ekranında mahsuller listelenir.
        public static List<Mahsul> OnaylanacakMahsuller()
        {
            List<Mahsul> liste = new List<Mahsul>();
            foreach (Kullanici kullanici in GirilenVeriler.kullanicilar)
            {
                foreach (Mahsul mahsul in kullanici.Mahsuller)
                {
                    if (!mahsul.Onay)
                    {
                        liste.Add(mahsul);
                    }
                }
            }
            return liste;
        }
        public AdminEkrani(string kullaniciAdi, 
            string sifre, string tC, string ad, 
            string soyad, string telefon, string email, 
            string adres) : base(kullaniciAdi, sifre, tC, ad, soyad, 
                telefon, email, adres)
        {
        }
    }
}
