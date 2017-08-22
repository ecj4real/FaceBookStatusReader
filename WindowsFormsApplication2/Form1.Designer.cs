namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.signInButton = new System.Windows.Forms.Button();
            this.webFacebook = new System.Windows.Forms.WebBrowser();
            this.getStatusButton = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.ExportToExcelButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signInFaceBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutFaceBookStausReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutFaceBookReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.Label();
            this.firstPostDateLabel = new System.Windows.Forms.Label();
            this.lastPostDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(365, 460);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // webFacebook
            // 
            this.webFacebook.Location = new System.Drawing.Point(3, 35);
            this.webFacebook.MinimumSize = new System.Drawing.Size(20, 20);
            this.webFacebook.Name = "webFacebook";
            this.webFacebook.Size = new System.Drawing.Size(345, 377);
            this.webFacebook.TabIndex = 0;
            this.webFacebook.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webFacebook_DocumentCompleted);
            // 
            // getStatusButton
            // 
            this.getStatusButton.Location = new System.Drawing.Point(446, 460);
            this.getStatusButton.Name = "getStatusButton";
            this.getStatusButton.Size = new System.Drawing.Size(151, 23);
            this.getStatusButton.TabIndex = 1;
            this.getStatusButton.Text = "Show Status";
            this.getStatusButton.UseVisualStyleBackColor = true;
            this.getStatusButton.Visible = false;
            this.getStatusButton.Click += new System.EventHandler(this.getStatusButton_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(354, 35);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(541, 377);
            this.axAcroPDF1.TabIndex = 2;
            // 
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.Location = new System.Drawing.Point(603, 460);
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(156, 23);
            this.ExportToExcelButton.TabIndex = 3;
            this.ExportToExcelButton.Text = "Export to Excel";
            this.ExportToExcelButton.UseVisualStyleBackColor = true;
            this.ExportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "fbMenuStrip";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInFaceBookToolStripMenuItem,
            this.showStatusToolStripMenuItem1,
            this.toolStripSeparator4,
            this.exportToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // signInFaceBookToolStripMenuItem
            // 
            this.signInFaceBookToolStripMenuItem.Name = "signInFaceBookToolStripMenuItem";
            this.signInFaceBookToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.signInFaceBookToolStripMenuItem.Text = "Sign in (FaceBook)";
            this.signInFaceBookToolStripMenuItem.Click += new System.EventHandler(this.signInFaceBookToolStripMenuItem_Click);
            // 
            // showStatusToolStripMenuItem1
            // 
            this.showStatusToolStripMenuItem1.Enabled = false;
            this.showStatusToolStripMenuItem1.Name = "showStatusToolStripMenuItem1";
            this.showStatusToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.showStatusToolStripMenuItem1.Text = "Show Status";
            this.showStatusToolStripMenuItem1.Click += new System.EventHandler(this.showStatusToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(169, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem1,
            this.toolStripSeparator6,
            this.aboutFaceBookStausReaderToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem1
            // 
            this.documentationToolStripMenuItem1.Name = "documentationToolStripMenuItem1";
            this.documentationToolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.documentationToolStripMenuItem1.Text = "Documentation";
            this.documentationToolStripMenuItem1.Click += new System.EventHandler(this.documentationToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(228, 6);
            // 
            // aboutFaceBookStausReaderToolStripMenuItem
            // 
            this.aboutFaceBookStausReaderToolStripMenuItem.Name = "aboutFaceBookStausReaderToolStripMenuItem";
            this.aboutFaceBookStausReaderToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.aboutFaceBookStausReaderToolStripMenuItem.Text = "About FaceBook Staus Reader";
            this.aboutFaceBookStausReaderToolStripMenuItem.Click += new System.EventHandler(this.aboutFaceBookStausReaderToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutFaceBookReaderToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // aboutFaceBookReaderToolStripMenuItem
            // 
            this.aboutFaceBookReaderToolStripMenuItem.Name = "aboutFaceBookReaderToolStripMenuItem";
            this.aboutFaceBookReaderToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aboutFaceBookReaderToolStripMenuItem.Text = "About FaceBook Reader";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.signInToolStripMenuItem.Text = "Sign in";
            // 
            // showStatusToolStripMenuItem
            // 
            this.showStatusToolStripMenuItem.Enabled = false;
            this.showStatusToolStripMenuItem.Name = "showStatusToolStripMenuItem";
            this.showStatusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showStatusToolStripMenuItem.Text = "Show Status";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exportStatusToolStripMenuItem
            // 
            this.exportStatusToolStripMenuItem.Enabled = false;
            this.exportStatusToolStripMenuItem.Name = "exportStatusToolStripMenuItem";
            this.exportStatusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportStatusToolStripMenuItem.Text = "Export Status";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(28, 429);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(53, 20);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "status";
            this.statusLabel.Visible = false;
            // 
            // firstPostDateLabel
            // 
            this.firstPostDateLabel.AutoSize = true;
            this.firstPostDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPostDateLabel.Location = new System.Drawing.Point(27, 453);
            this.firstPostDateLabel.Name = "firstPostDateLabel";
            this.firstPostDateLabel.Size = new System.Drawing.Size(66, 20);
            this.firstPostDateLabel.TabIndex = 6;
            this.firstPostDateLabel.Text = "firstpost";
            this.firstPostDateLabel.Visible = false;
            // 
            // lastPostDateLabel
            // 
            this.lastPostDateLabel.AutoSize = true;
            this.lastPostDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPostDateLabel.Location = new System.Drawing.Point(27, 477);
            this.lastPostDateLabel.Name = "lastPostDateLabel";
            this.lastPostDateLabel.Size = new System.Drawing.Size(65, 20);
            this.lastPostDateLabel.TabIndex = 7;
            this.lastPostDateLabel.Text = "lastpost";
            this.lastPostDateLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(906, 517);
            this.Controls.Add(this.lastPostDateLabel);
            this.Controls.Add(this.firstPostDateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ExportToExcelButton);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.getStatusButton);
            this.Controls.Add(this.webFacebook);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceBook Status Reader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.WebBrowser webFacebook;
        private System.Windows.Forms.Button getStatusButton;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button ExportToExcelButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutFaceBookReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem signInFaceBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStatusToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem aboutFaceBookStausReaderToolStripMenuItem;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label firstPostDateLabel;
        private System.Windows.Forms.Label lastPostDateLabel;
    }
}

