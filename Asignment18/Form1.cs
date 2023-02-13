using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInvNum.Text = new Random().Next(1000000,9999999)+"";
            txtDate.Text = DateTime.Now.ToString("MMM/d/yyyy hh:mm:ss tt");
            Dictionary<int, string> itemsData = new Dictionary<int, string>();
            itemsData.Add(16000, "لاب توب DELL");
            itemsData.Add(17000, "لاب توب HP");
            itemsData.Add(15500, "لاب توب سامسونج");
            itemsData.Add(150, "كيبورد عادي");
            itemsData.Add(80, "ماوس عادي");
            itemsData.Add(250, "كيبورد DELL");
            itemsData.Add(120, "ماوس DELL");
            itemsData.Add(280, "كيبورد HP");
            itemsData.Add(130, "ماوس HP");
            itemsData.Add(950, "طابعة حبر HP");
            itemsData.Add(1650, "طابعة ليزر HP");
            itemsData.Add(400, "راوتر انترنت"); txtName.Select();
            cbxItems.DataSource = new BindingSource(itemsData,null);
            cbxItems.DisplayMember="value";
            cbxItems.ValueMember = "key";
            txtPrice.Text = cbxItems.SelectedValue+"";
            txtName.Focus();
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = cbxItems.SelectedValue + "";
        }        

        private void txtDate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                txtDate.ContextMenu = new ContextMenu();
            }
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Apps)
            {
                txtDate.ContextMenu = new ContextMenu();
            }
        }

        private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
        private void txtTotal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                txtTotal.ContextMenu = new ContextMenu();
            }
        }

        private void txtTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Apps)
            {
                txtTotal.ContextMenu = new ContextMenu();
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            object[] InvoiceData = {cbxItems.Text, txtQty.Text, txtPrice.Text,(int.Parse(txtPrice.Text)*int.Parse(txtQty.Text)) };
            dgvInvoice.Rows.Add(InvoiceData);
            txtTotal.Text = (int.Parse(txtTotal.Text)+(int.Parse(txtPrice.Text)*int.Parse(txtQty.Text))) + "";
        }
    }
}
