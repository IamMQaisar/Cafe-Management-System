namespace Cafe_Management_System.User_Controls
{
    partial class UC_AddItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_itemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbx_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_additem = new Guna.UI2.WinForms.Guna2Button();
            this.cmbx_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kalam", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label2.Location = new System.Drawing.Point(120, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(120, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.label4.Location = new System.Drawing.Point(120, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Name";
            // 
            // txtbx_itemName
            // 
            this.txtbx_itemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_itemName.DefaultText = "";
            this.txtbx_itemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbx_itemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbx_itemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_itemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbx_itemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_itemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.txtbx_itemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_itemName.Location = new System.Drawing.Point(170, 280);
            this.txtbx_itemName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtbx_itemName.Name = "txtbx_itemName";
            this.txtbx_itemName.PasswordChar = '\0';
            this.txtbx_itemName.PlaceholderText = "";
            this.txtbx_itemName.SelectedText = "";
            this.txtbx_itemName.Size = new System.Drawing.Size(438, 41);
            this.txtbx_itemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_itemName.TabIndex = 2;
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
            this.txtbx_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbx_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.txtbx_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbx_price.Location = new System.Drawing.Point(170, 361);
            this.txtbx_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.PasswordChar = '\0';
            this.txtbx_price.PlaceholderText = "";
            this.txtbx_price.SelectedText = "";
            this.txtbx_price.Size = new System.Drawing.Size(438, 44);
            this.txtbx_price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbx_price.TabIndex = 3;
            // 
            // btn_additem
            // 
            this.btn_additem.BorderRadius = 15;
            this.btn_additem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_additem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_additem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_additem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_additem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(87)))), ((int)(((byte)(17)))));
            this.btn_additem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_additem.ForeColor = System.Drawing.Color.White;
            this.btn_additem.Location = new System.Drawing.Point(428, 441);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(180, 45);
            this.btn_additem.TabIndex = 4;
            this.btn_additem.Text = "Add Item";
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // cmbx_category
            // 
            this.cmbx_category.BackColor = System.Drawing.Color.Transparent;
            this.cmbx_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbx_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbx_category.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbx_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(71)))), ((int)(((byte)(9)))));
            this.cmbx_category.ItemHeight = 30;
            this.cmbx_category.Items.AddRange(new object[] {
            "Cake",
            "Soft Drink",
            "Chinese",
            "Tea",
            "Coffee",
            "Fast Food"});
            this.cmbx_category.Location = new System.Drawing.Point(170, 159);
            this.cmbx_category.Name = "cmbx_category";
            this.cmbx_category.Size = new System.Drawing.Size(438, 36);
            this.cmbx_category.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbx_category.TabIndex = 1;
            this.cmbx_category.SelectedIndexChanged += new System.EventHandler(this.cmbx_category_SelectedIndexChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbx_category);
            this.Controls.Add(this.btn_additem);
            this.Controls.Add(this.txtbx_price);
            this.Controls.Add(this.txtbx_itemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddItems";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_AddItems_Load);
            this.Leave += new System.EventHandler(this.UC_AddItems_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_itemName;
        private Guna.UI2.WinForms.Guna2TextBox txtbx_price;
        private Guna.UI2.WinForms.Guna2Button btn_additem;
        private Guna.UI2.WinForms.Guna2ComboBox cmbx_category;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
