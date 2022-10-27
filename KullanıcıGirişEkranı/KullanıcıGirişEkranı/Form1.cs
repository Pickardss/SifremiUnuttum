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
    public partial class Form1 : Form
    {
        KullanıcıGirişEkranıEntitiesConnectionDB db = new KullanıcıGirişEkranıEntitiesConnectionDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public static int Id;
        private void button1_Click(object sender, EventArgs e)
        {
            var Durum = db.KullanıcıGirişTablo.FirstOrDefault(x => x.E_posta == textBox1.Text && x.Şifre == textBox2.Text);

            if (Durum != null)
            {
                Id = Durum.Id;
                GirisBasarili gb = new GirisBasarili();
                gb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bilgileriniz yanlıştır", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ŞifreSıfırlama şs = new ŞifreSıfırlama();
            şs.ShowDialog();
        }
    }
}
