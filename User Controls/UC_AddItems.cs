using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.User_Controls
{
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,category,price) values('" + txtbx_itemName.Text + "','" + cmbx_category.Text + "','"+ txtbx_price.Text+"')";
            fn.setData(query);
            clearAll();
            cmbx_category.Focus();
        }
        public void clearAll()
        {
            txtbx_itemName.Clear();
            cmbx_category.SelectedIndex = -1;
            txtbx_price.Clear();
        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddItems_Load(object sender, EventArgs e)
        {

        }

        private void cmbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
