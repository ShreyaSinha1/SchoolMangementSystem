using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SchoolMangementSystemDA
{
    public class SqlConnect
    {
        public SqlConnection con=null;
        string connect;

        public SqlConnect()
        {

        }
        public SqlConnect(string param)
        {
            connect = ConfigurationManager.ConnectionStrings[param].ToString();
            con = new SqlConnection(connect);

        }
    }
}
