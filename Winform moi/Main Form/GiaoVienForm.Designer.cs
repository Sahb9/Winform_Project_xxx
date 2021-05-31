namespace Winform_moi
{
    partial class GiaoVienForm
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
            this.buttonDanhSach = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonTra = new Guna.UI2.WinForms.Guna2Button();
            this.buttonChoMuon = new Guna.UI2.WinForms.Guna2Button();
            this.buttonMuon = new Guna.UI2.WinForms.Guna2Button();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelX = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sach_GiaoVien1 = new Winform_moi.Sach_GiaoVien();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.traSach_GiaoVien1 = new Winform_moi.TraSach_GiaoVien();
            this.choMuon_GiaoVien1 = new Winform_moi.ChoMuon_GiaoVien();
            this.muon_GiaoVien1 = new Winform_moi.Muon_GiaoVien();
            this.buttonImage = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.panelX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.Panel1.Controls.Add(this.buttonImage);
            this.Panel1.Controls.Add(this.buttonDanhSach);
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Controls.Add(this.buttonTra);
            this.Panel1.Controls.Add(this.buttonChoMuon);
            this.Panel1.Controls.Add(this.buttonMuon);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(167, 540);
            this.Panel1.TabIndex = 3;
            // 
            // buttonDanhSach
            // 
            this.buttonDanhSach.CheckedState.Parent = this.buttonDanhSach;
            this.buttonDanhSach.CustomImages.Parent = this.buttonDanhSach;
            this.buttonDanhSach.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDanhSach.ForeColor = System.Drawing.Color.White;
            this.buttonDanhSach.HoverState.Parent = this.buttonDanhSach;
            this.buttonDanhSach.Location = new System.Drawing.Point(-20, 293);
            this.buttonDanhSach.Name = "buttonDanhSach";
            this.buttonDanhSach.ShadowDecoration.Parent = this.buttonDanhSach;
            this.buttonDanhSach.Size = new System.Drawing.Size(193, 42);
            this.buttonDanhSach.TabIndex = 7;
            this.buttonDanhSach.Text = "Danh sách đã mượn";
            this.buttonDanhSach.Click += new System.EventHandler(this.buttonDanhSach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox1.ShadowDecoration.Parent = this.pictureBox1;
            this.pictureBox1.Size = new System.Drawing.Size(143, 96);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTra
            // 
            this.buttonTra.CheckedState.Parent = this.buttonTra;
            this.buttonTra.CustomImages.Parent = this.buttonTra;
            this.buttonTra.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTra.ForeColor = System.Drawing.Color.White;
            this.buttonTra.HoverState.Parent = this.buttonTra;
            this.buttonTra.Location = new System.Drawing.Point(-23, 209);
            this.buttonTra.Name = "buttonTra";
            this.buttonTra.ShadowDecoration.Parent = this.buttonTra;
            this.buttonTra.Size = new System.Drawing.Size(196, 42);
            this.buttonTra.TabIndex = 5;
            this.buttonTra.Text = "Trả sách";
            this.buttonTra.Click += new System.EventHandler(this.buttonTra_Click);
            // 
            // buttonChoMuon
            // 
            this.buttonChoMuon.CheckedState.Parent = this.buttonChoMuon;
            this.buttonChoMuon.CustomImages.Parent = this.buttonChoMuon;
            this.buttonChoMuon.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoMuon.ForeColor = System.Drawing.Color.White;
            this.buttonChoMuon.HoverState.Parent = this.buttonChoMuon;
            this.buttonChoMuon.Location = new System.Drawing.Point(-23, 251);
            this.buttonChoMuon.Name = "buttonChoMuon";
            this.buttonChoMuon.ShadowDecoration.Parent = this.buttonChoMuon;
            this.buttonChoMuon.Size = new System.Drawing.Size(193, 42);
            this.buttonChoMuon.TabIndex = 4;
            this.buttonChoMuon.Text = "Cho Thư Viện Mượn";
            this.buttonChoMuon.Click += new System.EventHandler(this.buttonChoMuon_Click);
            // 
            // buttonMuon
            // 
            this.buttonMuon.CheckedState.Parent = this.buttonMuon;
            this.buttonMuon.CustomImages.Parent = this.buttonMuon;
            this.buttonMuon.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMuon.ForeColor = System.Drawing.Color.White;
            this.buttonMuon.HoverState.Parent = this.buttonMuon;
            this.buttonMuon.Location = new System.Drawing.Point(-29, 169);
            this.buttonMuon.Name = "buttonMuon";
            this.buttonMuon.ShadowDecoration.Parent = this.buttonMuon;
            this.buttonMuon.Size = new System.Drawing.Size(196, 42);
            this.buttonMuon.TabIndex = 3;
            this.buttonMuon.Text = "Mượn sách";
            this.buttonMuon.Click += new System.EventHandler(this.buttonMuon_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.panelX);
            this.Panel2.Controls.Add(this.sach_GiaoVien1);
            this.Panel2.Controls.Add(this.panel3);
            this.Panel2.Controls.Add(this.traSach_GiaoVien1);
            this.Panel2.Controls.Add(this.choMuon_GiaoVien1);
            this.Panel2.Controls.Add(this.muon_GiaoVien1);
            this.Panel2.Location = new System.Drawing.Point(167, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(833, 540);
            this.Panel2.TabIndex = 4;
            // 
            // panelX
            // 
            this.panelX.Controls.Add(this.pictureBox3);
            this.panelX.FillColor = System.Drawing.Color.Coral;
            this.panelX.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(93)))), ((int)(((byte)(156)))));
            this.panelX.Location = new System.Drawing.Point(3, 0);
            this.panelX.Name = "panelX";
            this.panelX.ShadowDecoration.Parent = this.panelX;
            this.panelX.Size = new System.Drawing.Size(830, 537);
            this.panelX.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Winform_moi.Properties.Resources._1535317867_photofunky2;
            this.pictureBox3.Location = new System.Drawing.Point(124, 169);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(493, 192);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // sach_GiaoVien1
            // 
            this.sach_GiaoVien1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.sach_GiaoVien1.Location = new System.Drawing.Point(3, 3);
            this.sach_GiaoVien1.Name = "sach_GiaoVien1";
            this.sach_GiaoVien1.Size = new System.Drawing.Size(833, 540);
            this.sach_GiaoVien1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(526, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 284);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Winform_moi.Properties.Resources._1535317867_photofunky1;
            this.pictureBox2.Location = new System.Drawing.Point(54, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(697, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // traSach_GiaoVien1
            // 
            this.traSach_GiaoVien1.Location = new System.Drawing.Point(0, 0);
            this.traSach_GiaoVien1.Name = "traSach_GiaoVien1";
            this.traSach_GiaoVien1.Size = new System.Drawing.Size(833, 540);
            this.traSach_GiaoVien1.TabIndex = 2;
            // 
            // choMuon_GiaoVien1
            // 
            this.choMuon_GiaoVien1.Location = new System.Drawing.Point(0, 3);
            this.choMuon_GiaoVien1.Name = "choMuon_GiaoVien1";
            this.choMuon_GiaoVien1.Size = new System.Drawing.Size(833, 540);
            this.choMuon_GiaoVien1.TabIndex = 1;
            // 
            // muon_GiaoVien1
            // 
            this.muon_GiaoVien1.Location = new System.Drawing.Point(3, 3);
            this.muon_GiaoVien1.Name = "muon_GiaoVien1";
            this.muon_GiaoVien1.Size = new System.Drawing.Size(833, 540);
            this.muon_GiaoVien1.TabIndex = 0;
            // 
            // buttonImage
            // 
            this.buttonImage.CheckedState.Parent = this.buttonImage;
            this.buttonImage.CustomImages.Parent = this.buttonImage;
            this.buttonImage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.buttonImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonImage.ForeColor = System.Drawing.Color.White;
            this.buttonImage.HoverState.Parent = this.buttonImage;
            this.buttonImage.Location = new System.Drawing.Point(39, 116);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.ShadowDecoration.Parent = this.buttonImage;
            this.buttonImage.Size = new System.Drawing.Size(86, 26);
            this.buttonImage.TabIndex = 15;
            this.buttonImage.Text = "Edit Image";
            // 
            // GiaoVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "GiaoVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoVienForm";
            this.Load += new System.EventHandler(this.GiaoVienForm_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.panelX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Button buttonChoMuon;
        private Guna.UI2.WinForms.Guna2Button buttonMuon;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2Button buttonTra;
        private Muon_GiaoVien muon_GiaoVien1;
        private ChoMuon_GiaoVien choMuon_GiaoVien1;
        private TraSach_GiaoVien traSach_GiaoVien1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button buttonDanhSach;
        private Sach_GiaoVien sach_GiaoVien1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelX;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonImage;
    }
}