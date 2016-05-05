using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Mime;
using OpenPop.Pop3;
using Message = OpenPop.Mime.Message;


namespace PPLR45
{
    public partial class POP : Form
    {
        private static string path;
        private static bool useSsl;
        private static int port;
        private static string username;
        private static string password;
        private static string host;
        

        public POP()
        {
            InitializeComponent();
        }

        public void GetConfigurationData()
        {
            path = ConfigurationManager.AppSettings["path"];
            useSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["useSsl"]);
            port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);
            username = loginBox.Text;
            password = passwordBox.Text;
            host = popBox.Text;
        }

        static void SaveMessage(List<Message> Messages)
        {
            string folderName = path; 
            foreach (var message in Messages)
            {
                var subFolder = message.Headers.From.Address + message.Headers.Date.Replace(":", ".");
                subFolder.Trim('\\','/', ':', '*');


                string pathString = Path.Combine(folderName, subFolder);
                Directory.CreateDirectory(pathString);
                string fileName = "Сообщение";
                using (StreamWriter file =new StreamWriter(pathString + "/" + fileName + ".txt"))
                {
                    file.WriteLine("Тема: " + message.Headers.Subject + "\n\n" + message.FindFirstPlainTextVersion().GetBodyAsText());

                }
                List<MessagePart> mpart = message.FindAllAttachments();
                foreach (var attach in mpart)
                {

                    string attname = pathString + "/" + attach.FileName;

                    FileStream Stream = new FileStream(attname, FileMode.Create);
                    BinaryWriter BinaryStream = new BinaryWriter(Stream);
                    BinaryStream.Write(attach.Body);

                }
            }

        }
        public static List<Message> FetchAllMessages(string hostname, int port, bool useSsl, string username, string password)
        {

            using (Pop3Client client = new Pop3Client())
            {
                client.Connect(hostname, port, useSsl);
                client.Authenticate(username, password);
                int messageCount = client.GetMessageCount();

                List<Message> allMessages = new List<Message>(messageCount);


                for (int i = messageCount; i > 0; i--)
                {
                    allMessages.Add(client.GetMessage(i));
                }


                return allMessages;
            }
        }
     
        private void Save_Click(object sender, EventArgs e)
        {
            GetConfigurationData();
            List<Message> allMessages = FetchAllMessages(host, port, useSsl, username, password);
            SaveMessage(allMessages);

            Close();
        }
    }
}

