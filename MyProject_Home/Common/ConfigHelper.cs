using System;
using System.Configuration;
using System.Collections.Specialized;

namespace MyProject_Home.Common
{
    /// <summary>
    /// 
    /// </summary>
    public static class ConfigHelper
    {
        /// <summary>
        /// 获取指定的AppSettings
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Get(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// 获取web.config中的appSettings string
        /// </summary>
        /// <param name="strKey">设置项名称</param>
        /// <param name="strDefault">为空时的默认值</param>
        /// <returns>设置项的值</returns>
        public static string GetConfigString(string strKey, string strDefault = "")
        {
            string configStr = ConfigurationManager.AppSettings[strKey];
            if (string.IsNullOrEmpty(configStr))
            {
                return strDefault;
            }
            else
            {
                return configStr;
            }
        }

        /// <summary>
        /// 获取指定的AppSettings
        /// </summary>
        /// <param name="key"></param>
        /// <param name="t">默认值</param>
        /// <returns></returns>
        public static T GetConfigString<T>(string key, T t) where T : struct
        {
            string configValue = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrEmpty(configValue))
            {
                return t;
            }
            return configValue.TryParse<T>();
        }


        /// <summary>
        /// 获取指定的AppSettings
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(string key) where T : struct
        {
            string configValue = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrEmpty(configValue))
            {
                return default(T);
            }
            return configValue.TryParse<T>();
        }

        /// <summary>
        /// 获取指定Section的Key
        /// </summary>
        /// <param name="sectionName"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Get(string sectionName, string key)
        {
            NameValueCollection section = null;

            try
            {
                section = (NameValueCollection)ConfigurationManager.GetSection(sectionName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (section == null)
                throw new ConfigurationErrorsException("Not found " + sectionName + " section.");

            return section.Get(key);
        }

        /// <summary>
        /// 获取短信参数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSmsParameter(string key)
        {
            string sectionName = "smsPlatform/parameter";
            return Get(sectionName, key);
        }
        /// <summary>
        /// 获取短信模板
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSmsTemplate(string key)
        {
            string sectionName = "smsPlatform/template";
            return Get(sectionName, key);
        }
    }
}
