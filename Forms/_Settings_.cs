using MetroFramework.Forms;
using Sunny.UI;
using System.Collections;
using 智能工时系统.Utils;

namespace 智能工时系统
{
    public partial class _Settings_ : MetroForm
    {
        public _Settings_()
        {
            InitializeComponent();

            //初始化时将文本视图和提交视图内的内容加载到文本框内
            Init();
        }

        /// <summary>
        /// 将用户输入的文本视图和提交视图内的内容 加密的方式存入注册表中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btn_applicate_txt_Click(object sender, System.EventArgs e)
        {
            //提取文本视图 和 提交视图内容
            string _before_json_data = _json_data.Text.Trim();
            string _before_json_call_button = _json_call_button.Text.Trim();

            //判断两个视图里面的内容是否都为空
            if(!string.IsNullOrEmpty(_before_json_data)&&!string.IsNullOrEmpty(_before_json_call_button))
            {
               //对用户提交的文本视图和提交视图进行加密压缩 并保存在注册表中
               string _after_json_data = _MD5.Md5Encrypt(_before_json_data);
               string _after_json_call_button = _MD5.Md5Encrypt(_before_json_call_button);

                //将加密后的文本视图和提交视图里面的内容写入注册表中
                _Json_MD5_after_regedit.WriteIn(_after_json_data, _after_json_call_button);
                UIMessageTip.ShowOk("内容已成功写入数据，喵~~~", 3000);
                //写入成后将文本视图和提交视图的文本框锁死，不让用户再次操作
                _json_data.ReadOnly = true;
                _json_data.Enabled = false;
                _json_call_button.ReadOnly = true;
                _json_call_button.Enabled = false;
            }
            else
            {
                UIMessageTip.ShowError("文本视图或者提交视图中的内容为空，请您重新填写", 3000);
            }


        }

        /// <summary>
        /// 将文本视图和提交视图的文本框激活，让用户再次操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btn_edit_txt_Click(object sender, System.EventArgs e)
        {
            _json_data.ReadOnly = false;
            _json_data.Enabled = true;
            _json_call_button.ReadOnly = false;
            _json_call_button.Enabled = true;
        }

        private void Init()
        {
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

            //将还原出来的字符串填充到文本框内
            _json_data.Text = _user_select_json_data;
            _json_call_button.Text = _user_select_call_button;
        }
    }
}
