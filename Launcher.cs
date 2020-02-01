using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //interact w/ system processes and event logs

namespace GameLauncher
{
    class Launcher
    {
        public void PlayGame()
        {
            ProcessStartInfo proc_info = new ProcessStartInfo();
            proc_info.CreateNoWindow = false;
            proc_info.WindowStyle = ProcessWindowStyle.Normal;
            proc_info.FileName = @"C:";


            Process.Start(proc_info);
        }
        
        public void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
    }
}
