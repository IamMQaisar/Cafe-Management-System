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
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chckbx_agrmnt = new System.Windows.Forms.CheckBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtbx_repassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_rpswd = new System.Windows.Forms.Label();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtbx_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.txtbx_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_fullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_rmvItems = new System.Windows.Forms.Label();
            this.txtbx_CNIC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_secA = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbox_secQ = new System.Windows.Forms.ComboBox();
            this.btn_delUser = new Guna.UI2.WinForms.Guna2Button();
            this.showpass_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label4.Location = new System.Drawing.Point(121, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 33);
            this.label4.TabIndex = 45;
            this.label4.Text = "CNIC*";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // chckbx_agrmnt
            // 
            this.chckbx_agrmnt.AutoSize = true;
            this.chckbx_agrmnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.chckbx_agrmnt.Location = new System.Drawing.Point(259, 448);
            this.chckbx_agrmnt.Name = "chckbx_agrmnt";
            this.chckbx_agrmnt.Size = new System.Drawing.Size(284, 24);
            this.chckbx_agrmnt.TabIndex = 9;
            this.chckbx_agrmnt.Text = "I agree to the Terms and Condition.";
            this.chckbx_agrmnt.UseVisualStyleBackColor = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
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
            this.txtbx_repassword.Location = new System.Drawing.Point(258, 313);
            this.txtbx_repassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_repassword.Name = "txtbx_repassword";
            this.txtbx_repassword.PasswordChar = '*';
            this.txtbx_repassword.PlaceholderText = "Confirm your Password";
            this.txtbx_repassword.SelectedText = "";
            this.txtbx_repassword.Size = new System.Drawing.Size(462, 33);
            this.txtbx_repassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_repassword.TabIndex = 5;
            this.txtbx_repassword.TextChanged += new System.EventHandler(this.txtbx_password_TextChanged_1);
            // 
            // lbl_rpswd
            // 
            this.lbl_rpswd.AutoSize = true;
            this.lbl_rpswd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rpswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_rpswd.Location = new System.Drawing.Point(12, 313);
            this.lbl_rpswd.Name = "lbl_rpswd";
            this.lbl_rpswd.Size = new System.Drawing.Size(197, 33);
            this.lbl_rpswd.TabIndex = 43;
            this.lbl_rpswd.Text = "Conf. Password*";
            this.lbl_rpswd.Click += new System.EventHandler(this.label3_Click);
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
            this.btn_reset.Location = new System.Drawing.Point(574, 435);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(152, 47);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
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
            this.btn_addUser.Location = new System.Drawing.Point(574, 435);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(152, 47);
            this.btn_addUser.TabIndex = 10;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
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
            this.txtbx_password.Location = new System.Drawing.Point(258, 257);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.PasswordChar = '*';
            this.txtbx_password.PlaceholderText = "Type your Password";
            this.txtbx_password.SelectedText = "";
            this.txtbx_password.Size = new System.Drawing.Size(462, 33);
            this.txtbx_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_password.TabIndex = 4;
            this.txtbx_password.TextChanged += new System.EventHandler(this.txtbx_password_TextChanged_1);
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_pswd.Location = new System.Drawing.Point(77, 257);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(132, 33);
            this.lbl_pswd.TabIndex = 39;
            this.lbl_pswd.Text = "Password*";
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
            this.txtbx_username.Location = new System.Drawing.Point(258, 141);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.PasswordChar = '\0';
            this.txtbx_username.PlaceholderText = "Type your Username";
            this.txtbx_username.SelectedText = "";
            this.txtbx_username.Size = new System.Drawing.Size(462, 33);
            this.txtbx_username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_username.TabIndex = 2;
            this.txtbx_username.TextChanged += new System.EventHandler(this.txtbx_username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(84, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 37;
            this.label1.Text = "Username*";
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
            this.txtbx_fullName.Location = new System.Drawing.Point(258, 85);
            this.txtbx_fullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_fullName.Name = "txtbx_fullName";
            this.txtbx_fullName.PasswordChar = '\0';
            this.txtbx_fullName.PlaceholderText = "Type your Name";
            this.txtbx_fullName.SelectedText = "";
            this.txtbx_fullName.Size = new System.Drawing.Size(462, 33);
            this.txtbx_fullName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_fullName.TabIndex = 1;
            this.txtbx_fullName.TextChanged += new System.EventHandler(this.txtbx_fullName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label9.Location = new System.Drawing.Point(84, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 33);
            this.label9.TabIndex = 35;
            this.label9.Text = "Full Name*";
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
            // txtbx_CNIC
            // 
            this.txtbx_CNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_CNIC.DefaultText = "";
            this.txtbx_CNIC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_CNIC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_CNIC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_CNIC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_CNIC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_CNIC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_CNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.txtbx_CNIC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_CNIC.Location = new System.Drawing.Point(259, 201);
            this.txtbx_CNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_CNIC.Name = "txtbx_CNIC";
            this.txtbx_CNIC.PasswordChar = '\0';
            this.txtbx_CNIC.PlaceholderText = "Type your CNIC";
            this.txtbx_CNIC.SelectedText = "";
            this.txtbx_CNIC.Size = new System.Drawing.Size(461, 33);
            this.txtbx_CNIC.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_CNIC.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label5.Location = new System.Drawing.Point(15, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 33);
            this.label5.TabIndex = 47;
            this.label5.Text = "Security Ques.*";
            // 
            // txtbx_secA
            // 
            this.txtbx_secA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_secA.DefaultText = "";
            this.txtbx_secA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_secA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_secA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_secA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_secA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_secA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_secA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.txtbx_secA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_secA.Location = new System.Drawing.Point(538, 369);
            this.txtbx_secA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_secA.Name = "txtbx_secA";
            this.txtbx_secA.PasswordChar = '*';
            this.txtbx_secA.PlaceholderText = "Type Answer";
            this.txtbx_secA.SelectedText = "";
            this.txtbx_secA.Size = new System.Drawing.Size(188, 33);
            this.txtbx_secA.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_secA.TabIndex = 7;
            this.txtbx_secA.TextChanged += new System.EventHandler(this.txtbx_password_TextChanged_1);
            // 
            // cmbox_secQ
            // 
            this.cmbox_secQ.AllowDrop = true;
            this.cmbox_secQ.AutoCompleteCustomSource.AddRange(new string[] {
            "What is your mother\'s maiden name?",
            "What is the name of your first pet?",
            "What is the name of your birth city?",
            "What is your favorite book or movie?",
            "What is your favorite food or drink?"});
            this.cmbox_secQ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbox_secQ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbox_secQ.FormattingEnabled = true;
            this.cmbox_secQ.Items.AddRange(new object[] {
            "What is the name of your first pet",
            "What is your maiden name",
            "What is the name of your birth city",
            "What is your favorite book or movie",
            "What is your favorite food or drink"});
            this.cmbox_secQ.Location = new System.Drawing.Point(258, 374);
            this.cmbox_secQ.Name = "cmbox_secQ";
            this.cmbox_secQ.Size = new System.Drawing.Size(273, 28);
            this.cmbox_secQ.TabIndex = 6;
            // 
            // btn_delUser
            // 
            this.btn_delUser.BorderRadius = 15;
            this.btn_delUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_delUser.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_delUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delUser.ForeColor = System.Drawing.Color.White;
            this.btn_delUser.Location = new System.Drawing.Point(45, 435);
            this.btn_delUser.Name = "btn_delUser";
            this.btn_delUser.Size = new System.Drawing.Size(152, 47);
            this.btn_delUser.TabIndex = 11;
            this.btn_delUser.Text = "Delete";
            this.btn_delUser.Click += new System.EventHandler(this.btn_delUser_Click);
            // 
            // showpass_checkbox
            // 
            this.showpass_checkbox.AutoSize = true;
            this.showpass_checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.showpass_checkbox.Location = new System.Drawing.Point(355, 418);
            this.showpass_checkbox.Name = "showpass_checkbox";
            this.showpass_checkbox.Size = new System.Drawing.Size(176, 24);
            this.showpass_checkbox.TabIndex = 8;
            this.showpass_checkbox.Text = "Show Hidden Fields";
            this.showpass_checkbox.UseVisualStyleBackColor = true;
            this.showpass_checkbox.CheckedChanged += new System.EventHandler(this.showpass_checkbox_CheckedChanged);
            // 
            // uc_UserManag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.showpass_checkbox);
            this.Controls.Add(this.btn_delUser);
            this.Controls.Add(this.cmbox_secQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbx_secA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_CNIC);
            this.Controls.Add(this.chckbx_agrmnt);
            this.Controls.Add(this.lbl_rpswd);
            this.Controls.Add(this.txtbx_repassword);
            this.Controls.Add(this.lbl_pswd);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.lbl_rmvItems);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbx_fullName);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_addUser);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.Name = "uc_UserManag";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.uc_UserManag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chckbx_agrmnt;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_CNIC;
        private System.Windows.Forms.Label lbl_rpswd;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_repassword;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private Guna.UI2.WinForms.Guna2Button btn_addUser;
        private System.Windows.Forms.Label lbl_pswd;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_password;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_username;
        private System.Windows.Forms.Label lbl_rmvItems;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_fullName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_secA;
        private System.Windows.Forms.ComboBox cmbox_secQ;
        private Guna.UI2.WinForms.Guna2Button btn_delUser;
        private System.Windows.Forms.CheckBox showpass_checkbox;
    }
}
