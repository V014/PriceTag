namespace Prices
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
            this.panel_control = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel_stock = new System.Windows.Forms.Panel();
            this.label_stock = new System.Windows.Forms.Label();
            this.label_stock_count = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_stock_value = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchData)).BeginInit();
            this.panel_control.SuspendLayout();
            this.panel_stock.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.searchData);
            this.panel_main.Controls.Add(this.panel_control);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(552, 386);
            this.panel_main.TabIndex = 1;
            // 
            // searchData
            // 
            this.searchData.AllowUserToAddRows = false;
            this.searchData.AllowUserToDeleteRows = false;
            this.searchData.AllowUserToResizeColumns = false;
            this.searchData.AllowUserToResizeRows = false;
            this.searchData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchData.ColumnHeadersHeight = 40;
            this.searchData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchData.Location = new System.Drawing.Point(0, 165);
            this.searchData.Name = "searchData";
            this.searchData.RowHeadersVisible = false;
            this.searchData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchData.Size = new System.Drawing.Size(552, 221);
            this.searchData.TabIndex = 0;
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.panel1);
            this.panel_control.Controls.Add(this.panel_stock);
            this.panel_control.Controls.Add(this.txt_search);
            this.panel_control.Controls.Add(this.btn_add);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(552, 165);
            this.panel_control.TabIndex = 5;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Gray;
            this.txt_search.Location = new System.Drawing.Point(0, 134);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(552, 31);
            this.txt_search.TabIndex = 5;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 126);
            this.btn_add.TabIndex = 4;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel_stock
            // 
            this.panel_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_stock.Controls.Add(this.label_stock_count);
            this.panel_stock.Controls.Add(this.label_stock);
            this.panel_stock.Location = new System.Drawing.Point(139, 3);
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
            this.label_stock.Size = new System.Drawing.Size(93, 17);
            this.label_stock.TabIndex = 0;
            this.label_stock.Text = "Items in stock";
            // 
            // label_stock_count
            // 
            this.label_stock_count.AutoSize = true;
            this.label_stock_count.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stock_count.ForeColor = System.Drawing.Color.White;
            this.label_stock_count.Location = new System.Drawing.Point(3, 6);
            this.label_stock_count.Name = "label_stock_count";
            this.label_stock_count.Size = new System.Drawing.Size(57, 32);
            this.label_stock_count.TabIndex = 0;
            this.label_stock_count.Text = "216";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.label_stock_value);
            this.panel1.Controls.Add(this.label_value);
            this.panel1.Location = new System.Drawing.Point(278, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 125);
            this.panel1.TabIndex = 7;
            // 
            // label_stock_value
            // 
            this.label_stock_value.AutoSize = true;
            this.label_stock_value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stock_value.ForeColor = System.Drawing.Color.White;
            this.label_stock_value.Location = new System.Drawing.Point(3, 6);
            this.label_stock_value.Name = "label_stock_value";
            this.label_stock_value.Size = new System.Drawing.Size(106, 32);
            this.label_stock_value.TabIndex = 0;
            this.label_stock_value.Text = "216,000";
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(552, 386);
            this.Controls.Add(this.panel_main);
            this.Name = "Home";
            this.Text = "Prices";
            this.TopMost = true;
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchData)).EndInit();
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            this.panel_stock.ResumeLayout(false);
            this.panel_stock.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        public System.Windows.Forms.DataGridView searchData;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel_stock;
        private System.Windows.Forms.Label label_stock_count;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_stock_value;
        private System.Windows.Forms.Label label_value;
    }
}

