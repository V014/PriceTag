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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_main = new System.Windows.Forms.Panel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel_search = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.data_search = new System.Windows.Forms.DataGridView();
            this.menu_data = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.panel_stock = new System.Windows.Forms.Panel();
            this.lbl_products = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.panel_product_stock = new System.Windows.Forms.Panel();
            this.lbl_product_stock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_stock_value = new System.Windows.Forms.Panel();
            this.lbl_stock_value = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.chart_sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_search)).BeginInit();
            this.menu_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_stock.SuspendLayout();
            this.panel_product_stock.SuspendLayout();
            this.panel_stock_value.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.splitMain);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_main.Size = new System.Drawing.Size(873, 479);
            this.panel_main.TabIndex = 1;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(10, 10);
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
            this.splitMain.Panel2.Controls.Add(this.data_search);
            this.splitMain.Panel2.Controls.Add(this.splitContainer1);
            this.splitMain.Size = new System.Drawing.Size(853, 459);
            this.splitMain.SplitterDistance = 133;
            this.splitMain.TabIndex = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(0, 114);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 35);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "❌ Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(0, 79);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(133, 35);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "♻️ Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(0, 44);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 35);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "➕ Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_search.Controls.Add(this.txt_search);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_search.Location = new System.Drawing.Point(0, 0);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(133, 44);
            this.panel_search.TabIndex = 7;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_search.ForeColor = System.Drawing.Color.Gray;
            this.txt_search.Location = new System.Drawing.Point(9, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(127, 16);
            this.txt_search.TabIndex = 5;
            this.txt_search.Text = "🔍 Search";
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // data_search
            // 
            this.data_search.AllowUserToAddRows = false;
            this.data_search.AllowUserToDeleteRows = false;
            this.data_search.AllowUserToResizeColumns = false;
            this.data_search.AllowUserToResizeRows = false;
            this.data_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.data_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_search.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_search.ColumnHeadersHeight = 40;
            this.data_search.ContextMenuStrip = this.menu_data;
            this.data_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_search.Location = new System.Drawing.Point(0, 133);
            this.data_search.Name = "data_search";
            this.data_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_search.Size = new System.Drawing.Size(716, 326);
            this.data_search.TabIndex = 0;
            this.data_search.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_search_CellEndEdit);
            // 
            // menu_data
            // 
            this.menu_data.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.updateMenuItem,
            this.deleteMenuItem,
            this.refreshMenuItem});
            this.menu_data.Name = "menu_data";
            this.menu_data.Size = new System.Drawing.Size(114, 92);
            // 
            // addMenuItem
            // 
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(113, 22);
            this.addMenuItem.Text = "Add";
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Size = new System.Drawing.Size(113, 22);
            this.updateMenuItem.Text = "Update";
            this.updateMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshMenuItem.Text = "Refresh";
            this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart_sales);
            this.splitContainer1.Size = new System.Drawing.Size(716, 133);
            this.splitContainer1.SplitterDistance = 561;
            this.splitContainer1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_purchase);
            this.flowLayoutPanel1.Controls.Add(this.panel_stock);
            this.flowLayoutPanel1.Controls.Add(this.panel_product_stock);
            this.flowLayoutPanel1.Controls.Add(this.panel_stock_value);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 133);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
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
            // panel_product_stock
            // 
            this.panel_product_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_product_stock.Controls.Add(this.lbl_product_stock);
            this.panel_product_stock.Controls.Add(this.label1);
            this.panel_product_stock.Location = new System.Drawing.Point(281, 3);
            this.panel_product_stock.Name = "panel_product_stock";
            this.panel_product_stock.Size = new System.Drawing.Size(133, 125);
            this.panel_product_stock.TabIndex = 7;
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
            // panel_stock_value
            // 
            this.panel_stock_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_stock_value.Controls.Add(this.lbl_stock_value);
            this.panel_stock_value.Controls.Add(this.label_value);
            this.panel_stock_value.Location = new System.Drawing.Point(420, 3);
            this.panel_stock_value.Name = "panel_stock_value";
            this.panel_stock_value.Size = new System.Drawing.Size(133, 125);
            this.panel_stock_value.TabIndex = 7;
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
            // chart_sales
            // 
            this.chart_sales.BackColor = System.Drawing.Color.Transparent;
            this.chart_sales.BorderlineColor = System.Drawing.Color.Empty;
            this.chart_sales.BorderlineWidth = 0;
            this.chart_sales.BorderSkin.BackColor = System.Drawing.Color.Empty;
            this.chart_sales.BorderSkin.BorderColor = System.Drawing.Color.Empty;
            this.chart_sales.BorderSkin.BorderWidth = 0;
            this.chart_sales.BorderSkin.PageColor = System.Drawing.Color.Empty;
            chartArea1.AlignmentStyle = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Cursor)));
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            chartArea1.BorderColor = System.Drawing.Color.Empty;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart_sales.ChartAreas.Add(chartArea1);
            this.chart_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.AutoFitMinFontSize = 6;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chart_sales.Legends.Add(legend1);
            this.chart_sales.Location = new System.Drawing.Point(0, 0);
            this.chart_sales.Name = "chart_sales";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BackSecondaryColor = System.Drawing.Color.LimeGreen;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Name = "Sales";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Stock";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chart_sales.Series.Add(series1);
            this.chart_sales.Series.Add(series2);
            this.chart_sales.Size = new System.Drawing.Size(151, 133);
            this.chart_sales.TabIndex = 1;
            this.chart_sales.Text = "chart1";
            this.chart_sales.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(873, 479);
            this.Controls.Add(this.panel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prices";
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.panel_main.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_search)).EndInit();
            this.menu_data.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_stock.ResumeLayout(false);
            this.panel_stock.PerformLayout();
            this.panel_product_stock.ResumeLayout(false);
            this.panel_product_stock.PerformLayout();
            this.panel_stock_value.ResumeLayout(false);
            this.panel_stock_value.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        public System.Windows.Forms.DataGridView data_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel_stock;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Panel panel_stock_value;
        private System.Windows.Forms.Label lbl_stock_value;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Label lbl_product_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_product_stock;
        private System.Windows.Forms.ContextMenuStrip menu_data;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sales;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

