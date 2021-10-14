using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace 智能工时系统.POJO
{
    class _User_Token
    {
        [DataMember]
        public static CookieContainer Token { get; set; }
    }
}
