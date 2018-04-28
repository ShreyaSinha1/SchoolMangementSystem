using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemBO
{
    public class SrvSchoolInfoParams
    {
        public int SchoolID { get; set; }

        public string SchoolName { get; set; }

        public int CityID { get; set; }

        public int CountryID { get; set; }

        public string Address { get; set; }

        public long ContactNo { get; set; }

        public long Fax { get; set; }

        public string EmailID { get; set; }

        public string Website { get; set; }

        public string Image { get; set; }

        public int SchoolTypeID { get; set; }

    }

    public class SrvSchoolInfoMessage
    {
        public SrvMessage Message { get; set; }
        public SrvSchoolInfoMessage()
        {
            Message = new SrvMessage();
        }
    }
    public class SrvSchoolInfoListData : SrvListParam
    {
        public List<SrvSchoolInfo> SchoolType { get; set; }
    }

    public class SrvSchoolInfo
    {
        public int SchoolID { get; set; }

        public string SchoolName { get; set; }

        public int CityID { get; set; }

        public int CountryID { get; set; }

        public string Address { get; set; }

        public long ContactNo { get; set; }

        public long Fax { get; set; }

        public string EmailID { get; set; }

        public string Website { get; set; }

        public string Image { get; set; }

        public int SchoolTypeID { get; set; }
    }
}
