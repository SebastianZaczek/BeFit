using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFit.Classes
{
    public static class ReturnProjectDirectory
    {
        public static string GetProductImagePath(string name)
        {
            var path = Application.StartupPath + @"\Product_Images\" + name + ".jpeg";
            return path;
        }
        public static string GetProfilesPath()
        {
            var path = Application.StartupPath + @"\Profiles\";
            return path;
        }
    }
}
