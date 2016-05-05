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
            Gnostice.PDFOne.Windows.PDFViewer.ViewerPreferences viewerPreferences1 = new Gnostice.PDFOne.Windows.PDFViewer.ViewerPreferences();
            Gnostice.PDFOne.RenderingSettings renderingSettings1 = new Gnostice.PDFOne.RenderingSettings();
            Gnostice.PDFOne.ImageSettings imageSettings1 = new Gnostice.PDFOne.ImageSettings();
            Gnostice.PDFOne.PDFRenderOptions pdfRenderOptions1 = new Gnostice.PDFOne.PDFRenderOptions();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sendPage = new System.Windows.Forms.TabPage();
            this.Send = new System.Windows.Forms.Button();
            this.SMTPconfig = new System.Windows.Forms.Button();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.mailtoBox = new System.Windows.Forms.TextBox();
            this.nicknameBox = new System.Windows.Forms.TextBox();
            this.textMessageBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GetPage = new System.Windows.Forms.TabPage();
            this.pdfViewer1 = new Gnostice.PDFOne.Windows.PDFViewer.PDFViewer();
            this.AttachTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.upDate = new System.Windows.Forms.Button();
            this.POPconfigEdit = new System.Windows.Forms.Button();
            this.getMessageBox = new System.Windows.Forms.RichTextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(1004, 695);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // sendPage
            // 
            this.sendPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendPage.Controls.Add(this.Send);
            this.sendPage.Controls.Add(this.SMTPconfig);
            this.sendPage.Controls.Add(this.subjectBox);
            this.sendPage.Controls.Add(this.mailtoBox);
            this.sendPage.Controls.Add(this.nicknameBox);
            this.sendPage.Controls.Add(this.textMessageBox);
            this.sendPage.Controls.Add(this.label4);
            this.sendPage.Controls.Add(this.label3);
            this.sendPage.Controls.Add(this.label2);
            this.sendPage.Controls.Add(this.label1);
            this.sendPage.Location = new System.Drawing.Point(4, 24);
            this.sendPage.Name = "sendPage";
            this.sendPage.Padding = new System.Windows.Forms.Padding(1);
            this.sendPage.Size = new System.Drawing.Size(996, 667);
            this.sendPage.TabIndex = 0;
            this.sendPage.Text = "Отправить сообщение";
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.DarkCyan;
            this.Send.FlatAppearance.BorderSize = 0;
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Send.Location = new System.Drawing.Point(770, 621);
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
            this.SMTPconfig.Location = new System.Drawing.Point(554, 621);
            this.SMTPconfig.Name = "SMTPconfig";
            this.SMTPconfig.Size = new System.Drawing.Size(210, 30);
            this.SMTPconfig.TabIndex = 8;
            this.SMTPconfig.Text = "Настройка конфигурации";
            this.SMTPconfig.UseVisualStyleBackColor = false;
            this.SMTPconfig.Click += new System.EventHandler(this.SMTPconfig_Click);
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(148, 67);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(832, 27);
            this.subjectBox.TabIndex = 7;
            // 
            // mailtoBox
            // 
            this.mailtoBox.Location = new System.Drawing.Point(148, 36);
            this.mailtoBox.Name = "mailtoBox";
            this.mailtoBox.Size = new System.Drawing.Size(832, 27);
            this.mailtoBox.TabIndex = 6;
            // 
            // nicknameBox
            // 
            this.nicknameBox.Location = new System.Drawing.Point(148, 5);
            this.nicknameBox.Name = "nicknameBox";
            this.nicknameBox.Size = new System.Drawing.Size(832, 27);
            this.nicknameBox.TabIndex = 5;
            // 
            // textMessageBox
            // 
            this.textMessageBox.Location = new System.Drawing.Point(8, 116);
            this.textMessageBox.Name = "textMessageBox";
            this.textMessageBox.Size = new System.Drawing.Size(972, 493);
            this.textMessageBox.TabIndex = 4;
            this.textMessageBox.Text = "";
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
            this.GetPage.Controls.Add(this.pdfViewer1);
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
            this.GetPage.Size = new System.Drawing.Size(996, 667);
            this.GetPage.TabIndex = 1;
            this.GetPage.Text = "Входящие сообщения";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BorderWidth = 10;
            this.pdfViewer1.Document = null;
            this.pdfViewer1.HScrollBar = Gnostice.PDFOne.Windows.PDFViewer.ScrollBarVisibility.Always;
            this.pdfViewer1.HScrollValue = 0;
            this.pdfViewer1.KeyNavigationEnabled = true;
            this.pdfViewer1.Location = new System.Drawing.Point(400, 270);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(18, 39, 18, 39);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.PageBufferCount = 2;
            this.pdfViewer1.PageRotationAngle = Gnostice.PDFOne.Windows.PDFViewer.RotationAngle.Zero;
            this.pdfViewer1.Password = "";
            renderingSettings1.AnnotsRenderingRule = ((Gnostice.PDFOne.ItemsRenderingRule)((((Gnostice.PDFOne.ItemsRenderingRule.ifPrintableTrue | Gnostice.PDFOne.ItemsRenderingRule.ifPrintableFalse) 
            | Gnostice.PDFOne.ItemsRenderingRule.ifHiddenFalse) 
            | Gnostice.PDFOne.ItemsRenderingRule.ifNoViewFalse)));
            renderingSettings1.FormfieldsRenderingRule = ((Gnostice.PDFOne.ItemsRenderingRule)((((Gnostice.PDFOne.ItemsRenderingRule.ifPrintableTrue | Gnostice.PDFOne.ItemsRenderingRule.ifPrintableFalse) 
            | Gnostice.PDFOne.ItemsRenderingRule.ifHiddenFalse) 
            | Gnostice.PDFOne.ItemsRenderingRule.ifNoViewFalse)));
            imageSettings1.ColorMode = Gnostice.PDFOne.ColorMode.Color;
            renderingSettings1.Image = imageSettings1;
            renderingSettings1.ItemsToRender = ((Gnostice.PDFOne.ItemsToRender)(((((Gnostice.PDFOne.ItemsToRender.Annots | Gnostice.PDFOne.ItemsToRender.FormFields) 
            | Gnostice.PDFOne.ItemsToRender.Images) 
            | Gnostice.PDFOne.ItemsToRender.Text) 
            | Gnostice.PDFOne.ItemsToRender.Shapes)));
            viewerPreferences1.RenderingSettings = renderingSettings1;
            this.pdfViewer1.Preferences = viewerPreferences1;
            pdfRenderOptions1.SmoothImages = true;
            pdfRenderOptions1.SmoothLineart = true;
            pdfRenderOptions1.SmoothText = true;
            this.pdfViewer1.RenderingOptions = pdfRenderOptions1;
            this.pdfViewer1.Size = new System.Drawing.Size(577, 345);
            this.pdfViewer1.StdZoomType = Gnostice.PDFOne.Windows.PDFViewer.StandardZoomType.FitWidth;
            this.pdfViewer1.TabIndex = 19;
            this.pdfViewer1.Visible = false;
            this.pdfViewer1.VScrollBar = Gnostice.PDFOne.Windows.PDFViewer.ScrollBarVisibility.Always;
            this.pdfViewer1.VScrollValue = 0;
            this.pdfViewer1.ZoomPercent = 100D;
            // 
            // AttachTextBox
            // 
            this.AttachTextBox.Location = new System.Drawing.Point(400, 271);
            this.AttachTextBox.Name = "AttachTextBox";
            this.AttachTextBox.Size = new System.Drawing.Size(580, 344);
            this.AttachTextBox.TabIndex = 18;
            this.AttachTextBox.Text = "";
            this.AttachTextBox.Visible = false;
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
            this.label6.Location = new System.Drawing.Point(395, 243);
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
            this.label5.Location = new System.Drawing.Point(395, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Текст сообщения:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 344);
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
            this.treeView1.Size = new System.Drawing.Size(384, 616);
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
            this.upDate.Location = new System.Drawing.Point(770, 621);
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
            this.POPconfigEdit.Location = new System.Drawing.Point(554, 621);
            this.POPconfigEdit.Name = "POPconfigEdit";
            this.POPconfigEdit.Size = new System.Drawing.Size(210, 30);
            this.POPconfigEdit.TabIndex = 11;
            this.POPconfigEdit.Text = "Настройка конфигурации";
            this.POPconfigEdit.UseVisualStyleBackColor = false;
            this.POPconfigEdit.Click += new System.EventHandler(this.POPconfigEdit_Click);
            // 
            // getMessageBox
            // 
            this.getMessageBox.Location = new System.Drawing.Point(400, 35);
            this.getMessageBox.Name = "getMessageBox";
            this.getMessageBox.Size = new System.Drawing.Size(577, 205);
            this.getMessageBox.TabIndex = 10;
            this.getMessageBox.Text = "";
            // 
            // SendGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(995, 688);
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
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.TextBox mailtoBox;
        private System.Windows.Forms.TextBox nicknameBox;
        private System.Windows.Forms.RichTextBox textMessageBox;
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
        private Gnostice.PDFOne.Windows.PDFViewer.PDFViewer pdfViewer1;
    }
}

