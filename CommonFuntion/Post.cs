﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 智能工时系统.CommonFuntion
{
    class Post
    {
        /// <summary>
        /// 发送相关数据至页面
        /// 进行登录操作
        /// 并保存cookie
        /// </summary>
        /// <param name="postData"></param>
        /// <param name="postUrl"></param>
        /// <param name="cookie"></param>
        /// <returns></returns>
        public static string PostData(string postData, string postUrl, CookieContainer cookie)
        {
            string _return_data = null;
            HttpWebRequest request;
            HttpWebResponse response;
            UTF8Encoding encoding = new UTF8Encoding();
            request = (HttpWebRequest)HttpWebRequest.Create(postUrl);
            byte[] b = encoding.GetBytes(postData);
            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.KeepAlive = true;
            request.UserAgent = "Mozilla/5.0 (iPad; CPU OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5376e Safari/8536.25";
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("Accept-Language", "zh-CN,zh-TW;q=0.9,zh;q=0.8,en-US;q=0.7,en;q=0.6");
            request.CookieContainer = cookie;
            request.ContentLength = b.Length;

            //写入流
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(b, 0, b.Length);
            }

            try
            {
                //获取服务器返回的资源
                using (response = request.GetResponse() as HttpWebResponse)
                {
                    
                    using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        _return_data = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException wex)
            {
                WebResponse wr = wex.Response;
                using (Stream st = wr.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(st, System.Text.Encoding.Default))
                    {
                        _return_data =sr.ReadToEnd();
                    }
                }
                //UIMessageTip.ShowError("本喵宣布罢工，错误信息：" + wex.Message + "。请联系我家主人", 2000);
                //Fm_LoginSystem LoginSystem = new Fm_LoginSystem();
                //LoginSystem.Dispose();
            }
            catch (Exception ex)
            {
                //UIMessageTip.ShowError("本喵宣布罢工，错误信息：" + ex.Message + "。请联系我家主人", 2000);
                //Fm_LoginSystem LoginSystem = new Fm_LoginSystem();
                //LoginSystem.Dispose();
            }
            return _return_data;
        }
    }
}
