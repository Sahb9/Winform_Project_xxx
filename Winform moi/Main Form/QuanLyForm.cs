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
    public partial class QuanLyForm : Form
    {
        public QuanLyForm()
        {
            InitializeComponent();
        }

        private void quanLySach1_Load(object sender, EventArgs e)
        {

        }

        private void QuanLyForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonQLSinhVien_Click(object sender, EventArgs e)
        {
            qLy_SinhVien1.QLy_SinhVien_Load(sender, e);
            qLy_SinhVien1.BringToFront();
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            qLy_GiaoVien1.QLy_GiaoVien_Load(sender, e);
            qLy_GiaoVien1.BringToFront();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            dashBoard1.DashBoard_Load(sender, e);
            dashBoard1.BringToFront();
        }

        private void buttonQLSach_Click(object sender, EventArgs e)
        {
            
            quanLySach1.BringToFront();
        }

        private void buttonStatics_Click(object sender, EventArgs e)
        {
            statics1.Statics_Load(sender, e);
            statics1.BringToFront();
        }
    }
}
