namespace Winform_moi
{
    partial class StaffForm
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
            this.buttonImage = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.buttonCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.checkOut_Staff1 = new Winform_moi.CheckOut_Staff();
            this.checkIn_Staff1 = new Winform_moi.CheckIn_Staff();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelX = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.Panel1.Controls.Add(this.buttonImage);
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Controls.Add(this.buttonCheckOut);
            this.Panel1.Controls.Add(this.buttonCheckIn);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(167, 540);
            this.Panel1.TabIndex = 5;
            // 
            // buttonImage
            // 
            this.buttonImage.CheckedState.Parent = this.buttonImage;
            this.buttonImage.CustomImages.Parent = this.buttonImage;
            this.buttonImage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.buttonImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonImage.ForeColor = System.Drawing.Color.White;
            this.buttonImage.HoverState.Parent = this.buttonImage;
            this.buttonImage.Location = new System.Drawing.Point(37, 114);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.ShadowDecoration.Parent = this.buttonImage;
            this.buttonImage.Size = new System.Drawing.Size(86, 26);
            this.buttonImage.TabIndex = 15;
            this.buttonImage.Text = "Edit Image";
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.CheckedState.Parent = this.buttonCheckOut;
            this.buttonCheckOut.CustomImages.Parent = this.buttonCheckOut;
            this.buttonCheckOut.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.ForeColor = System.Drawing.Color.White;
            this.buttonCheckOut.HoverState.Parent = this.buttonCheckOut;
            this.buttonCheckOut.Location = new System.Drawing.Point(-23, 217);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.ShadowDecoration.Parent = this.buttonCheckOut;
            this.buttonCheckOut.Size = new System.Drawing.Size(193, 42);
            this.buttonCheckOut.TabIndex = 4;
            this.buttonCheckOut.Text = "Check - Out";
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.CheckedState.Parent = this.buttonCheckIn;
            this.buttonCheckIn.CustomImages.Parent = this.buttonCheckIn;
            this.buttonCheckIn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.White;
            this.buttonCheckIn.HoverState.Parent = this.buttonCheckIn;
            this.buttonCheckIn.Location = new System.Drawing.Point(-29, 175);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.ShadowDecoration.Parent = this.buttonCheckIn;
            this.buttonCheckIn.Size = new System.Drawing.Size(196, 42);
            this.buttonCheckIn.TabIndex = 3;
            this.buttonCheckIn.Text = "Check - In";
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.panelX);
            this.Panel2.Controls.Add(this.checkOut_Staff1);
            this.Panel2.Controls.Add(this.checkIn_Staff1);
            this.Panel2.Location = new System.Drawing.Point(167, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(833, 540);
            this.Panel2.TabIndex = 6;
            // 
            // checkOut_Staff1
            // 
            this.checkOut_Staff1.Location = new System.Drawing.Point(0, 0);
            this.checkOut_Staff1.Name = "checkOut_Staff1";
            this.checkOut_Staff1.Size = new System.Drawing.Size(833, 540);
            this.checkOut_Staff1.TabIndex = 1;
            // 
            // checkIn_Staff1
            // 
            this.checkIn_Staff1.Location = new System.Drawing.Point(0, 0);
            this.checkIn_Staff1.Name = "checkIn_Staff1";
            this.checkIn_Staff1.Size = new System.Drawing.Size(833, 540);
            this.checkIn_Staff1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox1.ShadowDecoration.Parent = this.pictureBox1;
            this.pictureBox1.Size = new System.Drawing.Size(143, 96);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelX
            // 
            this.panelX.Controls.Add(this.pictureBox3);
            this.panelX.FillColor = System.Drawing.Color.Coral;
            this.panelX.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(93)))), ((int)(((byte)(156)))));
            this.panelX.Location = new System.Drawing.Point(1, 2);
            this.panelX.Name = "panelX";
            this.panelX.ShadowDecoration.Parent = this.panelX;
            this.panelX.Size = new System.Drawing.Size(830, 537);
            this.panelX.TabIndex = 6;
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
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button buttonCheckOut;
        private Guna.UI2.WinForms.Guna2Button buttonCheckIn;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private CheckOut_Staff checkOut_Staff1;
        private CheckIn_Staff checkIn_Staff1;
        private Guna.UI2.WinForms.Guna2GradientTileButton buttonImage;
        private Guna.UI2.WinForms.Guna2GradientPanel panelX;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}