using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;

namespace PPLR45
{
    public partial class SMTP : Form
    {
        public SMTP()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            currentConfig.AppSettings.Settings["hostsmtp"].Value = "smtp."+smtpBox.Text;
            currentConfig.AppSettings.Settings["username"].Value = loginBox.Text;
            currentConfig.AppSettings.Settings["password"].Value = passwordBox.Text;
            currentConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
        }
    }
}
