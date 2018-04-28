using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemBO
{
    public class SrvClassInfoParam
    {
        public int ClassID { get; set; }

        public string Class { get; set; }

        public int ClassType { get; set; }
    }

    public class SrvClassInfoMessage
    {
        public SrvMessage Message { get; set; }

        public SrvClassInfoMessage()
        {
            Message = new SrvMessage();
        }
    }
}
