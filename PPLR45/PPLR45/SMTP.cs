using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PPLR45
{
    public partial class SMTP : Form{

        private ClientData client = new ClientData();

        public SMTP()
        {
            InitializeComponent();
        }
        public void GetConfigurationData()
        {
            client.path = ConfigurationManager.AppSettings["path"];
            client.useSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["useSsl"]);
            client.port = Convert.ToInt32(ConfigurationManager.AppSettings["portsmtp"]);
            client.username = loginBox.Text;
            client.password = passwordBox.Text;
            client.host = smtpBox.Text;
        }
        public void SaveClient()
        {
            string fileName = @"C:\PPLR45\PPLR45\client.conf";
            XmlSerializer serializer = new XmlSerializer(typeof(ClientData));
            FileStream stream = File.Create(fileName);
            serializer.Serialize(stream, client);
            stream.Dispose();
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Add("Key", "Value");
            config.Save(ConfigurationSaveMode.Modified);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            GetConfigurationData();
            SaveClient();
            Close();
        }
    }
}
