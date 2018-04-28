using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolManagementSystemBO;
using SchoolMangementSystemBL;

namespace SchoolManagementSystemAPI.Controllers
{
    public class SchoolTypeController : ApiController
    {
        [Route("~/api/SchoolType/InsertUpdateSchoolType")]
        [HttpPost]

        public SrvSchoolTypeMessage InsertUpdateSchoolType([FromBody]SrvSchoolTypeParam param)
        {
            SchoolTypeBL schoolType;
            SrvSchoolTypeMessage message=new SrvSchoolTypeMessage();
            try
            {
                schoolType = new SchoolTypeBL();
                message = schoolType.InsertUpdateSchoolType(param);
            }
            catch (SqlException ex)
            {
                message.Message.ReturnValue = -1;
                message.Message.ReturnMessage = "Sql Error";
            }

            catch (Exception ex)
            {
                message.Message.ReturnValue = -1;
                message.Message.ReturnMessage = "Internal Error";
            }

            return message;
        }
    }
}

