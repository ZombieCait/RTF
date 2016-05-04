using System.Drawing;

namespace PPLR45
{
    partial class SendGet
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sendPage = new System.Windows.Forms.TabPage();
            this.Send = new System.Windows.Forms.Button();
            this.SMTPconfig = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GetPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.upDate = new System.Windows.Forms.Button();
            this.POPconfigEdit = new System.Windows.Forms.Button();
            this.getMessageBox = new System.Windows.Forms.RichTextBox();
            this.AttachTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.sendPage.SuspendLayout();
            this.GetPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.sendPage);
            this.tabControl1.Controls.Add(this.GetPage);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 20);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 564);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // sendPage
            // 
            this.sendPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendPage.Controls.Add(this.Send);
            this.sendPage.Controls.Add(this.SMTPconfig);
            this.sendPage.Controls.Add(this.textBox3);
            this.sendPage.Controls.Add(this.textBox2);
            this.sendPage.Controls.Add(this.textBox1);
            this.sendPage.Controls.Add(this.richTextBox1);
            this.sendPage.Controls.Add(this.label4);
            this.sendPage.Controls.Add(this.label3);
            this.sendPage.Controls.Add(this.label2);
            this.sendPage.Controls.Add(this.label1);
            this.sendPage.Location = new System.Drawing.Point(4, 24);
            this.sendPage.Name = "sendPage";
            this.sendPage.Padding = new System.Windows.Forms.Padding(1);
            this.sendPage.Size = new System.Drawing.Size(653, 536);
            this.sendPage.TabIndex = 0;
            this.sendPage.Text = "Отправить сообщение";
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.DarkCyan;
            this.Send.FlatAppearance.BorderSize = 0;
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Send.Location = new System.Drawing.Point(435, 496);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(210, 30);
            this.Send.TabIndex = 9;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // SMTPconfig
            // 
            this.SMTPconfig.BackColor = System.Drawing.Color.DarkCyan;
            this.SMTPconfig.FlatAppearance.BorderSize = 0;
            this.SMTPconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMTPconfig.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SMTPconfig.Location = new System.Drawing.Point(219, 496);
            this.SMTPconfig.Name = "SMTPconfig";
            this.SMTPconfig.Size = new System.Drawing.Size(210, 30);
            this.SMTPconfig.TabIndex = 8;
            this.SMTPconfig.Text = "Настройка конфигурации";
            this.SMTPconfig.UseVisualStyleBackColor = false;
            this.SMTPconfig.Click += new System.EventHandler(this.SMTPconfig_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(497, 27);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(497, 27);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 27);
            this.textBox1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(637, 374);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Текст сообщения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(83, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тема:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(82, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кому:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(104, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "От:";
            // 
            // GetPage
            // 
            this.GetPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetPage.Controls.Add(this.AttachTextBox);
            this.GetPage.Controls.Add(this.label7);
            this.GetPage.Controls.Add(this.label6);
            this.GetPage.Controls.Add(this.label5);
            this.GetPage.Controls.Add(this.pictureBox1);
            this.GetPage.Controls.Add(this.treeView1);
            this.GetPage.Controls.Add(this.upDate);
            this.GetPage.Controls.Add(this.POPconfigEdit);
            this.GetPage.Controls.Add(this.getMessageBox);
            this.GetPage.Location = new System.Drawing.Point(4, 24);
            this.GetPage.Name = "GetPage";
            this.GetPage.Padding = new System.Windows.Forms.Padding(1);
            this.GetPage.Size = new System.Drawing.Size(653, 536);
            this.GetPage.TabIndex = 1;
            this.GetPage.Text = "Входящие сообщения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(0, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Сообщения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(210, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Вложенный файл:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(210, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Текст сообщения:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(215, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.treeView1.ForeColor = System.Drawing.Color.DarkCyan;
            this.treeView1.Location = new System.Drawing.Point(5, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(204, 455);
            this.treeView1.TabIndex = 13;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // upDate
            // 
            this.upDate.BackColor = System.Drawing.Color.DarkCyan;
            this.upDate.FlatAppearance.BorderSize = 0;
            this.upDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.upDate.Location = new System.Drawing.Point(435, 496);
            this.upDate.Name = "upDate";
            this.upDate.Size = new System.Drawing.Size(210, 30);
            this.upDate.TabIndex = 12;
            this.upDate.Text = "Обновить";
            this.upDate.UseVisualStyleBackColor = false;
            this.upDate.Click += new System.EventHandler(this.upDate_Click);
            // 
            // POPconfigEdit
            // 
            this.POPconfigEdit.BackColor = System.Drawing.Color.DarkCyan;
            this.POPconfigEdit.FlatAppearance.BorderSize = 0;
            this.POPconfigEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POPconfigEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.POPconfigEdit.Location = new System.Drawing.Point(215, 496);
            this.POPconfigEdit.Name = "POPconfigEdit";
            this.POPconfigEdit.Size = new System.Drawing.Size(210, 30);
            this.POPconfigEdit.TabIndex = 11;
            this.POPconfigEdit.Text = "Настройка конфигурации";
            this.POPconfigEdit.UseVisualStyleBackColor = false;
            this.POPconfigEdit.Click += new System.EventHandler(this.POPconfigEdit_Click);
            // 
            // getMessageBox
            // 
            this.getMessageBox.Location = new System.Drawing.Point(215, 35);
            this.getMessageBox.Name = "getMessageBox";
            this.getMessageBox.Size = new System.Drawing.Size(430, 205);
            this.getMessageBox.TabIndex = 10;
            this.getMessageBox.Text = "";
            // 
            // AttachTextBox
            // 
            this.AttachTextBox.Location = new System.Drawing.Point(215, 270);
            this.AttachTextBox.Name = "AttachTextBox";
            this.AttachTextBox.Size = new System.Drawing.Size(430, 220);
            this.AttachTextBox.TabIndex = 18;
            this.AttachTextBox.Text = "";
            this.AttachTextBox.Visible = false;
            // 
            // SendGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(655, 557);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SendGet";
            this.ShowIcon = false;
            this.tabControl1.ResumeLayout(false);
            this.sendPage.ResumeLayout(false);
            this.sendPage.PerformLayout();
            this.GetPage.ResumeLayout(false);
            this.GetPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sendPage;
        private System.Windows.Forms.TabPage GetPage;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button SMTPconfig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button upDate;
        private System.Windows.Forms.Button POPconfigEdit;
        private System.Windows.Forms.RichTextBox getMessageBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox AttachTextBox;
    }
}

