using Cafe_Management_System.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        string admin;
        
        public void changeLable(string user) {
            if (user == "guest") { 
                lbl_username.Text = "Guest";
            lbl_sadmin.Hide(); }
            else if (user == "reset")
            {
                lbl_username.Text = "Reset Menu";
                lbl_usertxt.Hide();
                lbl_sadmin.Hide();
            }
            else
            { if (user == "MQaisar")
                {
                    admin = "[Super Admin]";
                    lbl_sadmin.Text = admin;
                   
                }
                else
                {  admin = "[Admin]";
                lbl_sadmin.Text = admin; }
                lbl_username.Text = user;
            }
        }
        public bool IsGuestUser { get; set; }

        public bool IsAdminUser { get; set; }

        public bool IsSuperAdminUser { get; set; }


        string User;
        public Dashboard_Form(string user)
        {
            User = user;
            InitializeComponent();

            if (user == "Guest")
            {
                btn_AddItem.Hide();
                btn_AddItem.Enabled = false;
                btn_rmvItem.Hide();
                btn_rmvItem.Enabled = false;
                btn_UpdateItem.Hide();
                btn_UpdateItem.Enabled = false;
                btn_usrmng.Hide();
                btn_usrmng.Enabled = false;
                

            }
            if (user == "reset")
            {
                btn_PlcOrder.Hide();
                btn_PlcOrder.Enabled = false;
                btn_AddItem.Hide();
                btn_AddItem.Enabled = false;
                btn_rmvItem.Hide();
                btn_rmvItem.Enabled = false;
                btn_UpdateItem.Hide();
                btn_UpdateItem.Enabled = false;
                uc_UserManag1.IsResetUserButtonVisible = IsGuestUser;




            }
            else if (user=="MQaisar")
            {
                uc_UserManag1.IsDelUserButtonVisible = IsSuperAdminUser;
            }
            else
            {
                uc_UserManag1.IsAddUserButtonVisible = IsAdminUser;
                

            }

        }
        public void btn_logoutfn(string param)
        {
            this.Close();
            Login_form LF = new Login_form();
            LF.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_AddItem, "Click to Add Item.");
            toolTip1.SetToolTip(btn_PlcOrder, "Click to Place Order.");
            toolTip1.SetToolTip(btn_rmvItem, "Click to Remove Item.");
            toolTip1.SetToolTip(btn_UpdateItem, "Click to Update Item.");
            toolTip1.SetToolTip(btn_Logout, "Click to Logout.");
            toolTip1.SetToolTip(close_icon, "Click to Exit or Press Esc.");
            toolTip1.SetToolTip(btn_usrmng, "Click to Manage Users.");
            if (User == "reset")
            {
                uC_AddItems1.Visible = false;
                uc_plcOrder1.Visible = false;
                uC_UpdateItems1.Visible = false;
                uc_rmvItems1.Visible = false;
                uC_Welcome1.Visible = false;
                uc_UserManag1.Visible = true;
                uc_UserManag1.BringToFront();
                btn_Logout.Visible = false;
                btn_Logout.Enabled = false;
            }
            else
            {
                uC_AddItems1.Visible = false;
                uc_plcOrder1.Visible = false;
                uC_UpdateItems1.Visible = false;
                uc_rmvItems1.Visible = false;
                uc_UserManag1.Visible = false;
                uC_Welcome1.Visible = true;
                uC_Welcome1.BringToFront();
                btn_return.Visible = false;
                btn_return.Enabled = false;

            }
            this.KeyPreview = true;
        }

        private void lnk_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_form LF = new Login_form();
            this.Close();
            LF.Show();
            
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
                Application.Exit();

            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            btn_logoutfn("run");
            
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
            uC_Welcome1.SendToBack();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            uC_Welcome1.Visible = true;
            uC_Welcome1.BringToFront();
        }

        private void btn_PlcOrder_Click(object sender, EventArgs e)
        {
            uc_plcOrder1.Visible = true;
            uc_plcOrder1.BringToFront();
            uC_Welcome1.SendToBack();

        }

        private void uc_plcOrder1_Load(object sender, EventArgs e)
        {

        }

        private void btn_UpdateItem_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
            uC_Welcome1.SendToBack();
        }

        private void btn_rmvItem_Click(object sender, EventArgs e)
        {
            
            uc_rmvItems1.Visible = true;
            uc_rmvItems1.BringToFront();
            uC_Welcome1.SendToBack();
        }

        

        private void btn_usrmng_Click(object sender, EventArgs e)
            {
                uc_UserManag1.Visible = true;
                uc_UserManag1.BringToFront();
                uC_Welcome1.SendToBack();
            }

        private void uc_UserManag1_Load(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            btn_logoutfn("run");
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }
    }
}
