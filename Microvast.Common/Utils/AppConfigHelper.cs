using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Common.Utils
{
    /// <summary>
    /// 老是忘记从AppConfig读取的方法名，直接封装了哈哈。。。
    /// </summary>
    public class AppConfigHelper
    {
        /// <summary>
        /// 获取Appsetting中的值
        /// </summary>
        /// <param name="name">节点名字</param>
        /// <returns></returns>
        public static string GetAppsetting(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        /// <summary>
        /// 设置Appsetting中的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetAppsetting(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings[key] != null)
                    config.AppSettings.Settings[key].Value = value;
                else
                    config.AppSettings.Settings.Add(key, value);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 设置ConnectString中的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetConnetString(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.ConnectionStrings.ConnectionStrings[key] != null)
                    config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
                else
                    config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(key, value));
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
