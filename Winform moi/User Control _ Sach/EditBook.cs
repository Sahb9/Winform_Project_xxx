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
    public partial class EditBook : UserControl
    {
        public EditBook()
        {
            InitializeComponent();
        }
        Book book = new Book();


        private void EditBook_Load(object sender, EventArgs e)
        {
            //
            LoadForm();
            // show combo
            string sql = "select *from ShowcomboGenre";
            comboBoxGenre.DataSource = book.getBook(sql);
            comboBoxGenre.DisplayMember = "Genre";
            comboBoxGenre.ValueMember = "Genre";
        }
        public void LoadForm()
        {
            string sql = "select *from ShowBook";
            guna2DataGridView1.DataSource = book.getBook(sql);
        }
        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            
            textBoxID.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxGenre.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxQuantity.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPrice.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            int idcu =Convert.ToInt32( guna2DataGridView1.CurrentRow.Cells[0].Value);
            int id = Convert.ToInt32(textBoxID.Text);
            string tenbook = textBoxName.Text;
            string loai = comboBoxGenre.Text;
            int soluong = Convert.ToInt32(textBoxQuantity.Text);
            int gia = Convert.ToInt32(textBoxPrice.Text);
            if (!verify())
            {
                    if (book.updateBook(idcu,id, tenbook, loai, soluong, gia))
                    {
                        MessageBox.Show("Book has been edited", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please Fill out completely", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        bool verify()
        {
            if (textBoxID.Text.Trim() == "" || textBoxName.Text.Trim() == "" || textBoxPrice.Text.Trim() == "" || textBoxQuantity.Text.Trim() == "")
            {
                return true;
            }
            else
                return false;
        }


    }
}
