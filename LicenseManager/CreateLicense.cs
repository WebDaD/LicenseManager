using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDaD.Toolkit.Database;
using WebDaD.Toolkit.Helper;

namespace LicenseManager
{
    public partial class CreateLicense : Form
    {
        private Database db;
        public string Hash;
        public CreateLicense(Database db)
        {
            this.db = db;
            InitializeComponent();
            dt_expiry.Value = DateTime.Now.AddDays(365);
            foreach (ComboBoxItem c in License.GetApplications(this.db))
            {
                cb_app.Items.Add(c);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Hash = License.CreateHash(((ComboBoxItem)cb_app.SelectedItem).Text, tb_user.Text, dt_expiry.Value);
            this.DialogResult = DialogResult.OK;
            //TODO: create hash, 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
