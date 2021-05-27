namespace Winform_moi
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPasword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonStaff = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonTeacher = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonStudent = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonAdmin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(417, 136);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(197, 20);
            this.TextBoxPassword.TabIndex = 34;
            this.toolTip1.SetToolTip(this.TextBoxPassword, "Hay nhap PassWord");
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(417, 78);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(197, 20);
            this.TextBoxUsername.TabIndex = 33;
            this.toolTip1.SetToolTip(this.TextBoxUsername, "Hay nhap username");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 32;
            // 
            // labelPasword
            // 
            this.labelPasword.AutoSize = true;
            this.labelPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPasword.Location = new System.Drawing.Point(304, 139);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(78, 20);
            this.labelPasword.TabIndex = 29;
            this.labelPasword.Text = "Password";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(124)))), ((int)(((byte)(82)))));
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUserName.Location = new System.Drawing.Point(304, 76);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUserName.Size = new System.Drawing.Size(83, 20);
            this.labelUserName.TabIndex = 28;
            this.labelUserName.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(124)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.radioButtonStaff);
            this.panel1.Controls.Add(this.radioButtonTeacher);
            this.panel1.Controls.Add(this.radioButtonStudent);
            this.panel1.Controls.Add(this.radioButtonAdmin);
            this.panel1.Location = new System.Drawing.Point(308, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 50);
            this.panel1.TabIndex = 38;
            // 
            // radioButtonStaff
            // 
            this.radioButtonStaff.AutoSize = true;
            this.radioButtonStaff.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonStaff.CheckedState.BorderThickness = 0;
            this.radioButtonStaff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonStaff.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonStaff.CheckedState.InnerOffset = -4;
            this.radioButtonStaff.Location = new System.Drawing.Point(247, 20);
            this.radioButtonStaff.Name = "radioButtonStaff";
            this.radioButtonStaff.Size = new System.Drawing.Size(47, 17);
            this.radioButtonStaff.TabIndex = 31;
            this.radioButtonStaff.TabStop = true;
            this.radioButtonStaff.Text = "Staff";
            this.radioButtonStaff.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonStaff.UncheckedState.BorderThickness = 2;
            this.radioButtonStaff.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonStaff.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonStaff.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonTeacher.CheckedState.BorderThickness = 0;
            this.radioButtonTeacher.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonTeacher.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonTeacher.CheckedState.InnerOffset = -4;
            this.radioButtonTeacher.Location = new System.Drawing.Point(166, 20);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(65, 17);
            this.radioButtonTeacher.TabIndex = 30;
            this.radioButtonTeacher.TabStop = true;
            this.radioButtonTeacher.Text = "Teacher";
            this.radioButtonTeacher.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonTeacher.UncheckedState.BorderThickness = 2;
            this.radioButtonTeacher.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonTeacher.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonStudent.CheckedState.BorderThickness = 0;
            this.radioButtonStudent.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonStudent.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonStudent.CheckedState.InnerOffset = -4;
            this.radioButtonStudent.Location = new System.Drawing.Point(81, 20);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(62, 17);
            this.radioButtonStudent.TabIndex = 29;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonStudent.UncheckedState.BorderThickness = 2;
            this.radioButtonStudent.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonStudent.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonAdmin.CheckedState.BorderThickness = 0;
            this.radioButtonAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonAdmin.CheckedState.InnerOffset = -4;
            this.radioButtonAdmin.Location = new System.Drawing.Point(8, 20);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAdmin.TabIndex = 28;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAdmin.UncheckedState.BorderThickness = 2;
            this.radioButtonAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.CheckedState.Parent = this.buttonLogin;
            this.buttonLogin.CustomImages.Parent = this.buttonLogin;
            this.buttonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(247)))), ((int)(((byte)(48)))));
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.HoverState.Parent = this.buttonLogin;
            this.buttonLogin.Location = new System.Drawing.Point(525, 255);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.ShadowDecoration.Parent = this.buttonLogin;
            this.buttonLogin.Size = new System.Drawing.Size(89, 32);
            this.buttonLogin.TabIndex = 42;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(49)))), ((int)(((byte)(3)))));
            this.buttonCancel.CheckedState.Parent = this.buttonCancel;
            this.buttonCancel.CustomImages.Parent = this.buttonCancel;
            this.buttonCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(49)))), ((int)(((byte)(3)))));
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.HoverState.Parent = this.buttonCancel;
            this.buttonCancel.Location = new System.Drawing.Point(326, 255);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.ShadowDecoration.Parent = this.buttonCancel;
            this.buttonCancel.Size = new System.Drawing.Size(81, 32);
            this.buttonCancel.TabIndex = 43;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(422, 22);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(117, 24);
            this.labelLogin.TabIndex = 44;
            this.labelLogin.Text = "Login Form";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Winform_moi.Properties.Resources.dribbble_shot_6;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 362);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(124)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPasword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPasword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAdmin;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonStaff;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonTeacher;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonStudent;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private System.Windows.Forms.Label labelLogin;
    }
}