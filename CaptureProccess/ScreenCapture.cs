using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureProccess
{
    public class ScreenCapture
    {
        static private string CapturedScreenPath;
        static private string CapturedScreenExtension;
        static private int CapturedScreenCount = 0;
        public ScreenCapture(string imagePath, string imageExtension)
        {
            CapturedScreenPath = imagePath;
            CapturedScreenExtension = imageExtension;
            CapturedScreenCount = CapturedScreenCount + 1;
        }

        public static string ImagePath { get => CapturedScreenPath; set => CapturedScreenPath = value; }
        public static string ImageExtension { get => CapturedScreenExtension; set => CapturedScreenExtension = value; }
        public static int ImageCount { get => CapturedScreenCount; set => CapturedScreenCount = value; }

        public void Capture()
        {


            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                            Screen.PrimaryScreen.Bounds.Height,
                                            PixelFormat.Format32bppArgb);

            var gfxScreenShot = Graphics.FromImage(bmpScreenshot);

            gfxScreenShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                         Screen.PrimaryScreen.Bounds.Y, 0, 0,
                                         Screen.PrimaryScreen.Bounds.Size,
                                         CopyPixelOperation.SourceCopy);

            string directoryImage = CapturedScreenPath + DateTime.Now.ToLongDateString();
            if (!Directory.Exists(directoryImage))
            {
                Directory.CreateDirectory(directoryImage);
            }
            string imageName = string.Format("{0}\\{1}{2}", directoryImage, DateTime.Now.ToLongDateString() + CapturedScreenCount, CapturedScreenExtension);
            try
            {
                bmpScreenshot.Save(imageName, ImageFormat.Png);
            }
            catch
            {

            }
            CapturedScreenCount++;
        }
    }
}

