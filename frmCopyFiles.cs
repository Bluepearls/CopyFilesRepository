using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CopyFiles
{
    public partial class frmCopyFiles : Form
    {
        public string FilePath = System.AppDomain.CurrentDomain.BaseDirectory + "CopyFiles.cfg";
        public frmCopyFiles()
        {
            InitializeComponent();
        }
        private void frmCopyFiles_Load(object sender, EventArgs e)
        {
            SetControls(FilePath);
        }

        private void SetControls(string filePath)
        {
            if (File.Exists(filePath))
            {
                XElement xe = XElement.Load(filePath);
                IEnumerable<XElement> elements = from ele in xe.Elements("Settings")
                                                 select ele;
                foreach (var ele in elements)
                {
                    this.txtSourcePath.Text = ele.Element("SourcePath").Value;
                    this.txtTargetPath.Text = ele.Element("TargetPath").Value;
                    this.txtSolutionName.Text = ele.Element("SolutionName").Value;
                    this.txtUrl.Text = ele.Element("Url").Value;
                }
            }
            else
            {
                this.txtTargetPath.Text = @"C:\inetpub\wwwroot\FlexFlowWeb";
                this.txtUrl.Text = @"http://localhost/FlexFlowWeb";
            }
            this.cboCopyView.Checked = true;
            this.cboCopyDll.Checked = true;
        }

        private void btnCopyAndPaste_Click(object sender, EventArgs e)
        {
            this.pnlMessage.Visible = false;
            this.lblMessage.Text = "";
            if (string.IsNullOrEmpty(txtSolutionName.Text.ToString()))
            {
                ShowError("Solution name can not be null！");
                txtSolutionName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSourcePath.Text.ToString()))
            {
                ShowError("Source path can not be null！");
                txtSourcePath.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTargetPath.Text.ToString()))
            {
                ShowError("target path can not be null ！");
                txtSourcePath.Focus();
                return;
            }
            bool copy = CopyDirectory(this.txtSourcePath.Text, this.txtTargetPath.Text, this.txtSolutionName.Text, true, this.cboCopyView.Checked, this.cboCopyDll.Checked);
            if (copy)
            {
                this.pnlMessage.Visible = true;
                this.lblMessage.ForeColor = Color.Green;
                this.lblMessage.Text = "Copy Succeed.";
                IDictionary<string, string> writeXMLValue = new Dictionary<string, string>();
                writeXMLValue.Add("SolutionName", this.txtSolutionName.Text);
                writeXMLValue.Add("SourcePath", this.txtSourcePath.Text);
                writeXMLValue.Add("TargetPath", this.txtTargetPath.Text);
                writeXMLValue.Add("Url", this.txtUrl.Text);
                SaveFile(writeXMLValue);
                if (this.cboRestart.Checked == true)
                {
                    CloseGoogle();
                    OpenGoogle(txtUrl.Text.ToString());
                }
            }
            else
            {
                this.pnlMessage.Visible = true;
                this.lblMessage.ForeColor = Color.Red;
                this.lblMessage.Text = "Copy Failed.";
            }
        }

        private void ShowError(string message)
        {
            this.pnlMessage.Visible = true;
            this.lblMessage.ForeColor = Color.Red;
            this.lblMessage.Text = message;
        }

        private void SaveFile(IDictionary<string, string> writeXMLValue)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument = GetXML(writeXMLValue);
            xmlDocument.Save(FilePath);
        }

        private XmlDocument GetXML(IDictionary<string, string> writeXMLValue)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null));
            XmlElement Root = xmlDocument.CreateElement("CopyFiles");
            xmlDocument.AppendChild(Root);
            XmlElement Node = xmlDocument.CreateElement("Settings");
            foreach (var item in writeXMLValue)
            {
                XmlElement ChildNode = xmlDocument.CreateElement(item.Key);
                ChildNode.InnerText = item.Value;
                Node.AppendChild(ChildNode);
            }
            Root.AppendChild(Node);
            return xmlDocument;
        }

        private void CloseGoogle()
        {
            System.Diagnostics.Process[] myProcesses;
            myProcesses = System.Diagnostics.Process.GetProcessesByName("chrome");
            foreach (System.Diagnostics.Process instance in myProcesses)
            {
                instance.CloseMainWindow();
            }
        }

        public static void OpenGoogle(string url)
        {
            try
            {
                var openKey = @"SOFTWARE\Wow6432Node\Google\Chrome";
                if (IntPtr.Size == 4)
                {
                    openKey = @"SOFTWARE\Google\Chrome";
                }
                RegistryKey appPath = Registry.LocalMachine.OpenSubKey(openKey);
                if (appPath != null)
                {
                    System.Diagnostics.Process.Start("chrome.exe", url);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static bool CopyDirectory(string sourcePath, string destinationPath, string fileText, bool overwriteexisting, bool needcopyView, bool needcopyDLL)
        {
            bool ret = false;
            try
            {
                var sourcePathValue = sourcePath.EndsWith(@"\") ? sourcePath : sourcePath + @"\";
                var destinationPathValue = destinationPath.EndsWith(@"\") ? destinationPath : destinationPath + @"\";

                if (Directory.Exists(sourcePathValue))
                {
                    if (needcopyDLL)
                    {
                        CopyFiles(sourcePathValue + @"\bin\", destinationPathValue + @"\bin\", fileText, overwriteexisting);
                    }
                    if (needcopyView)
                    {
                        if (!CopyView(sourcePathValue + @"\Areas\", destinationPathValue + @"Areas\", true))
                        {
                            ret = false;
                        }
                    }
                    ret = true;
                }
            }
            catch (Exception ex)
            {

                ret = false;
                throw new Exception(ex.Message);
            }
            return ret;
        }

        private static bool CopyView(string sourcePathRelease, string targetPathRelease, bool overwriteexisting)
        {
            bool ret = false;
            try
            {
                var sourcePathReleaseValue = sourcePathRelease.EndsWith(@"\") ? sourcePathRelease : sourcePathRelease + @"\";
                var targetPathReleaseValue = targetPathRelease.EndsWith(@"\") ? targetPathRelease : targetPathRelease + @"\";
                CopyFiles(sourcePathReleaseValue, targetPathReleaseValue, "", overwriteexisting);
                foreach (string drs in Directory.GetDirectories(sourcePathReleaseValue))
                {
                    DirectoryInfo drinfo = new DirectoryInfo(drs);
                    if (drinfo.Name != "Controllers" && drinfo.Name != "Infrastructure" && drinfo.Name != "ViewModels" && drinfo.Name != "Shared")
                    {
                        if (CopyView(drs, targetPathReleaseValue + drinfo.Name, overwriteexisting) == false)
                            ret = false;
                    }
                }

                ret = true;
            }
            catch (Exception ex)
            {
                ret = false;
                throw new Exception(ex.Message);
            }
            return ret;
        }

        private static void CopyFiles(string sourcePathValue, string destinationPathValue, string fileText, bool overwriteexisting)
        {
            if (Directory.Exists(sourcePathValue))
            {
                if (Directory.Exists(destinationPathValue) == false)
                    Directory.CreateDirectory(destinationPathValue);

                foreach (string fls in Directory.GetFiles(sourcePathValue))
                {
                    FileInfo flinfo = new FileInfo(fls);
                    if (fileText != "")
                    {
                        if (flinfo.Name.Contains(fileText) && flinfo.Name.EndsWith("dll"))
                        {
                            if (File.Exists(destinationPathValue + flinfo.Name))
                            {
                                if (!FileContentChanged(sourcePathValue + flinfo.Name, destinationPathValue + flinfo.Name))
                                {
                                    flinfo.CopyTo(destinationPathValue + flinfo.Name, overwriteexisting);
                                }
                            }
                            else
                            {
                                flinfo.CopyTo(destinationPathValue + flinfo.Name, overwriteexisting);
                            }
                        }
                    }
                    else
                    {
                        if (File.Exists(destinationPathValue + flinfo.Name))
                        {
                            if (!flinfo.Name.Contains("AreaRegistration.cs"))
                            {
                                if (!FileContentChanged(sourcePathValue + flinfo.Name, destinationPathValue + flinfo.Name))
                                {
                                    flinfo.CopyTo(destinationPathValue + flinfo.Name, overwriteexisting);
                                }
                            }
                        }
                        else
                        {
                            if (!flinfo.Name.Contains("AreaRegistration.cs"))
                            {
                                flinfo.CopyTo(destinationPathValue + flinfo.Name, overwriteexisting);
                            }
                        }
                    }
                }
            }
        }

        private void btnTargetPath_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            if (path != "")
            {
                this.txtTargetPath.Text = path;
            }
        }

        private void btnSourcePath_Click(object sender, EventArgs e)
        {

            string path = GetSelectedPath();
            if (path != "")
            {
                this.txtSourcePath.Text = path;
            }

        }

        private string GetSelectedPath()
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "please select a path";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    ShowError("the path can not be null！");
                    return "";
                }
                return dialog.SelectedPath;
            }
            return "";
        }

        public static bool FileContentChanged(string sourthpath, string targetpath)
        {
            using (HashAlgorithm hash = HashAlgorithm.Create())
            {
                using (FileStream file1 = new FileStream(sourthpath, FileMode.Open), file2 = new FileStream(targetpath, FileMode.Open))
                {
                    byte[] hashByte1 = hash.ComputeHash(file1);
                    byte[] hashByte2 = hash.ComputeHash(file2);
                    string str1 = BitConverter.ToString(hashByte1);
                    string str2 = BitConverter.ToString(hashByte2);
                    return (str1 == str2);
                }
            }
        }

    }
}