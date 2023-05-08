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
    public partial class uc_rmvItems : UserControl
    {
        function fn = new function();
        string query;
        public uc_rmvItems()
        {
            InitializeComponent();
        }

        private void delLabel_Click(object sender, EventArgs e)
        {
            delLabel.Text = "*Click the Row to Delete.";
            delLabel.ForeColor = Color.Red;

        }

        private void uc_rmvItems_Load(object sender, EventArgs e)
        {
            loadData();

        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtbx_search_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtbx_search.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Are you sure you want to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           if ( MessageBox.Show("Are you sure you want to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){

                try
                {
                    bool Check = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value != null;

                    if (Check)
                    {

                        if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                        {
                            int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            query = "delete from items where iid=" + id + "";
                            fn.setData(query);
                            loadData();
                        }
                    }
                }
                 catch
                    {
                        MessageBox.Show("Please Select the Row.");
                    }
            }
        }

        private void uc_rmvItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
