namespace XPathTester
{
    partial class MainForm
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textboxInputXml = new System.Windows.Forms.TextBox();
			this.linkLabelSave = new System.Windows.Forms.LinkLabel();
			this.linkLabelReformat = new System.Windows.Forms.LinkLabel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.treeViewNodeHierarchy = new System.Windows.Forms.TreeView();
			this.listboxNamespace = new System.Windows.Forms.ListBox();
			this.fileOpenButton = new System.Windows.Forms.Button();
			this.textboxFilename = new System.Windows.Forms.TextBox();
			this.textboxResultXml = new System.Windows.Forms.TextBox();
			this.textboxXPath = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.textBoxSelectedNode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxTracking = new System.Windows.Forms.ComboBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
			this.splitContainer1.Panel1.Controls.Add(this.listboxNamespace);
			this.splitContainer1.Panel1.Controls.Add(this.fileOpenButton);
			this.splitContainer1.Panel1.Controls.Add(this.textboxFilename);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textboxResultXml);
			this.splitContainer1.Panel2.Controls.Add(this.textboxXPath);
			this.splitContainer1.Size = new System.Drawing.Size(649, 500);
			this.splitContainer1.SplitterDistance = 278;
			this.splitContainer1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 99);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(277, 398);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textboxInputXml);
			this.tabPage1.Controls.Add(this.linkLabelSave);
			this.tabPage1.Controls.Add(this.linkLabelReformat);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(269, 372);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Xml file";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// textboxInputXml
			// 
			this.textboxInputXml.AcceptsReturn = true;
			this.textboxInputXml.AcceptsTab = true;
			this.textboxInputXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textboxInputXml.Location = new System.Drawing.Point(0, 0);
			this.textboxInputXml.MaxLength = 327670;
			this.textboxInputXml.Multiline = true;
			this.textboxInputXml.Name = "textboxInputXml";
			this.textboxInputXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textboxInputXml.Size = new System.Drawing.Size(266, 353);
			this.textboxInputXml.TabIndex = 3;
			this.textboxInputXml.WordWrap = false;
			this.textboxInputXml.TextChanged += new System.EventHandler(this.inputXmlTextbox_TextChanged);
			// 
			// linkLabelSave
			// 
			this.linkLabelSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabelSave.AutoSize = true;
			this.linkLabelSave.Location = new System.Drawing.Point(126, 356);
			this.linkLabelSave.Name = "linkLabelSave";
			this.linkLabelSave.Size = new System.Drawing.Size(32, 13);
			this.linkLabelSave.TabIndex = 4;
			this.linkLabelSave.TabStop = true;
			this.linkLabelSave.Text = "Save";
			this.linkLabelSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSave_LinkClicked);
			// 
			// linkLabelReformat
			// 
			this.linkLabelReformat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabelReformat.AutoSize = true;
			this.linkLabelReformat.Location = new System.Drawing.Point(70, 356);
			this.linkLabelReformat.Name = "linkLabelReformat";
			this.linkLabelReformat.Size = new System.Drawing.Size(50, 13);
			this.linkLabelReformat.TabIndex = 4;
			this.linkLabelReformat.TabStop = true;
			this.linkLabelReformat.Text = "Reformat";
			this.linkLabelReformat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReformat_LinkClicked);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.splitContainer2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(269, 372);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Treeview";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// treeViewNodeHierarchy
			// 
			this.treeViewNodeHierarchy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewNodeHierarchy.Location = new System.Drawing.Point(0, 0);
			this.treeViewNodeHierarchy.Name = "treeViewNodeHierarchy";
			this.treeViewNodeHierarchy.Size = new System.Drawing.Size(263, 235);
			this.treeViewNodeHierarchy.TabIndex = 0;
			this.treeViewNodeHierarchy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNodeHierarchy_AfterSelect);
			// 
			// listboxNamespace
			// 
			this.listboxNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listboxNamespace.FormattingEnabled = true;
			this.listboxNamespace.Location = new System.Drawing.Point(3, 29);
			this.listboxNamespace.Name = "listboxNamespace";
			this.listboxNamespace.Size = new System.Drawing.Size(277, 69);
			this.listboxNamespace.TabIndex = 2;
			this.listboxNamespace.SelectedIndexChanged += new System.EventHandler(this.listboxNamespace_SelectedIndexChanged);
			this.listboxNamespace.SelectedValueChanged += new System.EventHandler(this.listboxNamespace_SelectedValueChanged);
			// 
			// fileOpenButton
			// 
			this.fileOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fileOpenButton.Location = new System.Drawing.Point(250, 3);
			this.fileOpenButton.Name = "fileOpenButton";
			this.fileOpenButton.Size = new System.Drawing.Size(25, 23);
			this.fileOpenButton.TabIndex = 1;
			this.fileOpenButton.Text = "...";
			this.fileOpenButton.UseVisualStyleBackColor = true;
			this.fileOpenButton.Click += new System.EventHandler(this.fileOpenButton_Click);
			// 
			// textboxFilename
			// 
			this.textboxFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textboxFilename.Location = new System.Drawing.Point(3, 3);
			this.textboxFilename.Name = "textboxFilename";
			this.textboxFilename.Size = new System.Drawing.Size(241, 20);
			this.textboxFilename.TabIndex = 0;
			this.textboxFilename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filenameTextbox_KeyPress);
			// 
			// textboxResultXml
			// 
			this.textboxResultXml.AcceptsReturn = true;
			this.textboxResultXml.AcceptsTab = true;
			this.textboxResultXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textboxResultXml.Location = new System.Drawing.Point(4, 32);
			this.textboxResultXml.MaxLength = 327670;
			this.textboxResultXml.Multiline = true;
			this.textboxResultXml.Name = "textboxResultXml";
			this.textboxResultXml.Size = new System.Drawing.Size(360, 466);
			this.textboxResultXml.TabIndex = 1;
			this.textboxResultXml.WordWrap = false;
			// 
			// textboxXPath
			// 
			this.textboxXPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textboxXPath.Location = new System.Drawing.Point(4, 7);
			this.textboxXPath.Name = "textboxXPath";
			this.textboxXPath.Size = new System.Drawing.Size(360, 20);
			this.textboxXPath.TabIndex = 0;
			this.textboxXPath.TextChanged += new System.EventHandler(this.XPathTextbox_TextChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "xml";
			this.openFileDialog1.Filter = "Xml Files|*.xml";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(3, 3);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.comboBoxTracking);
			this.splitContainer2.Panel1.Controls.Add(this.label1);
			this.splitContainer2.Panel1.Controls.Add(this.treeViewNodeHierarchy);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.textBoxSelectedNode);
			this.splitContainer2.Size = new System.Drawing.Size(263, 366);
			this.splitContainer2.SplitterDistance = 264;
			this.splitContainer2.TabIndex = 1;
			// 
			// textBoxSelectedNode
			// 
			this.textBoxSelectedNode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxSelectedNode.Location = new System.Drawing.Point(0, 0);
			this.textBoxSelectedNode.Multiline = true;
			this.textBoxSelectedNode.Name = "textBoxSelectedNode";
			this.textBoxSelectedNode.Size = new System.Drawing.Size(263, 98);
			this.textBoxSelectedNode.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 243);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Track XPath";
			// 
			// comboBoxTracking
			// 
			this.comboBoxTracking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxTracking.FormattingEnabled = true;
			this.comboBoxTracking.Items.AddRange(new object[] {
            "None",
            "Node Name only"});
			this.comboBoxTracking.Location = new System.Drawing.Point(75, 240);
			this.comboBoxTracking.Name = "comboBoxTracking";
			this.comboBoxTracking.Size = new System.Drawing.Size(185, 21);
			this.comboBoxTracking.TabIndex = 2;
			this.comboBoxTracking.SelectedIndexChanged += new System.EventHandler(this.comboBoxTracking_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 500);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "MainForm";
			this.Text = "XPathTester 0.1 - by Patware";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textboxInputXml;
        private System.Windows.Forms.Button fileOpenButton;
        private System.Windows.Forms.TextBox textboxFilename;
        private System.Windows.Forms.TextBox textboxResultXml;
        private System.Windows.Forms.TextBox textboxXPath;
        private System.Windows.Forms.ListBox listboxNamespace;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.LinkLabel linkLabelSave;
		private System.Windows.Forms.LinkLabel linkLabelReformat;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TreeView treeViewNodeHierarchy;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TextBox textBoxSelectedNode;
		private System.Windows.Forms.ComboBox comboBoxTracking;
		private System.Windows.Forms.Label label1;
    }
}

