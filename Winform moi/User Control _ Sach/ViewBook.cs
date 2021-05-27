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
    public partial class ViewBook : UserControl
    {
        public ViewBook()
        {
            InitializeComponent();
        }
        Book book = new Book();
        private void ViewBook_Load(object sender, EventArgs e)
        {
            string sql = "select *from ShowcomboGenre";
            dataGridView1.DataSource = book.getBook(sql);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            string loaisach = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            DataTable Muon = book.soSachMuon(loaisach);
            DataTable Conlai = book.soSachtrongThuVien(loaisach);
            labelMuon.Text = "Sách Mượn : " + Muon.Rows[0]["Quantity"].ToString();
            labelCon.Text = "Sách còn : " + Conlai.Rows[0]["Quantity"].ToString();
            // data 2 
            string sql = "SELECT * FROM SearchAll  ('" + loaisach + "')";
            dataGridView2.DataSource = book.getBook(sql);
        }

        private void comboBoxShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaisach = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(loaisach);
            try
            {
                if (comboBoxShow.Text == "Học Sinh")
                {
                    string sql = "SELECT * FROM Search_Student  ('" + loaisach + "')";
                    dataGridView2.DataSource = book.getBook(sql);
                }
                else if (comboBoxShow.Text == "Giáo Viên")
                {
                    string sql = "SELECT * FROM Search_Teacher  ('" + loaisach + "')";
                    dataGridView2.DataSource = book.getBook(sql);

                }
            }
            catch
            {

            }
        }

       
    }
}
