using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeScreenLimit
{
    public class ShutDown
    {
        public static void ShutDownCommand(string command)
        {
            System.Diagnostics.Process.Start("shutdown", command);
        }
    }
}
