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
    public partial class TinhTrang_SinhVien : UserControl
    {
        private static TinhTrang_SinhVien _instance;
        public static TinhTrang_SinhVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TinhTrang_SinhVien();
                return _instance;
            }
        }

        public TinhTrang_SinhVien()
        {
            InitializeComponent();
        }
        Book book = new Book();
        public void TinhTrang_SinhVien_Load(object sender, EventArgs e)
        {
            string sql = "select *from ThongTinSachMuon(" + 191100 + ")";
            dataGridView1.DataSource = book.getBook(sql);

            string sql2 = "SELECT *FROM phatsinhvien WHERE ID= " + 191100;
            dataGridView2.DataSource = book.getBook(sql2);
        }
    }
}
