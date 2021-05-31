using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_moi
{
    public partial class CheckOut_Staff : UserControl
    {
        public CheckOut_Staff()
        {
            InitializeComponent();
        }
        CheckOut check = new CheckOut();
        ChiaCa chiaca = new ChiaCa();
        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update CheckOut ";
                string query = "";
                if (comboBox1.Text == "Monday")
                {
                    query = " set Monday ='x'";
                }
                else if (comboBox1.Text == "Tuesday")
                {
                    query = " set Tuesday ='x'";
                }
                else if (comboBox1.Text == "Wednesday")
                {
                    query = " set Wednesday ='x'";
                }
                else if (comboBox1.Text == "Thursday")
                {
                    query = " set Thursday ='x'";
                }
                else if (comboBox1.Text == "Friday")
                {
                    query = " set Friday ='x'";
                }
                else if (comboBox1.Text == "Saturday")
                {
                    query = " set Saturday ='x'";
                }

                string result = sql + query + " where id = " + Convert.ToInt32(textBoxID2.Text);
                chiaca.getData(result);
                MessageBox.Show("Check-out Success", "Check - out Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            { }
        }

        public void CheckOut_Staff_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CheckOut WHERE id =" + StatisID.GlobalUserId;
            dataGridView1.DataSource = check.getTable(sql);
            textBoxID2.Text = StatisID.GlobalUserId.ToString();
        }
    }
}
