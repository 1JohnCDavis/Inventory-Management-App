using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace John_Davis_Inventory_App
{
    partial class AddPartForm : Form
    {
        bool isInhouse;

        private bool AllowSave()
        {
            return (!string.IsNullOrWhiteSpace(addPartNameTextBox.Text) && !string.IsNullOrWhiteSpace(addPartInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addPartPriceCostTextBox.Text) && !string.IsNullOrWhiteSpace(addPartMaxTextBox.Text) && !string.IsNullOrWhiteSpace(addPartMinTextBox.Text)) &&
                (!(string.IsNullOrWhiteSpace(addPartMachineIDTextBox.Text) || (isInhouse && !Int32.TryParse(addPartMachineIDTextBox.Text, out _))));
        }

        private void checkOnRBSwitch()
        {
            if (string.IsNullOrWhiteSpace(addPartMachineIDTextBox.Text) || (isInhouse && !Int32.TryParse(addPartMachineIDTextBox.Text, out _)))
            {
                addPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else if ((!isInhouse && Int32.TryParse(addPartMachineIDTextBox.Text, out _)) || string.IsNullOrWhiteSpace(addPartMachineIDTextBox.Text))
            {
                addPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartMachineIDTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartSaveBtn.Enabled = AllowSave();
        }

        //Empty constructor

        public AddPartForm()
        {
            InitializeComponent();

            addPartNameTextBox.BackColor = System.Drawing.Color.Salmon;
            addPartInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            addPartPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            addPartMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            addPartMinTextBox.BackColor = System.Drawing.Color.Salmon;
            addPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
        }

        //Inhouse part constructor

        public AddPartForm(Inhouse inhouse)
        {
            InitializeComponent();

            textBoxAddPartID = inhouse.PartID;
            textBoxAddPartName = inhouse.Name;
            textBoxAddPartInventory = inhouse.InStock;
            textBoxAddPartPriceCost = inhouse.Price;
            textBoxAddPartMax = inhouse.Max;
            textBoxAddPartMin = inhouse.Min;
            textBoxAddPartMachineID = inhouse.MachineID.ToString();

            if (Inventory.CurrentPart is Inhouse)
            {
                Inhouse temp = (Inhouse)Inventory.CurrentPart;
                addPartMachineIDTextBox.Text = temp.MachineID.ToString();
                isInhouse = true;
                addPartInHouseRadioBtn.Checked = true;
            }
            else
            {
                Outsourced temp = (Outsourced)Inventory.CurrentPart;
                addPartMachineIDTextBox.Text = temp.CompanyName;
                isInhouse = false;
                addPartOutSourcedRadioBtn.Checked = true;
            }
        }

        //Outsourced part constructor

        public AddPartForm(Outsourced outsourced)
        {
            InitializeComponent();

            textBoxAddPartID = outsourced.PartID;
            textBoxAddPartName = outsourced.Name;
            textBoxAddPartInventory = outsourced.InStock;
            textBoxAddPartPriceCost = outsourced.Price;
            textBoxAddPartMax = outsourced.Max;
            textBoxAddPartMin = outsourced.Min;
            textBoxAddPartMachineID = outsourced.CompanyName;
            addPartInHouseRadioBtn.Checked = true;
        }
        
        //Button events

        private void addPartInHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            addPartMachineIDLabel.Text = "Machine ID";
            isInhouse = true;
            checkOnRBSwitch();
        }

        private void addPartOutSourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            addPartMachineIDLabel.Text = "Company name";
            isInhouse = false;
            checkOnRBSwitch();
        }

        private void addPartSaveBtn_Click(object sender, EventArgs e)
        {
            //Exception message boxes working great!

            //try
            //{
            //    if (!Decimal.TryParse(addPartPriceCostTextBox.Text, out _))
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
            //    if (Int32.TryParse(addPartNameTextBox.Text, out _))
            //    {
            //        MessageBox.Show("Name should be a string value");
            //        return;
            //    }
            //}
            //catch
            //{

            //}


            try
            {
                if (textBoxAddPartMax < textBoxAddPartMin)
                {
                    MessageBox.Show("Minimum should be less than maximum.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter an integer value for both minimum and maximum.");
            }
            try
            {
                if (textBoxAddPartInventory < textBoxAddPartMin || textBoxAddPartInventory > textBoxAddPartMax)
                {
                    MessageBox.Show("Inventory should be between minimum and maximum.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter an integer value for inventory.");
            }
            try
            {
                if (addPartInHouseRadioBtn.Checked)
                {
                    Inhouse inHouse = new Inhouse((Inventory.AllParts.Count + 1), textBoxAddPartName, textBoxAddPartPriceCost, textBoxAddPartInventory,
                                                    textBoxAddPartMin, textBoxAddPartMax, int.Parse(textBoxAddPartMachineID));
                    Inventory.AddPart(inHouse);
                }
                else
                {
                    if (textBoxAddPartMax < textBoxAddPartMin)
                    {
                        MessageBox.Show("Minimum should be less than maximum.");
                        return;
                    }
                    if (textBoxAddPartInventory < textBoxAddPartMin || textBoxAddPartInventory > textBoxAddPartMax)
                    {
                        MessageBox.Show("Inventory should be between minimum and maximum.");
                        return;
                    }
                    Outsourced outsourced = new Outsourced((Inventory.AllParts.Count), textBoxAddPartName, textBoxAddPartPriceCost, textBoxAddPartInventory,
                                                    textBoxAddPartMin, textBoxAddPartMax, textBoxAddPartMachineID);
                    Inventory.AddPart(outsourced);
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Name should be a string and price/inventory/min/max/machineID should be numbers.");
            }
            this.Hide();
            MainForm f1 = new MainForm();
            f1.Show();
        }

        private void addPartCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().ShowDialog();
        }

        private void addPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(addPartNameTextBox.Text, out _) || string.IsNullOrWhiteSpace(addPartNameTextBox.Text))
            {
                addPartNameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartNameTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartSaveBtn.Enabled = AllowSave();
        }

        private void addPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(addPartInventoryTextBox.Text, out _) || string.IsNullOrWhiteSpace(addPartInventoryTextBox.Text))
            {
                addPartInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartInventoryTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartSaveBtn.Enabled = AllowSave();
        }

        private void addPartPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(addPartPriceCostTextBox.Text, out _) || string.IsNullOrWhiteSpace(addPartPriceCostTextBox.Text))
            {
                addPartPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartPriceCostTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartSaveBtn.Enabled = AllowSave();
        }

        private void addPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(addPartMaxTextBox.Text, out _) || string.IsNullOrWhiteSpace(addPartMaxTextBox.Text))
            {
                addPartMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartMaxTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartSaveBtn.Enabled = AllowSave();
        }

        private void addPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(addPartMinTextBox.Text, out _) || string.IsNullOrWhiteSpace(addPartMinTextBox.Text))
            {
                addPartMinTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartMinTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartSaveBtn.Enabled = AllowSave();
        }

        private void addPartMachineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((isInhouse && !Int32.TryParse(addPartMachineIDTextBox.Text, out _)) || string.IsNullOrWhiteSpace(addPartMachineIDTextBox.Text))
            {
                addPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            //else if ((!isInhouse && Int32.TryParse(addPartMachineIDTextBox.Text, out _)) || string.IsNullOrWhiteSpace(addPartMachineIDTextBox.Text))
            //    {
            //        addPartMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
            //    }
            else
            {
                addPartMachineIDTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartSaveBtn.Enabled = AllowSave();
        }

    }
}
