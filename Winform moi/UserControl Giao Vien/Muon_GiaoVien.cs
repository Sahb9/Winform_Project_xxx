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
    public partial class Muon_GiaoVien : UserControl
    {
        public Muon_GiaoVien()
        {
            InitializeComponent();
        }
        Book book = new Book();
        GiaoVien teacher = new GiaoVien();
        
        public void Muon_GiaoVien_Load(object sender, EventArgs e)
        {
            string sql = "select *from ShowcomboGenre";
            comboBoxGenre.DataSource = book.getBook(sql);
            comboBoxGenre.DisplayMember = "Genre";
            comboBoxGenre.ValueMember = "Genre";
            setUpdata();
          
        }
        public void setUpdata()
        {
            dataGridView1.ColumnCount = 5;
           
            dataGridView1.Columns[0].Name = "Book Name";
            dataGridView1.Columns[1].Name = "Genre ";
            dataGridView1.Columns[2].Name = "Quantity";
            dataGridView1.Columns[3].Name = "Borrow Day";
            dataGridView1.Columns[4].Name = "Return Day";
        }
       

        private void buttonMuon_Click(object sender, EventArgs e)
        {
            int kt = 1;
            //MessageBox.Show(dataGridView1.Rows.Count.ToString());
            for (int i = 0; i < dataGridView1.Rows.Count -1; i++)
            {
 
                string bookname = dataGridView1.Rows[i].Cells[1].Value.ToString();
                
                int slg = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                DateTime dateMuon = DateTime.ParseExact(dataGridView1.Rows[i].Cells[3].Value.ToString(), "dd/MM/yyyy", null);
                DateTime dateTra = DateTime.ParseExact(dataGridView1.Rows[i].Cells[4].Value.ToString(), "dd/MM/yyyy", null);  
                if (book.muonsach(bookname,990, dateMuon, dateTra, slg, "dangmuon"))
                {
                    kt = 1;
           
                }
              
            }
            if (kt == 1)
            {
                MessageBox.Show("Borrow Book has been succedded", "Borrow Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Rows.Clear();
            }
            else
                MessageBox.Show("Borrow Book Fail", "Borrow Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
        public bool verify()
        {
            if (textBoxQuantity.Text.Trim() == "")
                return true;
            else
                return false;
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select *from ShowTen ('" +comboBoxGenre.SelectedValue+ "')";
                comboBoxName.DataSource = book.getBook(sql);
                comboBoxName.DisplayMember = "BookName";
                comboBoxName.ValueMember = "BookID";
            }
            catch
            {

            }
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                string genre = comboBoxGenre.Text;
                string bookname = comboBoxName.Text;
                int slg = Convert.ToInt32(textBoxQuantity.Text);
                string dateMuon = ((DateTime)dateTimePicker1.Value).ToString("dd/MM/yyyy");
                string dateTra = ((DateTime)dateTimePicker2.Value).ToString("dd/MM/yyyy");
                // tạo dòng datagridView
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                //((DateTime)dataGridView1.Rows[r].Cells[3].Value).ToString("dd/MM/yyyy")
                row.Cells[0].Value = genre;
                row.Cells[1].Value = bookname;
                //MessageBox.Show(bookname);
                row.Cells[2].Value = slg;
                row.Cells[3].Value = dateMuon;
                row.Cells[4].Value = dateTra;
                dataGridView1.Rows.Add(row);
            }
            else
                MessageBox.Show("Please fill out Quantity");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            dataGridView1.BringToFront();
        }

       

        private void labelexist_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Conlai = book.soSachTheoTen(comboBoxName.Text);
                int trongkho = (int)Conlai.Rows[0]["Quantity"];
                int SL = Convert.ToInt32(textBoxQuantity.Text);
                if (SL > trongkho)
                    textBoxQuantity.Text = "";
            }

            catch
            {
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Conlai = book.soSachTheoTen(comboBoxName.Text);
                labelexist.Text = "Existing: " + (int)Conlai.Rows[0]["Quantity"];
            }
            catch
            { }
        }

        private void linkLabelFresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
