using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_moi
{
    public partial class Sach_GiaoVien : UserControl
    {
        public Sach_GiaoVien()
        {
            InitializeComponent();
        }
        Book book = new Book();
        public void Sach_GiaoVien_Load(object sender, EventArgs e)
        {
           
            string sql = "select *from ThongTinSachMuon(" + StatisID.GlobalUserId + ")";
            dataGridView1.DataSource = book.getBook(sql);

            string sql2 = "SELECT *FROM phatsinhvien WHERE ID= " + StatisID.GlobalUserId;
            dataGridView2.DataSource = book.getBook(sql2);
        }
    }
}
