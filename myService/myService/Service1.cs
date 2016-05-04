using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Timers;
using OpenPop.Mime;
using OpenPop.Pop3;


namespace myService
{
    public partial class Service1 : ServiceBase
    {
        private string fileName;
        private Config clientDate =new Config();
        private Timer timer;
        private static List<string> oldMessagesUids = new List<string>();

        public Service1()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            //Thread.Sleep(100000);
            clientDate.GetConfigurationData();
            fileName = @"D:\test\myService.log";
            File.AppendAllText(fileName, "\nStart service"); 
            timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.AutoReset = true; 
            timer.Interval = 1000*60*5; 
            timer.Elapsed += new ElapsedEventHandler(OnTimerEvent);
            timer.AutoReset = true;
            timer.Start();
        }
        protected override void OnStop() 
        {
            File.AppendAllText(fileName,"\nStop service");
        }

        private void OnTimerEvent(object sender, ElapsedEventArgs args)
        {
            File.AppendAllText(fileName, "\n" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
            List<Message> newMessages = FetchUnseenMessages(clientDate.host, clientDate.port, clientDate.useSsl, clientDate.username, clientDate.password, oldMessagesUids);
            Save(newMessages);
            File.AppendAllText(fileName, "\nMessages Saved" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
        }
        private void Save(List<Message> newMessages)
        {
            string folder = clientDate.path;
           
            foreach (Message message in newMessages)
            {
                string subFolder = message.Headers.From.Address + " " + message.Headers.Date;
                string path = Path.Combine(folder, subFolder);
                Directory.CreateDirectory(path);
                string fileName = message.Headers.MessageId;
                StreamWriter file = new StreamWriter(Path.Combine(clientDate.path, fileName, ".txt"));

                MessagePart plainText = message.FindFirstPlainTextVersion();
                if (plainText != null)
                {
                    file.WriteLine(plainText.GetBodyAsText());
                }
                

                foreach (var attachment in  message.FindAllAttachments())
                {
                    string attachName = Path.Combine(path, attachment.FileName);

                    FileStream Stream = new FileStream(attachName, FileMode.Create);
                    BinaryWriter BinaryStream = new BinaryWriter(Stream);
                    BinaryStream.Write(attachment.Body);
                    BinaryStream.Close();
                }
            }
        }

        public static List<Message> FetchUnseenMessages(string hostname, int port, bool useSsl, string username, string password, List<string> seenUids)
        {
            using (Pop3Client client = new Pop3Client())
            {

                client.Connect(hostname, port, useSsl);
                client.Authenticate(username, password);
                
                List<string> uids = client.GetMessageUids();
                List<Message> newMessages = new List<Message>();
                for (int i = 0; i < uids.Count; i++)
                {
                    string currentUidOnServer = uids[i];
                    if (!seenUids.Contains(currentUidOnServer))
                    {
                        Message unseenMessage = client.GetMessage(i + 1);
                        newMessages.Add(unseenMessage);
                        oldMessagesUids.Add(currentUidOnServer);
                    }
                }
                return newMessages;
            }     
        }
        public void DeleteMessage(List<Message> newMessages)
        {
            string folder = clientDate.path;
            List<string> subFolders = new List<string>();
            foreach(Message subFolder in newMessages)
            {
                subFolders.Add(subFolder.Headers.From.Address + " " + subFolder.Headers.Date);
            }
            
            DirectoryInfo dinfo = new DirectoryInfo(folder);
            var directories = dinfo.GetDirectories();
            List<DirectoryInfo> selectedDirectories = directories.Where(directory => !subFolders.Contains(directory.Name)).ToList();
            foreach (var selectedDir in selectedDirectories)
            {
                selectedDir.Delete(true);
            }
        }
    }
}
  
  