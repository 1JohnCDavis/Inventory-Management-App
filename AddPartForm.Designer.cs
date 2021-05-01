namespace John_Davis_Inventory_App
{
    partial class AddPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPartScreenLabel = new System.Windows.Forms.Label();
            this.addPartOutSourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.addPartInHouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartIDLabel = new System.Windows.Forms.Label();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartMachineIDLabel = new System.Windows.Forms.Label();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.addPartPriceCostLabel = new System.Windows.Forms.Label();
            this.addPartInventoryLabel = new System.Windows.Forms.Label();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.addPartCancelBtn = new System.Windows.Forms.Button();
            this.addPartSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartScreenLabel
            // 
            this.addPartScreenLabel.AutoSize = true;
            this.addPartScreenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartScreenLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartScreenLabel.Name = "addPartScreenLabel";
            this.addPartScreenLabel.Size = new System.Drawing.Size(81, 25);
            this.addPartScreenLabel.TabIndex = 0;
            this.addPartScreenLabel.Text = "Add Part";
            // 
            // addPartOutSourcedRadioBtn
            // 
            this.addPartOutSourcedRadioBtn.AutoSize = true;
            this.addPartOutSourcedRadioBtn.Location = new System.Drawing.Point(304, 10);
            this.addPartOutSourcedRadioBtn.Name = "addPartOutSourcedRadioBtn";
            this.addPartOutSourcedRadioBtn.Size = new System.Drawing.Size(116, 25);
            this.addPartOutSourcedRadioBtn.TabIndex = 2;
            this.addPartOutSourcedRadioBtn.TabStop = true;
            this.addPartOutSourcedRadioBtn.Text = "Outsourced";
            this.addPartOutSourcedRadioBtn.UseVisualStyleBackColor = true;
            this.addPartOutSourcedRadioBtn.CheckedChanged += new System.EventHandler(this.addPartOutSourcedRadioBtn_CheckedChanged);
            // 
            // addPartInHouseRadioBtn
            // 
            this.addPartInHouseRadioBtn.AutoSize = true;
            this.addPartInHouseRadioBtn.Location = new System.Drawing.Point(155, 10);
            this.addPartInHouseRadioBtn.Name = "addPartInHouseRadioBtn";
            this.addPartInHouseRadioBtn.Size = new System.Drawing.Size(98, 25);
            this.addPartInHouseRadioBtn.TabIndex = 1;
            this.addPartInHouseRadioBtn.TabStop = true;
            this.addPartInHouseRadioBtn.Text = "In-House";
            this.addPartInHouseRadioBtn.UseVisualStyleBackColor = true;
            this.addPartInHouseRadioBtn.CheckedChanged += new System.EventHandler(this.addPartInHouseRadioBtn_CheckedChanged);
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.Location = new System.Drawing.Point(255, 75);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.ReadOnly = true;
            this.addPartIDTextBox.Size = new System.Drawing.Size(149, 29);
            this.addPartIDTextBox.TabIndex = 4;
            // 
            // addPartMachineIDTextBox
            // 
            this.addPartMachineIDTextBox.Location = new System.Drawing.Point(255, 250);
            this.addPartMachineIDTextBox.Name = "addPartMachineIDTextBox";
            this.addPartMachineIDTextBox.Size = new System.Drawing.Size(149, 29);
            this.addPartMachineIDTextBox.TabIndex = 16;
            this.addPartMachineIDTextBox.TextChanged += new System.EventHandler(this.addPartMachineIDTextBox_TextChanged);
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.Location = new System.Drawing.Point(255, 215);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(101, 29);
            this.addPartMaxTextBox.TabIndex = 12;
            this.addPartMaxTextBox.TextChanged += new System.EventHandler(this.addPartMaxTextBox_TextChanged);
            // 
            // addPartPriceCostTextBox
            // 
            this.addPartPriceCostTextBox.Location = new System.Drawing.Point(255, 180);
            this.addPartPriceCostTextBox.Name = "addPartPriceCostTextBox";
            this.addPartPriceCostTextBox.Size = new System.Drawing.Size(149, 29);
            this.addPartPriceCostTextBox.TabIndex = 10;
            this.addPartPriceCostTextBox.TextChanged += new System.EventHandler(this.addPartPriceCostTextBox_TextChanged);
            // 
            // addPartInventoryTextBox
            // 
            this.addPartInventoryTextBox.Location = new System.Drawing.Point(255, 145);
            this.addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            this.addPartInventoryTextBox.Size = new System.Drawing.Size(149, 29);
            this.addPartInventoryTextBox.TabIndex = 8;
            this.addPartInventoryTextBox.TextChanged += new System.EventHandler(this.addPartInventoryTextBox_TextChanged);
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.Location = new System.Drawing.Point(255, 110);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(149, 29);
            this.addPartNameTextBox.TabIndex = 6;
            this.addPartNameTextBox.TextChanged += new System.EventHandler(this.addPartNameTextBox_TextChanged);
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.Location = new System.Drawing.Point(446, 215);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(101, 29);
            this.addPartMinTextBox.TabIndex = 14;
            this.addPartMinTextBox.TextChanged += new System.EventHandler(this.addPartMinTextBox_TextChanged);
            // 
            // addPartIDLabel
            // 
            this.addPartIDLabel.AutoSize = true;
            this.addPartIDLabel.Location = new System.Drawing.Point(198, 78);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(25, 21);
            this.addPartIDLabel.TabIndex = 3;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Location = new System.Drawing.Point(383, 218);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(37, 21);
            this.addPartMinLabel.TabIndex = 13;
            this.addPartMinLabel.Text = "Min";
            // 
            // addPartMachineIDLabel
            // 
            this.addPartMachineIDLabel.AutoSize = true;
            this.addPartMachineIDLabel.Location = new System.Drawing.Point(135, 253);
            this.addPartMachineIDLabel.Name = "addPartMachineIDLabel";
            this.addPartMachineIDLabel.Size = new System.Drawing.Size(88, 21);
            this.addPartMachineIDLabel.TabIndex = 15;
            this.addPartMachineIDLabel.Text = "Machine ID";
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Location = new System.Drawing.Point(184, 218);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(39, 21);
            this.addPartMaxLabel.TabIndex = 11;
            this.addPartMaxLabel.Text = "Max";
            // 
            // addPartPriceCostLabel
            // 
            this.addPartPriceCostLabel.AutoSize = true;
            this.addPartPriceCostLabel.Location = new System.Drawing.Point(134, 183);
            this.addPartPriceCostLabel.Name = "addPartPriceCostLabel";
            this.addPartPriceCostLabel.Size = new System.Drawing.Size(89, 21);
            this.addPartPriceCostLabel.TabIndex = 9;
            this.addPartPriceCostLabel.Text = "Price / Cost";
            // 
            // addPartInventoryLabel
            // 
            this.addPartInventoryLabel.AutoSize = true;
            this.addPartInventoryLabel.Location = new System.Drawing.Point(147, 148);
            this.addPartInventoryLabel.Name = "addPartInventoryLabel";
            this.addPartInventoryLabel.Size = new System.Drawing.Size(76, 21);
            this.addPartInventoryLabel.TabIndex = 7;
            this.addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Location = new System.Drawing.Point(171, 113);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(52, 21);
            this.addPartNameLabel.TabIndex = 5;
            this.addPartNameLabel.Text = "Name";
            // 
            // addPartCancelBtn
            // 
            this.addPartCancelBtn.AutoSize = true;
            this.addPartCancelBtn.Location = new System.Drawing.Point(472, 315);
            this.addPartCancelBtn.Name = "addPartCancelBtn";
            this.addPartCancelBtn.Size = new System.Drawing.Size(75, 31);
            this.addPartCancelBtn.TabIndex = 18;
            this.addPartCancelBtn.Text = "Cancel";
            this.addPartCancelBtn.UseVisualStyleBackColor = true;
            this.addPartCancelBtn.Click += new System.EventHandler(this.addPartCancelBtn_Click);
            // 
            // addPartSaveBtn
            // 
            this.addPartSaveBtn.AutoSize = true;
            this.addPartSaveBtn.Location = new System.Drawing.Point(391, 315);
            this.addPartSaveBtn.Name = "addPartSaveBtn";
            this.addPartSaveBtn.Size = new System.Drawing.Size(75, 31);
            this.addPartSaveBtn.TabIndex = 17;
            this.addPartSaveBtn.Text = "Save";
            this.addPartSaveBtn.UseVisualStyleBackColor = true;
            this.addPartSaveBtn.Click += new System.EventHandler(this.addPartSaveBtn_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 364);
            this.Controls.Add(this.addPartSaveBtn);
            this.Controls.Add(this.addPartCancelBtn);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.addPartInventoryLabel);
            this.Controls.Add(this.addPartPriceCostLabel);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.addPartMachineIDLabel);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartIDLabel);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartInventoryTextBox);
            this.Controls.Add(this.addPartPriceCostTextBox);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartMachineIDTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.addPartInHouseRadioBtn);
            this.Controls.Add(this.addPartOutSourcedRadioBtn);
            this.Controls.Add(this.addPartScreenLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartScreenLabel;
        private System.Windows.Forms.RadioButton addPartOutSourcedRadioBtn;
        private System.Windows.Forms.RadioButton addPartInHouseRadioBtn;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartMachineIDTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.TextBox addPartPriceCostTextBox;
        private System.Windows.Forms.TextBox addPartInventoryTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.Label addPartIDLabel;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.Label addPartMachineIDLabel;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.Label addPartPriceCostLabel;
        private System.Windows.Forms.Label addPartInventoryLabel;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.Button addPartCancelBtn;
        private System.Windows.Forms.Button addPartSaveBtn;

        public int textBoxAddPartID
        {
            get { return int.Parse(addPartIDTextBox.Text); }
            set { addPartIDTextBox.Text = value.ToString(); }
        }

        public string textBoxAddPartName
        {
            get { return addPartNameTextBox.Text; }
            set { addPartNameTextBox.Text = value; }
        }

        public int textBoxAddPartInventory
        {
            get { return int.Parse(addPartInventoryTextBox.Text); }
            set { addPartInventoryTextBox.Text = value.ToString(); }
        }

        public decimal textBoxAddPartPriceCost
        {
            get { return decimal.Parse(addPartPriceCostTextBox.Text); }
            set { addPartPriceCostTextBox.Text = value.ToString(); }
        }

        public int textBoxAddPartMax
        {
            get { return int.Parse(addPartMaxTextBox.Text); }
            set { addPartMaxTextBox.Text = value.ToString(); }
        }
        public int textBoxAddPartMin
        {
            get { return int.Parse(addPartMinTextBox.Text); }
            set { addPartMinTextBox.Text = value.ToString(); }
        }

        public string textBoxAddPartMachineID
        {
            get { return addPartMachineIDTextBox.Text; }
            set { addPartMachineIDTextBox.Text = value; }
        }

    }
}