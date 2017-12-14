using MyProject_Home.Entity.XmlEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyProject_Home.Common
{
    public class XmlHelper
    {
        private XmlDocument doc = null;
        private string XmlPath = string.Empty;

        public XmlHelper(string xmlPath)
        {
            if (string.IsNullOrEmpty(xmlPath))
            {
                throw new Exception("xml文件路径不正确");
            }
            XmlPath = xmlPath;
            doc = new XmlDocument();
            doc.Load(xmlPath);
        }

        /// <summary>
        /// 获取登陆过的用户信息
        /// </summary>
        /// <returns></returns>
        public List<XmlLoginUserEntity> GetLoginedUserInfo()
        {
            List<XmlLoginUserEntity> xmlList = null;
            try
            {
                // 得到根节点LoginUser
                XmlNode xn = doc.SelectSingleNode("LoginUser");
                // 得到根节点的所有子节点
                XmlNodeList xnl = xn.ChildNodes;

                xmlList = new List<XmlLoginUserEntity>();
                foreach (XmlNode node in xnl)
                {
                    XmlLoginUserEntity entity = new XmlLoginUserEntity();
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement xe = (XmlElement)node;
                    // 得到Type和ISBN两个属性的属性值
                    entity.CreateTime = Convert.ToDateTime(xe.GetAttribute("CreateTime"));
                    entity.UserName = xe.GetAttribute("UserName");
                    entity.Password = xe.GetAttribute("Password");
                    entity.AutoLogin = xe.GetAttribute("AutoLogin");
                    entity.RememberPwd = xe.GetAttribute("RememberPwd");
                    // 得到Book节点的所有子节点
                    //XmlNodeList item = xe.ChildNodes;
                    //entity.UserName = item.Item(0).InnerText;
                    //entity.Password = item.Item(1).InnerText;
                    //entity.AutoLogin = item.Item(2).InnerText;
                    //entity.RememberPws = item.Item(3).InnerText;
                    xmlList.Add(entity);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return xmlList;
        }

        /// <summary>
        /// 获取登陆过的用户名
        /// </summary>
        /// <returns></returns>
        public List<string> GetLoginedUserName()
        {
            List<string> xmlList = null;
            try
            {
                // 得到根节点LoginUser
                XmlNode xn = doc.SelectSingleNode("LoginUser");
                // 得到根节点的所有子节点
                XmlNodeList xnl = xn.ChildNodes;

                xmlList = new List<string>();
                foreach (XmlNode node in xnl)
                {
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement xe = (XmlElement)node;
                    // 得到Book节点的所有子节点
                    XmlNodeList item = xe.ChildNodes;
                    xmlList.Add(item.Item(0).InnerText);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return xmlList;
        }

        /// <summary>
        /// 更改登录过的用户信息
        /// </summary>
        /// <param name="entityList"></param>
        /// <returns></returns>
        public bool AddOrEditLoginedUserInfo(XmlLoginUserEntity entity)
        {
            if (entity == null)
            {
                return false;
            }
            //查找xml中是否有此节点
            var list = GetLoginedUserInfo();
            var item = list.Where(e => e.UserName == entity.UserName).FirstOrDefault();
            if (item != null)
            {
                XmlNodeList nodes = doc.SelectNodes(string.Format("//LoginUser/UserInfo [@UserName='{0}']", item.UserName));
                if (nodes.Count <= 0) return false;
                foreach (XmlNode node in nodes)
                {
                    node.Attributes["CreateTime"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    node.Attributes["UserName"].Value = entity.UserName;
                    node.Attributes["Password"].Value = entity.Password;
                    node.Attributes["AutoLogin"].Value = entity.AutoLogin;
                    node.Attributes["RememberPwd"].Value = entity.RememberPwd;
                }
                doc.Save(XmlPath);
            }
            else
            {
                XmlNode root = doc.SelectSingleNode("LoginUser");//查找<LoginUser>
                XmlElement ui = doc.CreateElement("UserInfo");//创建一个<UserInfo>节点
                ui.SetAttribute("CreateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));//设置该节点CreateTime属性
                ui.SetAttribute("UserName", entity.UserName);//设置该节点UserName属性
                ui.SetAttribute("Password", entity.Password);//设置该节点UserName属性
                ui.SetAttribute("AutoLogin", entity.AutoLogin);//设置该节点UserName属性
                ui.SetAttribute("RememberPwd", entity.RememberPwd);//设置该节点UserName属性
                root.AppendChild(ui);//添加到<LoginUser>节点中
                doc.Save(XmlPath);
            }

            return true;
        }
    }
}
