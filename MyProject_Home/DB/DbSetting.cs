using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Home.DB
{
    public class DbSetting
    {
        /// <summary>
        /// 买车服务大全
        /// </summary>
        public static DbSetting WeiXinDb = new DbSetting();
        /// <summary>
        /// E币商城
        /// </summary>
        public static DbSetting ECoinDb = new DbSetting();
        /// <summary>
        /// EP统计数据
        /// </summary>
        public static DbSetting EPStatDb = new DbSetting();

        static DbSetting()
        {
            WeiXinDb.Reader = GetConnectionString("SqlConnectString");
            WeiXinDb.Writer = GetConnectionString("SqlConnectString");
            ECoinDb.Reader = GetConnectionString("SqlConnectString");
            ECoinDb.Writer = GetConnectionString("SqlConnectString");
            EPStatDb.Reader = GetConnectionString("SqlConnectString");
            EPStatDb.Writer = GetConnectionString("SqlConnectString");
        }
        private static string GetConnectionString(string name)
        {
            string connectionString = String.Empty;
            var config = ConfigurationManager.ConnectionStrings[name];
            if (config != null)
            {
                connectionString = config.ConnectionString;
            }
            return connectionString ?? String.Empty;
        }

        /// <summary>
        /// 只读链接
        /// </summary>
        public string Reader { get; protected set; }
        /// <summary>
        /// 读/写链接
        /// </summary>
        public string Writer { get; protected set; }
    }
}
