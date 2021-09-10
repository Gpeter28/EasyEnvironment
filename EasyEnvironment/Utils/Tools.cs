using EasyEnvironment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace OneSetSetUpEnvironment.Utils
{
    public class Tools
    {
        public static Image GetImage(string s)
        {
            if (!File.Exists($"{Config.IconPath}\\{s}.png"))
            {
                return Image.FromFile($"{Config.IconPath}\\empty.png");
            }
            else
            {
                return Image.FromFile($"{Config.IconPath}\\{s}.png");
            }
        }
    }
}
