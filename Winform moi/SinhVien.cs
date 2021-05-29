using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_moi
{
    class SinhVien
    {
        Database mydb = new Database();
        public DataTable getUserById(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM users_std  WHERE ID = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertUserSTD(int id, string name, string gender, int phone, string address, MemoryStream picture, string user, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO users_std ( ID, Name, Gender, Phone, Address,Picture,Username,Password )"
                + "VALUES ( @uid, @name, @gen, @phn, @add,@pic,@user,@pass)", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@gen", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.Int).Value = phone;
            command.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }



        public bool updateUserSTD(int id, string name, string gender, int phone, string address, MemoryStream picture, string user, string pass)
        {
            SqlCommand command = new SqlCommand("UPDATE users_std SET  Name=@name, Gender=@gen, Phone=@phn, Address=@add,Picture=@pic,Username=@user,Password=@pass" +
                " WHERE ID=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@gen", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.Int).Value = phone;
            command.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool DeleteUserSTD(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM users_std   WHERE ID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection(); return true;
            }
            else
            {
                mydb.closeConnection(); return false;
            }

        }
    }
}
