using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_moi
{
    class Book
    {
        Database db = new Database();
        public DataTable getBook(string sql)
        {
            SqlCommand command = new SqlCommand(sql, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertBook(int Idbook,string tenbook,string loai,int solg,int gia,int id_gv)
        {
            //INSERT[dbo].[Book]([BookID], [BookName], [Genre], [Quantity], [Price],[ID_GV]) VALUES(@idbook, @ten, @loai, @solg, @gia,@magv)
            SqlCommand command = new SqlCommand("INSERT[dbo].[Book]([BookID], [BookName], [Genre], [Quantity], [Price],[ID_GV]) VALUES(@idbook, @ten, @loai, @solg, @gia,@magv)", db.getConnection);
            command.Parameters.Add("@idbook", SqlDbType.Int).Value = Idbook;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = tenbook;
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loai;
            command.Parameters.Add("@solg", SqlDbType.Int).Value = solg;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            command.Parameters.Add("@magv", SqlDbType.Int).Value = id_gv;
        

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
        public bool updateBook(int idcu,int Idbook, string tenbook, string loai, int solg, int gia)
        {
            SqlCommand command = new SqlCommand("exec Update_Book @idcu , @idbook, @ten,@loai ,@solg,@gia", db.getConnection);
            command.Parameters.Add("@idcu", SqlDbType.Int).Value = idcu;
            command.Parameters.Add("@idbook", SqlDbType.Int).Value = Idbook;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = tenbook;
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loai;
            command.Parameters.Add("@solg", SqlDbType.Int).Value = solg;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            //command.Parameters.Add("@magv", SqlDbType.Int).Value = id_gv;


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

        public bool checkIDBook(int id)
        {
            SqlCommand command = new SqlCommand("SELECT *FROM ShowBook WHERE BookID = "+id, db.getConnection);
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
        public bool deleteBook(int ID)
        {
            SqlCommand command = new SqlCommand("exec Delete_Book @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
        public DataTable soSachMuon(string sql)     //tên thể loại
        {
            SqlCommand command = new SqlCommand("exec Sosachmuon @loai", db.getConnection);
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = sql;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
           adapter.Fill(table);
            return table;
        }
        public DataTable soSachtrongThuVien(string sql)     //tên thể loại
        {
            SqlCommand command = new SqlCommand("exec Sosachtrongkho @tensach", db.getConnection);
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = sql;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
       
        public DataTable soSachTheoTen(string sql)     //tên thể loại
        {
            SqlCommand command = new SqlCommand("exec  Sosachtrongkho_theoten @tensach", db.getConnection);
            command.Parameters.Add("@tensach", SqlDbType.VarChar).Value = sql;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool muonsach(string tensach,int IDmember ,DateTime muon, DateTime tra , int solg,string status)
        {
            SqlCommand command = new SqlCommand("exec Muonsach @tensach,@idmember,@ngaymuon,@ngaytra,@solg,@st", db.getConnection);
            command.Parameters.Add("@tensach", SqlDbType.VarChar).Value = tensach;
            command.Parameters.Add("@idmember", SqlDbType.Int).Value = IDmember;
            command.Parameters.Add("@ngaymuon", SqlDbType.DateTime).Value = muon;
            command.Parameters.Add("@ngaytra", SqlDbType.DateTime).Value = tra;
            command.Parameters.Add("@solg", SqlDbType.Int).Value = solg;
            command.Parameters.Add("@st", SqlDbType.VarChar).Value = status;


            db.openConnection();
            if ((command.ExecuteNonQuery() == -1))
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
        public bool traSach(int maid,string tensach, int sl)
        {
           
            SqlCommand command = new SqlCommand("exec  TraSach_ @maid,@ten,@sl", db.getConnection);
            command.Parameters.Add("@maid", SqlDbType.Int).Value = maid;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = tensach;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = sl;

            db.openConnection();
            if ((command.ExecuteNonQuery() == -1))
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
    }
}
