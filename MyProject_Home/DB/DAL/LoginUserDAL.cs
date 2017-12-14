using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Home.DB.DAL
{
    public class LoginUserDAL
    {
        /// <summary>
        /// 验证用户是否存在
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        public bool LoginCheck(string strUserName, string strPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * from LoginUser lu where lu.IsValid = 'Y' and lu.UserName=@UserName and lu.Password=@Password;");

            OleDbParameter[] parameters = {
                    new OleDbParameter("@UserName", OleDbType.VarChar,100),
                    new OleDbParameter("@Password", OleDbType.VarChar,100)
            };
            parameters[0].Value = strUserName;
            parameters[1].Value = strPassword;

            DataSet ds = OledbHelper.Query(strSql.ToString(), parameters);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取用户权限
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        public DataTable GetLoginUserRole(string strUserName, string strPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * from LoginUser lu where lu.IsValid = 'Y' and lu.UserName=@UserName and lu.Password=@Password;");

            OleDbParameter[] parameters = {
                    new OleDbParameter("@UserName", OleDbType.VarChar,100),
                    new OleDbParameter("@Password", OleDbType.VarChar,100)
            };
            parameters[0].Value = strUserName;
            parameters[1].Value = strPassword;

            DataSet ds = OledbHelper.Query(strSql.ToString(), parameters);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }
    }
}
