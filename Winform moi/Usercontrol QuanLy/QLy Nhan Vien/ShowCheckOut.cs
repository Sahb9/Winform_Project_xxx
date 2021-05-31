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
    public partial class ShowCheckOut : Form
    {
        public ShowCheckOut()
        {
            InitializeComponent();
        }
        ChiaCa chiaca = new ChiaCa();
        private void ShowCheckOut_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = chiaca.getTable("SELECT * FROM CheckOut");
        }
    }
}
