namespace Cafe_Management_System.User_Controls
{
    partial class uc_plcOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_totalRs = new System.Windows.Forms.Label();
            this.btn_print = new Guna.UI2.WinForms.Guna2Button();
            this.btn_rmv = new Guna.UI2.WinForms.Guna2Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_addtoCart = new Guna.UI2.WinForms.Guna2Button();
            this.txtbx_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbx_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbx_itemname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumUPDwn_quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_placeOrder = new System.Windows.Forms.Label();
            this.lstbx_items = new System.Windows.Forms.ListBox();
            this.cmbx_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtbx_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_plcOrder = new System.Windows.Forms.Label();
            this.plcOrder_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumUPDwn_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_totalRs
            // 
            this.lbl_totalRs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_totalRs.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_totalRs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_totalRs.Location = new System.Drawing.Point(439, 467);
            this.lbl_totalRs.Name = "lbl_totalRs";
            this.lbl_totalRs.Size = new System.Drawing.Size(120, 37);
            this.lbl_totalRs.TabIndex = 45;
            this.lbl_totalRs.Text = "Rs. 00";
            this.lbl_totalRs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_print
            // 
            this.btn_print.BorderRadius = 15;
            this.btn_print.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_print.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(620, 458);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(148, 45);
            this.btn_print.TabIndex = 7;
            this.btn_print.Text = "Print";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_rmv
            // 
            this.btn_rmv.BorderRadius = 15;
            this.btn_rmv.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_rmv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rmv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rmv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rmv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rmv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_rmv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_rmv.ForeColor = System.Drawing.Color.White;
            this.btn_rmv.Location = new System.Drawing.Point(243, 458);
            this.btn_rmv.Name = "btn_rmv";
            this.btn_rmv.Size = new System.Drawing.Size(148, 45);
            this.btn_rmv.TabIndex = 6;
            this.btn_rmv.Text = "Remove";
            this.btn_rmv.Click += new System.EventHandler(this.btn_rmv_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(438, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "Grand Total";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 28;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(230, 258);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.Size = new System.Drawing.Size(538, 169);
            this.guna2DataGridView1.TabIndex = 41;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // btn_addtoCart
            // 
            this.btn_addtoCart.BorderRadius = 15;
            this.btn_addtoCart.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_addtoCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addtoCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addtoCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addtoCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addtoCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_addtoCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addtoCart.ForeColor = System.Drawing.Color.White;
            this.btn_addtoCart.Location = new System.Drawing.Point(614, 205);
            this.btn_addtoCart.Name = "btn_addtoCart";
            this.btn_addtoCart.Size = new System.Drawing.Size(154, 45);
            this.btn_addtoCart.TabIndex = 5;
            this.btn_addtoCart.Text = "Add to Cart";
            this.btn_addtoCart.Click += new System.EventHandler(this.btn_addtoCart_Click);
            // 
            // txtbx_total
            // 
            this.txtbx_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_total.DefaultText = "";
            this.txtbx_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_total.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbx_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_total.Location = new System.Drawing.Point(561, 155);
            this.txtbx_total.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbx_total.Name = "txtbx_total";
            this.txtbx_total.PasswordChar = '\0';
            this.txtbx_total.PlaceholderText = "Total";
            this.txtbx_total.SelectedText = "";
            this.txtbx_total.Size = new System.Drawing.Size(207, 41);
            this.txtbx_total.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_total.TabIndex = 39;
            // 
            // txtbx_price
            // 
            this.txtbx_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_price.DefaultText = "";
            this.txtbx_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_price.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbx_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_price.Location = new System.Drawing.Point(561, 73);
            this.txtbx_price.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.PasswordChar = '\0';
            this.txtbx_price.PlaceholderText = "Price";
            this.txtbx_price.SelectedText = "";
            this.txtbx_price.Size = new System.Drawing.Size(207, 37);
            this.txtbx_price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_price.TabIndex = 38;
            // 
            // txtbx_itemname
            // 
            this.txtbx_itemname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_itemname.DefaultText = "";
            this.txtbx_itemname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_itemname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_itemname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_itemname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_itemname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_itemname.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtbx_itemname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_itemname.Location = new System.Drawing.Point(283, 69);
            this.txtbx_itemname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbx_itemname.Name = "txtbx_itemname";
            this.txtbx_itemname.PasswordChar = '\0';
            this.txtbx_itemname.PlaceholderText = "Item Name";
            this.txtbx_itemname.SelectedText = "";
            this.txtbx_itemname.Size = new System.Drawing.Size(223, 37);
            this.txtbx_itemname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_itemname.TabIndex = 33;
            this.txtbx_itemname.TextChanged += new System.EventHandler(this.txtbx_itemname_TextChanged);
            // 
            // txtNumUPDwn_quantity
            // 
            this.txtNumUPDwn_quantity.BackColor = System.Drawing.Color.Transparent;
            this.txtNumUPDwn_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumUPDwn_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumUPDwn_quantity.Location = new System.Drawing.Point(283, 155);
            this.txtNumUPDwn_quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumUPDwn_quantity.Name = "txtNumUPDwn_quantity";
            this.txtNumUPDwn_quantity.Size = new System.Drawing.Size(223, 41);
            this.txtNumUPDwn_quantity.TabIndex = 4;
            this.txtNumUPDwn_quantity.ValueChanged += new System.EventHandler(this.txtNumUPDwn_quantity_ValueChanged);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_total.Location = new System.Drawing.Point(554, 112);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(65, 37);
            this.lbl_total.TabIndex = 35;
            this.lbl_total.Text = "Total";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_price.Location = new System.Drawing.Point(554, 28);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(62, 37);
            this.lbl_price.TabIndex = 34;
            this.lbl_price.Text = "Price";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_quantity.Location = new System.Drawing.Point(276, 112);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(99, 37);
            this.lbl_quantity.TabIndex = 33;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_itemname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_itemname.Location = new System.Drawing.Point(276, 28);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(115, 37);
            this.lbl_itemname.TabIndex = 32;
            this.lbl_itemname.Text = "Item Name";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_category.Location = new System.Drawing.Point(14, 65);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(99, 37);
            this.lbl_category.TabIndex = 31;
            this.lbl_category.Text = "Category";
            // 
            // lbl_placeOrder
            // 
            this.lbl_placeOrder.AutoSize = true;
            this.lbl_placeOrder.Font = new System.Drawing.Font("Kalam", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_placeOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.lbl_placeOrder.Location = new System.Drawing.Point(12, 12);
            this.lbl_placeOrder.Name = "lbl_placeOrder";
            this.lbl_placeOrder.Size = new System.Drawing.Size(215, 53);
            this.lbl_placeOrder.TabIndex = 30;
            this.lbl_placeOrder.Text = "Place Order";
            // 
            // lstbx_items
            // 
            this.lstbx_items.FormattingEnabled = true;
            this.lstbx_items.ItemHeight = 20;
            this.lstbx_items.Location = new System.Drawing.Point(16, 220);
            this.lstbx_items.Name = "lstbx_items";
            this.lstbx_items.Size = new System.Drawing.Size(201, 284);
            this.lstbx_items.TabIndex = 3;
            this.lstbx_items.SelectedIndexChanged += new System.EventHandler(this.lstbx_items_SelectedIndexChanged);
            // 
            // cmbx_category
            // 
            this.cmbx_category.BackColor = System.Drawing.Color.Transparent;
            this.cmbx_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbx_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbx_category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbx_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbx_category.ItemHeight = 30;
            this.cmbx_category.Items.AddRange(new object[] {
            "Cake",
            "Soft Drink",
            "Chinese",
            "Tea",
            "Coffee"});
            this.cmbx_category.Location = new System.Drawing.Point(16, 113);
            this.cmbx_category.Name = "cmbx_category";
            this.cmbx_category.Size = new System.Drawing.Size(201, 36);
            this.cmbx_category.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbx_category.TabIndex = 1;
            this.cmbx_category.SelectedIndexChanged += new System.EventHandler(this.cmbx_category_SelectedIndexChanged);
            // 
            // txtbx_search
            // 
            this.txtbx_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_search.DefaultText = "";
            this.txtbx_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_search.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_search.Location = new System.Drawing.Point(16, 168);
            this.txtbx_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbx_search.Name = "txtbx_search";
            this.txtbx_search.PasswordChar = '\0';
            this.txtbx_search.PlaceholderText = "Search";
            this.txtbx_search.SelectedText = "";
            this.txtbx_search.Size = new System.Drawing.Size(201, 37);
            this.txtbx_search.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_search.TabIndex = 2;
            this.txtbx_search.TextChanged += new System.EventHandler(this.txtbx_search_TextChanged);
            // 
            // lbl_plcOrder
            // 
            this.lbl_plcOrder.AutoSize = true;
            this.lbl_plcOrder.Location = new System.Drawing.Point(35, 23);
            this.lbl_plcOrder.Name = "lbl_plcOrder";
            this.lbl_plcOrder.Size = new System.Drawing.Size(0, 20);
            this.lbl_plcOrder.TabIndex = 26;
            // 
            // plcOrder_Elipse
            // 
            this.plcOrder_Elipse.BorderRadius = 30;
            this.plcOrder_Elipse.TargetControl = this;
            // 
            // uc_plcOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_totalRs);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_rmv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btn_addtoCart);
            this.Controls.Add(this.txtbx_total);
            this.Controls.Add(this.txtbx_price);
            this.Controls.Add(this.txtbx_itemname);
            this.Controls.Add(this.txtNumUPDwn_quantity);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_itemname);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_placeOrder);
            this.Controls.Add(this.lstbx_items);
            this.Controls.Add(this.cmbx_category);
            this.Controls.Add(this.txtbx_search);
            this.Controls.Add(this.lbl_plcOrder);
            this.Name = "uc_plcOrder";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.uc_plcOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumUPDwn_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_totalRs;
        private Guna.UI2.WinForms.Guna2Button btn_print;
        private Guna.UI2.WinForms.Guna2Button btn_rmv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btn_addtoCart;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_total;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_price;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_itemname;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtNumUPDwn_quantity;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_placeOrder;
        private System.Windows.Forms.ListBox lstbx_items;
        private Guna.UI2.WinForms.Guna2ComboBox cmbx_category;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_search;
        private System.Windows.Forms.Label lbl_plcOrder;
        private Guna.UI2.WinForms.Guna2Elipse plcOrder_Elipse;
    }
}
