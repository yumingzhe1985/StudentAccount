using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Home.Entity.XmlEntity
{
    public class XmlLoginUserEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 是否自动登录
        /// </summary>
        public string AutoLogin { get; set; }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否记住密码
        /// </summary>
        public string RememberPwd { get; set; }
    }
}
