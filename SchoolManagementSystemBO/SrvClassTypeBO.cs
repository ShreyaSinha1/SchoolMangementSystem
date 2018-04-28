using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemBO
{
   public  class SrvClassTypeParam
    {
        public int ClassTypeID { get; set; }

        public string ClassType { get; set; }
    }
    public class SrvClassTypeMessage
    {
        public SrvMessage Message { get; set; }
        public SrvClassTypeMessage()
        {
            Message = new SrvMessage();
        }
    }
}
