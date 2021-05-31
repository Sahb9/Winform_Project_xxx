using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_moi
{
    class ChiaCa
    {
        Database db = new Database();
        public bool getData(string sql)
        {
            SqlCommand command = new SqlCommand(sql, db.getConnection);
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public DataTable getTable(string sql)
        {
            SqlCommand command = new SqlCommand(sql, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void capNhat(int id,string mon,string tues,string wed,string thurs,string fri,string sa)
        {
            string sql = "update ChiaCa set Monday = @mon , Tuesday = @tu , Wednesday = @we , Thursday =@thurs , Friday=@fri,Saturday =@sa WHERE id = @id";
            SqlCommand command = new SqlCommand(sql, db.getConnection);
            command.Parameters.Add("@mon", SqlDbType.VarChar).Value = mon;
            command.Parameters.Add("@tu", SqlDbType.VarChar).Value = tues;
            command.Parameters.Add("@we", SqlDbType.VarChar).Value = wed;
            command.Parameters.Add("@thurs", SqlDbType.VarChar).Value = thurs;
            command.Parameters.Add("@fri", SqlDbType.VarChar).Value = fri;
            command.Parameters.Add("@sa", SqlDbType.VarChar).Value = sa;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                //return true;
            }
            else
            {
                db.closeConnection();
                //return false;
            }



        }

    }
}
