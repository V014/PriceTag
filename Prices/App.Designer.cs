namespace Prices
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_search = new System.Windows.Forms.Panel();
            this.searchData = new System.Windows.Forms.DataGridView();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchData)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.AcceptsReturn = false;
            this.txt_search.AcceptsTab = false;
            this.txt_search.AnimationSpeed = 200;
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_search.BackgroundImage")));
            this.txt_search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_search.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_search.BorderRadius = 16;
            this.txt_search.BorderThickness = 1;
            this.txt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_search.DefaultText = "";
            this.txt_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.HideSelection = true;
            this.txt_search.IconLeft = null;
            this.txt_search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.IconPadding = 10;
            this.txt_search.IconRight = null;
            this.txt_search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(12, 133);
            this.txt_search.MaxLength = 32767;
            this.txt_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_search.Modified = false;
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_search.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnIdleState = stateProperties8;
            this.txt_search.Padding = new System.Windows.Forms.Padding(3);
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Search item";
            this.txt_search.ReadOnly = false;
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(549, 38);
            this.txt_search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txt_search.TabIndex = 0;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginBottom = 0;
            this.txt_search.TextMarginLeft = 3;
            this.txt_search.TextMarginTop = 0;
            this.txt_search.TextPlaceholder = "Search item";
            this.txt_search.UseSystemPasswordChar = false;
            this.txt_search.WordWrap = true;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.btn_add);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.lbl_title);
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Controls.Add(this.panel_search);
            this.panel_main.Controls.Add(this.txt_search);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(569, 381);
            this.panel_main.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.Gray;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(420, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 115);
            this.btn_add.TabIndex = 4;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(154, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start typing in the item you are looking for\r\nyou can also do some quick math.";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_title.ForeColor = System.Drawing.Color.Silver;
            this.lbl_title.Location = new System.Drawing.Point(150, 28);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(264, 37);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Price Tag Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel_search
            // 
            this.panel_search.Controls.Add(this.searchData);
            this.panel_search.Location = new System.Drawing.Point(12, 177);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(549, 192);
            this.panel_search.TabIndex = 1;
            // 
            // searchData
            // 
            this.searchData.AllowUserToAddRows = false;
            this.searchData.AllowUserToDeleteRows = false;
            this.searchData.AllowUserToResizeRows = false;
            this.searchData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchData.ColumnHeadersHeight = 40;
            this.searchData.ColumnHeadersVisible = false;
            this.searchData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchData.Location = new System.Drawing.Point(0, 0);
            this.searchData.Name = "searchData";
            this.searchData.RowHeadersVisible = false;
            this.searchData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchData.Size = new System.Drawing.Size(549, 192);
            this.searchData.TabIndex = 0;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(569, 381);
            this.Controls.Add(this.panel_main);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prices";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txt_search;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_search;
        public System.Windows.Forms.DataGridView searchData;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

