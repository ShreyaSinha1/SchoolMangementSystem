using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystemBO;
using System.Data.SqlClient;
using System.Data;

namespace SchoolMangementSystemDA
{
    public class SchoolTypeDA:SqlConnect

    {
        public SchoolTypeDA() :base("schoolmanage") { }

        public SrvSchoolTypeMessage InsertUpdateSchoolType(SrvSchoolTypeParam param)
        {
            con.Open();
            SrvSchoolTypeMessage message = new SrvSchoolTypeMessage();
                 
            SqlCommand cmd = new SqlCommand("sp_InsertUpdateSchoolType", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("SchoolTypeID", param.SchoolTypeID);
            cmd.Parameters.AddWithValue("SchoolTypeName", param.SchoolTypeName);
            cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
            cmd.Parameters["@ReturnValue"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@ReturnMessage", SqlDbType.NVarChar, 500);
            cmd.Parameters["@ReturnMessage"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            message.Message.ReturnValue = Convert.ToInt32(cmd.Parameters["@ReturnValue"].Value);
            message.Message.ReturnMessage = cmd.Parameters["@ReturnMessage"].Value.ToString(); 
            con.Close();
            return message;

        }
    }
}
