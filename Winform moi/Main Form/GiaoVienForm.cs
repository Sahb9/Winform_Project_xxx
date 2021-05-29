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
    public partial class GiaoVienForm : Form
    {
        public GiaoVienForm()
        {
            InitializeComponent();
        }

        private void buttonTra_Click(object sender, EventArgs e)
        {
            traSach_GiaoVien1.TraSach_GiaoVien_Load(sender, e);
            traSach_GiaoVien1.BringToFront();
            
        }

        private void buttonMuon_Click(object sender, EventArgs e)
        {
            muon_GiaoVien1.Muon_GiaoVien_Load(sender, e);
            muon_GiaoVien1.BringToFront();
        }

        private void buttonChoMuon_Click(object sender, EventArgs e)
        {
            choMuon_GiaoVien1.ChoMuon_GiaoVien_Load(sender, e);
            choMuon_GiaoVien1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void GiaoVienForm_Load(object sender, EventArgs e)
        {
            Panel2.BringToFront();
        }

        private void buttonDanhSach_Click(object sender, EventArgs e)
        {
            sach_GiaoVien1.Sach_GiaoVien_Load(sender, e);
            sach_GiaoVien1.BringToFront();
        }
    }
}
