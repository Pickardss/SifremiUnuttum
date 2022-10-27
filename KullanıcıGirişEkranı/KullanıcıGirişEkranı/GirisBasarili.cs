using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KullanıcıGirişEkranı.Models;

namespace KullanıcıGirişEkranı
{
    public partial class GirisBasarili : Form
    {
        KullanıcıGirişEkranıEntitiesConnectionDB db = new KullanıcıGirişEkranıEntitiesConnectionDB();
        public GirisBasarili()
        {
            InitializeComponent();
        }

        private void GirisBasarili_Load(object sender, EventArgs e)
        {
            //label1.Text = $@"Hoş Geldiniz.{db.KullanıcıGirişTablo.FirstOrDefault(x => x.Id == Form1.Id).isim} {db.KullanıcıGirişTablo.FirstOrDefault(x => x.Id == Form1.Id).soyisim}";                    
        }
    }
}
