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
    public partial class RemoveBook : UserControl
    {
        public RemoveBook()
        {
            InitializeComponent();
        }
        Book book = new Book();
        private void RemoveBook_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        public void LoadForm()
        {
             string sql = "select *from ShowBook";
            dataGridView1.DataSource = book.getBook(sql);

        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string tenbook = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if ((MessageBox.Show("Do you want to delete  Book: "+ tenbook, "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (book.deleteBook(id))
                    {

                        MessageBox.Show("Book has been deleted", "Delete Book ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadForm();
                    }
                    else
                    {
                        MessageBox.Show("Book has not Deleted", "Delete Book ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
        }
    }
}
