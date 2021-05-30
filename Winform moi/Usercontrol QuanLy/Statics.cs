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
    public partial class Statics : UserControl
    {
        public Statics()
        {
            InitializeComponent();
        }
        Book book = new Book();
        public void Statics_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == "Return" && comboBox1.Text == "Student")
                {
                    string sql1 = "exec SinhVien_datra ";
                    dataGridView1.DataSource = book.getBook(sql1);
                }
                else if (comboBox2.Text == "No Return" && comboBox1.Text == "Student")
                {
                    string sql1 = "exec SinhVien_chuatra ";
                    dataGridView1.DataSource = book.getBook(sql1);
                }
                else if (comboBox2.Text == "Return" && comboBox1.Text == "Teacher")
                {
                    string sql1 = "exec GiaoVien_datra ";
                    dataGridView1.DataSource = book.getBook(sql1);
                }
                else if (comboBox2.Text == "No Return" && comboBox1.Text == "Teacher")
                {
                    string sql1 = "exec GiaoVien_chuatra ";
                    dataGridView1.DataSource = book.getBook(sql1);
                }
            }
            catch
            { }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == "Return" && comboBox1.Text == "Student")
                {
                    string sql1 = "exec SinhVien_datra ";
                    dataGridView1.DataSource = book.getBook(sql1);
                }
                else if (comboBox2.Text == "No Return" && comboBox1.Text == "Student")
                {
                    string sql1 = "exec SinhVien_chuatra ";
                    dataGridView1.DataSource = book.getBook(sql1);
                }
                else if (comboBox2.Text == "Return" && comboBox1.Text == "Teacher")
                {
                    string sql1 = "exec GiaoVien_datra ";
                    dataGridView1.DataSource = book.getBook(sql1);
                }
                else if (comboBox2.Text == "No Return" && comboBox1.Text == "Teacher")
                {
                    string sql1 = "exec GiaoVien_chuatra ";
                    dataGridView1.DataSource = book.getBook(sql1);
                }
            }
            catch
            { }
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (comboBox2.Text == "Return")
                {
                    string sql = " select Book.BookID,Book.BookName,trasach.Quantity,trasach.ReturnDate"
                               + " from trasach, Book" +
                                 " where Book.BookName = trasach.BookName and ID = " + id;
                    dataGridView2.DataSource = book.getBook(sql);


                }
                else if (comboBox2.Text == "No Return")
                {
                    string sql = " select Book.BookID,Book.BookName,Search.Quantity,Search.IssueDate,Search.ReturnDate"
                              + " from Search,Book" +
                                " where Book.BookID = Search.BookID and  MemberID = " + id;
                    dataGridView2.DataSource = book.getBook(sql);

                }
            }
            catch
            { }
        }

        private void buttonRank_Click(object sender, EventArgs e)
        {
            RankForm frm = new RankForm();
            frm.Show();
        }
    }
}
