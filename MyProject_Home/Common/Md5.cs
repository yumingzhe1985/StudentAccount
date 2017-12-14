using System.Text;
using System.Security.Cryptography;

namespace MyProject_Home.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class Md5
    {
        /// <summary>
        /// md5加密
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Encrypt(string source)
        {
            using (var md5Hash = MD5.Create())
            {
                var bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(source));

                StringBuilder hashBuilder = new StringBuilder(32);
                for (int i = 0; i < bytes.Length; i++)
                {
                    hashBuilder.Append(bytes[i].ToString("x").PadLeft(2, '0'));
                }
                return hashBuilder.ToString();
            }
        }
    }
}
