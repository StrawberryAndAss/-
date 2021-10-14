using Microsoft.Win32;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能工时系统
{
    class RememberMeManager
    {
        #region 保存用户名、密码进注册表
        private static Dictionary<string, string> dicUserInfo = new Dictionary<string, string>();
        private static RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE", true).OpenSubKey("Microsoft", true);


        /// <summary>
        /// //创建注册表项
        /// </summary>
        private static void buildreg()
        {
            RegistryKey softUserInfo = key.CreateSubKey("IntelligentTaskTime");//写入注册表项(你所说的文件夹)
            softUserInfo.SetValue("username", "");
            softUserInfo.SetValue("userPassword", "");
            softUserInfo.SetValue("checkBox", "");
            softUserInfo.SetValue("jsonData", "");
            softUserInfo.SetValue("jsonCallButton", "");
        }

        /// <summary>
        /// 写入账号密码
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="userPwd"></param>
        public static void WriteIn(string userCode, string userPwd, bool checkBox)
        {
            RegistryKey softwareXXX = key.OpenSubKey("IntelligentTaskTime", true);
            if (softwareXXX == null)
            {
                buildreg();
                softwareXXX = key.OpenSubKey("IntelligentTaskTime1733");
            }
            if (checkBox)
            {
                softwareXXX.SetValue("username", userCode);
                softwareXXX.SetValue("userPassword", userPwd);
                softwareXXX.SetValue("checkBox", "1");
            }
            else
            {
                softwareXXX.SetValue("username", "");
                softwareXXX.SetValue("userPassword", "");
                softwareXXX.SetValue("checkBox", "");
            }
        }

        /// <summary>
        /// 读出账号密码
        /// </summary>
        public static void ReadOut(UITextBox userName, UITextBox passWord, UICheckBox rememberMe)
        {
            dicUserInfo.Clear();
            RegistryKey softwareXXX = key.OpenSubKey("IntelligentTaskTime", true);
            if (softwareXXX == null)
            {
                buildreg();
                softwareXXX = key.OpenSubKey("IntelligentTaskTime", true);
            }
            userName.Text = softwareXXX.GetValue("username").ToString();
            passWord.Text = softwareXXX.GetValue("userPassword").ToString();
            if (softwareXXX.GetValue("checkBox").ToString() == "1")
            {
                rememberMe.Checked = true;
            }
        }
        #endregion
    }
}
