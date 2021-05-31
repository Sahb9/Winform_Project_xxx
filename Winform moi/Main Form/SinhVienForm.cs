using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        SinhVien sv = new SinhVien();
        Database db = new Database();
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
            LoadAnh();
        }
        public void LoadAnh()
        {
            string sql = "SELECT *FROM users_std WHERE ID =" + StatisID.GlobalUserId;
            DataTable table = sv.getTable(sql);
            byte[] pic = (byte[])table.Rows[0]["Picture"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
            //Tùy chỉnh Zoom
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void buttonImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(opf.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                //
                SqlCommand command = new SqlCommand("UPDATE users_std set Picture = @pic WHERE ID =" + StatisID.GlobalUserId, db.getConnection);
                command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
                db.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    db.closeConnection();
                    // return true;
                }
                else
                {
                    db.closeConnection();
                    //return false;
                }
            }
            catch
            { }
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tinhTrang_SinhVien1_Load_1(object sender, EventArgs e)
        {

        }

        private void muonSach_SinhVien1_Load(object sender, EventArgs e)
        {

        }

        private void traSach_SinhVien1_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
