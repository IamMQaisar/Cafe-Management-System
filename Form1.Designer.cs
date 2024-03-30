namespace Cafe_Management_System
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txtbx_usrnm = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lnlbl_guest = new System.Windows.Forms.LinkLabel();
            this.showpass_checkbox = new System.Windows.Forms.CheckBox();
            this.lnklbl_forgotpswd = new System.Windows.Forms.LinkLabel();
            this.txtbx_pswd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(52, 223);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(116, 29);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Username";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.ForeColor = System.Drawing.Color.White;
            this.lbl_pwd.Location = new System.Drawing.Point(52, 309);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(110, 29);
            this.lbl_pwd.TabIndex = 2;
            this.lbl_pwd.Text = "Password";
            // 
            // txtbx_usrnm
            // 
            this.txtbx_usrnm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_usrnm.DefaultText = "";
            this.txtbx_usrnm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_usrnm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_usrnm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_usrnm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_usrnm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_usrnm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbx_usrnm.ForeColor = System.Drawing.Color.Black;
            this.txtbx_usrnm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_usrnm.Location = new System.Drawing.Point(57, 258);
            this.txtbx_usrnm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbx_usrnm.Name = "txtbx_usrnm";
            this.txtbx_usrnm.PasswordChar = '\0';
            this.txtbx_usrnm.PlaceholderText = "";
            this.txtbx_usrnm.SelectedText = "";
            this.txtbx_usrnm.Size = new System.Drawing.Size(269, 45);
            this.txtbx_usrnm.TabIndex = 1;
            this.txtbx_usrnm.TextChanged += new System.EventHandler(this.txtbx_usrnm_TextChanged);
            this.txtbx_usrnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_usrnm_KeyPress);
            // 
            // btn_login
            // 
            this.btn_login.BorderRadius = 15;
            this.btn_login.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_login.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_login.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(116, 436);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(152, 47);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.MouseLeave += new System.EventHandler(this.btn_login_MouseLeave);
            this.btn_login.MouseHover += new System.EventHandler(this.btn_login_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // lnlbl_guest
            // 
            this.lnlbl_guest.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnlbl_guest.AutoSize = true;
            this.lnlbl_guest.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lnlbl_guest.Location = new System.Drawing.Point(53, 504);
            this.lnlbl_guest.Name = "lnlbl_guest";
            this.lnlbl_guest.Size = new System.Drawing.Size(61, 20);
            this.lnlbl_guest.TabIndex = 5;
            this.lnlbl_guest.TabStop = true;
            this.lnlbl_guest.Text = "Guest !";
            this.lnlbl_guest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // showpass_checkbox
            // 
            this.showpass_checkbox.AutoSize = true;
            this.showpass_checkbox.ForeColor = System.Drawing.Color.White;
            this.showpass_checkbox.Location = new System.Drawing.Point(178, 396);
            this.showpass_checkbox.Name = "showpass_checkbox";
            this.showpass_checkbox.Size = new System.Drawing.Size(148, 24);
            this.showpass_checkbox.TabIndex = 3;
            this.showpass_checkbox.Text = "Show Password";
            this.showpass_checkbox.UseVisualStyleBackColor = true;
            this.showpass_checkbox.CheckedChanged += new System.EventHandler(this.showpass_checkbox_CheckedChanged);
            // 
            // lnklbl_forgotpswd
            // 
            this.lnklbl_forgotpswd.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklbl_forgotpswd.AutoSize = true;
            this.lnklbl_forgotpswd.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lnklbl_forgotpswd.Location = new System.Drawing.Point(184, 504);
            this.lnklbl_forgotpswd.Name = "lnklbl_forgotpswd";
            this.lnklbl_forgotpswd.Size = new System.Drawing.Size(142, 20);
            this.lnklbl_forgotpswd.TabIndex = 6;
            this.lnklbl_forgotpswd.TabStop = true;
            this.lnklbl_forgotpswd.Text = "Forgot Password ?";
            this.lnklbl_forgotpswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // txtbx_pswd
            // 
            this.txtbx_pswd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbx_pswd.Location = new System.Drawing.Point(57, 341);
            this.txtbx_pswd.Multiline = true;
            this.txtbx_pswd.Name = "txtbx_pswd";
            this.txtbx_pswd.PasswordChar = '*';
            this.txtbx_pswd.Size = new System.Drawing.Size(269, 45);
            this.txtbx_pswd.TabIndex = 2;
            this.txtbx_pswd.UseSystemPasswordChar = true;
            this.txtbx_pswd.TextChanged += new System.EventHandler(this.txtbx_pswd_TextChanged_1);
            this.txtbx_pswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_pswd_KeyPress_1);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(397, 579);
            this.Controls.Add(this.txtbx_pswd);
            this.Controls.Add(this.lnklbl_forgotpswd);
            this.Controls.Add(this.showpass_checkbox);
            this.Controls.Add(this.lnlbl_guest);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbx_usrnm);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pwd;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_usrnm;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel lnlbl_guest;
        private System.Windows.Forms.CheckBox showpass_checkbox;
        private System.Windows.Forms.LinkLabel lnklbl_forgotpswd;
        private System.Windows.Forms.TextBox txtbx_pswd;
    }
}

