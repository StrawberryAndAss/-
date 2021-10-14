using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using Sunny.UI;
using System;
using System.Collections;
using System.Drawing;
using System.Net;
using 智能工时系统.CommonFuntion;
using 智能工时系统.POJO;
using 智能工时系统.Utils;

namespace 智能工时系统
{
    public partial class _Main_Window : MetroForm
    {
        //定义工时时间草稿的接口
        private const string POST_TASK_TIME_URL = "http://106.39.111.226/web/dataset/call_kw/time_to_declare/create";

        //定义工时时间草稿提交到管理员的接口
        private const string POST_TASK_TIME_REALLY_URL = "http://106.39.111.226/web/dataset/call_button";

        //初始化Cookie容器
        CookieContainer cookie = new CookieContainer();

        //定义一个存放工时订单的单号
        //JSON数据中 显示该属性为整型数据
        private int _RETURN_TASK_TIME_ORDER_NUM = 0;

        //定义一个存放UUID
        //JSON数据中 显示该属性为整型数据
        private int _RETURN_TASK_TIME_UUID = 0;

        public _Main_Window()
        {
            InitializeComponent();

            //初始化时将日期调整为当前日期
            _Date_Init();
        }

        /// <summary>
        ///  点击批量录入工时 将间隔的日期时间全部录入发送至服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btn_logon_Click(object sender, System.EventArgs e)
        {
            //将批量录入工时的按钮锁死
            _btn_send_task_time.Enabled = false;

            //获取登录成功后的Cookie
            //初始化Cookie容器
            cookie = _User_Token.Token;

            //从注册表中读取加密后的MD5数据
            ArrayList _MD5_after_json_list = _Json_MD5_after_regedit._ReadOut_json_text_();

            //加密后的文本视图内的数据
            string _MD5_after_json_data = _MD5_after_json_list[0].ToString();
            //加密后的提交视图内的数据
            string _MD5_after_call_button = _MD5_after_json_list[1].ToString();

            //进行解密还原
            //还原出来的是文本视图内的json数据    和   提交视图内的json数据
            string _user_select_json_data = _MD5.Md5Decrypt(_MD5_after_json_data);
            //提交视图内的数据
            string _user_select_call_button = _MD5.Md5Decrypt(_MD5_after_call_button);

            //用户填写的开始日期
            string _user_select_start_date = _date_picker_start.Text.Trim();
            string _system_select_start_date = _user_select_start_date + " 01:00:00";
            DateTime _format_after_start_time = DateTime.Parse(_system_select_start_date);
            //用户填写的结束日期
            string _user_select_end_date = _date_picker_end.Text.Trim();
            string _system_select_end_date = _user_select_end_date ;
            DateTime _format_after_end_time = DateTime.Parse(_system_select_end_date);

            if (!string.IsNullOrEmpty(_user_select_json_data)&&!string.IsNullOrEmpty(_user_select_call_button))
            {
                //将用户填写的文本视图的json字符串转化为json格式的数据，并进行修改
                JObject _format_json = JObject.Parse(_user_select_json_data);
                JObject _format_json_params = (JObject)_format_json["params"];
                JArray _format_json_params_args = (JArray)_format_json_params["args"];

                //从JSON数据里面取出UUID放入常量中
                JObject _format_json_params_kwargs = (JObject)_format_json_params["kwargs"];
                JObject _format_json_params_kwargs_context = (JObject)_format_json_params_kwargs["context"];
                _RETURN_TASK_TIME_UUID = (int)_format_json_params_kwargs_context["uid"];

               




                //里面内部结构包含数组，需要对数组内的数据进行修改
                JObject _format_json_params_args_arrays = (JObject)_format_json_params_args[0];


                //将用户填写的提交视图里面的json字符串转化为json格式的数据，并进行修改
                JObject _format_call_button = JObject.Parse(_user_select_call_button);
                JObject _format_call_button_params = (JObject)_format_call_button["params"];
                JArray _format_call_button_params_args = (JArray)_format_call_button_params["args"];

                //修改提交视图JSON数据中的UUID对应的值,将文本视图中的UUID的值直接替换掉提交视图里面的额值
                JObject _format_call_button_params_kwargs = (JObject)_format_call_button_params["kwargs"];
                JObject _format_call_button_params_kwargs_context = (JObject)_format_call_button_params_kwargs["context"];
                _format_call_button_params_kwargs_context["uid"] = _RETURN_TASK_TIME_UUID;


                //限定循环次数
                int _day_count = _format_after_end_time.Day - _format_after_start_time.Day;
                //进入循环
                for (int i = 0; i <= _day_count; i++)
                {
                    //循环后的开始时间日期
                    DateTime _system_repeat_ = _format_after_start_time.AddDays(i);
                    string _system_repeat_start_date = _system_repeat_.ToString("yyyy-MM-dd HH:mm:ss");
                    string _system_repeat_end_date = _system_repeat_.AddHours(8).ToString("yyyy-MM-dd HH:mm:ss");
                    //修改时间  origin-time为开始时间    term_time为结束时间
                    _format_json_params_args_arrays["origin_time"] = _system_repeat_start_date;
                    _format_json_params_args_arrays["term_time"] = _system_repeat_end_date;

                    //修改后的JSON数据发送至接口 POST到草稿接口上
                    string _post_return_data = Post.PostData(_format_json.ToString(), POST_TASK_TIME_URL,cookie);

                    //对返回的字符串进行判断
                    if(JObject.Parse(_post_return_data).ContainsKey("result"))
                    {
                        //对修改过日期的工时进行提取单号
                        _RETURN_TASK_TIME_ORDER_NUM = (int)JObject.Parse(_post_return_data)["result"];
                        _format_call_button_params_args[0][0] = _RETURN_TASK_TIME_ORDER_NUM;
                        //将修改后的最终JSON数据发送至管理员审核的接口 POST到   管理员审核的接口上
                        string _post_really_success_return_data = Post.PostData(_format_call_button.ToString(), POST_TASK_TIME_REALLY_URL, cookie);
                        //判断最终批量录入工时是否成功的依据
                            JObject _success_result_json = (JObject)JObject.Parse(_post_really_success_return_data);
                        if(_success_result_json.ContainsKey("name")&& _success_result_json.ContainsKey("res_id"))
                        {
                            _result_message_data.ItemSelectForeColor = Color.Green;
                            _result_message_data.Items.Add(_system_repeat_.ToShortDateString() + "==>"+ _system_repeat_ .DayOfWeek + "  的工时已录入完毕");
                            _result_message_data.SelectedIndex = this._result_message_data.Items.Count - 1;
                        }
                        else
                        {
                            _result_message_data.ItemSelectForeColor = Color.Red;
                            _result_message_data.Items.Add(_system_repeat_.ToShortDateString() + "==>" + _system_repeat_.DayOfWeek + "  的工时录入失败，请您重新再试");
                            _result_message_data.SelectedIndex = this._result_message_data.Items.Count - 1 ;
                        }
                    }
                    else
                    {
                        _result_message_data.ItemSelectForeColor = Color.Red;
                        _result_message_data.Items.Add(_system_repeat_.ToShortDateString() + "==>" + _system_repeat_.DayOfWeek + "  的工时录入失败，请您重新再试");
                        _result_message_data.SelectedIndex = this._result_message_data.Items.Count - 1;
                    }

                }
                //将批量录入工时的按钮激活
                _btn_send_task_time.Enabled = true;
            }

            else
            {
                UIMessageTip.ShowError("文本视图或提交视图中的内容为空，请您重新填写", 3000);
            }

        }

        /// <summary>
        /// 打开设置 将文本视图和提交视图文本内容写入至注册表中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _settings__Click(object sender, EventArgs e)
        {
            if (!Form_IsOpen.IsOpen("_Settings_"))
            {
                _Settings_ settings_ = new _Settings_();
                settings_.TopMost = true;
                settings_.Show();
            }
            else
            {
                UIMessageTip.ShowWarning("已为您打开设置，请您再换个姿势试试吧！！！",3000);
            }
        }

        /// <summary>
        /// 初始化为当前日期
        /// </summary>
        private void _Date_Init()
        {
            _date_picker_start.Value = DateTime.Now;
            _date_picker_end.Value = DateTime.Now;
        }
    }
}
