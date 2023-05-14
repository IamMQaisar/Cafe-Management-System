using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cafe_Management_System.User_Controls
{
    public partial class uc_UserManag : UserControl
    {
        function fn = new function();
        Login_form lf = new Login_form();
      

        string query;
        public uc_UserManag()
        {
            InitializeComponent();
        }

        public bool IsAddUserButtonVisible
        {
            get { return btn_addUser.Visible; }
            set
            {

                btn_addUser.Show();
                btn_addUser.BringToFront();
                btn_addUser.Visible = true; 
                chckbx_agrmnt.Visible = true;
                btn_addUser.Enabled = true;
                chckbx_agrmnt.Enabled = true;
                cmbox_secQ.Enabled = true;
                btn_reset.Visible = false;
                btn_reset.Enabled = false;
                btn_delUser.Visible = false;
                btn_delUser.Enabled = false;
            }

        }

        public bool IsDelUserButtonVisible
        {
            get { return btn_delUser.Visible; }
            set
            {
                btn_delUser.Visible = true;
                btn_delUser.Enabled = true;
                btn_addUser.Show();
                btn_addUser.BringToFront();
                btn_addUser.Visible = true;

                chckbx_agrmnt.Visible = true;
                btn_addUser.Enabled = true;
                chckbx_agrmnt.Enabled = true;
                cmbox_secQ.Enabled = true;
                btn_reset.Visible = false;
                btn_reset.Enabled = false;
            }
        }
        public bool IsResetUserButtonVisible

        {
            get { return btn_reset.Visible; }
            set
            {
                btn_reset.BringToFront();
                btn_reset.Visible = true;
                btn_reset.Enabled = true;
                btn_delUser.Visible = false;
                btn_delUser.Enabled = false;
                cmbox_secQ.Enabled = false;
                chckbx_agrmnt.Visible = false;
                chckbx_agrmnt.Enabled = false;
            }
        }

        private void clearAll() {
            txtbx_fullName.Clear();
            txtbx_username.Clear();
            txtbx_CNIC.Clear();
            txtbx_password.Clear();
            txtbx_repassword.Clear();
            cmbox_secQ.Text = "";
            txtbx_secA.Clear();
        }

        
        private (string salt, string hashedPassword) HashPassword(string password)
        {
            byte[] saltBytes = new byte[32];

            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(saltBytes);
            }

            string salt = Convert.ToBase64String(saltBytes);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
            byte[] hashBytes;

            using (SHA256 sha256 = SHA256.Create())
            {
                hashBytes = sha256.ComputeHash(passwordBytes);
            }

            string hashedPassword = Convert.ToBase64String(hashBytes);

            return (salt, hashedPassword);
        }

        private void Reset_pswd()
        {
            query = "select * from users where username='"+txtbx_username.Text+"';";
            SqlCommand command = fn.getInstance();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            string Username = "";
            while (reader.Read())
            {
                Username = reader["Username"].ToString();
            }
            reader.Close();
            if (txtbx_username.Text == Username && txtbx_username.Text != "")
            {

                (string salt, string hashedPassword) = HashPassword(txtbx_repassword.Text);
                query = "UPDATE users SET FullName='" + txtbx_fullName.Text + "', Username='" + txtbx_username.Text + "', Password='" + hashedPassword + "', salt='" + salt+ "', CNIC='" + txtbx_CNIC.Text + "' where  sec_A='" + txtbx_secA.Text + "';"; 
                fn.setData(query);
                MessageBox.Show("Password Reset Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();


                Form parentForm = this.ParentForm;
                parentForm.Close();
                lf.Show();


                //Dashboard_Form ds = new Dashboard_Form();
                //ds.btn_logoutfn("run");
                //lf.Show();

            }
            else
            {
                MessageBox.Show("Invalid Security Question or Answer!");
                clearAll();
            }
            command.Dispose();
            fn.closeInstance();
        }

        private void Del_User()
        {
            query = "select * from users where username='" + txtbx_username.Text + "';";
            SqlCommand command = fn.getInstance();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            string Username = "";
            while (reader.Read())
            {
                Username = reader["Username"].ToString();
            }
            reader.Close();
            if (txtbx_username.Text == Username && txtbx_username.Text != "")
            {

                query = "Delete users where username='" + txtbx_username.Text +"';";
                if (MessageBox.Show("Are you sure you want to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    fn.setData(query);
                }
                MessageBox.Show("User Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();



            }
            else
            {
                MessageBox.Show("Invalid Security Question or Answer!");
                clearAll();
            }
            command.Dispose();
            fn.closeInstance();
        }

        private void lbl_rmvItems_Click(object sender, EventArgs e)
        {

           
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            if (txtbx_username.Text == "" || txtbx_fullName.Text == "" || txtbx_password.Text == "" || txtbx_repassword.Text == "")
            {
                MessageBox.Show("Fill all mandatory fields, if any is empty.");
            }
            else if (txtbx_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be 8 characters long");
            }
            else if (txtbx_password.Text != txtbx_repassword.Text)
            {
                MessageBox.Show("Password doesn't match");
            }
            else if (chckbx_agrmnt.Checked != true)
            {
                MessageBox.Show("Please Agree to the terms and condtitions.");
            }
            else if (cmbox_secQ.Text=="") { 
                MessageBox.Show("Please select a Security Question.");

            }
            else if (txtbx_secA.Text=="")
            {
                MessageBox.Show("Please enter the Security Answer.");
            }
            else if (txtbx_username.Text != "" && txtbx_fullName.Text != "" && txtbx_CNIC.Text.Length == 13 && txtbx_password.Text.Length >= 8 && txtbx_password.Text == txtbx_repassword.Text && chckbx_agrmnt.Checked && cmbox_secQ.Text!="" && txtbx_secA.Text!="")
            {
               

                (string salt, string hashedPassword) = HashPassword(txtbx_repassword.Text);


                string query = "INSERT INTO users (FullName, Username, CNIC, Password, Salt, sec_Q, sec_A) VALUES ('" + txtbx_fullName.Text + "','" + txtbx_username.Text + "','" + txtbx_CNIC.Text + "','" + hashedPassword + "','" +salt + "','" + cmbox_secQ.Text + "','" + txtbx_secA.Text + "')";// " + "'" + txtbx_fullName.Text + "', '" + txtbx_username.Text + "', '" + txtbx_CNIC.Text + "', '" + txtbx_repassword.Text + "')";
                fn.setData(query);
                MessageBox.Show("You have registered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
                Form parentForm = this.ParentForm;
                parentForm.Close();
                lf.Show();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (txtbx_username.Text == "" || txtbx_password.Text == "" || txtbx_repassword.Text == "")
                MessageBox.Show("Fill all mandatory fields, if any is empty.");
            else if (txtbx_password.Text.Length < 8 || txtbx_repassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be 8 characters long");
            }
            
            else if (txtbx_password.Text != txtbx_repassword.Text)
            {
                MessageBox.Show("Password doesn't match");
            }
            
            else if (string.IsNullOrWhiteSpace(txtbx_secA.Text))
            {
                MessageBox.Show("Please enter the Security Answer.");
            }
            else if (txtbx_username.Text != "" && txtbx_CNIC.Text.Length == 13 && txtbx_password.Text.Length >= 8 && txtbx_password.Text == txtbx_repassword.Text && !string.IsNullOrWhiteSpace(txtbx_secA.Text))
            {
                Reset_pswd();

            }

        }

        private void uc_UserManag_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(chckbx_agrmnt, "New User must Agree to terms and conditions.");
            toolTip1.SetToolTip(txtbx_fullName, "Enter your Full Name Here.");
            toolTip1.SetToolTip(txtbx_username, "Enter your Unique Username here, to Reset enter the username you have.");
            toolTip1.SetToolTip(txtbx_password, "Enter your Password here, must be atleast 8 character long.");
            toolTip1.SetToolTip(txtbx_repassword, "Re-Enter your password, must match to above.");
            toolTip1.SetToolTip(txtbx_secA, "Caution! If Sec. Answer Forgotten account can't be recovered, contact DBA.");
            

        }

        private void txtbx_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbx_repassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delUser_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtbx_username.Text))
                MessageBox.Show("Provide Uaername to Proceed");
            
            else 
                Del_User();

        }

        private void txtbx_password_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void showpass_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass_checkbox.Checked)
            {
                txtbx_secA.PasswordChar = '\0';
                txtbx_repassword.PasswordChar = '\0';
                txtbx_password.PasswordChar = '\0';
            }
            else
            {
                txtbx_secA.PasswordChar = '*';
                txtbx_repassword.PasswordChar = '*';
                txtbx_password.PasswordChar = '*';
            }
        }

       
    }
}
