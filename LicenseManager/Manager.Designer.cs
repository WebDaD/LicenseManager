namespace LicenseManager
{
    partial class Manager
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_filter_application = new System.Windows.Forms.ComboBox();
            this.cb_filter_user = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_copy_text = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.btn_open_folder = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridview);
            this.splitContainer1.Size = new System.Drawing.Size(949, 458);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(281, 458);
            this.splitContainer2.SplitterDistance = 229;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.27273F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_filter_application, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_filter_user, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 210);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // cb_filter_application
            // 
            this.cb_filter_application.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_filter_application.FormattingEnabled = true;
            this.cb_filter_application.Location = new System.Drawing.Point(70, 3);
            this.cb_filter_application.Name = "cb_filter_application";
            this.cb_filter_application.Size = new System.Drawing.Size(202, 21);
            this.cb_filter_application.TabIndex = 2;
            this.cb_filter_application.SelectedIndexChanged += new System.EventHandler(this.cb_filter_application_SelectedIndexChanged);
            // 
            // cb_filter_user
            // 
            this.cb_filter_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_filter_user.FormattingEnabled = true;
            this.cb_filter_user.Location = new System.Drawing.Point(70, 108);
            this.cb_filter_user.Name = "cb_filter_user";
            this.cb_filter_user.Size = new System.Drawing.Size(202, 21);
            this.cb_filter_user.TabIndex = 3;
            this.cb_filter_user.SelectedIndexChanged += new System.EventHandler(this.cb_filter_user_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 225);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_create, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_copy_text, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_open_folder, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_upload, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(275, 206);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_create
            // 
            this.btn_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_create.Location = new System.Drawing.Point(3, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(131, 97);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "New License";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_copy_text
            // 
            this.btn_copy_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_copy_text.Location = new System.Drawing.Point(140, 3);
            this.btn_copy_text.Name = "btn_copy_text";
            this.btn_copy_text.Size = new System.Drawing.Size(132, 97);
            this.btn_copy_text.TabIndex = 1;
            this.btn_copy_text.Text = "Copy Selected Data to Clipboard";
            this.btn_copy_text.UseVisualStyleBackColor = true;
            this.btn_copy_text.Click += new System.EventHandler(this.btn_copy_text_Click);
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AllowUserToOrderColumns = true;
            this.gridview.AllowUserToResizeRows = false;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.ContextMenuStrip = this.contextMenuStrip;
            this.gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview.Location = new System.Drawing.Point(0, 0);
            this.gridview.MultiSelect = false;
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(664, 458);
            this.gridview.TabIndex = 0;
            // 
            // btn_open_folder
            // 
            this.btn_open_folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_open_folder.Location = new System.Drawing.Point(140, 106);
            this.btn_open_folder.Name = "btn_open_folder";
            this.btn_open_folder.Size = new System.Drawing.Size(132, 97);
            this.btn_open_folder.TabIndex = 2;
            this.btn_open_folder.Text = "Open Key Folder";
            this.btn_open_folder.UseVisualStyleBackColor = true;
            this.btn_open_folder.Click += new System.EventHandler(this.btn_open_folder_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_upload.Location = new System.Drawing.Point(3, 106);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(131, 97);
            this.btn_upload.TabIndex = 3;
            this.btn_upload.Text = "Upload Public Key";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDataToolStripMenuItem,
            this.checkLicenseToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(150, 48);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // copyDataToolStripMenuItem
            // 
            this.copyDataToolStripMenuItem.Name = "copyDataToolStripMenuItem";
            this.copyDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyDataToolStripMenuItem.Text = "Copy Data";
            this.copyDataToolStripMenuItem.Click += new System.EventHandler(this.copyDataToolStripMenuItem_Click);
            // 
            // checkLicenseToolStripMenuItem
            // 
            this.checkLicenseToolStripMenuItem.Name = "checkLicenseToolStripMenuItem";
            this.checkLicenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkLicenseToolStripMenuItem.Text = "Check License";
            this.checkLicenseToolStripMenuItem.Click += new System.EventHandler(this.checkLicenseToolStripMenuItem_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 458);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Manager";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_filter_application;
        private System.Windows.Forms.ComboBox cb_filter_user;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_copy_text;
        private System.Windows.Forms.Button btn_open_folder;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkLicenseToolStripMenuItem;
    }
}

