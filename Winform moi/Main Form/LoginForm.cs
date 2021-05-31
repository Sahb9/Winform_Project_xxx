using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_moi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (verif())
            {
                if (radioButtonStudent.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM users_std WHERE Username = @un AND Password = @pass", db.getConnection);
                    command.Parameters.Add("@un", SqlDbType.VarChar).Value = textBoxUser.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    //set id
                    int userId = Convert.ToInt32(table.Rows[0][0]);
                    StatisID.SetGlobalUserId(userId);
                    if ((table.Rows.Count > 0))
                    {

                        SinhVienForm frm = new SinhVienForm();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai Username hoặc Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButtonTeacher.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM users_teacher WHERE Username = @un AND Password = @pass", db.getConnection);
                    command.Parameters.Add("@un", SqlDbType.VarChar).Value = textBoxUser.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    //set id
                    int userId = Convert.ToInt32(table.Rows[0][0]);
                    StatisID.SetGlobalUserId(userId);
                    if ((table.Rows.Count > 0))
                    {
                        GiaoVienForm frm = new GiaoVienForm();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai Username hoặc Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (radioButtonAdmin.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Manager WHERE Username = @un AND Password = @pass", db.getConnection);
                    command.Parameters.Add("@un", SqlDbType.VarChar).Value = textBoxUser.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    //set id
                    int userId = Convert.ToInt32(table.Rows[0][0]);
                    StatisID.SetGlobalUserId(userId);
                    if ((table.Rows.Count > 0))
                    {
                        QuanLyForm frm = new QuanLyForm();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai Username hoặc Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if(radioButtonStaff.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Staff WHERE Username = @un AND Password = @pass", db.getConnection);
                    command.Parameters.Add("@un", SqlDbType.VarChar).Value = textBoxUser.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    //set id
                    int userId = Convert.ToInt32(table.Rows[0][0]);
                    StatisID.SetGlobalUserId(userId);
                    if ((table.Rows.Count > 0))
                    {

                        StaffForm frm = new StaffForm();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai Username hoặc Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                    
                else { MessageBox.Show("Chưa chọn ", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Chưa nhập Username hoặc Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
     
    
    bool verif()
    {
        if ((textBoxUser.Text.Trim() == "")
            || (textBoxPassWord.Text.Trim() == ""))
        {
            return false;
        }
        else
        { return true; }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void LoginForm_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "User Name")
                textBoxUser.Text = "";
        }
        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
                textBoxUser.Text = "User Name";
        }

        private void textBoxPassWord_Leave(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text == "")
            {

                textBoxPassWord.Text = "PassWord";
            }
        }

        private void textBoxPassWord_Enter(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text == "PassWord")
                textBoxPassWord.Text = "";
        }
    }
}
