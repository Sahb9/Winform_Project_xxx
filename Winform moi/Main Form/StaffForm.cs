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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }
        Database db = new Database();
        Staff staff = new Staff();
        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            checkIn_Staff1.CheckIn_Staff_Load(sender, e);
            checkIn_Staff1.BringToFront();
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            checkOut_Staff1.CheckOut_Staff_Load(sender, e);
            checkOut_Staff1.BringToFront();
        }
        public void LoadAnh()
        {
            string sql = "SELECT *FROM Staff WHERE ID =" + StatisID.GlobalUserId;
            DataTable table = staff.getTable(sql);
            //

            byte[] pic = (byte[])table.Rows[0][7];
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
                SqlCommand command = new SqlCommand("UPDATE Staff set Picture = @pic WHERE ID =" + StatisID.GlobalUserId, db.getConnection);
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

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadAnh();
        }
    }
}
