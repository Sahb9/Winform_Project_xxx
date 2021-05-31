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
    public partial class ShowCheckIn : Form
    {
        public ShowCheckIn()
        {
            InitializeComponent();
        }

        ChiaCa chiaca = new ChiaCa();
        private void ShowCheckIn_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = chiaca.getTable("SELECT * FROM CheckIn");
        }
    }
}
