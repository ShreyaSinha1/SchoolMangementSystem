using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemBO
{

    /// <summary>
    /// Student Properties
    /// </summary>
    public class SrvSessionProperties
    {
        public int SessionID { get; set; }

        public string Session { get; set; }
    }
    public class SrvSessionReturnMessage
    {
        public SrvMessage Message { get; set; }

        public SrvSessionReturnMessage()
        {
            Message = new SrvMessage();
        }
    }

    public class SrvSessionInfo
    {
        public SrvMessage Message { get; set; }

        public int SessionID { get; set; }

        public string Session { get; set; }

        public SrvSessionInfo()
        {
            Message = new SrvMessage();
        }
    }

    public class SrvSessionParams : SrvListParams
    {
        public string Filter { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }

    /// <summary>
    /// Displaying List Items
    /// </summary>
    public class SrvSessionInfoListData : SrvListData
    {
        public List<SrvSession> aaData { get; set; }
    }

    public class SrvSession
    {
        public int SessionID { get; set; }

        public string Session { get; set; }
    }


}
