using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Winform_moi
{
    public partial class DashBoard : UserControl
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        Book book = new Book();
        SinhVien sinhvien = new SinhVien();
        GiaoVien giaovien = new GiaoVien();
        public void DashBoard_Load(object sender, EventArgs e)
        {
            thongkeNguoiDung();
            thongkeSoLuongSach();
            thongkeSoLuongNopPhat();
            thongKePhat();
        }
        public void thongkeNguoiDung()
        {
            string student = "select count(*) from users_std";
            SqlCommand command1 = new SqlCommand(student); 
            string teacher = "select count(*) from users_teacher";
            SqlCommand command2 = new SqlCommand(teacher);
            DataTable s1 = sinhvien.getStudents(command1);
            DataTable s2 = giaovien.getTeacher(command2);
            //myNum = int.Parse(dt.Rows[0][0].ToString());
            int tong = int.Parse(s1.Rows[0][0].ToString()) +  int.Parse(s2.Rows[0][0].ToString());
            groupBoxNguoiDung.Text = "Số Lượng Người Dùng - " +tong;
            label1.Text = s1.Rows[0][0].ToString();
            label2.Text = s2.Rows[0][0].ToString();
        }
        public void thongkeSoLuongSach()
        {
            string library = "select count(*) from Book where ID_GV  is null";
            //SqlCommand command1 = new SqlCommand(library);
            string teacher = "select count(*) from Book where ID_GV  is not null";
            //SqlCommand command2 = new SqlCommand(teacher);
            DataTable s1 = book.getBook(library);
            DataTable s2 = book.getBook(teacher);
            int tong = int.Parse(s1.Rows[0][0].ToString()) + int.Parse(s2.Rows[0][0].ToString());
            groupBoxSach.Text = "Số Lượng Sách -  " + tong;
            label3.Text = s1.Rows[0][0].ToString();
            label4.Text = s2.Rows[0][0].ToString();
        }
        public void thongkeSoLuongNopPhat()
        {
            string student = "select count(*)  from phatsinhvien, users_std where phatsinhvien.ID = users_std.ID";
            //SqlCommand command1 = new SqlCommand(library);
            string teacher = "select count(*)  from phatsinhvien, users_teacher where phatsinhvien.ID = users_teacher.ID";
            //SqlCommand command2 = new SqlCommand(teacher);
            DataTable s1 = book.getBook(student);
            DataTable s2 = book.getBook(teacher);
            int tong = int.Parse(s1.Rows[0][0].ToString()) + int.Parse(s2.Rows[0][0].ToString());
            groupBoxPhat.Text = "Tổng số người nộp phạt -  " + tong;
            label5.Text = s1.Rows[0][0].ToString();
            label6.Text = s2.Rows[0][0].ToString();
        }
        public void thongKePhat()
        {
            string sql1 = "select count(*) from phatsinhvien where condition = 'Worn'";
        
            string sql2 = "select count(*) from phatsinhvien where condition = 'Late Book'";
           
            DataTable s1 = book.getBook(sql1);
            DataTable s2 = book.getBook(sql2);
            int tong = int.Parse(s1.Rows[0][0].ToString()) + int.Parse(s2.Rows[0][0].ToString());
            groupBoxCondition.Text = "Book Condition -  " + tong+ " person";
            label7.Text = s1.Rows[0][0].ToString();
            label8.Text = s2.Rows[0][0].ToString();
            //
            string p1 = "select sum(Price) from phatsinhvien where condition = 'Worn'";

            string p2 = "select sum(Price) from phatsinhvien where condition = 'Late Book'";

            DataTable s3 = book.getBook(p1);
            DataTable s4 = book.getBook(p2);
            int tongprice = int.Parse(s3.Rows[0][0].ToString()) + int.Parse(s4.Rows[0][0].ToString());
            groupBoxCondition.Text += " - "+tongprice +"$" ;
            labelWorn.Text ="Total: " +s3.Rows[0][0].ToString()+" $";
            labelLateBook.Text ="Total: "+ s4.Rows[0][0].ToString()+" $";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
