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
                    SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE Name = @un AND Password = @pass", db.getConnection);
                    command.Parameters.Add("@un", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if ((table.Rows.Count > 0))
                    {


                        //MainFormStudent mfs = new MainFormStudent();
                        //mfs.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("Sai Username hoặc Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (radioButtonTeacher.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Teacher WHERE Name = @un AND Password = @pass", db.getConnection);
                    command.Parameters.Add("@un", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if ((table.Rows.Count > 0))
                    {

                        //this.Hide();
                        //MainFormTeacher mft = new MainFormTeacher();
                        //mft.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("Sai Username hoặc Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (radioButtonAdmin.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Manager WHERE Name = @un AND Password = @pass", db.getConnection);
                    command.Parameters.Add("@un", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    /*  int userId = Convert.ToInt16(table.Rows[0][0].ToString());
                      Globals.SetGlobalUserId(userId);*/
                    if ((table.Rows.Count > 0))
                    {

                        //this.Hide();
                        //MainFormAdmin mfa = new MainFormAdmin();
                        //mfa.ShowDialog();


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
        if ((TextBoxUsername.Text.Trim() == "")
            || (TextBoxPassword.Text.Trim() == ""))
        {
            return false;
        }
        else
        { return true; }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
