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
    public partial class CheckIn_Staff : UserControl
    {
        public CheckIn_Staff()
        {
            InitializeComponent();
        }
        CheckIn check = new CheckIn();
        ChiaCa chiaca = new ChiaCa();
        public void CheckIn_Staff_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CheckIn WHERE id =" + StatisID.GlobalUserId;
            dataGridView1.DataSource = check.getTable(sql);
            textBoxID1.Text = StatisID.GlobalUserId.ToString();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            string sql = "update CheckIn ";
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

            string result = sql + query + " where id = " + Convert.ToInt32(textBoxID1.Text);
            chiaca.getData(result);
            MessageBox.Show("Check-in Success", "Check - in Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
