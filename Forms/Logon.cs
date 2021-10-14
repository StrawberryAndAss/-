using MetroFramework.Forms;
using NSoup;
using NSoup.Nodes;
using NSoup.Select;
using Sunny.UI;
using System.Collections;
using System.Net;
using 智能工时系统.CommonFuntion;
using 智能工时系统.POJO;

namespace 智能工时系统
{
    public partial class Logon : MetroForm
    {

        //获取csrf_token凭证的URL
        private const string GET_CSRF_TOKEN_URL = "http://106.39.111.226/web/login";
        //将用户的登录信息传参到登录接口
        private const string POST_LOGON_URL = "http://106.39.111.226/web/login";
        //测试URL
        private const string TEST_URL = "http://106.39.111.226/web";
        //初始化Cookie容器
        CookieContainer cookie = new CookieContainer();
        //定义一个接收csrf_token令牌的常量
        private string _CSRF_TOKEN_;

        public Logon()
        {
            InitializeComponent();

            //读入账号密码
            RememberMeManager.ReadOut(_txt_username, _txt_password, _Checkbox_RememberPassword);

            //调用初始化获取Token令牌
            _Init_CSRF_TOKEN();
        }

        /// <summary>
        /// 系统初始化时从网页上获取到Token令牌
        /// </summary>
        private void _Init_CSRF_TOKEN()
        {
            //接收下返回的集合数据    0：Cookie    1：网页数据
            ArrayList _return_data = _Token_Get.getCookie(GET_CSRF_TOKEN_URL, cookie);
            cookie = (CookieContainer)_return_data[0];
            string html_data = _return_data[1].ToString();
            Document doc = NSoupClient.Parse(html_data);
            _CSRF_TOKEN_ = doc.GetElementsByTag("input").Val();
        }

        /// <summary>
        /// 对登录进行绑定事件，点击登录按钮触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btn_logon_Click(object sender, System.EventArgs e)
        {
            string _logon_username = _txt_username.Text.Trim();
            string _logon_password = _txt_password.Text.Trim();
            bool checkBox = _Checkbox_RememberPassword.Checked;
            if (!string.IsNullOrEmpty(_CSRF_TOKEN_))
            {
                _User_Data user_Data = new _User_Data()
                {
                    csrf_token = _CSRF_TOKEN_,
                    Username = _logon_username,
                    Password = _logon_password
                };
                CookieContainer _logon_return_cookie_ = _Token_Post.PostData(user_Data.ToString(), POST_LOGON_URL,cookie);
                cookie = _logon_return_cookie_;
            }

            ArrayList _return_arrayList = Get.get_html_data(TEST_URL,cookie);
            cookie = (CookieContainer)_return_arrayList[0];
            string _return_html_data = _return_arrayList[1].ToString();
            Document doc = NSoupClient.Parse(_return_html_data);
            string _logon_error = doc.GetElementsByTag("input").Val();
            if (string.IsNullOrEmpty(_logon_error))
            {
                UIMessageTip.ShowOk("您已成功登录", 2000);
                //写入账号密码 保存至本地
                RememberMeManager.WriteIn(_logon_username, _logon_password, checkBox);

                //将登录成功的Token传送至主页面
                _User_Token.Token = cookie;

                //显示主页面
                _Main_Window main_Window = new _Main_Window();
                main_Window.Show();
                this.Hide();
            }
            else
            {
                UIMessageTip.ShowError("账号或密码错误，请您重新输入", 3000);
                //调用初始化获取Token令牌
                _Init_CSRF_TOKEN();
            }
        }
    }
}
