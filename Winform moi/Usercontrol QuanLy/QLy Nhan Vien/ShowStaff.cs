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
    public partial class ShowStaff : Form
    {
        public ShowStaff()
        {
            InitializeComponent();
        }

        ChiaCa chiaca = new ChiaCa();
        private void ShowStaff_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Staff";
            dataGridView1.DataSource = chiaca.getTable(sql);
        }
    }
}
