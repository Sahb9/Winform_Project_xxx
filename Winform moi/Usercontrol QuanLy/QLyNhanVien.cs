using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Winform_moi
{
    public partial class QLyNhanVien : UserControl
    {
        public QLyNhanVien()
        {
            InitializeComponent();
        }
        Database mydb = new Database();
        ChiaCa chiaca = new ChiaCa(); 
        public void QLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand commandCa = new SqlCommand(" SELECT * FROM ChiaCa ", mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(commandCa);
                DataTable tableCa = new DataTable();
                adapter.Fill(tableCa);
                //
                dataGridView1.DataSource = tableCa;
                for (int i = 0; i < tableCa.Rows.Count; i++)
                {
                    for (int j = 1; j < tableCa.Columns.Count - 1; j++)
                    {
                     

                        if (tableCa.Rows[i][j].ToString() == "1")
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "Ca 1";
                         

                        }
                        else if (tableCa.Rows[i][j].ToString() == "2")
                        {
                             dataGridView1.Rows[i].Cells[j].Value = "Ca 2";
                         
                        }
                    }
                }
                
            }
            catch
            { }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxID1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxID2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            string sql = "update CheckIn ";
            string query="";
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
           
            string result = sql + query + " where id = "+ Convert.ToInt32( textBoxID1.Text);
            chiaca.getData(result);
            MessageBox.Show("Check-in Success","Check - in Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
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

        private void buttonShowCheckIn_Click(object sender, EventArgs e)
        {
            ShowCheckIn frm = new ShowCheckIn();
            frm.Show();
        }

        private void buttonShowChecOut_Click(object sender, EventArgs e)
        {
            ShowCheckOut frm = new ShowCheckOut();
            frm.Show();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            ShowStaff frm = new ShowStaff();
            frm.Show();
        }

        private void buttonRenew_Click(object sender, EventArgs e)
        {
            string n;
            Random rd = new Random();
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count - 1; j++)
                {
                    n = rd.Next(2, 3).ToString();
                    dataGridView1.Rows[i].Cells[j].Value = n;
                    
                }
            }
            //DataTable tableCa = new DataTable();
            //for (int i = 0; i < tableCa.Rows.Count; i++)
            //{
            //    for (int j = 1; j < tableCa.Columns.Count - 1; j++)
            //    {

            //        //tableCa.Rows[i][j].ToString() = "1";
            //        if (tableCa.Rows[i][j].ToString() == "1")
            //        {
            //            dataGridView1.Rows[i].Cells[j].Value = "Ca 1";


            //        }
            //        else if (tableCa.Rows[i][j].ToString() == "2")
            //        {
            //            dataGridView1.Rows[i].Cells[j].Value = "Ca 2";

            //        }
            //    }
            //}
        }
    }
}
