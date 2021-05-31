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
    public partial class GiaoVienForm : Form
    {
        public GiaoVienForm()
        {
            InitializeComponent();
        }
        Database db = new Database();
        GiaoVien giaovien = new GiaoVien();
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
            LoadAnh();
            Panel2.BringToFront();
        }

        private void buttonDanhSach_Click(object sender, EventArgs e)
        {
            sach_GiaoVien1.Sach_GiaoVien_Load(sender, e);
            sach_GiaoVien1.BringToFront();
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
                SqlCommand command = new SqlCommand("UPDATE users_teacher set Picture = @pic WHERE ID =" + StatisID.GlobalUserId, db.getConnection);
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
        public void LoadAnh()
        {
            string sql = "SELECT *FROM users_teacher WHERE ID =" + StatisID.GlobalUserId;
            DataTable table = giaovien.getTable(sql);
            //

            byte[] pic = (byte[])table.Rows[0]["Picture"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
            //Tùy chỉnh Zoom
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
