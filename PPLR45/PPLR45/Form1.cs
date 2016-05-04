using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using интерфЛР1;

namespace PPLR45
{
    public partial class SendGet : Form
    {
        string path = "C:\\PPLR45\\mail";
        public SendGet()
        {
            InitializeComponent();
            
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

        private void Send_Click(object sender, EventArgs e)
        {

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
            FileInfo selectedFile=new FileInfo(TreeNodePath);
            string nameSelectedFile = Path.GetFileNameWithoutExtension(TreeNodePath);
            string Extension = Path.GetExtension(TreeNodePath);

            if (nameSelectedFile == "Текст письма")
            {
                try
                {
                    getMessageBox.Text = File.ReadAllText(TreeNodePath, Encoding.Default);
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
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(TreeNodePath);
                }
                if (Extension == ".pdf")
                {
                }
            }


        }
    }
}
