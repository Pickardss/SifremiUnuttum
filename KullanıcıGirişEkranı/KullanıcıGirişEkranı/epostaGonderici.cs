using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using KullanıcıGirişEkranı.Models;

namespace KullanıcıGirişEkranı
{
    public class epostaGonderici
    {
        KullanıcıGirişEkranıEntitiesConnectionDB db = new KullanıcıGirişEkranıEntitiesConnectionDB();
        public void Microsoft( string GondericiMail, string GondericiPass, string AliciMail)
        {
            KullanıcıGirişTablo kgt = db.KullanıcıGirişTablo.FirstOrDefault(x => x.E_posta == GondericiMail);
            Random rnd = new Random();
            kgt.Şifre = rnd.Next(1000, 10000).ToString();
            db.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, "mail gönderme örnek");
            mail.To.Add(AliciMail);
            mail.Subject = "Şifre sıfırlama talebi";
            mail.IsBodyHtml = true;
            mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre sıfırlama talebinde bulundunuz. Yeni Şifreniz {kgt.Şifre}";
            //sc.Timeout = 100;
            sc.Send(mail);
        }

    }
}
