using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melans_LLC
{
    class SendMail
    {
        private string bodyMail = "";
        private string nameAuthor = "";
        private string subject = "";
        const string passMail = "SergeiZhyikov@inbox.ru";
        public SendMail(string bodyMail, string nameAuthor, string subject)
        {
            this.bodyMail = bodyMail;
            this.nameAuthor = nameAuthor;
            this.subject = subject;
        }

        public void MySendMail()
        {
            FeedBack _FB = new FeedBack();
            var from = new MailAddress("bomber106460@gmail.com", nameAuthor); //Ящик для отправки сообщений
            var to = new MailAddress("bomber825@mail.ru", "Phil Phoenix"); //Личный ящик  
            
            try
            {
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(from.Address, passMail);
                    smtp.EnableSsl = true;
                    smtp.Timeout = 20000;

                    MailMessage mail = new MailMessage(from, to);
                    mail.Subject = subject;
                    mail.Body = bodyMail;

                    smtp.Send(mail);

                    MetroFramework.MetroMessageBox.Show(_FB, "Сообщение доставлено!", "Информационное письмо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(_FB, ex.ToString(), "Ошибка отправки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
