using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_moi
{
    public partial class RankForm : Form
    {
        public RankForm()
        {
            InitializeComponent();
        }
        Book book = new Book();
        private void RankForm_Load(object sender, EventArgs e)
        {
            string sql = "exec XepHang ";
            dataGridView1.DataSource = book.getBook(sql);
        }
    }
}
