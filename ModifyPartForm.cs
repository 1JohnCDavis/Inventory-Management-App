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
    partial class ModifyPartForm : Form
    {
        bool isInhouse;

        private bool AllowSave()
        {
            return (!string.IsNullOrWhiteSpace(modifyPartNameTextBox.Text) && !string.IsNullOrWhiteSpace(modifyPartInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyPartPriceCostTextBox.Text) && !string.IsNullOrWhiteSpace(modifyPartMaxTextBox.Text) && !string.IsNullOrWhiteSpace(modifyPartMinTextBox.Text)) &&
                (!(string.IsNullOrWhiteSpace(modifyPartMachineIDTextBox.Text) || (isInhouse && !Int32.TryParse(modifyPartMachineIDTextBox.Text, out _))));
        }

        private void checkOnRBSwitch()
        {
            if (string.IsNullOrWhiteSpace(modifyPartMachineIDTextBox.Text) || (isInhouse && !Int32.TryParse(modifyPartMachineIDTextBox.Text, out _)))
            {
                modifyPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else if ((!isInhouse && Int32.TryParse(modifyPartMachineIDTextBox.Text, out _)) || string.IsNullOrWhiteSpace(modifyPartMachineIDTextBox.Text))
            {
                modifyPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyPartMachineIDTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartSaveBtn.Enabled = AllowSave();
        }
        
        //Empty constructor
        public ModifyPartForm()
        {
            InitializeComponent();

            modifyPartNameTextBox.BackColor = System.Drawing.Color.Salmon;
            modifyPartInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            modifyPartPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            modifyPartMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            modifyPartMinTextBox.BackColor = System.Drawing.Color.Salmon;
            modifyPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
        }

        //Inhouse part constructor

        public ModifyPartForm(Inhouse inhouse)
        {
            InitializeComponent();

            textBoxModifyPartID = inhouse.PartID;
            textBoxModifyPartName = inhouse.Name;
            textBoxModifyPartInventory = inhouse.InStock;
            textBoxModifyPartPriceCost = inhouse.Price;
            textBoxModifyPartMax = inhouse.Max;
            textBoxModifyPartMin = inhouse.Min;
            textBoxModifyPartMachineID = inhouse.MachineID.ToString();

        }

        //Outsourced part constructor

        public ModifyPartForm(Outsourced outsourced)
        {
            InitializeComponent();

            textBoxModifyPartID = outsourced.PartID;
            textBoxModifyPartName = outsourced.Name;
            textBoxModifyPartInventory = outsourced.InStock;
            textBoxModifyPartPriceCost = outsourced.Price;
            textBoxModifyPartMax = outsourced.Max;
            textBoxModifyPartMin = outsourced.Min;
            textBoxModifyPartMachineID = outsourced.CompanyName;
            modifyPartOutSourcedRadioBtn.Checked = true;
        }

        //Button events

        private void modifyPartInHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartMachineIDLabel.Text = "Machine ID";
            isInhouse = true;
            checkOnRBSwitch();
        }

        private void modifyPartOutSourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartMachineIDLabel.Text = "Company name";
            isInhouse = false;
            checkOnRBSwitch();
        }

        private void modifyPartSaveBtn_Click(object sender, EventArgs e)
        {
            //Exception message boxes working great!

            //try
            //{
            //    if (!Decimal.TryParse(modifyPartPriceCostTextBox.Text, out _))
            //    {
            //        MessageBox.Show("Price should be a decimal value.");
            //        return;
            //    }
            //}
            //catch
            //{

            //}

            //try
            //{
            //    if (Int32.TryParse(modifyPartNameTextBox.Text, out _))
            //    {
            //        MessageBox.Show("Name should be a string value");
            //        return;
            //    }
            //}
            //catch
            //{

            //}

            if (textBoxModifyPartMax < textBoxModifyPartMin)
            {
                MessageBox.Show("Minimum should be less than maximum.");
                return;
            }
            if (textBoxModifyPartInventory < textBoxModifyPartMin || textBoxModifyPartInventory > textBoxModifyPartMax)
            {
                MessageBox.Show("Inventory should be between minimum and maximum.");
                return;
            }

            Part newPart;
            if (modifyPartInHouseRadioBtn.Checked)
            {
                newPart = new Inhouse(Convert.ToInt32(modifyPartIDTextBox.Text), modifyPartNameTextBox.Text, Convert.ToDecimal(modifyPartPriceCostTextBox.Text),
                                    Convert.ToInt32(modifyPartInventoryTextBox.Text), Convert.ToInt32(modifyPartMinTextBox.Text), Convert.ToInt32(modifyPartMaxTextBox.Text),
                                    Convert.ToInt32(modifyPartMachineIDTextBox.Text));
                Inventory.UpdateInHouse(Convert.ToInt32(modifyPartIDTextBox.Text), (Inhouse) newPart);
                //modifyPartInHouseRadioBtn.Checked = true;
            }
            else
            {
                newPart = new Outsourced(Convert.ToInt32(modifyPartIDTextBox.Text), modifyPartNameTextBox.Text, Convert.ToDecimal(modifyPartPriceCostTextBox.Text),
                                    Convert.ToInt32(modifyPartInventoryTextBox.Text), Convert.ToInt32(modifyPartMinTextBox.Text), Convert.ToInt32(modifyPartMaxTextBox.Text),
                                    modifyPartMachineIDTextBox.Text);
                Inventory.UpdateOutsourced(Convert.ToInt32(modifyPartIDTextBox.Text), (Outsourced) newPart);
                //modifyPartOutSourcedRadioBtn.Checked = true;
            }
            for (int index = 0; index < Inventory.AllParts.Count; index++)
            {
                if(Inventory.AllParts.ElementAt(index).PartID == newPart.PartID)
                {
                    Inventory.AllParts.Insert(index, newPart);
                    Inventory.AllParts.RemoveAt(index + 1);
                    break;
                }
            }            
            
            this.Hide();
            MainForm f1 = new MainForm();
            f1.Show();
        }

        private void modifyPartCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().ShowDialog();
        }

        private void modifyPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(modifyPartNameTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyPartNameTextBox.Text))
            {
                modifyPartNameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyPartNameTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartSaveBtn.Enabled = AllowSave();
        }

        private void modifyPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(modifyPartInventoryTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyPartInventoryTextBox.Text))
            {
                modifyPartInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyPartInventoryTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartSaveBtn.Enabled = AllowSave();
        }

        private void modifyPartPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(modifyPartPriceCostTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyPartPriceCostTextBox.Text))
            {
                modifyPartPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyPartPriceCostTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartSaveBtn.Enabled = AllowSave();
        }

        private void modifyPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(modifyPartMaxTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyPartMaxTextBox.Text))
            {
                modifyPartMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyPartMaxTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartSaveBtn.Enabled = AllowSave();
        }

        private void modifyPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(modifyPartMinTextBox.Text, out _) || string.IsNullOrWhiteSpace(modifyPartMinTextBox.Text))
            {
                modifyPartMinTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyPartMinTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartSaveBtn.Enabled = AllowSave();
        }

        private void modifyPartMachineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((isInhouse && !Int32.TryParse(modifyPartMachineIDTextBox.Text, out _)) || string.IsNullOrWhiteSpace(modifyPartMachineIDTextBox.Text))
            {
                modifyPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            //else if ((!isInhouse && Int32.TryParse(modifyPartMachineIDTextBox.Text, out _)) || string.IsNullOrWhiteSpace(modifyPartMachineIDTextBox.Text))
            //{
            //    modifyPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
            //}
            else
            {
                modifyPartMachineIDTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartSaveBtn.Enabled = AllowSave();
        }

        
    }

}



