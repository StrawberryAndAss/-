using Microsoft.Win32;
using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能工时系统.Utils
{
    class _Json_MD5_after_regedit
    {
        #region 保存文本视图、进注册表
        private static Dictionary<string, string> dicUserInfo = new Dictionary<string, string>();
        private static RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE", true).OpenSubKey("Microsoft", true);

        /// <summary>
        /// 写入所填写的文本视图和提交视图
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="userPwd"></param>
        public static void WriteIn(string jsonData, string jsonCallButton)
        {
            RegistryKey softwareXXX = key.OpenSubKey("IntelligentTaskTime", true);
            softwareXXX.SetValue("jsonData",jsonData);
            softwareXXX.SetValue("jsonCallButton", jsonCallButton);
        }

        /// <summary>
        /// 读出用户所填写的文本视图和提交视图
        /// </summary>
        /// 
        /*
        public static void ReadOut(UITextBox jsonData, UITextBox jsonCallButton)
        {
            dicUserInfo.Clear();
            RegistryKey softwareXXX = key.OpenSubKey("IntelligentTaskTime", true);
            jsonData.Text = softwareXXX.GetValue("jsonData").ToString();
            jsonCallButton.Text = softwareXXX.GetValue("jsonCallButton").ToString();
        }
        */

        /// <summary>
        /// 读出用户所填写的文本视图和提交视图并加入至集合中
        /// </summary>
        public static ArrayList _ReadOut_json_text_()
        {
            ArrayList _json_list = new ArrayList();
            dicUserInfo.Clear();
            RegistryKey softwareXXX = key.OpenSubKey("IntelligentTaskTime", true);
            string _json_data = softwareXXX.GetValue("jsonData").ToString();
            string _jsonCallButton = softwareXXX.GetValue("jsonCallButton").ToString();
            _json_list.Add(_json_data);
            _json_list.Add(_jsonCallButton);

            return _json_list;
        }

        #endregion

    }
}
