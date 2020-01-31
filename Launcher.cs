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
            Process.Start("C:/Users/Mike/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Steam/cuphead.url");
        }
        
        public void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
    }
}
