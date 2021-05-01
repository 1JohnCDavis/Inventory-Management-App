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
    partial class ModifyProduct : Form
    {
        private bool AllowSave()
        {
            return (!string.IsNullOrWhiteSpace(modifyProductPartNameTextBox.Text) && !string.IsNullOrWhiteSpace(modifyProductPartInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyProductPartPriceCostTextBox.Text) && !string.IsNullOrWhiteSpace(modifyProductPartMaxTextBox.Text) && !string.IsNullOrWhiteSpace(modifyProductPartMinTextBox.Text));
        }

        //This is for the grid list AssociatedParts

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

        public ModifyProduct(Product product)
        {
            InitializeComponent();
            modifyProductAllCandidatePartsDataGridView.DataSource = Inventory.AllParts;
            foreach (Product prod in Inventory.Products)
            {
                if (prod.Equals(product))
                {
                    ProductParts = prod.AssociatedParts;
                    //modifyProductPartsAssociatedDataGridView.DataSource = prod.AssociatedParts;
                    break;
                }
                    
            }

            modifyProductPartsAssociatedDataGridView.DataSource = ProductParts;

            //modifyProductPartsAssociatedDataGridView.DataSource = ProductParts;
            modifyProductAllCandidatePartsDataGridView.ClearSelection();
            modifyProductPartsAssociatedDataGridView.ClearSelection();

            modifyProductPartNameTextBox.BackColor = System.Drawing.Color.Salmon;
            modifyProductPartInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            modifyProductPartPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            modifyProductPartMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            modifyProductPartMinTextBox.BackColor = System.Drawing.Color.Salmon;

            textBoxModifyProductPartID = product.ProductID;
            textBoxModifyProductPartName = product.Name;
            textBoxModifyProductPartInventory = product.InStock;
            textBoxModifyProductPartPriceCost = product.Price;
            textBoxModifyProductPartMax = product.Max;
            textBoxModifyProductPartMin = product.Min;
            
        }

        private void modifyProductSearchBtn_Click(object sender, EventArgs e)
        {
            modifyProductAllCandidatePartsDataGridView.ClearSelection();
            bool found = false;
            if (modifyProductSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(modifyProductSearchBox.Text.ToUpper()))
                    {
                        modifyProductAllCandidatePartsDataGridView.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
            modifyProductSearchBox.Clear();
        }

        private void modifyProductAllCandidatePartsAddBtn_Click(object sender, EventArgs e)
        {
            Part productPart = (Part)modifyProductAllCandidatePartsDataGridView.CurrentRow.DataBoundItem;
            ProductParts.Add(productPart);
            modifyProductPartsAssociatedDataGridView.Refresh();
        }
        
        private void modifyProductPartsAssociatedDeleteBtn_Click(object sender, EventArgs e)
        {        
          
            if (!modifyProductPartsAssociatedDataGridView.Rows.Count.Equals(0))
            {
                DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);

                if (deletePartDialogResult == DialogResult.Yes)
                {
                    Part productPart = (Part)modifyProductPartsAssociatedDataGridView.CurrentRow.DataBoundItem;
                    ProductParts.Remove(productPart);
                }                    
            }
            else
            {
                MessageBox.Show("Cannot remove parts that are not present.");
            }               
        }

        private void modifyProductPartsAssociatedSaveBtn_Click(object sender, EventArgs e)
        {
            if (textBoxModifyProductPartMax < textBoxModifyProductPartMin)
            {
                MessageBox.Show("Minimum should be less than maximum.");
                return;
            }
            if (textBoxModifyProductPartInventory < textBoxModifyProductPartMin || textBoxModifyProductPartInventory > textBoxModifyProductPartMax)
            {
                MessageBox.Show("Inventory should be between minimum and maximum.");
                return;
            }
            Product updatedProduct = new Product(textBoxModifyProductPartID, textBoxModifyProductPartName, textBoxModifyProductPartPriceCost, textBoxModifyProductPartInventory, textBoxModifyProductPartMin, textBoxModifyProductPartMax);

            foreach (Part newPart in productParts)
            {
                updatedProduct.AddAssociatedPart(newPart);
            }

            Inventory.UpdateProduct(textBoxModifyProductPartID, updatedProduct);
            this.Hide();
            new MainForm().ShowDialog();
        }

        private void modifyProductPartsAssociatedCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().ShowDialog();
        }

        private void modifyProductPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(modifyProductPartNameTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyProductPartNameTextBox.Text))
            {
                modifyProductPartNameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyProductPartNameTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }

        private void modifyProductPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(modifyProductPartInventoryTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyProductPartInventoryTextBox.Text))
            {
                modifyProductPartInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyProductPartInventoryTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }

        private void modifyProductPartPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(modifyProductPartPriceCostTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyProductPartPriceCostTextBox.Text))
            {
                modifyProductPartPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyProductPartPriceCostTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }

        private void modifyProductPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(modifyProductPartMaxTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyProductPartMaxTextBox.Text))
            {
                modifyProductPartMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyProductPartMaxTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }

        private void modifyProductPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(modifyProductPartMinTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyProductPartMinTextBox.Text))
            {
                modifyProductPartMinTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyProductPartMinTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyProductPartsAssociatedSaveBtn.Enabled = AllowSave();
        }
    }
}
