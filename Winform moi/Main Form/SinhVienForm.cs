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
    public partial class SinhVienForm : Form
    {
        public SinhVienForm()
        {
            InitializeComponent();
        }

        private void buttonMuon_Click(object sender, EventArgs e)
        {

            muonSach_SinhVien1.MuonSach_SinhVien_Load(sender, e);
            muonSach_SinhVien1.BringToFront();
          
         
        }

        private void buttonTra_Click(object sender, EventArgs e)
        {
            traSach_SinhVien1.TraSach_SinhVien_Load(sender, e);
            traSach_SinhVien1.BringToFront();
           

        }

        private void buttonTinhTrang_Click(object sender, EventArgs e)
        {
            tinhTrang_SinhVien1.TinhTrang_SinhVien_Load(sender, e);
            tinhTrang_SinhVien1.BringToFront();
         
        }

        private void traSach_SinhVien1_Load(object sender, EventArgs e)
        {
            
        }

        private void tinhTrang_SinhVien1_Load(object sender, EventArgs e)
        {

                    }

        private void SinhVienForm_Load(object sender, EventArgs e)
        {

        }
    }
}
