using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mail;


namespace Parents_Assistant___OOP_project
{
    public partial class Form1 : Form
    {
        static string imagePath = "Image_";
        static string imageExtension = ".png";
        static int imageCount = 0;
        static int captureTime = 1000;
        static void CaptureScreen()
        {
            
            
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                            Screen.PrimaryScreen.Bounds.Height,
                                            PixelFormat.Format32bppArgb);

            var gfxScreenShot = Graphics.FromImage(bmpScreenshot);

            gfxScreenShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                         Screen.PrimaryScreen.Bounds.Y, 0 ,0 ,
                                         Screen.PrimaryScreen.Bounds.Size,
                                         CopyPixelOperation.SourceCopy);

            string directoryImage = imagePath + DateTime.Now.ToLongDateString();
            if(!Directory.Exists(directoryImage))
            {
                Directory.CreateDirectory(directoryImage);
            }
            string imageName = string.Format("{0}\\{1}{2}", directoryImage, DateTime.Now.ToLongDateString() + imageCount, imageExtension);
            try
            {
                bmpScreenshot.Save(imageName, ImageFormat.Png);
            }
            catch
            {

            }
            imageCount++;
        }

        static void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient Server = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("thongthailb2@gmail.com");
                mail.To.Add("19522188@gm.uit.edu.vn");
                mail.Subject = "Test Project";
                string directoryImage = imagePath + DateTime.Now.ToLongDateString();
                DirectoryInfo image = new DirectoryInfo(directoryImage);
                foreach(FileInfo item in image.GetFiles("*.png"))
                {
                    if (File.Exists(directoryImage + "\\" + item.Name))
                    {
                        mail.Attachments.Add(new Attachment(directoryImage + "\\" + item.Name));
                    }
                }
                Server.Port = 587;
                Server.Credentials = new System.Net.NetworkCredential("thongthailb2@gmail.com", "Thai******:::542001");
                Server.EnableSsl = true;
                Server.Send(mail);
                Console.WriteLine("send mail");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(CaptureScreen);
            CaptureScreen();
            
           // MessageBox.Show("Clicked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart thread = new ThreadStart(SendMail);
            Thread thr = new Thread(thread);
            thr.Start();
            
        }
    }
}
