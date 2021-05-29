using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Winform_moi
{
    public partial class QLy_SinhVien : UserControl
    {
        public QLy_SinhVien()
        {
            InitializeComponent();
        }
        SinhVien std = new SinhVien();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string name = textBoxName.Text;
            string gender = "Male";
            if (femaleradioButton.Checked)
                gender = "Female";
            MemoryStream pic = new MemoryStream();
            int phone = Convert.ToInt32(textBoxPhone.Text);
            string adrs = textBoxAddress.Text;
            string user = textBoxUserName.Text;
            string pass = textBoxPassWord.Text;
            if (verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (std.insertUserSTD(id, name, gender, phone, adrs, pic, user, pass))
                {
                    MessageBox.Show("Add Student has been completed", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QLy_SinhVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string name = textBoxName.Text;
            string gender = "Male";
            if (femaleradioButton.Checked)
                gender = "Female";
            MemoryStream pic = new MemoryStream();
            int phone = Convert.ToInt32(textBoxPhone.Text);
            string adrs = textBoxAddress.Text;
            string user = textBoxUserName.Text;
            string pass = textBoxPassWord.Text;
            if (verif())
            {
                try
                {


                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (std.updateUserSTD(id, name, gender, phone, adrs, pic, user, pass))
                    {
                        MessageBox.Show("Edit has been completed", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        QLy_SinhVien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textBoxID.Text);

                if ((MessageBox.Show("Do you want to delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (std.DeleteUserSTD(Id))
                    {
                        MessageBox.Show("Delete Student has been completed", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxID.Text = "";
                        textBoxName.Text = "";
                        textBoxUserName.Text = "";
                        textBoxPassWord.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";

                        pictureBox1.Image = null;
                        QLy_SinhVien_Load(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Delete Student has not been completed", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        QLy_SinhVien_Load(sender, e);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM users_std");
            dataGridView1.ReadOnly = true;// nap lai du lieu len datagrid view
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = std.getStudents(command);
            piccol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        public void QLy_SinhVien_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT* FROM users_std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = std.getStudents(command);
            
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.AllowUserToAddRows = false;
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxName.Text.Trim() == "") || (textBoxAddress.Text.Trim() == "") || (textBoxPhone.Text.Trim() == "") || (pictureBox1.Image == null) || (textBoxUserName.Text.Trim() == "") || (textBoxPassWord.Text.Trim() == ""))
                return false;
            else
                return true;
        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                femaleradioButton.Checked = true;
            }
            else
            {
                maleradioButton.Checked = true;
            }
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
            textBoxUserName.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxPassWord.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
