namespace Winform_moi
{
    partial class QuanLySach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ButtonView = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.removeBook1 = new Winform_moi.RemoveBook();
            this.viewBook1 = new Winform_moi.ViewBook();
            this.editBook1 = new Winform_moi.EditBook();
            this.addBook1 = new Winform_moi.AddBook();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.ButtonRemove);
            this.guna2Panel2.Controls.Add(this.ButtonEdit);
            this.guna2Panel2.Controls.Add(this.ButtonAdd);
            this.guna2Panel2.Controls.Add(this.ButtonView);
            this.guna2Panel2.Location = new System.Drawing.Point(31, 77);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(766, 72);
            this.guna2Panel2.TabIndex = 9;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.CheckedState.Parent = this.ButtonRemove;
            this.ButtonRemove.CustomImages.Parent = this.ButtonRemove;
            this.ButtonRemove.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(145)))));
            this.ButtonRemove.HoverState.Parent = this.ButtonRemove;
            this.ButtonRemove.Location = new System.Drawing.Point(605, 25);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.ShadowDecoration.Parent = this.ButtonRemove;
            this.ButtonRemove.Size = new System.Drawing.Size(140, 39);
            this.ButtonRemove.TabIndex = 4;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.CheckedState.Parent = this.ButtonEdit;
            this.ButtonEdit.CustomImages.Parent = this.ButtonEdit;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(145)))));
            this.ButtonEdit.HoverState.Parent = this.ButtonEdit;
            this.ButtonEdit.Location = new System.Drawing.Point(396, 25);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.ShadowDecoration.Parent = this.ButtonEdit;
            this.ButtonEdit.Size = new System.Drawing.Size(140, 39);
            this.ButtonEdit.TabIndex = 3;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.CheckedState.Parent = this.ButtonAdd;
            this.ButtonAdd.CustomImages.Parent = this.ButtonAdd;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(145)))));
            this.ButtonAdd.HoverState.Parent = this.ButtonAdd;
            this.ButtonAdd.Location = new System.Drawing.Point(204, 25);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.ShadowDecoration.Parent = this.ButtonAdd;
            this.ButtonAdd.Size = new System.Drawing.Size(140, 39);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonView
            // 
            this.ButtonView.CheckedState.Parent = this.ButtonView;
            this.ButtonView.CustomImages.Parent = this.ButtonView;
            this.ButtonView.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(145)))));
            this.ButtonView.HoverState.Parent = this.ButtonView;
            this.ButtonView.Location = new System.Drawing.Point(14, 25);
            this.ButtonView.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonView.Name = "ButtonView";
            this.ButtonView.ShadowDecoration.Parent = this.ButtonView;
            this.ButtonView.Size = new System.Drawing.Size(140, 39);
            this.ButtonView.TabIndex = 0;
            this.ButtonView.Text = "View";
            this.ButtonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.removeBook1);
            this.guna2Panel1.Controls.Add(this.viewBook1);
            this.guna2Panel1.Controls.Add(this.editBook1);
            this.guna2Panel1.Controls.Add(this.addBook1);
            this.guna2Panel1.Location = new System.Drawing.Point(31, 155);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(766, 364);
            this.guna2Panel1.TabIndex = 13;
            // 
            // removeBook1
            // 
            this.removeBook1.Location = new System.Drawing.Point(0, 0);
            this.removeBook1.Name = "removeBook1";
            this.removeBook1.Size = new System.Drawing.Size(766, 364);
            this.removeBook1.TabIndex = 3;
            this.removeBook1.Load += new System.EventHandler(this.removeBook1_Load);
            // 
            // viewBook1
            // 
            this.viewBook1.Location = new System.Drawing.Point(0, -3);
            this.viewBook1.Name = "viewBook1";
            this.viewBook1.Size = new System.Drawing.Size(766, 364);
            this.viewBook1.TabIndex = 2;
            // 
            // editBook1
            // 
            this.editBook1.Location = new System.Drawing.Point(0, 0);
            this.editBook1.Name = "editBook1";
            this.editBook1.Size = new System.Drawing.Size(766, 364);
            this.editBook1.TabIndex = 1;
            // 
            // addBook1
            // 
            this.addBook1.Location = new System.Drawing.Point(0, 0);
            this.addBook1.Name = "addBook1";
            this.addBook1.Size = new System.Drawing.Size(766, 364);
            this.addBook1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 31);
            this.label9.TabIndex = 62;
            this.label9.Text = "Manage Book";
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(241)))), ((int)(((byte)(179)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "QuanLySach";
            this.Size = new System.Drawing.Size(833, 540);
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonRemove;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonEdit;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonAdd;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private EditBook editBook1;
        private AddBook addBook1;
        private ViewBook viewBook1;
        private RemoveBook removeBook1;
        private System.Windows.Forms.Label label9;
    }
}
