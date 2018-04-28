using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemBO
{
    public class SrvSchoolTypeParam
    {
        public int SchoolTypeID { get; set; }

        public string SchoolTypeName { get; set; }


    }
    public class SrvSchoolTypeMessage
    {
        public SrvMessage Message { get; set; }
        public SrvSchoolTypeMessage()
        {
            Message = new SrvMessage();
        }
    }

    public class SrvSchoolTypeListData:SrvListParams
    {
        public  List<SrvSchoolTypeInfo> SchoolType { get; set; }
    }

    public class SrvSchoolTypeInfo
    {
        public int SchoolTypeID { get; set; }

        public string SchoolTypeName { get; set; } 
    }
}
