using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BorsaProjesi
{
    class GirilenVeriler
    {
        public static List<Kullanici> kullanicilar = new List<Kullanici>();

        
        public static Kullanici kullaniciAra(string kullaniciadi)
        {
            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.KullaniciAdi == kullaniciadi)
                {
                    return kullanici;
                }
            }
            return null;
        }
        //Kullanıcı olup olmadığı konrol edilir.
        public static bool KullaniciVarmi(string TC, string Kullaniciadi)
        {
            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.TC == TC || kullanici.KullaniciAdi == Kullaniciadi)
                {
                    return true;
                }
            }
            return false;
        }
        public static AdminEkrani yonetici = new AdminEkrani("admin", "admin", "admin", "admin", "admin", "admin", "admin", "admin");
        public static DateTime dovizTarihi = DateTime.Now;

        //Kullanıcı giriş yaptığında kullancı adı ve şifresi kontrol edilir..

        public static Kullanici Login(string nickname, string parola)
        {
            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.KullaniciAdi == nickname && kullanici.Parola == parola)
                {
                    return kullanici;
                }
            }
            return null;
        }
        //Kullanıcının kayıt olup olmadığı kontrol edilir.
        public static bool SignUp(Kullanici uye)
        {
            if (KullaniciVarmi(uye.TC, uye.KullaniciAdi) == false && kullanicilar.Contains(uye) == false)
            {
                kullanicilar.Add(uye);
                return true;
            }
            return false;
        }

        public static List<Talepler> UrunTalepleri = new List<Talepler>();
        public static List<Talepler> KullaniciTalepleri(Kullanici kullanici)
        {
            List<Talepler> talepler = new List<Talepler>();
            foreach (Talepler talep in UrunTalepleri)
            {
                if (talep.Alici == kullanici)
                {
                    talepler.Add(talep);
                }
            }
            return talepler;
        }
        //Bu fonksiyonun içinde talep kontrol edilir.
        public static void TalepKontrol()
        {
            List<Talepler> hazirTalepler = new List<Talepler>();
            foreach (Talepler talepler in UrunTalepleri)
            {
                Mahsul alinacakMahsul;
                do
                {
                    alinacakMahsul = UcuzUrunBul(talepler);
                    if (alinacakMahsul != null)
                    {
                        talepler.AlimiGerceklestir(alinacakMahsul);
                        MahsulTemizle();
                        if (talepler.Hazirmi())
                        {
                            hazirTalepler.Add(talepler);
                            break;
                        }
                        else if (talepler.Alici.Bakiye < alinacakMahsul.Fiyat || alinacakMahsul.Miktar <= 0)
                        {
                            break;
                        }
                    }
                    else break;
                } while (alinacakMahsul != null);
            }
            foreach (Talepler talep1 in hazirTalepler)
            {
                UrunTalepleri.Remove(talep1);
            }
            MahsulTemizle();
        }
        public static List<IslemDetaylari> Islemler = new List<IslemDetaylari>();

         //Bu fonksiyonun içinde mahsul silinebiliyor.
        public static void MahsulTemizle()
        {
            List<Mahsul> silinecekler;
            foreach (Kullanici kullanici in kullanicilar)
            {
                silinecekler = new List<Mahsul>();
                foreach (Mahsul mahsul in kullanici.Mahsuller)
                {
                    if (mahsul.Miktar == 0)
                    {
                        silinecekler.Add(mahsul);
                    }
                }
                foreach (Mahsul silinecek in silinecekler)
                {
                    kullanici.Mahsuller.Remove(silinecek);
                }
            }

        }

        public static Mahsul UcuzUrunBul(Talepler talepler)
        {
            Mahsul UcuzUrun = null;
            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.KullaniciAdi != talepler.Alici.KullaniciAdi)
                {
                    foreach (Mahsul mahsul in kullanici.Mahsuller)
                    {
                        if (mahsul.Ad == talepler.Urun && mahsul.Onay && mahsul.Fiyat<=talepler.Fiyat)
                        {
                            if (UcuzUrun == null)
                            {
                                UcuzUrun = mahsul;
                            }
                            else if (mahsul.Fiyat < UcuzUrun.Fiyat)
                            {
                                UcuzUrun = mahsul;
                            }
                        }
                    }
                }
            }
            return UcuzUrun;
        }
        
        
       
        //Bu fonksiyonun içinde döviz kuru üzerinden tlye çevrilerek sisteme aktarılacak. veriler anlık olarak siteden çekiliyor.
        public static double DovizDonustur(double miktar, string doviz)
        {
            try
            {
                string yil = dovizTarihi.Year.ToString();
                string ay = dovizTarihi.Month.ToString();
                string gun = dovizTarihi.Day.ToString();
                if (gun.Length < 2)
                {
                    gun = "0" + gun;
                }
                if (ay.Length < 2)
                {
                    ay = "0" + ay;
                }
                XmlDocument veriler = new XmlDocument();
                veriler.Load("http://www.tcmb.gov.tr/kurlar/" + yil + ay + "/" + gun + ay + yil + ".xml");
                switch (doviz)
                {
                    case "Euro":
                        miktar *= (double)Convert.ToDecimal(veriler.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace(".", ","));
                        break;
                    case "Dolar":
                        miktar *=(double) Convert.ToDecimal(veriler.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace(".",",")) ;
                        break;
                    case "Sterlin":
                        miktar*= (double)Convert.ToDecimal(veriler.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace(".",","));
                        break;
                    default:
                        break;
                }
                return miktar;
            }
            catch (XmlException)
            {
            }
            return 0;
        }

        //Bu fonksiyonun içinde Pdf formatında rapor alınabiliyor.
        public static void RaporAl(DateTime baslangic,DateTime bitis)
        {
            ReportViewer reportViewer = new ReportViewer();
            ReportDataSource rds = new ReportDataSource("DataSet1", Islemler.Where(x=>x.TarihSaat>=baslangic.Date && x.TarihSaat.Date<=bitis.Date).ToList());
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.LocalReport.ReportPath = (Application.StartupPath + "\\Rapor.rdlc");
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.LocalReport.Refresh();
            reportViewer.RefreshReport();
            byte[] Bytes = reportViewer.LocalReport.Render(format: "PDF", deviceInfo: "");
            using (FileStream stream = new FileStream("rapor.pdf", FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
            Process.Start("rapor.pdf");
        }

    }
}
