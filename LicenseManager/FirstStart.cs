using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDaD.Toolkit.Database;

namespace LicenseManager
{
    public partial class FirstStart : Form
    {
        public FirstStart()
        {
            InitializeComponent();
            foreach (DatabaseType t in (DatabaseType[])Enum.GetValues(typeof(DatabaseType)))
            {
                cb_types.Items.Add(t.ToString());
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //check if fields are save
            //TODO: On Close: firstStart to False,save databaseinfo, licenseFiles start Manager
        }

        private void cb_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if sqlite hide fields
        }

        private void btn_create_keys_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Path = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
                WebDaD.Toolkit.Licensing.License.CreateKeys(Properties.Settings.Default.Path);
                //TODO: write to settingfs
                MessageBox.Show("Keys Created!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void tb_server_Click(object sender, EventArgs e)
        {
            //if type=sqlite open exploder
        }
    }
}
