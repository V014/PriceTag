﻿namespace Prices
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel_main = new System.Windows.Forms.Panel();
            this.searchData = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel_stock = new System.Windows.Forms.Panel();
            this.label_stock = new System.Windows.Forms.Label();
            this.lbl_products = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_stock_value = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.panel_search = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_product_stock = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchData)).BeginInit();
            this.panel_stock.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.splitMain);
            this.panel_main.Controls.Add(this.flowLayoutPanel1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_main.Size = new System.Drawing.Size(954, 479);
            this.panel_main.TabIndex = 1;
            // 
            // searchData
            // 
            this.searchData.AllowUserToAddRows = false;
            this.searchData.AllowUserToDeleteRows = false;
            this.searchData.AllowUserToResizeColumns = false;
            this.searchData.AllowUserToResizeRows = false;
            this.searchData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchData.ColumnHeadersHeight = 40;
            this.searchData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchData.Location = new System.Drawing.Point(0, 0);
            this.searchData.Name = "searchData";
            this.searchData.ReadOnly = true;
            this.searchData.RowHeadersVisible = false;
            this.searchData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchData.Size = new System.Drawing.Size(749, 325);
            this.searchData.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_search.ForeColor = System.Drawing.Color.Gray;
            this.txt_search.Location = new System.Drawing.Point(9, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(127, 19);
            this.txt_search.TabIndex = 5;
            this.txt_search.Text = "🔍 Search";
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // panel_stock
            // 
            this.panel_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_stock.Controls.Add(this.lbl_products);
            this.panel_stock.Controls.Add(this.label_stock);
            this.panel_stock.Location = new System.Drawing.Point(142, 3);
            this.panel_stock.Name = "panel_stock";
            this.panel_stock.Size = new System.Drawing.Size(133, 125);
            this.panel_stock.TabIndex = 6;
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_stock.ForeColor = System.Drawing.Color.White;
            this.label_stock.Location = new System.Drawing.Point(3, 106);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(116, 17);
            this.label_stock.TabIndex = 0;
            this.label_stock.Text = "Products in stock";
            // 
            // lbl_products
            // 
            this.lbl_products.AutoSize = true;
            this.lbl_products.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products.ForeColor = System.Drawing.Color.White;
            this.lbl_products.Location = new System.Drawing.Point(3, 6);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(29, 32);
            this.lbl_products.TabIndex = 0;
            this.lbl_products.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.lbl_stock_value);
            this.panel1.Controls.Add(this.label_value);
            this.panel1.Location = new System.Drawing.Point(420, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 125);
            this.panel1.TabIndex = 7;
            // 
            // lbl_stock_value
            // 
            this.lbl_stock_value.AutoSize = true;
            this.lbl_stock_value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_value.ForeColor = System.Drawing.Color.White;
            this.lbl_stock_value.Location = new System.Drawing.Point(3, 6);
            this.lbl_stock_value.Name = "lbl_stock_value";
            this.lbl_stock_value.Size = new System.Drawing.Size(29, 32);
            this.lbl_stock_value.TabIndex = 0;
            this.lbl_stock_value.Text = "0";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_value.ForeColor = System.Drawing.Color.White;
            this.label_value.Location = new System.Drawing.Point(4, 106);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(97, 17);
            this.label_value.TabIndex = 0;
            this.label_value.Text = "Value of stock";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_purchase);
            this.flowLayoutPanel1.Controls.Add(this.panel_stock);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(934, 134);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(10, 144);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.btn_delete);
            this.splitMain.Panel1.Controls.Add(this.btn_update);
            this.splitMain.Panel1.Controls.Add(this.btn_add);
            this.splitMain.Panel1.Controls.Add(this.panel_search);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.searchData);
            this.splitMain.Size = new System.Drawing.Size(934, 325);
            this.splitMain.SplitterDistance = 181;
            this.splitMain.TabIndex = 10;
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_search.Controls.Add(this.txt_search);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_search.Location = new System.Drawing.Point(0, 0);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(181, 50);
            this.panel_search.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(0, 50);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(181, 35);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "➕ Add Items";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(0, 85);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(181, 35);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "♻️ Update Item";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(0, 120);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(181, 35);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "❌ Delete Item";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_purchase.FlatAppearance.BorderSize = 0;
            this.btn_purchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_purchase.ForeColor = System.Drawing.Color.White;
            this.btn_purchase.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchase.Image")));
            this.btn_purchase.Location = new System.Drawing.Point(3, 3);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(133, 125);
            this.btn_purchase.TabIndex = 8;
            this.btn_purchase.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock of products ";
            // 
            // lbl_product_stock
            // 
            this.lbl_product_stock.AutoSize = true;
            this.lbl_product_stock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_stock.ForeColor = System.Drawing.Color.White;
            this.lbl_product_stock.Location = new System.Drawing.Point(8, 6);
            this.lbl_product_stock.Name = "lbl_product_stock";
            this.lbl_product_stock.Size = new System.Drawing.Size(29, 32);
            this.lbl_product_stock.TabIndex = 0;
            this.lbl_product_stock.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.lbl_product_stock);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(281, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 125);
            this.panel2.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(954, 479);
            this.Controls.Add(this.panel_main);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prices";
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchData)).EndInit();
            this.panel_stock.ResumeLayout(false);
            this.panel_stock.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        public System.Windows.Forms.DataGridView searchData;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel_stock;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_stock_value;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Label lbl_product_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

