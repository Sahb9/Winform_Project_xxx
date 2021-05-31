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
            this.label3 = new System.Windows.Forms.Label();
            this.labelPasword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radioButtonStaff = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonTeacher = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonStudent = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonAdmin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.labelPasword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
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
            this.labelUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUserName.Location = new System.Drawing.Point(19, 83);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUserName.Size = new System.Drawing.Size(83, 20);
            this.labelUserName.TabIndex = 28;
            this.labelUserName.Text = "Username";
            // 
            // radioButtonStaff
            // 
            this.radioButtonStaff.AutoSize = true;
            this.radioButtonStaff.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonStaff.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonStaff.CheckedState.BorderThickness = 0;
            this.radioButtonStaff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonStaff.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonStaff.CheckedState.InnerOffset = -4;
            this.radioButtonStaff.Location = new System.Drawing.Point(245, 12);
            this.radioButtonStaff.Name = "radioButtonStaff";
            this.radioButtonStaff.Size = new System.Drawing.Size(47, 17);
            this.radioButtonStaff.TabIndex = 31;
            this.radioButtonStaff.TabStop = true;
            this.radioButtonStaff.Text = "Staff";
            this.radioButtonStaff.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonStaff.UncheckedState.BorderThickness = 2;
            this.radioButtonStaff.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonStaff.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonStaff.UseVisualStyleBackColor = false;
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonTeacher.CheckedState.BorderThickness = 0;
            this.radioButtonTeacher.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonTeacher.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonTeacher.CheckedState.InnerOffset = -4;
            this.radioButtonTeacher.Location = new System.Drawing.Point(164, 12);
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
            this.radioButtonStudent.Location = new System.Drawing.Point(79, 12);
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
            this.radioButtonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonAdmin.CheckedState.BorderThickness = 0;
            this.radioButtonAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonAdmin.CheckedState.InnerOffset = -4;
            this.radioButtonAdmin.Location = new System.Drawing.Point(6, 12);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAdmin.TabIndex = 28;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAdmin.UncheckedState.BorderThickness = 2;
            this.radioButtonAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.UseVisualStyleBackColor = false;
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
            this.labelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.labelLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(103, 22);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(152, 31);
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
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.labelLogin);
            this.guna2GradientPanel1.Controls.Add(this.panel2);
            this.guna2GradientPanel1.Controls.Add(this.textBoxPassWord);
            this.guna2GradientPanel1.Controls.Add(this.panel1);
            this.guna2GradientPanel1.Controls.Add(this.textBoxUser);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Controls.Add(this.labelUserName);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(285, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(352, 362);
            this.guna2GradientPanel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(105, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 3);
            this.panel2.TabIndex = 16;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.textBoxPassWord.BorderThickness = 0;
            this.textBoxPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassWord.DefaultText = "PassWord";
            this.textBoxPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassWord.DisabledState.Parent = this.textBoxPassWord;
            this.textBoxPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.textBoxPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassWord.FocusedState.Parent = this.textBoxPassWord;
            this.textBoxPassWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassWord.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassWord.HoverState.Parent = this.textBoxPassWord;
            this.textBoxPassWord.Location = new System.Drawing.Point(107, 131);
            this.textBoxPassWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.PlaceholderText = "";
            this.textBoxPassWord.SelectedText = "";
            this.textBoxPassWord.SelectionStart = 8;
            this.textBoxPassWord.ShadowDecoration.Parent = this.textBoxPassWord;
            this.textBoxPassWord.Size = new System.Drawing.Size(197, 27);
            this.textBoxPassWord.TabIndex = 14;
            this.textBoxPassWord.Enter += new System.EventHandler(this.textBoxPassWord_Enter);
            this.textBoxPassWord.Leave += new System.EventHandler(this.textBoxPassWord_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(105, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 13;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.textBoxUser.BorderColor = System.Drawing.Color.White;
            this.textBoxUser.BorderThickness = 0;
            this.textBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUser.DefaultText = "User Name";
            this.textBoxUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUser.DisabledState.Parent = this.textBoxUser;
            this.textBoxUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.textBoxUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUser.FocusedState.Parent = this.textBoxUser;
            this.textBoxUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUser.HoverState.Parent = this.textBoxUser;
            this.textBoxUser.Location = new System.Drawing.Point(107, 76);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.PasswordChar = '\0';
            this.textBoxUser.PlaceholderText = "";
            this.textBoxUser.SelectedText = "";
            this.textBoxUser.SelectionStart = 9;
            this.textBoxUser.ShadowDecoration.Parent = this.textBoxUser;
            this.textBoxUser.Size = new System.Drawing.Size(197, 27);
            this.textBoxUser.TabIndex = 11;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            this.textBoxUser.Enter += new System.EventHandler(this.textBoxUser_Enter);
            this.textBoxUser.Leave += new System.EventHandler(this.textBoxUser_Leave);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.radioButtonStaff);
            this.guna2GradientPanel2.Controls.Add(this.radioButtonStudent);
            this.guna2GradientPanel2.Controls.Add(this.radioButtonTeacher);
            this.guna2GradientPanel2.Controls.Add(this.radioButtonAdmin);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(93)))), ((int)(((byte)(97)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(26, 184);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(303, 46);
            this.guna2GradientPanel2.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPasword);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Enter += new System.EventHandler(this.LoginForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPasword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAdmin;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonStaff;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonTeacher;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonStudent;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private System.Windows.Forms.Label labelLogin;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassWord;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUser;
    }
}