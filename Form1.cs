using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Login_form : Form
    {
        function fn = new function();
        string query;
        public Login_form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)

        {

            query = "select * from users where username='" + txtbx_usrnm.Text + "';";
            SqlCommand command = fn.getInstance();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            string Username = "";
            string Password = "";
            string Salt = "";
            while (reader.Read())
            {
                Username = reader["username"].ToString();
                Password = reader["password"].ToString();
                Salt = reader["salt"].ToString();
            }
            reader.Close();

            string password = txtbx_pswd.Text;
            

            string salt = Salt;
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
            byte[] hashBytes;

            using (SHA256 sha256 = SHA256.Create())
            {
                hashBytes = sha256.ComputeHash(passwordBytes);
            }

            string hashedPassword = Convert.ToBase64String(hashBytes);

            if (txtbx_usrnm.Text == Username && hashedPassword == Password && txtbx_usrnm.Text!="" && txtbx_pswd.Text!="")

            {
                Dashboard_Form ds = new Dashboard_Form(Username);
                ds.changeLable(Username);
                ds.Show();
                this.Hide();

            }
            else if (txtbx_usrnm.Text == "guest" && txtbx_pswd.Text == "123")
            {
                Dashboard_Form ds = new Dashboard_Form("Guest");
                ds.changeLable("guest");
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or password!");
                txtbx_usrnm.Clear();
                txtbx_pswd.Clear();
                txtbx_usrnm.Focus();
            }
            command.Dispose();
            fn.closeInstance();

        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_login, "Click to Login");
            toolTip1.SetToolTip(txtbx_usrnm, "Enter your Username");
            toolTip1.SetToolTip(txtbx_pswd, "Enter your Password");
            toolTip1.SetToolTip(lnlbl_guest, "Click to Enter as \"Guest\" or Use \"username=guest\" and \"password=123\".");
            toolTip1.SetToolTip(lnklbl_forgotpswd, "Click to Recover your Password");
            toolTip1.SetToolTip(showpass_checkbox, "Click to Show Password");
            //toolTip1.SetToolTip(btn_exit, "Click to Exit");
            this.KeyPreview = true;
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard_Form ds = new Dashboard_Form("Guest");
            ds.changeLable("guest");
            ds.Show();
            this.Hide();
        }

       

        private void txtbx_usrnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
               txtbx_pswd.Focus();
            }
        }


        private void showpass_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass_checkbox.Checked)
            {
                txtbx_pswd.UseSystemPasswordChar = true;
            }
            else
            {
                txtbx_pswd.UseSystemPasswordChar = false;
            }
        }

        private void txtbx_usrnm_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_usrnm.Text != "")
            {
                txtbx_usrnm.BackColor = Color.Blue;
            }
            else
            {
                txtbx_usrnm.BackColor = Color.White;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard_Form ds = new Dashboard_Form("reset");
            ds.changeLable("reset");
            ds.Show();
            this.Hide();
        }

        private void Login_form_KeyPress(object sender, KeyPressEventArgs e)
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

        

       

        private void txtbx_pswd_TextChanged_1(object sender, EventArgs e)
        {
            txtbx_pswd.UseSystemPasswordChar = false;
            if (txtbx_pswd.Text == "")
            {
                txtbx_pswd.BackColor = Color.White;
            }
            else if (txtbx_pswd.Text != "" && txtbx_pswd.Text.Length < 8)
            {
                txtbx_pswd.BackColor = Color.IndianRed;

            }
            else
            {
                txtbx_pswd.BackColor = Color.LightGreen;
            }

        }

        private void txtbx_pswd_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_login.PerformClick();
            }
        }

        private void btn_login_MouseHover(object sender, EventArgs e)
        {
            if (txtbx_usrnm.Text == "" || txtbx_pswd.Text == "" || txtbx_pswd.Text.Length < 8)
            {
                btn_login.FillColor = Color.IndianRed;

            }
            else
            {
                btn_login.FillColor = Color.LightBlue;
            }
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.FillColor = Color.FromArgb(111, 71, 9);
        }
    }
}
