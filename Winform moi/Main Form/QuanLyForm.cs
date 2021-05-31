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
    public partial class QuanLyForm : Form
    {
        public QuanLyForm()
        {
            InitializeComponent();
        }
        Database db = new Database();
        Manager ma = new Manager();
        private void quanLySach1_Load(object sender, EventArgs e)
        {
           
        }
        void LoadAnh()
        {
            string sql = "SELECT *FROM Manager WHERE ID =" + StatisID.GlobalUserId;
            DataTable table= ma.getTable(sql);
            //
           
            byte[] pic = (byte[])table.Rows[0][6];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
            //tùy chỉnh zoom
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void QuanLyForm_Load(object sender, EventArgs e)
        {
            LoadAnh();
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

        private void buttonQLNhanVien_Click(object sender, EventArgs e)
        {
            qLyNhanVien1.QLyNhanVien_Load(sender, e);
            qLyNhanVien1.BringToFront();
        }

        private void qLyNhanVien1_Load(object sender, EventArgs e)
        {

        }
        ChiaCa chia = new ChiaCa();
  

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
                SqlCommand command = new SqlCommand("UPDATE Manager set ManagerPicture = @pic WHERE ID =" + StatisID.GlobalUserId, db.getConnection);
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
    }
}
