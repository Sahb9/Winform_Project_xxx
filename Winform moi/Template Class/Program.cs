using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_moi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new QuanLyForm());
            //Application.Run(new GiaoVienForm());
            //Application.Run(new SinhVienForm());
            string n;
            string sql="";
            
            for (int i=0;i<5;i++)
            {
                Random rd = new Random();
               sql= rd.Next(1,3).ToString();
                //sql += n;
                MessageBox.Show(sql);
            }
            
        }
    }
}
