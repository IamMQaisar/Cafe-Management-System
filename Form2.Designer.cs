namespace Cafe_Management_System
{
    partial class Dashboard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_return = new Guna.UI2.WinForms.Guna2Button();
            this.btn_usrmng = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.close_icon = new System.Windows.Forms.PictureBox();
            this.btn_rmvItem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_UpdateItem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AddItem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_PlcOrder = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.plcOrder_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_usertxt = new System.Windows.Forms.Label();
            this.lbl_sadmin = new System.Windows.Forms.Label();
            this.uC_Welcome1 = new Cafe_Management_System.User_Controls.UC_Welcome();
            this.uc_UserManag1 = new Cafe_Management_System.User_Controls.uc_UserManag();
            this.uc_rmvItems1 = new Cafe_Management_System.User_Controls.uc_rmvItems();
            this.uC_UpdateItems1 = new Cafe_Management_System.User_Controls.UC_UpdateItems();
            this.uc_plcOrder1 = new Cafe_Management_System.User_Controls.uc_plcOrder();
            this.uC_AddItems1 = new Cafe_Management_System.User_Controls.UC_AddItems();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uC_Welcome1);
            this.panel1.Controls.Add(this.uc_UserManag1);
            this.panel1.Controls.Add(this.uc_rmvItems1);
            this.panel1.Controls.Add(this.uC_UpdateItems1);
            this.panel1.Controls.Add(this.uc_plcOrder1);
            this.panel1.Controls.Add(this.uC_AddItems1);
            this.panel1.Location = new System.Drawing.Point(211, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 514);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.panel2.Controls.Add(this.lbl_sadmin);
            this.panel2.Controls.Add(this.lbl_usertxt);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.btn_return);
            this.panel2.Controls.Add(this.btn_usrmng);
            this.panel2.Controls.Add(this.btn_Logout);
            this.panel2.Controls.Add(this.close_icon);
            this.panel2.Controls.Add(this.btn_rmvItem);
            this.panel2.Controls.Add(this.btn_UpdateItem);
            this.panel2.Controls.Add(this.btn_AddItem);
            this.panel2.Controls.Add(this.btn_PlcOrder);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 514);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(39, 400);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 34);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "(Name)";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // btn_return
            // 
            this.btn_return.BorderRadius = 12;
            this.btn_return.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(118)))), ((int)(((byte)(66)))));
            this.btn_return.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(45)))), ((int)(((byte)(18)))));
            this.btn_return.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_return.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_return.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_return.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Location = new System.Drawing.Point(28, 435);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(152, 45);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "Return";
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_usrmng
            // 
            this.btn_usrmng.BorderRadius = 15;
            this.btn_usrmng.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_usrmng.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(118)))), ((int)(((byte)(66)))));
            this.btn_usrmng.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(45)))), ((int)(((byte)(18)))));
            this.btn_usrmng.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_usrmng.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_usrmng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_usrmng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_usrmng.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_usrmng.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_usrmng.ForeColor = System.Drawing.Color.White;
            this.btn_usrmng.Location = new System.Drawing.Point(28, 311);
            this.btn_usrmng.Name = "btn_usrmng";
            this.btn_usrmng.Size = new System.Drawing.Size(202, 41);
            this.btn_usrmng.TabIndex = 5;
            this.btn_usrmng.Text = "User Manag.";
            this.btn_usrmng.Click += new System.EventHandler(this.btn_usrmng_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BorderRadius = 12;
            this.btn_Logout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(118)))), ((int)(((byte)(66)))));
            this.btn_Logout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(45)))), ((int)(((byte)(18)))));
            this.btn_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(28, 435);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(152, 45);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // close_icon
            // 
            this.close_icon.Image = ((System.Drawing.Image)(resources.GetObject("close_icon.Image")));
            this.close_icon.Location = new System.Drawing.Point(3, 3);
            this.close_icon.Name = "close_icon";
            this.close_icon.Size = new System.Drawing.Size(35, 35);
            this.close_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_icon.TabIndex = 7;
            this.close_icon.TabStop = false;
            this.close_icon.Click += new System.EventHandler(this.close_icon_Click);
            // 
            // btn_rmvItem
            // 
            this.btn_rmvItem.BorderRadius = 15;
            this.btn_rmvItem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_rmvItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(118)))), ((int)(((byte)(66)))));
            this.btn_rmvItem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(45)))), ((int)(((byte)(18)))));
            this.btn_rmvItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rmvItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rmvItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rmvItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rmvItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_rmvItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_rmvItem.ForeColor = System.Drawing.Color.White;
            this.btn_rmvItem.Location = new System.Drawing.Point(28, 251);
            this.btn_rmvItem.Name = "btn_rmvItem";
            this.btn_rmvItem.Size = new System.Drawing.Size(202, 41);
            this.btn_rmvItem.TabIndex = 4;
            this.btn_rmvItem.Text = "Remove Item";
            this.btn_rmvItem.Click += new System.EventHandler(this.btn_rmvItem_Click);
            // 
            // btn_UpdateItem
            // 
            this.btn_UpdateItem.BorderRadius = 15;
            this.btn_UpdateItem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_UpdateItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(118)))), ((int)(((byte)(66)))));
            this.btn_UpdateItem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(45)))), ((int)(((byte)(18)))));
            this.btn_UpdateItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_UpdateItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_UpdateItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_UpdateItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_UpdateItem.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateItem.Location = new System.Drawing.Point(28, 190);
            this.btn_UpdateItem.Name = "btn_UpdateItem";
            this.btn_UpdateItem.Size = new System.Drawing.Size(202, 41);
            this.btn_UpdateItem.TabIndex = 3;
            this.btn_UpdateItem.Text = "Update Items";
            this.btn_UpdateItem.Click += new System.EventHandler(this.btn_UpdateItem_Click);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.BorderRadius = 15;
            this.btn_AddItem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_AddItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(118)))), ((int)(((byte)(66)))));
            this.btn_AddItem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(45)))), ((int)(((byte)(18)))));
            this.btn_AddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_AddItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddItem.ForeColor = System.Drawing.Color.White;
            this.btn_AddItem.Location = new System.Drawing.Point(28, 127);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(202, 41);
            this.btn_AddItem.TabIndex = 2;
            this.btn_AddItem.Text = "Add Item";
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_PlcOrder
            // 
            this.btn_PlcOrder.BorderRadius = 15;
            this.btn_PlcOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_PlcOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(118)))), ((int)(((byte)(66)))));
            this.btn_PlcOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(45)))), ((int)(((byte)(18)))));
            this.btn_PlcOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_PlcOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_PlcOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_PlcOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_PlcOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_PlcOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_PlcOrder.ForeColor = System.Drawing.Color.White;
            this.btn_PlcOrder.Location = new System.Drawing.Point(31, 68);
            this.btn_PlcOrder.Name = "btn_PlcOrder";
            this.btn_PlcOrder.Size = new System.Drawing.Size(202, 41);
            this.btn_PlcOrder.TabIndex = 1;
            this.btn_PlcOrder.Text = "Place Order";
            this.btn_PlcOrder.Click += new System.EventHandler(this.btn_PlcOrder_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 16;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel1;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel1;
            // 
            // plcOrder_Elipse
            // 
            this.plcOrder_Elipse.BorderRadius = 30;
            this.plcOrder_Elipse.TargetControl = this.panel1;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel1;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel1;
            // 
            // guna2Elipse8
            // 
            this.guna2Elipse8.BorderRadius = 30;
            this.guna2Elipse8.TargetControl = this.panel1;
            // 
            // lbl_usertxt
            // 
            this.lbl_usertxt.AutoSize = true;
            this.lbl_usertxt.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usertxt.ForeColor = System.Drawing.Color.White;
            this.lbl_usertxt.Location = new System.Drawing.Point(12, 373);
            this.lbl_usertxt.Name = "lbl_usertxt";
            this.lbl_usertxt.Size = new System.Drawing.Size(58, 26);
            this.lbl_usertxt.TabIndex = 9;
            this.lbl_usertxt.Text = "User:";
            this.lbl_usertxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sadmin
            // 
            this.lbl_sadmin.AutoSize = true;
            this.lbl_sadmin.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sadmin.ForeColor = System.Drawing.Color.White;
            this.lbl_sadmin.Location = new System.Drawing.Point(63, 374);
            this.lbl_sadmin.Name = "lbl_sadmin";
            this.lbl_sadmin.Size = new System.Drawing.Size(80, 26);
            this.lbl_sadmin.TabIndex = 10;
            this.lbl_sadmin.Text = "S.Admin";
            this.lbl_sadmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.uC_Welcome1.Location = new System.Drawing.Point(-27, 3);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(815, 514);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // uc_UserManag1
            // 
            this.uc_UserManag1.BackColor = System.Drawing.Color.White;
            this.uc_UserManag1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
          
            this.uc_UserManag1.Location = new System.Drawing.Point(3, -3);
            this.uc_UserManag1.Name = "uc_UserManag1";
            this.uc_UserManag1.Size = new System.Drawing.Size(781, 514);
            this.uc_UserManag1.TabIndex = 8;
            this.uc_UserManag1.Load += new System.EventHandler(this.uc_UserManag1_Load);
            // 
            // uc_rmvItems1
            // 
            this.uc_rmvItems1.BackColor = System.Drawing.Color.White;
            this.uc_rmvItems1.Location = new System.Drawing.Point(0, -3);
            this.uc_rmvItems1.Name = "uc_rmvItems1";
            this.uc_rmvItems1.Size = new System.Drawing.Size(781, 514);
            this.uc_rmvItems1.TabIndex = 7;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.White;
            this.uC_UpdateItems1.Location = new System.Drawing.Point(3, 0);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItems1.TabIndex = 6;
            // 
            // uc_plcOrder1
            // 
            this.uc_plcOrder1.BackColor = System.Drawing.Color.White;
            this.uc_plcOrder1.Location = new System.Drawing.Point(0, 3);
            this.uc_plcOrder1.Name = "uc_plcOrder1";
            this.uc_plcOrder1.Size = new System.Drawing.Size(781, 514);
            this.uc_plcOrder1.TabIndex = 5;
            this.uc_plcOrder1.Load += new System.EventHandler(this.uc_plcOrder1_Load);
            // 
            // uC_AddItems1
            // 
            this.uC_AddItems1.BackColor = System.Drawing.Color.White;
            this.uC_AddItems1.Location = new System.Drawing.Point(7, -3);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_AddItems1.TabIndex = 4;
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1011, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dashboard_Form_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_rmvItem;
        private Guna.UI2.WinForms.Guna2Button btn_UpdateItem;
        private Guna.UI2.WinForms.Guna2Button btn_AddItem;
        private Guna.UI2.WinForms.Guna2Button btn_PlcOrder;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.PictureBox close_icon;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btn_Logout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private User_Controls.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private User_Controls.UC_AddItems uC_AddItems1;
        private Guna.UI2.WinForms.Guna2Elipse plcOrder_Elipse;
        private User_Controls.uc_plcOrder uc_plcOrder1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private User_Controls.UC_UpdateItems uC_UpdateItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private User_Controls.uc_rmvItems uc_rmvItems1;
        private Guna.UI2.WinForms.Guna2Button btn_usrmng;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse8;
        private User_Controls.uc_UserManag uc_UserManag1;
        private Guna.UI2.WinForms.Guna2Button btn_return;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_usertxt;
        private System.Windows.Forms.Label lbl_sadmin;
    }
}