using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_moi
{
    class CheckOut
    {
        Database db = new Database();
        public DataTable getTable(string sql)
        {
            SqlCommand command = new SqlCommand(sql, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
