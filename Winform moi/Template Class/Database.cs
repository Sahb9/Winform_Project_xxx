using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_moi
{
    class Database
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-LD7KLDC7\SQLEXPRESS02;Initial Catalog=CSDL_Winform;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        //open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }
    }
}
