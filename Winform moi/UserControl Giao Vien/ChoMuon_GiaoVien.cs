﻿using System;
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
    public partial class ChoMuon_GiaoVien : UserControl
    {
        public ChoMuon_GiaoVien()
        {
            InitializeComponent();
        }
        Book book = new Book();
        private void buttonLend_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string tenbook = textBoxName.Text;
            string loai = comboBoxGenre.Text;
            int soluong = Convert.ToInt32(textBoxQuantity.Text);
            int gia = Convert.ToInt32(textBoxPrice.Text);
            if (!verify())
            {
                if (!book.checkIDBook(id))
                {
                    if (book.insertBook(id, tenbook, loai, soluong, gia, 990))
                    {
                        MessageBox.Show("New Book has been added", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadBook();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadBook();
                    }
                }
                else
                    MessageBox.Show("ID Book is already exist", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please Fill out completely", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void loadBook()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";

        }
        bool verify()
        {
            if (textBoxID.Text.Trim() == "" || textBoxName.Text.Trim() == "" || textBoxPrice.Text.Trim() == "" || textBoxQuantity.Text.Trim() == "")
            {
                return true;
            }
            else
                return false;
        }

        private void ChoMuon_GiaoVien_Load(object sender, EventArgs e)
        {
            string sql = "select *from ShowcomboGenre";
            comboBoxGenre.DataSource = book.getBook(sql);
            comboBoxGenre.DisplayMember = "Genre";
            comboBoxGenre.ValueMember = "Genre";
        }
    }
}
