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
    public partial class TraSach_GiaoVien : UserControl
    {
        public TraSach_GiaoVien()
        {
            InitializeComponent();
        }
        Book book = new Book();
        private void TraSach_GiaoVien_Load(object sender, EventArgs e)
        {
            loadForm();
            setUpdata();
        }
        public void loadForm()
        {
            string sql = "SELECT BookName,Quantity,status FROM ThongTinSachMuon(" + 191100 + ")";
            dataGridView1.DataSource = book.getBook(sql);
        }
        public void setUpdata()
        {
            dataGridView2.ColumnCount = 2;

            dataGridView2.Columns[0].Name = "Book Name";
            dataGridView2.Columns[1].Name = "Quantity";
        }
       
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string bookname = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string sl = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //tạo bảng 2
            DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row.Cells[0].Value = bookname;
            row.Cells[1].Value = sl;
            //MessageBox.Show(bookname);
            dataGridView2.Rows.Add(row);
            //xóa hàng vừa chọn
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.Rows.Count.ToString());
            int kt = 1;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    string bookname = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    int slg = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    if (book.traSach(191100, bookname, slg))
                    {
                        kt = 1;
                    }
                    else
                        kt = 0;

                }
            if (kt==1)
            {
                MessageBox.Show("Return to the libary Success", "Return Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadForm();
            }
            else
                MessageBox.Show("Fail", "Return Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabelFresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadForm();
            dataGridView2.Rows.Clear();
        }
    }
}
