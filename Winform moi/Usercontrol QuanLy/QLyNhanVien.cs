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

     

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
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
            SqlCommand commandCa = new SqlCommand(" SELECT * FROM ChiaCa ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandCa);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //DataTable table = new DataTable();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count - 1; j++)
                {
                    n = rd.Next(1, 3).ToString();
                  
                    dataGridView1.Rows[i].Cells[j].Value = n;
                }
                chiaca.capNhat(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                    dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    dataGridView1.Rows[i].Cells[5].Value.ToString(),
                    dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
           

            table = (DataTable)dataGridView1.DataSource;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 1; j < table.Columns.Count - 1; j++)
                {


                    if (table.Rows[i][j].ToString() == "1")
                    {
                        dataGridView1.Rows[i].Cells[j].Value = "Ca 1";


                    }
                    else if (table.Rows[i][j].ToString() == "2")
                    {
                        dataGridView1.Rows[i].Cells[j].Value = "Ca 2";

                    }
                }
            }
            dataGridView1.DataSource = table;
            string sql = "update CheckIn set Monday = null, Tuesday = null, Wednesday = null, Thursday = null, Friday = null, Saturday = null " 
                        +"update CheckOut set Monday = null, Tuesday = null, Wednesday = null, Thursday = null, Friday = null, Saturday = null ";
            chiaca.getData(sql);

        }
    }
}
