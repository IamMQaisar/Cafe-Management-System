using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DGVPrinterHelper;


namespace Cafe_Management_System.User_Controls
{
    public partial class uc_plcOrder : UserControl
    {
        function fn = new function();
        string query;
        public uc_plcOrder()
        {
            InitializeComponent();
        }
        private void uc_plcOrder_Load(object sender, EventArgs e)
        {
            if (txtbx_itemname.Text == "" || txtbx_price.Text == "")
            {
                txtNumUPDwn_quantity.Enabled = false;
            }
        }
        
        private void clearAll()
        {

            txtNumUPDwn_quantity.ResetText();
            txtNumUPDwn_quantity.Value = 0;
            txtNumUPDwn_quantity.Minimum = 0;
            txtbx_total.Clear();
            txtbx_itemname.Clear();
            txtbx_price.Clear();

        }
        private void clearAll(string partial)
        {

            txtNumUPDwn_quantity.ResetText();
            txtNumUPDwn_quantity.Value = 0;
            txtNumUPDwn_quantity.Minimum = 0;
            txtbx_total.Clear();
            
        }

        protected int n, total = 0;
        private void btn_addtoCart_Click(object sender, EventArgs e)
        {
            if (txtbx_total.Text == "" || txtbx_itemname.Text == "" || txtbx_price.Text == "")
            {
                MessageBox.Show("Please Select an Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtNumUPDwn_quantity.Value == 0 || txtbx_total.Text == "0") 
            {
                MessageBox.Show("Please Select Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtbx_itemname.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtbx_price.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtNumUPDwn_quantity.Value;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtbx_total.Text;
                total += Int32.Parse(txtbx_total.Text);
                lbl_totalRs.Text ="Rs." + total.ToString();
                clearAll();
                txtNumUPDwn_quantity.Enabled = false;

            }

        }

        private void showitemList(string query)
        {
            lstbx_items.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lstbx_items.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
        private void cmbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbx_category.Text;
            query = "select name from items where category='" + category + "'";
           showitemList(query);

        }

        private void txtbx_search_TextChanged(object sender, EventArgs e)
        {
           
            string category = cmbx_category.Text;
            query = "select name from items where category='" + category + "' and name like '" + txtbx_search.Text+"%'";
            showitemList(query);
        }

        private void lstbx_items_SelectedIndexChanged(object sender, EventArgs e)
        {

            clearAll("partial");

            string text = lstbx_items.GetItemText(lstbx_items.SelectedItem);
            txtbx_itemname.Text = text;
            query = "select price from items where name='" + text + "'";
            DataSet ds = fn.getData(query);
            try { 
            txtbx_price.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int amount;
        bool cellSelected = false;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool Check = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value != null;

                if (Check)
                {
                    amount = Int32.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    cellSelected = true;

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Select any Item Row.");
            }
        }

       

        private void btn_rmv_Click(object sender, EventArgs e)
        {
            if (amount != 0)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {
                   MessageBox.Show("Select Item to Delete");
                }
                total -= amount;
                amount = 0;
                lbl_totalRs.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Select Item to Delete");
            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = String.Format("Date:{0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + lbl_totalRs.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            guna2DataGridView1.Rows.Clear();
            lbl_totalRs.Text = "Rs. " + total;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbx_itemname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtbx_itemname.Text) || !string.IsNullOrEmpty(txtbx_price.Text))
                {
                    txtNumUPDwn_quantity.Enabled = true;
                }
                else
                {
                    txtNumUPDwn_quantity.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtNumUPDwn_quantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quantity = Int64.Parse(txtNumUPDwn_quantity.Value.ToString());
            Int64 price = Int64.Parse(txtbx_price.Text);
            Int64 total = quantity * price;
            txtbx_total.Text = total.ToString();

        }
    }
}
