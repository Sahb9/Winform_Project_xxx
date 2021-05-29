namespace Winform_moi
{
    partial class QuanLyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.buttonQLSinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonQLNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.buttonQLSach = new Guna.UI2.WinForms.Guna2Button();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.qLy_SinhVien1 = new Winform_moi.QLy_SinhVien();
            this.quanLySach1 = new Winform_moi.QuanLySach();
            this.qLy_GiaoVien1 = new Winform_moi.QLy_GiaoVien();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.Panel1.Controls.Add(this.buttonTeacher);
            this.Panel1.Controls.Add(this.buttonQLSinhVien);
            this.Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.Panel1.Controls.Add(this.buttonQLNhanVien);
            this.Panel1.Controls.Add(this.buttonQLSach);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(167, 540);
            this.Panel1.TabIndex = 1;
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.CheckedState.Parent = this.buttonTeacher;
            this.buttonTeacher.CustomImages.Parent = this.buttonTeacher;
            this.buttonTeacher.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeacher.ForeColor = System.Drawing.Color.White;
            this.buttonTeacher.HoverState.Parent = this.buttonTeacher;
            this.buttonTeacher.Location = new System.Drawing.Point(-23, 307);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.ShadowDecoration.Parent = this.buttonTeacher;
            this.buttonTeacher.Size = new System.Drawing.Size(193, 42);
            this.buttonTeacher.TabIndex = 9;
            this.buttonTeacher.Text = "Quản Lý Giáo Viên";
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
            // 
            // buttonQLSinhVien
            // 
            this.buttonQLSinhVien.CheckedState.Parent = this.buttonQLSinhVien;
            this.buttonQLSinhVien.CustomImages.Parent = this.buttonQLSinhVien;
            this.buttonQLSinhVien.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLSinhVien.ForeColor = System.Drawing.Color.White;
            this.buttonQLSinhVien.HoverState.Parent = this.buttonQLSinhVien;
            this.buttonQLSinhVien.Location = new System.Drawing.Point(-11, 262);
            this.buttonQLSinhVien.Name = "buttonQLSinhVien";
            this.buttonQLSinhVien.ShadowDecoration.Parent = this.buttonQLSinhVien;
            this.buttonQLSinhVien.Size = new System.Drawing.Size(193, 42);
            this.buttonQLSinhVien.TabIndex = 8;
            this.buttonQLSinhVien.Text = "Quản Lý Sinh Viên";
            this.buttonQLSinhVien.Click += new System.EventHandler(this.buttonQLSinhVien_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(143, 96);
            this.guna2CirclePictureBox1.TabIndex = 7;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // buttonQLNhanVien
            // 
            this.buttonQLNhanVien.CheckedState.Parent = this.buttonQLNhanVien;
            this.buttonQLNhanVien.CustomImages.Parent = this.buttonQLNhanVien;
            this.buttonQLNhanVien.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.buttonQLNhanVien.HoverState.Parent = this.buttonQLNhanVien;
            this.buttonQLNhanVien.Location = new System.Drawing.Point(-23, 217);
            this.buttonQLNhanVien.Name = "buttonQLNhanVien";
            this.buttonQLNhanVien.ShadowDecoration.Parent = this.buttonQLNhanVien;
            this.buttonQLNhanVien.Size = new System.Drawing.Size(193, 42);
            this.buttonQLNhanVien.TabIndex = 4;
            this.buttonQLNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // buttonQLSach
            // 
            this.buttonQLSach.CheckedState.Parent = this.buttonQLSach;
            this.buttonQLSach.CustomImages.Parent = this.buttonQLSach;
            this.buttonQLSach.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLSach.ForeColor = System.Drawing.Color.White;
            this.buttonQLSach.HoverState.Parent = this.buttonQLSach;
            this.buttonQLSach.Location = new System.Drawing.Point(-29, 169);
            this.buttonQLSach.Name = "buttonQLSach";
            this.buttonQLSach.ShadowDecoration.Parent = this.buttonQLSach;
            this.buttonQLSach.Size = new System.Drawing.Size(196, 42);
            this.buttonQLSach.TabIndex = 3;
            this.buttonQLSach.Text = "Quản Lý Sách";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.qLy_GiaoVien1);
            this.Panel2.Controls.Add(this.qLy_SinhVien1);
            this.Panel2.Controls.Add(this.quanLySach1);
            this.Panel2.Location = new System.Drawing.Point(167, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(833, 540);
            this.Panel2.TabIndex = 2;
            // 
            // qLy_SinhVien1
            // 
            this.qLy_SinhVien1.Location = new System.Drawing.Point(0, 0);
            this.qLy_SinhVien1.Name = "qLy_SinhVien1";
            this.qLy_SinhVien1.Size = new System.Drawing.Size(833, 540);
            this.qLy_SinhVien1.TabIndex = 1;
            // 
            // quanLySach1
            // 
            this.quanLySach1.Location = new System.Drawing.Point(0, 0);
            this.quanLySach1.Name = "quanLySach1";
            this.quanLySach1.Size = new System.Drawing.Size(833, 540);
            this.quanLySach1.TabIndex = 0;
            this.quanLySach1.Load += new System.EventHandler(this.quanLySach1_Load);
            // 
            // qLy_GiaoVien1
            // 
            this.qLy_GiaoVien1.Location = new System.Drawing.Point(3, 0);
            this.qLy_GiaoVien1.Name = "qLy_GiaoVien1";
            this.qLy_GiaoVien1.Size = new System.Drawing.Size(833, 540);
            this.qLy_GiaoVien1.TabIndex = 2;
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "QuanLyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuanLyForm_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Button buttonQLNhanVien;
        private Guna.UI2.WinForms.Guna2Button buttonQLSach;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private QuanLySach quanLySach1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button buttonTeacher;
        private Guna.UI2.WinForms.Guna2Button buttonQLSinhVien;
        private QLy_SinhVien qLy_SinhVien1;
        private QLy_GiaoVien qLy_GiaoVien1;
    }
}

