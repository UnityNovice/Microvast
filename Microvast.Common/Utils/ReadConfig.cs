using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Common.Utils
{
    public class   ReadConfig
    {
        static IniReadWriteOther setting = new IniReadWriteOther();
        
        public static string GetLocalDataSetting()
        {
            setting.inipath = System.IO.Directory.GetCurrentDirectory() + "\\config.ini";
            setting.ExistINIFile();
            string IP = setting.IniReadValue("Setting", "本地数据库地址");
            string SQLName = setting.IniReadValue("Setting", "本地数据库名");
            string UserName = setting.IniReadValue("Setting", "本地数据库用户名");
            string Userpwd = setting.IniReadValue("Setting", "本地数据库密码");
            string constring =" Data Source = "+ IP + "; Initial Catalog =  "+ SQLName+"; Persist Security Info = True; User ID = "+UserName+"; pwd = "+Userpwd;
            return constring;
        }
    }
}
