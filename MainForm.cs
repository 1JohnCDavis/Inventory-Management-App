using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace John_Davis_Inventory_App
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            mainPartsDataGridView.DataSource = Inventory.AllParts;
            mainProductsDataGridView.DataSource = Inventory.Products;
            mainPartsDataGridView.ClearSelection();
            mainProductsDataGridView.ClearSelection();

        }
        
        //Parts search button method
        private void mainPartsSearchBtn_Click(object sender, EventArgs e)
        {
            mainPartsDataGridView.ClearSelection();
            bool found = false;
            if (searchBoxParts.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(searchBoxParts.Text.ToUpper()))
                    {
                        mainPartsDataGridView.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
            searchBoxParts.Clear();
        }
        //Products search button method
        private void mainProductsSearchBtn_Click(object sender, EventArgs e)
        {
            mainProductsDataGridView.ClearSelection();
            //mainProductsDataGridView.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            //mainProductsDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            bool found = false;
            if (searchBoxProducts.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(searchBoxProducts.Text.ToUpper()))
                    {
                        mainProductsDataGridView.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
            searchBoxProducts.Clear();
        }

        private void mainExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPartsDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);

            if (deletePartDialogResult == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in mainPartsDataGridView.SelectedRows)
                {
                    mainPartsDataGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void mainProductsDeleteBtn_Click(object sender, EventArgs e)
        {
            Product product = (Product)mainProductsDataGridView.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Oops.  A product that has a part assigned to it cannot be deleted.");
                return;
            }
            foreach (DataGridViewRow row in mainProductsDataGridView.SelectedRows)
            {
                mainProductsDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void mainPartsAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddPartForm().ShowDialog();
        }

        private void mainProductsAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProduct().ShowDialog();
        }

        private void mainPartsModifyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mainPartsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(John_Davis_Inventory_App.Inhouse))
            {
                Inhouse inhouse = (Inhouse)mainPartsDataGridView.CurrentRow.DataBoundItem;
                new ModifyPartForm(inhouse).ShowDialog();
            }
            else
            {
                Outsourced outsourced = (Outsourced)mainPartsDataGridView.CurrentRow.DataBoundItem;
                new ModifyPartForm(outsourced).ShowDialog();
            }
        }

        private void mainProductsModifyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = (Product)mainProductsDataGridView.CurrentRow.DataBoundItem;
            new ModifyProduct(product).ShowDialog();
        }
    }
}
