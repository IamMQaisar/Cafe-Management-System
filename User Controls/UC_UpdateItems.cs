using System;
using System.Collections;
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
    public partial class UC_UpdateItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "update items set name='" + txtBx_itemName.Text + "',category='" + txtBx_category.Text + "',price=" + txtBx_Price.Text + "where iid=" + id + "";
            fn.setData(query);
            loadData();

            txtBx_category.Clear();
            txtBx_itemName.Clear();
            txtBx_Price.Clear();
        }
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool Check = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value != null;

                if (Check)
                {
                    if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                        String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                        txtBx_category.Text = category;
                        txtBx_itemName.Text = name;
                        txtBx_Price.Text = price.ToString();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select any Item Row.");
            }
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtBx_search.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "Select * From Items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
