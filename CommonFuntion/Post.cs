using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        public static CookieContainer PostData(string postData, string postUrl, CookieContainer cookie)
        {
            //ArrayList list = new ArrayList();
            HttpWebRequest request;
            HttpWebResponse response;
            ASCIIEncoding encoding = new ASCIIEncoding();
            request = (HttpWebRequest)HttpWebRequest.Create(postUrl);
            byte[] b = encoding.GetBytes(postData);
            request.Headers.Add("Accept-Encoding", "gzip,deflate");
            request.KeepAlive = true;
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = " Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.88 Safari/537.36";
            request.Method = "POST";
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
                    //new GZipStream(response.GetResponseStream(), CompressionMode.Decompress))
                    //对返回的网络流进行解压，解压成字符串流
                    using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default))
                    {

                        //response.ContentType = "text/html; charset=UTF-8";
                        if (response.Cookies.Count > 0)
                            cookie.Add(response.Cookies);
                    }
                }
            }
            catch (Exception ex)
            {
                //UIMessageTip.ShowError("本喵宣布罢工，错误信息：" + ex.Message + "。请联系我家主人", 2000);
               // LoginSystem LoginSystem = new LoginSystem();
                //LoginSystem.Dispose();
            }
            return cookie;


        }

    }
}
