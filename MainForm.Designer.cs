namespace John_Davis_Inventory_App
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainScreenLabel = new System.Windows.Forms.Label();
            this.mainPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainPartsDataGridLabel = new System.Windows.Forms.Label();
            this.mainProductsDataGridLabel = new System.Windows.Forms.Label();
            this.searchBoxParts = new System.Windows.Forms.TextBox();
            this.searchBoxProducts = new System.Windows.Forms.TextBox();
            this.mainPartsSearchBtn = new System.Windows.Forms.Button();
            this.mainProductsSearchBtn = new System.Windows.Forms.Button();
            this.mainPartsAddBtn = new System.Windows.Forms.Button();
            this.mainPartsModifyBtn = new System.Windows.Forms.Button();
            this.mainPartsDeleteBtn = new System.Windows.Forms.Button();
            this.mainProductsDeleteBtn = new System.Windows.Forms.Button();
            this.mainProductsModifyBtn = new System.Windows.Forms.Button();
            this.mainProductsAddBtn = new System.Windows.Forms.Button();
            this.mainExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainScreenLabel
            // 
            this.mainScreenLabel.AutoSize = true;
            this.mainScreenLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenLabel.Location = new System.Drawing.Point(13, 13);
            this.mainScreenLabel.Name = "mainScreenLabel";
            this.mainScreenLabel.Size = new System.Drawing.Size(283, 28);
            this.mainScreenLabel.TabIndex = 0;
            this.mainScreenLabel.Text = "Inventory Management System";
            // 
            // mainPartsDataGridView
            // 
            this.mainPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPartsDataGridView.Location = new System.Drawing.Point(13, 113);
            this.mainPartsDataGridView.Name = "mainPartsDataGridView";
            this.mainPartsDataGridView.RowHeadersVisible = false;
            this.mainPartsDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.mainPartsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mainPartsDataGridView.RowTemplate.Height = 28;
            this.mainPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainPartsDataGridView.Size = new System.Drawing.Size(447, 184);
            this.mainPartsDataGridView.TabIndex = 7;
            // 
            // mainProductsDataGridView
            // 
            this.mainProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainProductsDataGridView.Location = new System.Drawing.Point(516, 113);
            this.mainProductsDataGridView.Name = "mainProductsDataGridView";
            this.mainProductsDataGridView.RowHeadersVisible = false;
            this.mainProductsDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.mainProductsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.mainProductsDataGridView.RowTemplate.Height = 28;
            this.mainProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainProductsDataGridView.Size = new System.Drawing.Size(447, 184);
            this.mainProductsDataGridView.TabIndex = 8;
            // 
            // mainPartsDataGridLabel
            // 
            this.mainPartsDataGridLabel.AutoSize = true;
            this.mainPartsDataGridLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPartsDataGridLabel.Location = new System.Drawing.Point(12, 85);
            this.mainPartsDataGridLabel.Name = "mainPartsDataGridLabel";
            this.mainPartsDataGridLabel.Size = new System.Drawing.Size(50, 25);
            this.mainPartsDataGridLabel.TabIndex = 1;
            this.mainPartsDataGridLabel.Text = "Parts";
            // 
            // mainProductsDataGridLabel
            // 
            this.mainProductsDataGridLabel.AutoSize = true;
            this.mainProductsDataGridLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainProductsDataGridLabel.Location = new System.Drawing.Point(511, 85);
            this.mainProductsDataGridLabel.Name = "mainProductsDataGridLabel";
            this.mainProductsDataGridLabel.Size = new System.Drawing.Size(82, 25);
            this.mainProductsDataGridLabel.TabIndex = 4;
            this.mainProductsDataGridLabel.Text = "Products";
            // 
            // searchBoxParts
            // 
            this.searchBoxParts.Location = new System.Drawing.Point(359, 78);
            this.searchBoxParts.Name = "searchBoxParts";
            this.searchBoxParts.Size = new System.Drawing.Size(100, 29);
            this.searchBoxParts.TabIndex = 3;
            // 
            // searchBoxProducts
            // 
            this.searchBoxProducts.Location = new System.Drawing.Point(863, 78);
            this.searchBoxProducts.Name = "searchBoxProducts";
            this.searchBoxProducts.Size = new System.Drawing.Size(100, 29);
            this.searchBoxProducts.TabIndex = 6;
            // 
            // mainPartsSearchBtn
            // 
            this.mainPartsSearchBtn.AutoSize = true;
            this.mainPartsSearchBtn.Location = new System.Drawing.Point(278, 76);
            this.mainPartsSearchBtn.Name = "mainPartsSearchBtn";
            this.mainPartsSearchBtn.Size = new System.Drawing.Size(75, 31);
            this.mainPartsSearchBtn.TabIndex = 2;
            this.mainPartsSearchBtn.Text = "Search";
            this.mainPartsSearchBtn.UseVisualStyleBackColor = true;
            this.mainPartsSearchBtn.Click += new System.EventHandler(this.mainPartsSearchBtn_Click);
            // 
            // mainProductsSearchBtn
            // 
            this.mainProductsSearchBtn.AutoSize = true;
            this.mainProductsSearchBtn.Location = new System.Drawing.Point(782, 76);
            this.mainProductsSearchBtn.Name = "mainProductsSearchBtn";
            this.mainProductsSearchBtn.Size = new System.Drawing.Size(75, 31);
            this.mainProductsSearchBtn.TabIndex = 5;
            this.mainProductsSearchBtn.Text = "Search";
            this.mainProductsSearchBtn.UseVisualStyleBackColor = true;
            this.mainProductsSearchBtn.Click += new System.EventHandler(this.mainProductsSearchBtn_Click);
            // 
            // mainPartsAddBtn
            // 
            this.mainPartsAddBtn.AutoSize = true;
            this.mainPartsAddBtn.Location = new System.Drawing.Point(222, 303);
            this.mainPartsAddBtn.Name = "mainPartsAddBtn";
            this.mainPartsAddBtn.Size = new System.Drawing.Size(75, 31);
            this.mainPartsAddBtn.TabIndex = 9;
            this.mainPartsAddBtn.Text = "Add";
            this.mainPartsAddBtn.UseVisualStyleBackColor = true;
            this.mainPartsAddBtn.Click += new System.EventHandler(this.mainPartsAddBtn_Click);
            // 
            // mainPartsModifyBtn
            // 
            this.mainPartsModifyBtn.AutoSize = true;
            this.mainPartsModifyBtn.Location = new System.Drawing.Point(303, 303);
            this.mainPartsModifyBtn.Name = "mainPartsModifyBtn";
            this.mainPartsModifyBtn.Size = new System.Drawing.Size(75, 31);
            this.mainPartsModifyBtn.TabIndex = 10;
            this.mainPartsModifyBtn.Text = "Modify";
            this.mainPartsModifyBtn.UseVisualStyleBackColor = true;
            this.mainPartsModifyBtn.Click += new System.EventHandler(this.mainPartsModifyBtn_Click);
            // 
            // mainPartsDeleteBtn
            // 
            this.mainPartsDeleteBtn.AutoSize = true;
            this.mainPartsDeleteBtn.Location = new System.Drawing.Point(384, 303);
            this.mainPartsDeleteBtn.Name = "mainPartsDeleteBtn";
            this.mainPartsDeleteBtn.Size = new System.Drawing.Size(75, 31);
            this.mainPartsDeleteBtn.TabIndex = 11;
            this.mainPartsDeleteBtn.Text = "Delete";
            this.mainPartsDeleteBtn.UseVisualStyleBackColor = true;
            this.mainPartsDeleteBtn.Click += new System.EventHandler(this.mainPartsDeleteBtn_Click);
            // 
            // mainProductsDeleteBtn
            // 
            this.mainProductsDeleteBtn.AutoSize = true;
            this.mainProductsDeleteBtn.Location = new System.Drawing.Point(888, 303);
            this.mainProductsDeleteBtn.Name = "mainProductsDeleteBtn";
            this.mainProductsDeleteBtn.Size = new System.Drawing.Size(75, 31);
            this.mainProductsDeleteBtn.TabIndex = 14;
            this.mainProductsDeleteBtn.Text = "Delete";
            this.mainProductsDeleteBtn.UseVisualStyleBackColor = true;
            this.mainProductsDeleteBtn.Click += new System.EventHandler(this.mainProductsDeleteBtn_Click);
            // 
            // mainProductsModifyBtn
            // 
            this.mainProductsModifyBtn.AutoSize = true;
            this.mainProductsModifyBtn.Location = new System.Drawing.Point(807, 303);
            this.mainProductsModifyBtn.Name = "mainProductsModifyBtn";
            this.mainProductsModifyBtn.Size = new System.Drawing.Size(75, 31);
            this.mainProductsModifyBtn.TabIndex = 13;
            this.mainProductsModifyBtn.Text = "Modify";
            this.mainProductsModifyBtn.UseVisualStyleBackColor = true;
            this.mainProductsModifyBtn.Click += new System.EventHandler(this.mainProductsModifyBtn_Click);
            // 
            // mainProductsAddBtn
            // 
            this.mainProductsAddBtn.AutoSize = true;
            this.mainProductsAddBtn.Location = new System.Drawing.Point(726, 303);
            this.mainProductsAddBtn.Name = "mainProductsAddBtn";
            this.mainProductsAddBtn.Size = new System.Drawing.Size(75, 31);
            this.mainProductsAddBtn.TabIndex = 12;
            this.mainProductsAddBtn.Text = "Add";
            this.mainProductsAddBtn.UseVisualStyleBackColor = true;
            this.mainProductsAddBtn.Click += new System.EventHandler(this.mainProductsAddBtn_Click);
            // 
            // mainExitBtn
            // 
            this.mainExitBtn.AutoSize = true;
            this.mainExitBtn.Location = new System.Drawing.Point(888, 429);
            this.mainExitBtn.Name = "mainExitBtn";
            this.mainExitBtn.Size = new System.Drawing.Size(75, 31);
            this.mainExitBtn.TabIndex = 15;
            this.mainExitBtn.Text = "Exit";
            this.mainExitBtn.UseVisualStyleBackColor = true;
            this.mainExitBtn.Click += new System.EventHandler(this.mainExitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 472);
            this.Controls.Add(this.mainExitBtn);
            this.Controls.Add(this.mainProductsAddBtn);
            this.Controls.Add(this.mainProductsModifyBtn);
            this.Controls.Add(this.mainProductsDeleteBtn);
            this.Controls.Add(this.mainPartsDeleteBtn);
            this.Controls.Add(this.mainPartsModifyBtn);
            this.Controls.Add(this.mainPartsAddBtn);
            this.Controls.Add(this.mainProductsSearchBtn);
            this.Controls.Add(this.mainPartsSearchBtn);
            this.Controls.Add(this.searchBoxProducts);
            this.Controls.Add(this.searchBoxParts);
            this.Controls.Add(this.mainProductsDataGridLabel);
            this.Controls.Add(this.mainPartsDataGridLabel);
            this.Controls.Add(this.mainProductsDataGridView);
            this.Controls.Add(this.mainPartsDataGridView);
            this.Controls.Add(this.mainScreenLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainScreenLabel;
        private System.Windows.Forms.DataGridView mainProductsDataGridView;
        private System.Windows.Forms.Label mainPartsDataGridLabel;
        private System.Windows.Forms.Label mainProductsDataGridLabel;
        private System.Windows.Forms.TextBox searchBoxParts;
        private System.Windows.Forms.TextBox searchBoxProducts;
        private System.Windows.Forms.Button mainPartsSearchBtn;
        private System.Windows.Forms.Button mainProductsSearchBtn;
        private System.Windows.Forms.Button mainPartsAddBtn;
        private System.Windows.Forms.Button mainPartsModifyBtn;
        private System.Windows.Forms.Button mainPartsDeleteBtn;
        private System.Windows.Forms.Button mainProductsDeleteBtn;
        private System.Windows.Forms.Button mainProductsModifyBtn;
        private System.Windows.Forms.Button mainProductsAddBtn;
        private System.Windows.Forms.Button mainExitBtn;
        private System.Windows.Forms.DataGridView mainPartsDataGridView;

    }
}

