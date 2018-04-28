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
    public class SrvStudentProperties
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string Address { get; set; }

        public string Image { get; set; }
    }

    public class SrvStudentReturnMessage
    {
        public SrvMessage Message { get; set; }

        public SrvStudentReturnMessage()
        {
            Message = new SrvMessage();
        }
    }

    public class SrvStudentInfo
    {
        public SrvMessage Message { get; set; }

        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string Address { get; set; }

        public string Image { get; set; }

        public SrvStudentInfo()
        {
            Message = new SrvMessage();
        }
    }

    public class SrvStudentParams : SrvListParams
    {
        public string Filter { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }

    /// <summary>
    /// Displaying List Items
    /// </summary>
    public class SrvStudentInfoListData :SrvListData
    {
       public  List<SrvStudent> aaData { get; set; }
    }
    
    public class SrvStudent
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string Address { get; set; }

        public string Image { get; set; }
    }
}
