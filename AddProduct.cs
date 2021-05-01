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
    partial class AddProduct : Form
    {
        bool isInhouse;

        private bool AllowSave()
        {
            return (!string.IsNullOrWhiteSpace(addProductPartNameTextBox.Text) && !string.IsNullOrWhiteSpace(addProductPartInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addProductPartPriceCostTextBox.Text) && !string.IsNullOrWhiteSpace(addProductPartMaxTextBox.Text) && !string.IsNullOrWhiteSpace(addProductPartMinTextBox.Text));
        }

        private static BindingList<Part> productParts = new BindingList<Part>();
        public static BindingList<Part> ProductParts
        {
            get
            {
                return productParts;
            }
            set
            {
                productParts = value;
            }
        }


        public AddProduct()
        {
            InitializeComponent();

            addProductAllCandidatePartsDataGridView.DataSource = Inventory.AllParts;
            addProductPartsAssociatedDataGridView.DataSource = ProductParts;
            addProductAllCandidatePartsDataGridView.ClearSelection();
            addProductPartsAssociatedDataGridView.ClearSelection();

            ProductParts.Clear();

            addProductPartNameTextBox.BackColor = System.Drawing.Color.Salmon;
            addProductPartInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            addProductPartPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            addProductPartMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            addProductPartMinTextBox.BackColor = System.Drawing.Color.Salmon;
            
        }

        private void addProductSearchBtn_Click(object sender, EventArgs e)
        {
            addProductAllCandidatePartsDataGridView.ClearSelection();
            bool found = false;
            if (addProductSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(addProductSearchBox.Text.ToUpper()))
                    {
                        addProductAllCandidatePartsDataGridView.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
            addProductSearchBox.Clear();
        }

        private void addProductAllCandidatePartsAddBtn_Click(object sender, EventArgs e)
        {
            Part productParts = (Part)addProductAllCandidatePartsDataGridView.CurrentRow.DataBoundItem;
            ProductParts.Add(productParts);
        }

        private void addProductPartsAssociatedDeleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addProductPartsAssociatedDataGridView.SelectedRows)
            {
                addProductPartsAssociatedDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void addProductPartsAssociatedSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAddProductPartMax < textBoxAddProductPartMin)
                {
                    MessageBox.Show("Minimum should be less than maximum.");
                    return;
                }

                if (textBoxAddProductPartInventory < textBoxAddProductPartMin || textBoxAddProductPartInventory > textBoxAddProductPartMax)
                {
                    MessageBox.Show("Inventory should be between minimum and maximum.");
                    return;
                }

                Product product = new Product((Inventory.Products.Count), textBoxAddProductPartName, textBoxAddProductPartPriceCost, textBoxAddProductPartInventory, textBoxAddProductPartMin, textBoxAddProductPartMax);
                

                foreach (Part newPart in ProductParts)
                {
                    product.AddAssociatedPart(newPart);
                }
                Inventory.AddProduct(product);

            }
         
            catch (FormatException)
            {
                MessageBox.Show("Name should be a string and price/inventory/min/max should be numbers.");
            }
            this.Hide();
            new MainForm().ShowDialog();
        }

        private void addProductPartsAssociatedCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().ShowDialog();
        }

        private void addProductPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(addProductPartNameTextBox.Text, out _) || string.IsNullOrWhiteSpace(addProductPartNameTextBox.Text))
            {
                addProductPartNameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProductPartNameTextBox.BackColor = System.Drawing.Color.White;
            }
            addProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }

        private void addProductPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(addProductPartInventoryTextBox.Text, out _) || string.IsNullOrWhiteSpace(addProductPartInventoryTextBox.Text))
            {
                addProductPartInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProductPartInventoryTextBox.BackColor = System.Drawing.Color.White;
            }
            addProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }

        private void addProductPartPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(addProductPartPriceCostTextBox.Text, out _) || string.IsNullOrWhiteSpace(addProductPartPriceCostTextBox.Text))
            {
                addProductPartPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProductPartPriceCostTextBox.BackColor = System.Drawing.Color.White;
            }
            addProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }

        private void addProductPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(addProductPartMaxTextBox.Text, out _) || string.IsNullOrWhiteSpace(addProductPartMaxTextBox.Text))
            {
                addProductPartMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProductPartMaxTextBox.BackColor = System.Drawing.Color.White;
            }
            addProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }

        private void addProductPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(addProductPartMinTextBox.Text, out _) || string.IsNullOrWhiteSpace(addProductPartMinTextBox.Text))
            {
                addProductPartMinTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProductPartMinTextBox.BackColor = System.Drawing.Color.White;
            }
            addProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }
    }
}
