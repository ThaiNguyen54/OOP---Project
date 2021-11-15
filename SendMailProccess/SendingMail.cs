using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendMailProccess
{
    public class SendingMail
    {
        public static void SendMail(string imagePath, string EmailAddress)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient Server = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("parentsassistant123@gmail.com");
                mail.To.Add(EmailAddress);
                mail.Subject = "Test Project";
                string directoryImage = imagePath + DateTime.Now.ToLongDateString();
                DirectoryInfo image = new DirectoryInfo(directoryImage);
                foreach (FileInfo item in image.GetFiles("*.png"))
                {
                    if (File.Exists(directoryImage + "\\" + item.Name))
                    {
                        mail.Attachments.Add(new Attachment(directoryImage + "\\" + item.Name));
                    }
                }
                Server.Port = 587;
                Server.Credentials = new System.Net.NetworkCredential("parentsassistant123@gmail.com", "PA@123456789");
                Server.EnableSsl = true;
                Server.Send(mail);
                Console.WriteLine("send mail");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
