using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TimeScreenLimit
{
    public class StartWithOperatingSystem
    {
       public static void StartByRegistykey(string ApplicationPath, string ApplicationName)
       {
            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\ParentsAssistant");
            RegistryKey regStart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyValue = "1";
            try
            {
                regkey.SetValue("Index", keyValue);
                regStart.SetValue("ParentsAssistant", ApplicationPath + "\\" + ApplicationName + ".exe");
                regkey.Close();
            }
            catch(Exception ex)
            {

            }
       }

        public static void StartByCreatingShortcut(string ShortcutName, string ShortcutPath, string TargetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(ShortcutPath, ShortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.TargetPath = TargetFileLocation;
            shortcut.Save();
        }
    }
}
