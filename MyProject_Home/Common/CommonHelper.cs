using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject_Home.Common
{
    public static class CommonHelper
    {
        public static readonly string XmlLoginUserPath = ConfigHelper.GetConfigString("LoginUserXml", "Xml\\LoginUserInfo.xml");

        public static string GetLoginUserXmlPath()
        {
            string strPath = string.Empty;
            strPath = Application.StartupPath.Replace("bin\\Debug", "") + XmlLoginUserPath;

            return strPath;
        }
    }
}
