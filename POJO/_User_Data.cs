using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace 智能工时系统.POJO
{
    [DataContract]
    class _User_Data
    {
        [DataMember]
        public string csrf_token { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Redirect { get; set; }
  
        public override string ToString()
        {
            return "csrf_token=" + csrf_token
                + "&login=" + Username
                + "&password=" + Password
                + "&redirect=" + Redirect;
        }
    }
}
