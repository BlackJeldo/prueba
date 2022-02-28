using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Dominio.Procesos
{
    public class Correo
    {
       

        public void EnviarCorreo(string To, string Subject, string Body)
        {

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();

            mail.From = new MailAddress("mailanurotec@gmail.com");

            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;

            SmtpClient smtp = new SmtpClient();

            smtp.Host = "smtp.gmail.com";
            //smtp.Host = "mail.anurotec.com";
            smtp.Port = 587; //465; //587
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("mailanurotec@gmail.com", "anurotec2022");
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            finally
            {
                smtp.Dispose();
            }

        }
    }
}
