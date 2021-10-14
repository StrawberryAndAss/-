using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能工时系统.Utils
{
    class Form_IsOpen
    {
        /// <summary>
        /// 判断该窗口是否处入打开状态
        /// </summary>
        /// <param name="frmName"></param>
        /// <returns></returns>
        public static bool IsOpen(string frmName)
        {
            foreach (Form frm in Application.OpenForms) //遍历已打开窗口
            {
                if (frm.Name == frmName)                         //如果此窗口已打开
                {
                    frm.Activate();             //激活当前窗体

                    if (frm.WindowState == FormWindowState.Minimized)       //如果当前窗体已经最小化
                    {
                        frm.WindowState = FormWindowState.Normal;              //还原窗体
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
