using MyProject_Home.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Home.DB.DAL
{
    public class CustomerDAL
    {
        private static readonly string DefaultHighestAuthority = string.IsNullOrWhiteSpace(ConfigHelper.Get("DefaultHighestAuthority")) ? "1" : ConfigHelper.Get("DefaultHighestAuthority");
        private static readonly string IsNotHaveUNPW = ConfigHelper.Get("IsNotHaveUNPW");

        /// <summary>
        /// 通过用户权限获取所有客户数据
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        public DataSet GetAllCustomer(string strUserName, string strPassword)
        {
            LoginUserDAL dal = new LoginUserDAL();
            DataTable dt = dal.GetLoginUserRole(strUserName, strPassword);
            if (dt != null || IsNotHaveUNPW == "0")
            {
                StringBuilder strSql = new StringBuilder();
                OleDbParameter[] parameters = { new OleDbParameter("@LID", OleDbType.VarChar, 100) };
                strSql.Append(@"SELECT c.ID
, l.UserName
, c.FullName
, c.Phone
, c.Address
, c.Gender
, c.CreateTime
, c.UpdateTime
, c.IsValid
, c.Remarks
, c.Account
, c.AccountRemarks
, c.ConsumptionTime
FROM Customer As c
LEFT JOIN LoginUser l on c.LID = l.UID");
                if (IsNotHaveUNPW == "0")
                {
                    parameters = null;
                }
                else if(!DefaultHighestAuthority.Equals(dt.Rows[0]["Authority"].ToString()))
                {
                    strSql.Append(" where c.LID = @LID");
                    parameters[0].Value = dt.Rows[0]["UID"];
                }
                strSql.Append(" Order By c.CreateTime desc;");

                return OledbHelper.Query(strSql.ToString(), parameters);
            }
            return null;
        }
    }
}
