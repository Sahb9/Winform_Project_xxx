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
     class GiaoVien
    {
        Database mydb = new Database();
        public bool getData(string sql)
        {
            SqlCommand command = new SqlCommand(sql, mydb.getConnection);
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
        public DataTable getTable(string sql)
        {
            SqlCommand command = new SqlCommand(sql, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertUserTeacher(int id, string name, string gender, int phone, string address, MemoryStream picture, string user, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO users_teacher( ID, Name, Gender, Phone, Address,Picture,Username,Password )"
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
        public bool updateUserTeacher(int id, string name, string gender, int phone, string address, MemoryStream picture, string user, string pass)
        {
            SqlCommand command = new SqlCommand("UPDATE users_teacher SET  Name=@name, Gender=@gen, Phone=@phn, Address=@add,Picture=@pic,Username=@user,Password=@pass" +
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
        public DataTable getTeacher(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool DeleteUserTeacher(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM users_teacher   WHERE ID = @id", mydb.getConnection);
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
