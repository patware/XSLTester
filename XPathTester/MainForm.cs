using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace XPathTester
{
    public partial class MainForm : Form
    {
        private XPathDocument _xPathDocument = null;
        private Hashtable _namespaces = null;
		private XmlDocument _loadedXml = new XmlDocument();

        public MainForm()
        {
            InitializeComponent();
		}

		#region GUI Handlers
		private void fileOpenButton_Click(object sender, EventArgs e)
        {
			FileInfo file = null;

			if (this.textboxFilename.Text.Trim().Length > 0)
			{
				file = new FileInfo(this.textboxFilename.Text);
				this.openFileDialog1.InitialDirectory = file.Directory.FullName;
			}
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				file = new FileInfo(this.openFileDialog1.FileName);

				loadGivenFile(file);
				this.textboxFilename.Text = file.FullName;
			}
            
        }
        private void inputXmlTextbox_TextChanged(object sender, EventArgs e)
        {
			
			try
			{
				if (textboxInputXml.Focused)
				{
					_loadedXml.LoadXml(this.textboxInputXml.Text);

					loadNamespaces();
				}

				FileInfo fi = new FileInfo(Application.ExecutablePath);

				_loadedXml.Save(fi.Directory + @"\input.xml");

				_xPathDocument = new XPathDocument(fi.Directory + @"\input.xml");
				this.textboxResultXml.Text = parseXPath(this.textboxXPath.Text);
			}
			catch (Exception ex)
			{
				this.textboxResultXml.Text = string.Format("Message=[{0}]", ex.Message);
			}

        }
        private void XPathTextbox_TextChanged(object sender, EventArgs e)
        {
            this.textboxResultXml.Text = parseXPath(this.textboxXPath.Text);
		}
        private void MainForm_Load(object sender, EventArgs e)
        {
            _namespaces = new Hashtable();
        }
		private void filenameTextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				FileInfo file = new FileInfo(this.textboxFilename.Text);

				loadGivenFile(file);
				e.Handled = true;
			}
		}
		private void linkLabelReformat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.textboxInputXml.Text = format();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void linkLabelSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.textboxInputXml.Text.Trim().Length > 0)
			{
				if (this.textboxFilename.Text.Trim().Length > 0)
				{
					FileInfo file = new FileInfo(this.textboxFilename.Text);
					bool write = true;

					if (file.Exists)
						if (MessageBox.Show(string.Format("File [{0}] already exists, do you want to overwrite?", file.Name), "Overwrite?", MessageBoxButtons.YesNo) == DialogResult.No)
							write = false;

					if (write)
					{
						_loadedXml.Save(file.FullName);
					}
				}
			}
		}
		private void treeViewNodeHierarchy_AfterSelect(object sender, TreeViewEventArgs e)
		{
			XmlNode xmlNode = (XmlNode)e.Node.Tag;

			if (e.Node.Nodes.Count == 0 && xmlNode.HasChildNodes)
				loadChildren(e.Node, xmlNode);

			XmlNode thisNode = xmlNode.CloneNode(false);
			this.textBoxSelectedNode.Text = thisNode.OuterXml;

			if (comboBoxTracking.SelectedIndex > 0)
			{
				this.textboxXPath.Text = getPath(comboBoxTracking.SelectedIndex, xmlNode);
			}
		}
		private void comboBoxTracking_SelectedIndexChanged(object sender, EventArgs e)
		{
			TreeNode node = this.treeViewNodeHierarchy.SelectedNode;

			if (node != null)
			{
				if (comboBoxTracking.SelectedIndex > 0)
				{
					XmlNode xmlNode = (XmlNode)node.Tag;
					this.textboxXPath.Text = getPath(comboBoxTracking.SelectedIndex, xmlNode);
				}
			}
		}
		#endregion

		#region Private Methods
		private string parseXPath(string xPath)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                if (_xPathDocument != null)
                {
                    XPathNavigator navigator = _xPathDocument.CreateNavigator();
                    XPathExpression expression = navigator.Compile(xPath);

                    XmlNamespaceManager xnm = new XmlNamespaceManager(new NameTable());

                    foreach (DictionaryEntry de in _namespaces)
                    {
                        xnm.AddNamespace((string)de.Key, (string)de.Value);
                    }

                    expression.SetContext(xnm);

                    XPathNodeIterator xni = navigator.Select(expression);

                    sb.AppendFormat("Count: [{0}]", xni.Count);
                    sb.AppendLine();
                    while (xni.MoveNext())
                    {
                        sb.AppendFormat("[{0}] - {1}", xni.CurrentPosition, xni.Current.OuterXml);
                        sb.AppendLine();
                    }
                }
            }
            catch (Exception ex)
            {
                sb.Append(ex.Message);
                sb.AppendLine();
            }

            return sb.ToString();
        }
        private void loadNamespaces()
        {
            _namespaces.Clear();

			loadNamespaces(_loadedXml.DocumentElement);

            this.listboxNamespace.BeginUpdate();
			this.listboxNamespace.Items.Clear();

            foreach (DictionaryEntry de in _namespaces)
            {
				this.listboxNamespace.Items.Add(de.Key + "\t" + de.Value);
            }

            this.listboxNamespace.EndUpdate();
        }
        private void loadNamespaces(XmlNode node)
        {
			if (node != null)
			{
				if (node.NamespaceURI != null && node.NamespaceURI.Length > 0)
				{
					if (node.Prefix != null && node.Prefix.Length > 0)
					{
						if (node.Prefix == "xmlns")
						{
							if (node.LocalName != null && node.LocalName.Length > 0)
							{
								if (!_namespaces.ContainsKey(node.LocalName))
									_namespaces.Add(node.LocalName, node.Value);
							}
						}
						else
						{
							if (!_namespaces.ContainsKey(node.Prefix))
								_namespaces.Add(node.Prefix, node.NamespaceURI);
						}
					}
					else
						if (!_namespaces.ContainsKey("ns"))
							_namespaces.Add("ns", node.NamespaceURI);
				}
				if (node.Attributes != null)
				{
					foreach (XmlAttribute attrib in node.Attributes)
					{
						loadNamespaces((XmlNode)attrib);
					}
				}

				if (node.ChildNodes != null)
				{
					foreach (XmlNode child in node.ChildNodes)
					{
						loadNamespaces(child);
					}
				}
			}
        }
		private void loadGivenFile(FileInfo file)
		{
			string content="";

			try
			{
				//load the TreeView
				this.treeViewNodeHierarchy.BeginUpdate();
				this.treeViewNodeHierarchy.Nodes.Clear();

				if (file.Exists)
				{
					_loadedXml.Load(file.FullName);
					loadNamespaces();

					content = format();

					TreeNode node = new TreeNode();
					node.Text = _loadedXml.DocumentElement.Name;
					node.Tag = _loadedXml.DocumentElement;
					this.treeViewNodeHierarchy.Nodes.Add(node);
				}
				else
				{
					content = "File doesn't exist";
				}
			}
			catch (Exception ex)
			{
				content = ex.Message;
			}
			finally
			{
				this.treeViewNodeHierarchy.EndUpdate();
			}

			this.textboxInputXml.Text = content;
		}
		private string format()
		{
			string content = "";

			using (StringWriter stringWriter = new StringWriter())
			{
				using (XmlNodeReader xmlNodeReader = new XmlNodeReader(_loadedXml))
				{
					XmlWriterSettings settings = new XmlWriterSettings();
					settings.Indent = true;
					settings.IndentChars = "\t";
					settings.NewLineChars = "\r\n";
					settings.NewLineOnAttributes = true;
					using (XmlWriter tw = XmlWriter.Create(stringWriter,settings))
					{
						//tw.Formatting = Formatting.Indented;
						//tw.Indentation = 1;
						//tw.IndentChar = '\t';
						
						tw.WriteNode(xmlNodeReader, false);

						tw.Flush();

						content = stringWriter.ToString();
					}
				}
			}

			return content;
		}
		private void loadChildren(TreeNode parentNode, XmlNode parentXml)
		{

			foreach (XmlNode childXml in parentXml.ChildNodes)
			{
				TreeNode childNode = new TreeNode();
				childNode.Text = childXml.Name;
				childNode.Tag = childXml;

				parentNode.Nodes.Add(childNode);

			}

		}
		private string getPath(int trackingType, XmlNode node)
		{
			XmlNode runner = node;

			Stack<string> stack = new Stack<string>();

			switch (trackingType)
			{
				case 1: //Node Name only
					do
					{
						runner = runner.ParentNode;

					} while (runner !=null && runner.Name != "#document");

					break;
				case 2: //Positional
					do
					{
						stack.Push(runner.Name);
						runner = runner.ParentNode;
					} while (runner != null && runner.Name != "#document");
					break;
				case 3: //Attribute differentiator
					do
					{
						stack.Push(runner.Name);
						runner = runner.ParentNode;

					} while (runner != null && runner.Name != "#document");
					break;
			}

			return string.Join("/", stack.ToArray());

			
		}
		#endregion

		private void listboxNamespace_SelectedValueChanged(object sender, EventArgs e)
		{


		}

		private void listboxNamespace_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] s = listboxNamespace.Items[listboxNamespace.SelectedIndex].ToString().Split('\t');

			this.textboxXPath.Text = "//" + s[0] + ":*";
		}


		



	}
}