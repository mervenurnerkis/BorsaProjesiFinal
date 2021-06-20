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
    public partial class YapilanIslemler : Form
    {
        public YapilanIslemler()
        {
            InitializeComponent();
        }
        //Yapılan işlemler formunda daha önce kullanıcının yaptığı işlemlerin detayları gözükür.
        private void YapilanIslemler_Load(object sender, EventArgs e)
        {
            foreach (IslemDetaylari islem in GirilenVeriler.Islemler)
            {
                dataGridIslemler.Rows.Add(islem.TarihSaat, islem.Detay, islem.Tutar, islem.Alicikalan, islem.Birimfiyat);
            }
        }
    }
}
