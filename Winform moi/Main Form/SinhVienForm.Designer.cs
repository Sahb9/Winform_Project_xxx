namespace Winform_moi
{
    partial class SinhVienForm
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
            this.buttonTinhTrang = new Guna.UI2.WinForms.Guna2Button();
            this.buttonTra = new Guna.UI2.WinForms.Guna2Button();
            this.buttonMuon = new Guna.UI2.WinForms.Guna2Button();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.traSach_SinhVien1 = new Winform_moi.TraSach_SinhVien();
            this.muonSach_SinhVien1 = new Winform_moi.MuonSach_SinhVien();
            this.tinhTrang_SinhVien1 = new Winform_moi.TinhTrang_SinhVien();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.Panel1.Controls.Add(this.buttonTinhTrang);
            this.Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.Panel1.Controls.Add(this.buttonTra);
            this.Panel1.Controls.Add(this.buttonMuon);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(167, 540);
            this.Panel1.TabIndex = 3;
            // 
            // buttonTinhTrang
            // 
            this.buttonTinhTrang.CheckedState.Parent = this.buttonTinhTrang;
            this.buttonTinhTrang.CustomImages.Parent = this.buttonTinhTrang;
            this.buttonTinhTrang.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTinhTrang.ForeColor = System.Drawing.Color.White;
            this.buttonTinhTrang.HoverState.Parent = this.buttonTinhTrang;
            this.buttonTinhTrang.Location = new System.Drawing.Point(-23, 258);
            this.buttonTinhTrang.Name = "buttonTinhTrang";
            this.buttonTinhTrang.ShadowDecoration.Parent = this.buttonTinhTrang;
            this.buttonTinhTrang.Size = new System.Drawing.Size(193, 42);
            this.buttonTinhTrang.TabIndex = 8;
            this.buttonTinhTrang.Text = "Tình trạng Sinh Viên";
            this.buttonTinhTrang.Click += new System.EventHandler(this.buttonTinhTrang_Click);
            // 
            // buttonTra
            // 
            this.buttonTra.CheckedState.Parent = this.buttonTra;
            this.buttonTra.CustomImages.Parent = this.buttonTra;
            this.buttonTra.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTra.ForeColor = System.Drawing.Color.White;
            this.buttonTra.HoverState.Parent = this.buttonTra;
            this.buttonTra.Location = new System.Drawing.Point(-23, 217);
            this.buttonTra.Name = "buttonTra";
            this.buttonTra.ShadowDecoration.Parent = this.buttonTra;
            this.buttonTra.Size = new System.Drawing.Size(193, 42);
            this.buttonTra.TabIndex = 4;
            this.buttonTra.Text = "Trả Sách";
            this.buttonTra.Click += new System.EventHandler(this.buttonTra_Click);
            // 
            // buttonMuon
            // 
            this.buttonMuon.CheckedState.Parent = this.buttonMuon;
            this.buttonMuon.CustomImages.Parent = this.buttonMuon;
            this.buttonMuon.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMuon.ForeColor = System.Drawing.Color.White;
            this.buttonMuon.HoverState.Parent = this.buttonMuon;
            this.buttonMuon.Location = new System.Drawing.Point(-29, 175);
            this.buttonMuon.Name = "buttonMuon";
            this.buttonMuon.ShadowDecoration.Parent = this.buttonMuon;
            this.buttonMuon.Size = new System.Drawing.Size(196, 42);
            this.buttonMuon.TabIndex = 3;
            this.buttonMuon.Text = "Mượn Sách";
            this.buttonMuon.Click += new System.EventHandler(this.buttonMuon_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.tinhTrang_SinhVien1);
            this.Panel2.Controls.Add(this.muonSach_SinhVien1);
            this.Panel2.Controls.Add(this.traSach_SinhVien1);
            this.Panel2.Location = new System.Drawing.Point(167, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(833, 540);
            this.Panel2.TabIndex = 4;
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
            // traSach_SinhVien1
            // 
            this.traSach_SinhVien1.Location = new System.Drawing.Point(0, 0);
            this.traSach_SinhVien1.Name = "traSach_SinhVien1";
            this.traSach_SinhVien1.Size = new System.Drawing.Size(833, 540);
            this.traSach_SinhVien1.TabIndex = 0;
            // 
            // muonSach_SinhVien1
            // 
            this.muonSach_SinhVien1.Location = new System.Drawing.Point(0, 0);
            this.muonSach_SinhVien1.Name = "muonSach_SinhVien1";
            this.muonSach_SinhVien1.Size = new System.Drawing.Size(833, 540);
            this.muonSach_SinhVien1.TabIndex = 1;
            // 
            // tinhTrang_SinhVien1
            // 
            this.tinhTrang_SinhVien1.Location = new System.Drawing.Point(0, 0);
            this.tinhTrang_SinhVien1.Name = "tinhTrang_SinhVien1";
            this.tinhTrang_SinhVien1.Size = new System.Drawing.Size(833, 540);
            this.tinhTrang_SinhVien1.TabIndex = 2;
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Name = "SinhVienForm";
            this.Text = "SinhVienForm";
            this.Load += new System.EventHandler(this.SinhVienForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button buttonTra;
        private Guna.UI2.WinForms.Guna2Button buttonMuon;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2Button buttonTinhTrang;
        private TraSach_SinhVien traSach_SinhVien1;
        private TinhTrang_SinhVien tinhTrang_SinhVien1;
        private MuonSach_SinhVien muonSach_SinhVien1;
    }
}