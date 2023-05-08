namespace Cafe_Management_System.User_Controls
{
    partial class uc_UserManag
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
            this.components = new System.ComponentModel.Container();
            this.lbl_rmvItems = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbx_fullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_addUser = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_repassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.chckbx_agrmnt = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_rmvItems
            // 
            this.lbl_rmvItems.AutoSize = true;
            this.lbl_rmvItems.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rmvItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_rmvItems.Location = new System.Drawing.Point(15, 14);
            this.lbl_rmvItems.Name = "lbl_rmvItems";
            this.lbl_rmvItems.Size = new System.Drawing.Size(323, 51);
            this.lbl_rmvItems.TabIndex = 34;
            this.lbl_rmvItems.Text = "User Management";
            this.lbl_rmvItems.Click += new System.EventHandler(this.lbl_rmvItems_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label9.Location = new System.Drawing.Point(118, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 33);
            this.label9.TabIndex = 35;
            this.label9.Text = "Full Name";
            // 
            // txtbx_fullName
            // 
            this.txtbx_fullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_fullName.DefaultText = "";
            this.txtbx_fullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_fullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_fullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_fullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_fullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_fullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.txtbx_fullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_fullName.Location = new System.Drawing.Point(292, 114);
            this.txtbx_fullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_fullName.Name = "txtbx_fullName";
            this.txtbx_fullName.PasswordChar = '\0';
            this.txtbx_fullName.PlaceholderText = "Type your Name";
            this.txtbx_fullName.SelectedText = "";
            this.txtbx_fullName.Size = new System.Drawing.Size(340, 33);
            this.txtbx_fullName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_fullName.TabIndex = 1;
            this.txtbx_fullName.TextChanged += new System.EventHandler(this.txtbx_fullName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(118, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 37;
            this.label1.Text = "Username*";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_username.DefaultText = "";
            this.txtbx_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.txtbx_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_username.Location = new System.Drawing.Point(292, 189);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.PasswordChar = '\0';
            this.txtbx_username.PlaceholderText = "Type your Username";
            this.txtbx_username.SelectedText = "";
            this.txtbx_username.Size = new System.Drawing.Size(340, 33);
            this.txtbx_username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_username.TabIndex = 2;
            this.txtbx_username.TextChanged += new System.EventHandler(this.txtbx_username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label2.Location = new System.Drawing.Point(118, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 39;
            this.label2.Text = "Password*";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_password.DefaultText = "";
            this.txtbx_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.txtbx_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_password.Location = new System.Drawing.Point(292, 258);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.PasswordChar = '\0';
            this.txtbx_password.PlaceholderText = "Type your Password";
            this.txtbx_password.SelectedText = "";
            this.txtbx_password.Size = new System.Drawing.Size(340, 33);
            this.txtbx_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_password.TabIndex = 3;
            this.txtbx_password.TextChanged += new System.EventHandler(this.txtbx_password_TextChanged);
            // 
            // btn_addUser
            // 
            this.btn_addUser.BorderRadius = 15;
            this.btn_addUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_addUser.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_addUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.btn_addUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addUser.ForeColor = System.Drawing.Color.White;
            this.btn_addUser.Location = new System.Drawing.Point(292, 435);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(152, 47);
            this.btn_addUser.TabIndex = 6;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BorderRadius = 15;
            this.btn_reset.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_reset.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(480, 435);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(152, 47);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(118, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 33);
            this.label3.TabIndex = 43;
            this.label3.Text = "Password*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbx_repassword
            // 
            this.txtbx_repassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_repassword.DefaultText = "";
            this.txtbx_repassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_repassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_repassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_repassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_repassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_repassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_repassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.txtbx_repassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_repassword.Location = new System.Drawing.Point(292, 331);
            this.txtbx_repassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_repassword.Name = "txtbx_repassword";
            this.txtbx_repassword.PasswordChar = '\0';
            this.txtbx_repassword.PlaceholderText = "Confirm your Password";
            this.txtbx_repassword.SelectedText = "";
            this.txtbx_repassword.Size = new System.Drawing.Size(340, 33);
            this.txtbx_repassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_repassword.TabIndex = 4;
            this.txtbx_repassword.TextChanged += new System.EventHandler(this.txtbx_repassword_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // chckbx_agrmnt
            // 
            this.chckbx_agrmnt.AutoSize = true;
            this.chckbx_agrmnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.chckbx_agrmnt.Location = new System.Drawing.Point(281, 388);
            this.chckbx_agrmnt.Name = "chckbx_agrmnt";
            this.chckbx_agrmnt.Size = new System.Drawing.Size(284, 24);
            this.chckbx_agrmnt.TabIndex = 5;
            this.chckbx_agrmnt.Text = "I agree to the Terms and Condition.";
            this.chckbx_agrmnt.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // uc_UserManag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chckbx_agrmnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_repassword);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.lbl_rmvItems);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbx_fullName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.Name = "uc_UserManag";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.uc_UserManag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rmvItems;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_fullName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_username;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_password;
        private Guna.UI2.WinForms.Guna2Button btn_addUser;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_repassword;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.CheckBox chckbx_agrmnt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
