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
        public void TraSach_GiaoVien_Load(object sender, EventArgs e)
        {
            loadForm();
            setUpdata();
        }
        public void loadForm()
        {
            string sql = "SELECT BookName,Quantity,status FROM ThongTinSachMuon(" + 990 + ")";
            dataGridView1.DataSource = book.getBook(sql);
        }
        public void setUpdata()
        {
            dataGridView2.ColumnCount = 4;

            dataGridView2.Columns[0].Name = "Book Name";
            dataGridView2.Columns[1].Name = "Quantity";
            dataGridView2.Columns[2].Name = "Date Return";
            dataGridView2.Columns[3].Name = "Condition";
        }
       
       

        private void linkLabelFresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadForm();
            dataGridView2.Rows.Clear();
        }

   
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            string bookname = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int sl = (int)numericQuantity.Value;
            string date = ((DateTime)dateTimePicker1.Value).ToString("dd/MM/yyyy");
            string con = comboBoxCondition.Text;
            //tạo bảng 2
            DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row.Cells[0].Value = bookname;
            row.Cells[1].Value = sl;
            row.Cells[2].Value = date;
            row.Cells[3].Value = con;
            //MessageBox.Show(bookname);
            dataGridView2.Rows.Add(row);
            //xóa hàng vừa chọn (có điều kiện)
            if (sl == (int)dataGridView1.CurrentRow.Cells[1].Value)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBoxName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                numericQuantity.Value = (int)dataGridView1.CurrentRow.Cells[1].Value;
            }
            catch
            { }

        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            int slg = (int)dataGridView1.CurrentRow.Cells[1].Value;
            if (numericQuantity.Value > slg)
                numericQuantity.Value = 0;
        }

        private void buttonReturn_Click_1(object sender, EventArgs e)
        {
            int kt = 1;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                string bookname = dataGridView2.Rows[i].Cells[0].Value.ToString();
                int slg = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value.ToString());
                DateTime date = DateTime.ParseExact(dataGridView2.Rows[i].Cells[2].Value.ToString(), "dd/MM/yyyy", null);
                string con = dataGridView2.Rows[i].Cells[3].Value.ToString();
                //Phạt sách đối với sinh viên
                book.phatSach(191100, date, bookname, slg, con);
                if (book.traSach(191100, date, bookname, slg))
                {
                    kt = 1;
                }
                else
                    kt = 0;

            }
            if (kt == 1)
            {
                MessageBox.Show("Return to the libary Success", "Return Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadForm();
                dataGridView2.Rows.Clear();
            }
            else
                MessageBox.Show("Fail", "Return Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
