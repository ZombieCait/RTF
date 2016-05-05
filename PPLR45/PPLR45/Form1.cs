using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Gnostice.PDFOne;
using интерфЛР1;


namespace PPLR45
{
    public partial class SendGet : Form
    {
        string path = "C:\\PPLR45\\mail";
        
        public SendGet()
        {
            InitializeComponent();
            PDFDocument doc = new PDFDocument("7F31-B744-6AFD-6540-D4A9-C0D2-6103-D9A3");
            
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            InterfaceManager iManager = new InterfaceManager();
            iManager.DrawHorizontalTabControl(sender as TabControl, e);
        }
        public void TreeInit()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("", "Mail", 2);
            DirectoryInfo Directory = new DirectoryInfo(path);
            DirectoryInfo[] directories=Directory.GetDirectories();

            foreach (DirectoryInfo s in directories)
            {
                TreeNode message = new TreeNode(s.Name, 0, 0);
                treeView1.Nodes.Add(message);

                GetTextAndAttachments(message);
            }

            treeView1.EndUpdate();
        }
        private void GetTextAndAttachments(TreeNode message)
        {
            FileInfo[] files;

            message.Nodes.Clear();
            string fullPath = Path.Combine(path, message.FullPath);
            DirectoryInfo directory = new DirectoryInfo(fullPath);

            try
            {
                files = directory.GetFiles();
            }
            catch
            {
                return;
            }

            foreach (FileInfo fileInfo in files)
            {
                TreeNode file = new TreeNode(fileInfo.Name, 0, 0);
                message.Nodes.Add(file);
            }
        }
        private void upDate_Click(object sender, EventArgs e)
        {
            TreeInit();
        }
        private void POPconfigEdit_Click(object sender, EventArgs e)
        {
            POP smtpf = new POP();
            smtpf.ShowDialog();
        }
        public ClientData ReadObjectFromFile()
        {
            string fileName = @"C:\PPLR45\PPLR45\client.conf";
            XmlSerializer serializer = new XmlSerializer(typeof(ClientData));
            FileStream stream = File.OpenRead(fileName);
            ClientData obj;
            try
            {
                obj = (ClientData)serializer.Deserialize(stream);
            }
            finally
            {
                stream.Dispose();
            }
            return obj;
        }
        public void SendMessage()
        {
            ClientData clientData=ReadObjectFromFile();
            MailAddress to = new MailAddress(mailtoBox.Text);
            MailAddress from = new MailAddress(clientData.username, nicknameBox.Text);
            MailMessage message = new MailMessage(from, to);
            message.Subject = subjectBox.Text;
            message.Body = textMessageBox.Text;
            SmtpClient client = new SmtpClient();
            NetworkCredential credential =new NetworkCredential(clientData.username, clientData.password); 
            client.Host = clientData.host;
            client.Port = client.Port;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = credential;
            try
            {
                client.Send(message);
                MessageBox.Show("Сообщение отправлено");
            }
            catch (Exception e)
            {
                MessageBox.Show("Сообщение не отправлено.\n" + e.Message);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        { 
            SendMessage();
        }
        private void SMTPconfig_Click(object sender, EventArgs e)
        {
            SMTP smtpf=new SMTP();
            smtpf.ShowDialog();
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.BeginUpdate();

            foreach (TreeNode node in e.Node.Nodes)
            {
                GetTextAndAttachments(node);
            }
            treeView1.EndUpdate();
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            String TreeNodePath = Path.Combine(path,treeView1.SelectedNode.FullPath);
            string nameSelectedFile = Path.GetFileNameWithoutExtension(TreeNodePath);
            string Extension = Path.GetExtension(TreeNodePath);

            if (nameSelectedFile.StartsWith("Сообщение"))
            {
                try
                {
                    StreamReader sr = new StreamReader(TreeNodePath, Encoding.UTF8);
                    string text = sr.ReadToEnd();
                    getMessageBox.Text = text;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось открыть файл: " + Environment.NewLine + ex);
                }
            }
            else
            {
                if (Extension == ".txt")
                {
                    try
                    {
                        pictureBox1.Visible = false;
                        AttachTextBox.Visible = true;
                        AttachTextBox.Text = File.ReadAllText(TreeNodePath, Encoding.Default);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось открыть файл: " + Environment.NewLine + ex);
                    }
                }
                if (Extension == ".jpg" || Extension == ".png" || Extension == ".jpeg")
                {
                    AttachTextBox.Visible = false;
                    pdfViewer1.Visible = false;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(TreeNodePath);
                }
                if (Extension == ".pdf")
                {
                    pdfViewer1.Visible = true;
                    pictureBox1.Visible = false;
                    AttachTextBox.Visible = false;
                    if(pdfViewer1.PDFLoaded)
                        pdfViewer1.CloseDocument();
                    pdfViewer1.LoadDocument(TreeNodePath);
                }
            }


        }
    }
}
