using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    //işlem detaylarına ilişkin değişkenler tanımlanmıştır.
    class IslemDetaylari
    {
        private DateTime tarihSaat;
        private string detay; 
        private string tutar;
        private string alicikalan;
        private string birimfiyat;

        public IslemDetaylari(string bilgi, string tutar, string birimfiyat, string alicikalan)
        {
            TarihSaat = DateTime.Now;
            Detay = detay;
            Tutar = tutar;
            Birimfiyat = birimfiyat;
            Alicikalan = alicikalan;
        }

        public DateTime TarihSaat { get => tarihSaat; set => tarihSaat = value; }
        public string Detay { get => detay; set => detay = value; }
        public string Tutar { get => tutar; set => tutar = value; }
        public string Birimfiyat { get => birimfiyat; set => birimfiyat = value; }
        public string Alicikalan { get => alicikalan; set => alicikalan = value; }
    }
}
