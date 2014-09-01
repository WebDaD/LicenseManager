namespace LicenseManager
{
    partial class FirstStart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_server = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_types = new System.Windows.Forms.ComboBox();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_create_keys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_private_key = new System.Windows.Forms.TextBox();
            this.tb_public_key = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.22535F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.77465F));
            this.tableLayoutPanel1.Controls.Add(this.lb_type, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_server, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cb_types, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_server, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_user, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_password, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_database, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(3, 0);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(31, 13);
            this.lb_type.TabIndex = 0;
            this.lb_type.Text = "Type";
            // 
            // lb_server
            // 
            this.lb_server.AutoSize = true;
            this.lb_server.Location = new System.Drawing.Point(3, 27);
            this.lb_server.Name = "lb_server";
            this.lb_server.Size = new System.Drawing.Size(38, 13);
            this.lb_server.TabIndex = 1;
            this.lb_server.Text = "Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Database";
            // 
            // cb_types
            // 
            this.cb_types.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_types.FormattingEnabled = true;
            this.cb_types.Location = new System.Drawing.Point(85, 3);
            this.cb_types.Name = "cb_types";
            this.cb_types.Size = new System.Drawing.Size(196, 21);
            this.cb_types.TabIndex = 5;
            this.cb_types.SelectedIndexChanged += new System.EventHandler(this.cb_types_SelectedIndexChanged);
            // 
            // tb_server
            // 
            this.tb_server.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_server.Location = new System.Drawing.Point(85, 30);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(196, 20);
            this.tb_server.TabIndex = 6;
            this.tb_server.Click += new System.EventHandler(this.tb_server_Click);
            // 
            // tb_user
            // 
            this.tb_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_user.Location = new System.Drawing.Point(85, 56);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(196, 20);
            this.tb_user.TabIndex = 7;
            // 
            // tb_password
            // 
            this.tb_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_password.Location = new System.Drawing.Point(85, 82);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(196, 20);
            this.tb_password.TabIndex = 8;
            // 
            // tb_database
            // 
            this.tb_database.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_database.Location = new System.Drawing.Point(85, 108);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(196, 20);
            this.tb_database.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(319, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keys";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.18033F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.81967F));
            this.tableLayoutPanel2.Controls.Add(this.btn_create_keys, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_private_key, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_public_key, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(305, 140);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_create_keys
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btn_create_keys, 2);
            this.btn_create_keys.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_create_keys.Location = new System.Drawing.Point(3, 3);
            this.btn_create_keys.Name = "btn_create_keys";
            this.btn_create_keys.Size = new System.Drawing.Size(299, 23);
            this.btn_create_keys.TabIndex = 0;
            this.btn_create_keys.Text = "Create Keys";
            this.btn_create_keys.UseVisualStyleBackColor = true;
            this.btn_create_keys.Click += new System.EventHandler(this.btn_create_keys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Private Key File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Public Key File";
            // 
            // tb_private_key
            // 
            this.tb_private_key.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_private_key.Location = new System.Drawing.Point(92, 32);
            this.tb_private_key.Name = "tb_private_key";
            this.tb_private_key.Size = new System.Drawing.Size(210, 20);
            this.tb_private_key.TabIndex = 3;
            // 
            // tb_public_key
            // 
            this.tb_public_key.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_public_key.Location = new System.Drawing.Point(92, 58);
            this.tb_public_key.Name = "tb_public_key";
            this.tb_public_key.Size = new System.Drawing.Size(210, 20);
            this.tb_public_key.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(13, 175);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(290, 24);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(319, 175);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(311, 24);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save and Continue";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "mydatabase";
            // 
            // FirstStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 209);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FirstStart";
            this.Text = "FirstStart";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_types;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_create_keys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_private_key;
        private System.Windows.Forms.TextBox tb_public_key;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}