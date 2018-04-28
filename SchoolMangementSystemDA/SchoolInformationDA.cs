using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystemBO;

namespace SchoolMangementSystemDA
{
    public class SchoolInformationDA : SqlConnect
    {
        public SchoolInformationDA() : base("schoolmanage") { }

        //public SrvMessage InsertUpdateSchoolInfo(SrvSchoolInfoParams param)
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("sp_InsertUpdateSchoolInfo");
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("",param.SchoolName);
        //    cmd.Parameters.AddWithValue("", param.SchoolType.SchoolTypeID);
        //    cmd.Parameters.AddWithValue("", param.CityID);
        //    cmd.Parameters.AddWithValue("", param.CountryID);
        //    cmd.Parameters.AddWithValue("", param.Address);
        //    cmd.Parameters.AddWithValue("", param.ContactNo);
        //    cmd.Parameters.AddWithValue("", param.Fax);
        //    cmd.Parameters.AddWithValue("", param.EmailID);
        //    cmd.Parameters.AddWithValue("", param.Website);
        //    cmd.ExecuteNonQuery();
        //    return false;

        //}

    }
    }

