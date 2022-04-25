
namespace mert_software_task.WebFormsUI
{
    partial class MainMenu
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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnShippers = new System.Windows.Forms.Button();
            this.btnEmployess = new System.Windows.Forms.Button();
            this.btnPullAndSaveData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(48, 36);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(103, 43);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(48, 85);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(103, 43);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(48, 134);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(103, 43);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(48, 183);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(103, 43);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(157, 36);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(103, 43);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnShippers
            // 
            this.btnShippers.Location = new System.Drawing.Point(157, 85);
            this.btnShippers.Name = "btnShippers";
            this.btnShippers.Size = new System.Drawing.Size(103, 43);
            this.btnShippers.TabIndex = 5;
            this.btnShippers.Text = "Shippers";
            this.btnShippers.UseVisualStyleBackColor = true;
            this.btnShippers.Click += new System.EventHandler(this.btnShippers_Click);
            // 
            // btnEmployess
            // 
            this.btnEmployess.Location = new System.Drawing.Point(157, 134);
            this.btnEmployess.Name = "btnEmployess";
            this.btnEmployess.Size = new System.Drawing.Size(103, 43);
            this.btnEmployess.TabIndex = 6;
            this.btnEmployess.Text = "Employess";
            this.btnEmployess.UseVisualStyleBackColor = true;
            this.btnEmployess.Click += new System.EventHandler(this.btnEmployess_Click);
            // 
            // btnPullAndSaveData
            // 
            this.btnPullAndSaveData.Location = new System.Drawing.Point(157, 183);
            this.btnPullAndSaveData.Name = "btnPullAndSaveData";
            this.btnPullAndSaveData.Size = new System.Drawing.Size(103, 43);
            this.btnPullAndSaveData.TabIndex = 7;
            this.btnPullAndSaveData.Text = "Pull And Save Data";
            this.btnPullAndSaveData.UseVisualStyleBackColor = true;
            this.btnPullAndSaveData.Click += new System.EventHandler(this.btnPullAndSaveData_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 265);
            this.Controls.Add(this.btnPullAndSaveData);
            this.Controls.Add(this.btnEmployess);
            this.Controls.Add(this.btnShippers);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnOrders);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnShippers;
        private System.Windows.Forms.Button btnEmployess;
        private System.Windows.Forms.Button btnPullAndSaveData;
    }
}

