namespace English_Turkish_Dic_App
{
    partial class frm_treng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_treng));
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstVoca = new System.Windows.Forms.ListView();
            this.cEng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToWordPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTur
            // 
            this.txtTur.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTur.Location = new System.Drawing.Point(108, 22);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(86, 25);
            this.txtTur.TabIndex = 3;
            this.txtTur.Text = "Turkish";
            this.toolTip1.SetToolTip(this.txtTur, "Use comma(,) to separate multiple words");
            this.txtTur.Enter += new System.EventHandler(this.txtTur_Enter);
            this.txtTur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTur_KeyPress);
            this.txtTur.Leave += new System.EventHandler(this.txtTur_Leave);
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEng.Location = new System.Drawing.Point(12, 22);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(90, 25);
            this.txtEng.TabIndex = 2;
            this.txtEng.Text = "English";
            this.txtEng.Enter += new System.EventHandler(this.txtEng_Enter);
            this.txtEng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEng_KeyPress);
            this.txtEng.Leave += new System.EventHandler(this.txtEng_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lstVoca);
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 289);
            this.panel1.TabIndex = 1;
            // 
            // lstVoca
            // 
            this.lstVoca.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstVoca.BackColor = System.Drawing.Color.White;
            this.lstVoca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVoca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cEng,
            this.cTur});
            this.lstVoca.ContextMenuStrip = this.contextMenuStrip1;
            this.lstVoca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVoca.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVoca.FullRowSelect = true;
            this.lstVoca.GridLines = true;
            this.lstVoca.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVoca.Location = new System.Drawing.Point(0, 0);
            this.lstVoca.MultiSelect = false;
            this.lstVoca.Name = "lstVoca";
            this.lstVoca.ShowItemToolTips = true;
            this.lstVoca.Size = new System.Drawing.Size(225, 289);
            this.lstVoca.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstVoca.TabIndex = 0;
            this.lstVoca.UseCompatibleStateImageBehavior = false;
            this.lstVoca.View = System.Windows.Forms.View.Details;
            this.lstVoca.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.lstVoca_ItemMouseHover);
            this.lstVoca.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstVoca_ItemSelectionChanged);
            // 
            // cEng
            // 
            this.cEng.Text = "English";
            this.cEng.Width = 103;
            // 
            // cTur
            // 
            this.cTur.Text = "Turkish";
            this.cTur.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToExcelToolStripMenuItem,
            this.exportToWordPadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 152);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.ToolTipText = "if the result of the search that includes one row";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.exportToExcelToolStripMenuItem.Text = "Export to NotePad";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // exportToWordPadToolStripMenuItem
            // 
            this.exportToWordPadToolStripMenuItem.Name = "exportToWordPadToolStripMenuItem";
            this.exportToWordPadToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.exportToWordPadToolStripMenuItem.Text = "Export to Word";
            this.exportToWordPadToolStripMenuItem.Click += new System.EventHandler(this.exportToWordPadToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info Tip";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(12, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 25);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Search";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 7000;
            this.toolTip2.InitialDelay = 200;
            this.toolTip2.ReshowDelay = 100;
            this.toolTip2.ToolTipTitle = "Click Info";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = global::English_Turkish_Dic_App.Properties.Resources.info;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.Transparent;
            this.btnInfo.Location = new System.Drawing.Point(0, 1);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(16, 15);
            this.btnInfo.TabIndex = 7;
            this.toolTip2.SetToolTip(this.btnInfo, "Word Repository");
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(0, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 65);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = global::English_Turkish_Dic_App.Properties.Resources.error_2;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Location = new System.Drawing.Point(207, -3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(20, 20);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.BackgroundImage = global::English_Turkish_Dic_App.Properties.Resources.reload_alt1_24x28;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.CausesValidation = false;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(195, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(20, 20);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Enter.BackgroundImage = global::English_Turkish_Dic_App.Properties.Resources.plus;
            this.btn_Enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Enter.CausesValidation = false;
            this.btn_Enter.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Enter.Location = new System.Drawing.Point(195, 25);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(20, 20);
            this.btn_Enter.TabIndex = 4;
            this.btn_Enter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "TrEngWords";
            this.saveFileDialog1.Filter = "All files |*.*|Text files |*.txt*";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.ShowHelp = true;
            this.saveFileDialog1.Title = "Save Your Repository";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInExplorerToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(190, 28);
            // 
            // openInExplorerToolStripMenuItem
            // 
            this.openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            this.openInExplorerToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.openInExplorerToolStripMenuItem.Text = "Open in Explorer";
            this.openInExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInExplorerToolStripMenuItem_Click);
            // 
            // frm_treng
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(225, 372);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 850);
            this.MinimumSize = new System.Drawing.Size(225, 372);
            this.Name = "frm_treng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Words Repository";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_treng_FormClosing);
            this.Load += new System.EventHandler(this.frm_treng_Load);
            this.Click += new System.EventHandler(this.frm_treng_Click);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frm_treng_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_treng_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_treng_MouseMove);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lstVoca;
        private System.Windows.Forms.ColumnHeader cTur;
        public System.Windows.Forms.ColumnHeader cEng;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openInExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToWordPadToolStripMenuItem;
    }
}

