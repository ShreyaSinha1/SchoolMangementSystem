using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolMangementSystemDA;
using SchoolManagementSystemBO;

namespace SchoolMangementSystemBL
{
    public class SchoolInformationBL
    {
        public SrvMessage InsertUpdateSchoolInfo(SrvSchoolInfoParams param)
        {

            return new SchoolInformationBL().InsertUpdateSchoolInfo(param);
        }
    }
}
