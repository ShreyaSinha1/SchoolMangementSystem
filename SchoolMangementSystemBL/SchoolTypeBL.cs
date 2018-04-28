using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystemBO;
using SchoolMangementSystemDA;

namespace SchoolMangementSystemBL
{
    public class SchoolTypeBL
    {
        public SrvSchoolTypeMessage InsertUpdateSchoolType(SrvSchoolTypeParam param)
        {

            return new SchoolTypeDA().InsertUpdateSchoolType(param);
        }
    }
}
