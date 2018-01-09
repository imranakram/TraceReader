using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using CrmTraceReader.Properties;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Query;

namespace CrmTraceReader
{
    public sealed partial class MainForm : Form
    {
        #region Variables

        private bool applyFilter;

        /// <summary>
        /// Indicates if filters have been loaded
        /// </summary>
        private bool isLoaded;

        /// <summary>
        /// List of each individual traces
        /// </summary>
        private List<TraceInfo> traces;

        /// <summary>
        /// List of each files to load
        /// </summary>
        private List<FileInfo> files;

        private List<OrganizationData> oData;

        private string currentConnection;

        #endregion Variables

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            Text = string.Format("{0} (v{1})", Text, Assembly.GetExecutingAssembly().GetName().Version);

            oData = new List<OrganizationData>();
        }

        #endregion Constructor

        #region Methods

        #region Load file(s)

        private void LoadFile()
        {
            ClearDescription();
            traces = new List<TraceInfo>();
            lvTraces.Items.Clear();
            lvTraces.Visible = false;
            loadingPanel.Visible = true;
            loadingLabel.Text = Resources.LoadingFileLoadingPanelMessage;
          
            var bw = new BackgroundWorker{WorkerReportsProgress = true};
            bw.DoWork += BwLoadFileDoWork;
            bw.ProgressChanged += BwLoadFileProgressChanged;
            bw.RunWorkerCompleted += BwLoadFileRunWorkerCompleted;
            bw.RunWorkerAsync(files);
        }

        private void lvTraces_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

                FileAttributes attr = File.GetAttributes(droppedFiles[0]);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    e.Effect = new DirectoryInfo(droppedFiles[0]).GetFiles("*.log").Length > 0
                        ? DragDropEffects.All
                        : DragDropEffects.None;
                }
                else
                {
                    e.Effect = droppedFiles.ToList().Any(f => !f.EndsWith(".log"))
                        ? DragDropEffects.None
                        : DragDropEffects.All;
                }
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void lvTraces_DragDrop(object sender, DragEventArgs e)
        {
            files = new List<FileInfo>();
            
            FileAttributes attr = File.GetAttributes(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                foreach (var file in new DirectoryInfo(((string[])e.Data.GetData(DataFormats.FileDrop))[0]).GetFiles("*.log"))
                {
                    files.Add(file);
                }
            }
            else
            {
                foreach (var filename in (string[]) e.Data.GetData(DataFormats.FileDrop))
                {
                    files.Add(new FileInfo(filename));
                }
            }

            LoadFile();
        }

        private void FillFilters()
        {
            var orgSelectedText = isLoaded ? cbbOrganization.SelectedItem.ToString() : "*";
            var catSelectedText = isLoaded ? cbbCategory.SelectedItem.ToString() : "*";
            var levSelectedText =  isLoaded ?cbbLevel.SelectedItem.ToString() : "*";
            var opeSelectedText =  isLoaded ?cbbOperation.SelectedItem.ToString() : "*";
            var proSelectedText =  isLoaded ?cbbProcess.SelectedItem.ToString() : "*";
            var thrSelectedText =  isLoaded ?cbbThread.SelectedItem.ToString() : "*";
            var useSelectedText =  isLoaded ?cbbUser.SelectedItem.ToString() : "*";
            var reqSelectedText = isLoaded ? cbbRequId.SelectedItem.ToString() : "*";

            isLoaded = false;
            
            cbbOrganization.Items.Clear();
            cbbCategory.Items.Clear();
            cbbLevel.Items.Clear();
            cbbOperation.Items.Clear();
            cbbProcess.Items.Clear();
            cbbThread.Items.Clear();
            cbbUser.Items.Clear();
            cbbRequId.Items.Clear();

            cbbOrganization.Items.Add("*");
            cbbCategory.Items.Add("*");
            cbbLevel.Items.Add("*");
            cbbOperation.Items.Add("*");
            cbbProcess.Items.Add("*");
            cbbThread.Items.Add("*");
            cbbUser.Items.Add("*");
            cbbRequId.Items.Add("*");

            cbbOrganization.Items.AddRange(traces.OrderBy(a => a.Organization).Select(x => x.Organization).Distinct().Cast<object>().ToArray());
            cbbCategory.Items.AddRange(traces.OrderBy(a => a.Category).Select(x => x.Category).Distinct().Cast<object>().ToArray());
            cbbLevel.Items.AddRange(traces.OrderBy(a => a.Level).Select(x => x.Level).Distinct().Cast<object>().ToArray());
            cbbOperation.Items.AddRange(traces.OrderBy(a => a.Context).Select(x => x.Context).Distinct().Cast<object>().ToArray());
            cbbProcess.Items.AddRange(traces.OrderBy(a => a.Process).Select(x => x.Process).Distinct().Cast<object>().ToArray());
            cbbThread.Items.AddRange(traces.OrderBy(a => a.Thread).Select(x => x.Thread).Distinct().Cast<object>().ToArray());
            cbbUser.Items.AddRange(traces.OrderBy(a => a.User).Select(x => x.User).Distinct().Cast<object>().ToArray());

            if (traces.Any(x => !string.IsNullOrEmpty(x.ReqId)))
                cbbRequId.Items.AddRange(traces.OrderBy(a => a.ReqId).Select(x => x.ReqId).Distinct().Where(x => x.Length > 0).Cast<object>().ToArray());

            cbbOrganization.SelectedIndex = 0;
            cbbCategory.SelectedIndex = 0;
            cbbLevel.SelectedIndex = 0;
            cbbOperation.SelectedIndex = 0;
            cbbProcess.SelectedIndex = 0;
            cbbThread.SelectedIndex = 0;
            cbbUser.SelectedIndex = 0;
            cbbRequId.SelectedIndex = 0;
            
            cbbOrganization.SelectedItem = orgSelectedText;
            cbbCategory.SelectedItem = catSelectedText;
            cbbLevel.SelectedItem = levSelectedText;
            cbbOperation.SelectedItem = opeSelectedText;
            cbbProcess.SelectedItem = proSelectedText;
            cbbThread.SelectedItem = thrSelectedText;
            cbbUser.SelectedItem = useSelectedText;
            cbbRequId.SelectedItem = reqSelectedText; 

            isLoaded = true;
        }

        private List<ListViewItem> DisplayTrace(IEnumerable<TraceInfo> traceList, BackgroundWorker bw)
        {
            if (traceList == null)
                return new List<ListViewItem>();

            int i = 0;
            var traceInfos = traceList as IList<TraceInfo> ?? traceList.ToList();
            int total = traceInfos.Count();
            var lvis = new List<ListViewItem>();
            foreach (var ti in traceInfos)
            {
                var item = new ListViewItem(ti.Date.ToString("yyyy/MM/dd HH:mm:ss.FFF"));
                item.SubItems.Add(ti.Context);
                item.SubItems.Add(ti.Process);
                item.SubItems.Add(ti.Organization);
                item.SubItems.Add(ti.Thread);
                item.SubItems.Add(ti.Category);
                item.SubItems.Add(ti.User);
                item.SubItems.Add(ti.Level);
                item.SubItems.Add(ti.ReqId);
                item.Tag = ti;

                item.ImageIndex = (ti.Level == "Info"
                    ? 0
                    : ti.Level == "Warning" ? 1 : ti.Level == "Verbose" ? 3 : 2);

                item.ForeColor = (ti.Level == "Info"
                    ? Color.FromArgb(74, 125, 177)
                    : ti.Level == "Warning"
                        ? Color.FromArgb(240, 155, 33)
                        : ti.Level == "Verbose" ? Color.Black : Color.FromArgb(216, 3, 3));

                lvis.Add(item);
              
                i++;
                bw.ReportProgress(0, string.Format("Loading traces... ({0}%)", i * 100 / total));
            }

            return lvis;
        }

        #endregion Load file(s)

        #region Filter traces handlers

        private void CbbSelectedValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            Filter();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnClearAllFilters_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            cbbOrganization.SelectedIndex = 0;
            cbbCategory.SelectedIndex = 0;
            cbbLevel.SelectedIndex = 0;
            cbbOperation.SelectedIndex = 0;
            cbbProcess.SelectedIndex = 0;
            cbbThread.SelectedIndex = 0;
            cbbUser.SelectedIndex = 0;
            cbbRequId.SelectedIndex = 0;

            CbbSelectedValueChanged(null, null);
        }

        #endregion Filter traces handlers
       
        #region Menu handlers

        private void TsbOpenFolderClick(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog {Description = Resources.OpenFolderDescriptionMessage };
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                var di = new DirectoryInfo(fbd.SelectedPath);
                files = di.GetFiles("*.log").ToList();
                
                LoadFile();
            }
        }

        private void TsbOpenFileClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { Filter = Resources.OpenFileFilter, Title = Resources.OpenFileTitleMessage };
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                files = new List<FileInfo> {new FileInfo(ofd.FileName)};
                LoadFile();
            }
        }

        private void TsbRefreshClick(object sender, EventArgs e)
        {
            if (files != null && files.Count > 0)
            {
                applyFilter = true;
                LoadFile();
            }
        }

        private void tsbResolveNames_Click(object sender, EventArgs e)
        {
            try
            {
                Assembly.LoadFrom("Microsoft.Xrm.Client.dll");
                Assembly.LoadFrom("Microsoft.Xrm.Sdk.dll");
                Assembly.Load("Microsoft.IdentityModel, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35");
            }
            catch (Exception)
            {
                MessageBox.Show(this,
                    "The following assemblies are required to use the resolve feature:\r\n- Microsoft.Xrm.Client.dll\r\n- Microsoft.Xrm.Sdk.dll\r\n- Microsoft.IdentityModel",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = new ConnectionStringForm(currentConnection);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                currentConnection = dialog.ConnectionString;

                oData = new List<OrganizationData>();

                lvTraces.Items.Clear();
                lvTraces.Visible = false;
                loadingPanel.Visible = true;
                loadingLabel.Text = Resources.SearchingForAvailableOrganizations;

                var bwResolveNameWorker = new BackgroundWorker { WorkerReportsProgress = true };
                bwResolveNameWorker.DoWork += bwResolveNameWorker_DoWork;
                bwResolveNameWorker.ProgressChanged += bwResolveNameWorker_ProgressChanged;
                bwResolveNameWorker.RunWorkerCompleted += bwResolveNameWorker_RunWorkerCompleted;
                bwResolveNameWorker.RunWorkerAsync(dialog.ConnectionString);
            }
        }

        private void tsbClearNameCache_Click(object sender, EventArgs e)
        {
            currentConnection = string.Empty;
            tsslConnection.Text = Resources.NotConnected;
            oData = new List<OrganizationData>();
            LoadFile();
        }

        private void tsbViewXml_Click(object sender, EventArgs e)
        {
            var firstIndex = txtTraceDetail.Text.IndexOf("<", StringComparison.Ordinal);
            var lastIndex = txtTraceDetail.Text.LastIndexOf(">", StringComparison.Ordinal);

            var text = txtTraceDetail.Text.Substring(firstIndex, lastIndex - firstIndex + 1);

            var xmlViewer = new XmlViewer(text);
            xmlViewer.ShowDialog(this);
        }

        private void tsbRate_Click(object sender, EventArgs e)
        {
            Process.Start("http://crmtracereader.codeplex.com/releases");
        }

        private void tsbDiscuss_Click(object sender, EventArgs e)
        {
            Process.Start("http://crmtracereader.codeplex.com/discussions");
        }

        private void tsbReportBug_Click(object sender, EventArgs e)
        {
            Process.Start("http://crmtracereader.codeplex.com/WorkItem/Create");
        }

        #endregion Menu handlers

        #region Others

        private void LvTracesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTraces.SelectedItems.Count == 1)
            {
                txtTraceDetail.Text = ((TraceInfo)lvTraces.SelectedItems[0].Tag).Description;

                try
                {
                    if (txtTraceDetail.Text.IndexOf("<", StringComparison.Ordinal) > 0 && txtTraceDetail.Text.IndexOf(">", StringComparison.Ordinal) > 0)
                    {
                        var firstIndex = txtTraceDetail.Text.IndexOf("<", StringComparison.Ordinal);
                        var lastIndex = txtTraceDetail.Text.LastIndexOf(">", StringComparison.Ordinal);

                        var text = txtTraceDetail.Text.Substring(firstIndex, lastIndex - firstIndex + 1);

                        var xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(text);

                        tsbViewXml.Enabled = true;
                    }
                    else
                    {
                        tsbViewXml.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    tsbViewXml.Enabled = false;
                }
            }
            else
            {
                tsbViewXml.Enabled = false;
                ClearDescription();
            }
        }

        private void LvTracesColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvTraces.Sorting = lvTraces.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;

            lvTraces.ListViewItemSorter = new ListViewItemComparer(e.Column, lvTraces.Sorting);
        }

        private void LoadingPanelResize(object sender, EventArgs e)
        {
            pbLoading.Left = loadingPanel.Width / 2 - 18;
        }

        private void ClearDescription()
        {
            txtTraceDetail.Text = string.Empty;
        }

        private void Filter()
        {
            if (isLoaded)
            {
                lvTraces.Items.Clear();

                List<TraceInfo> filteredList = traces;

                if (cbbCategory.SelectedItem != null && (string)cbbCategory.SelectedItem != "*")
                    filteredList = filteredList.FindAll(x => String.CompareOrdinal(x.Category, cbbCategory.SelectedItem.ToString()) == 0).ToList();
                if (cbbLevel.SelectedItem != null && (string)cbbLevel.SelectedItem != "*")
                    filteredList = filteredList.FindAll(x => String.CompareOrdinal(x.Level, cbbLevel.SelectedItem.ToString()) == 0).ToList();
                if (cbbOperation.SelectedItem != null && (string)cbbOperation.SelectedItem != "*")
                    filteredList = filteredList.FindAll(x => String.CompareOrdinal(x.Context, cbbOperation.SelectedItem.ToString()) == 0).ToList();
                if (cbbOrganization.SelectedItem != null && (string)cbbOrganization.SelectedItem != "*")
                    filteredList = filteredList.FindAll(x => String.CompareOrdinal(x.Organization, cbbOrganization.SelectedItem.ToString()) == 0).ToList();
                if (cbbProcess.SelectedItem != null && (string)cbbProcess.SelectedItem != "*")
                    filteredList = filteredList.FindAll(x => String.CompareOrdinal(x.Process, cbbProcess.SelectedItem.ToString()) == 0).ToList();
                if (cbbThread.SelectedItem != null && (string)cbbThread.SelectedItem != "*")
                    filteredList = filteredList.FindAll(x => String.CompareOrdinal(x.Thread, cbbThread.SelectedItem.ToString()) == 0).ToList();
                if (cbbUser.SelectedItem != null && (string)cbbUser.SelectedItem != "*")
                    filteredList = filteredList.FindAll(x => String.CompareOrdinal(x.User, cbbUser.SelectedItem.ToString()) == 0).ToList();
                if (cbbRequId.SelectedItem != null && (string)cbbRequId.SelectedItem != "*")
                    filteredList = filteredList.FindAll(x => String.CompareOrdinal(x.ReqId, cbbRequId.SelectedItem.ToString()) == 0).ToList();

                if (txtSearch.Text.Length > 0)
                {
                    filteredList =
                        filteredList.FindAll(x => x.Description.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                }

                ClearDescription();
                lvTraces.Visible = false;
                loadingPanel.Visible = true;
                loadingLabel.Text = Resources.FilteringLoadingPanelMessage;

                var bwFilter = new BackgroundWorker { WorkerReportsProgress = true };
                bwFilter.RunWorkerCompleted += BwFilterRunWorkerCompleted;
                bwFilter.DoWork += BwFilterDoWork;
                bwFilter.RunWorkerAsync(filteredList);
            }
        }

        private void TsmiFilterBClick(object sender, EventArgs e)
        {
            if (lvTraces.SelectedItems.Count > 0)
            {
                var item = (TraceInfo)lvTraces.SelectedItems[0].Tag;

                switch (((ToolStripMenuItem)sender).Name)
                {
                    case "tsmiFilterByCategory":
                        cbbCategory.SelectedItem = item.Category;
                        break;
                    case "tsmiFilterByLevel":
                        cbbLevel.SelectedItem = item.Level;
                        break;
                    case "tsmiFilterByOperation":
                        cbbOperation.SelectedItem = item.Context;
                        break;
                    case "tsmiFilterByOrganization":
                        cbbOrganization.SelectedItem = item.Organization;
                        break;
                    case "tsmiFilterByProcess":
                        cbbProcess.SelectedItem = item.Process;
                        break;
                    case "tsmiFilterByThread":
                        cbbThread.SelectedItem = item.Thread;
                        break;
                    case "tsmiFilterByUser":
                        cbbUser.SelectedItem = item.User;
                        break;
                    case "tsmiFilterByReqId":
                        cbbRequId.SelectedItem = item.ReqId;
                        break;
                }
            }
        }
        
        #endregion Others

        #region Workers

        private void BwLoadFileDoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var file in files)
            {
                using (var fileStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var reader = new StreamReader(fileStream))
                {
                    TraceInfo ti = null;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Trim().StartsWith("#") || string.IsNullOrEmpty(line))
                            continue;

                        if (line.StartsWith("["))
                        {
                            var lineParts = line.Split('|');

                            if (lineParts.Length == 1)
                            {
                                ti.Description += lineParts[0];
                                continue;
                            }

                            if (ti != null)
                            {
                                traces.Add(ti);
                            }

                            var threadParts = lineParts[2].Split(':');
                            var list = threadParts.ToList();
                            list.RemoveAt(0);

                            ti = new TraceInfo();

                            for (int i = 0; i < lineParts.Length; i++)
                            {
                                if (i == 0)
                                {
                                    var parts = lineParts[i].Split(']');
                                    ti.Date = DateTime.Parse(parts[0].Remove(0, 1));
                                    ti.Process = parts[1].Trim().Split(':')[1].Trim();
                                }
                                else
                                {
                                    if (ti.Process == "OUTLOOK")
                                    {
                                        var parts = lineParts[i].Split(':');
                                        switch (parts[0].Trim())
                                        {
                                            case "Thread":
                                                ti.Thread = parts[1].Trim();
                                                break;
                                            case "Category":
                                                ti.Category = parts[1].Trim();
                                                break;
                                            case "User":
                                                ti.User = parts[1].Trim();
                                                break;
                                            case "Level":
                                                ti.Level = parts[1].Trim();
                                                break;
                                            default:
                                                ti.Description = lineParts[i].Trim() + "\r\n";
                                                break;
                                        }

                                        ti.Organization = string.Empty;
                                        ti.ReqId = string.Empty;
                                        ti.Context = string.Empty;
                                    }
                                    else
                                    {
                                        var parts = lineParts[i].Split(':');
                                        switch (parts[0].Trim())
                                        {
                                            case "Organization":
                                                ti.Organization = parts[1].Trim();
                                                break;
                                            case "Thread":
                                                ti.Thread = parts[1].Trim();
                                                break;
                                            case "Category":
                                                ti.Category = parts[1].Trim();
                                                break;
                                            case "User":
                                                ti.User = parts[1].Trim();
                                                break;
                                            case "Level":
                                                ti.Level = parts[1].Trim();
                                                break;
                                            case "ReqId":
                                                ti.ReqId = parts[1].Trim();
                                                break;
                                            default:
                                                ti.Context = lineParts[i].Trim().Split(' ')[0];
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (line.StartsWith(">"))
                        {
                            ti.Description += line.Remove(0, 1) + "\r\n";
                        }
                        else
                        {
                            ti.Description += line + "\r\n";
                        }
                    }
                }
            }

            var bw = (BackgroundWorker)sender;

            if (oData.Count > 0)
            {
                bw.ReportProgress(0, "Resolving names...");

                foreach (var trace in traces.Where(t => t.Process != "OUTLOOK"))
                {
                    var orgData = oData.FirstOrDefault(o => o.Id == new Guid(trace.Organization));
                    if (orgData != null)
                    {
                        trace.Organization = orgData.Name;

                        if (new Guid(trace.User) == Guid.Empty)
                        {
                            trace.User = "(none)";
                        }
                        else
                        {
                            trace.User = orgData.Users.ContainsKey(new Guid(trace.User)) ? orgData.Users[new Guid(trace.User)] : trace.User;
                        }
                    }
                    else
                    {
                        if (new Guid(trace.Organization) == Guid.Empty)
                        {
                            trace.Organization = "(none)";
                        }

                        if (new Guid(trace.User) == Guid.Empty)
                        {
                            trace.User = "(none)";
                        }
                    }
                }
            }

            bw.ReportProgress(0, "Loading traces...");
            e.Result = DisplayTrace(traces, (BackgroundWorker)sender);
        }

        private void BwLoadFileProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingLabel.Text = e.UserState.ToString();
        }

        private void BwLoadFileRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lvTraces.Visible = true;
            loadingPanel.Visible = false;

            if (e.Error != null)
            {
                MessageBox.Show(this, Resources.ErrorWhileLoadingFileMessage + e.Error.Message, Resources.MessageBoxErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var items = (List<ListViewItem>)e.Result;
                tslNumberOfItems.Text = string.Format("Number of items: {0}", items.Count);
                lvTraces.Items.Clear();
                lvTraces.Items.AddRange(items.ToArray());
                FillFilters();

                if (applyFilter)
                {
                    Filter();
                    applyFilter = false;
                }
            }
        }

        private void BwFilterDoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = DisplayTrace((List<TraceInfo>)e.Argument, (BackgroundWorker)sender);
        }

        private void BwFilterRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lvTraces.Visible = true;
            loadingPanel.Visible = false;

            if (e.Error != null)
            {
                MessageBox.Show(this, Resources.ErrorWhileFilteringMessage + e.Error.Message, Resources.MessageBoxErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var items = (List<ListViewItem>)e.Result;
                lvTraces.Items.Clear();
                lvTraces.Items.AddRange(items.ToArray());
                tslNumberOfItems.Text = string.Format("Number of items: {0}", items.Count);
            }
        }

        private void bwResolveNameWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;

            CrmConnection connection;
            try
            {
                connection = CrmConnection.Parse(e.Argument.ToString());
            }
            catch
            {
                throw new Exception("Invalid connection string!");    
            }

            var discoService = new DiscoveryService(connection);
            var orgRequest = new RetrieveOrganizationsRequest();
            var orgResponse = (RetrieveOrganizationsResponse)discoService.Execute(orgRequest);

            foreach (var org in orgResponse.Details)
            {
                worker.ReportProgress(0, "Retrieving users for organization " + org.FriendlyName);

                var orgData = new OrganizationData { Id = org.OrganizationId, Name = org.UniqueName };

                var url = org.Endpoints[EndpointType.OrganizationService];
                url = url.Replace("/XRMServices/2011/Organization.svc", "");

                var orgService = new OrganizationService(CrmConnection.Parse("Url=" + url));
                var users =
                    orgService.RetrieveMultiple(new QueryExpression("systemuser")
                    {
                        ColumnSet = new ColumnSet(new[] { "systemuserid", "fullname" })
                    });

                foreach (var user in users.Entities)
                {
                    orgData.Users.Add(user.Id, user.GetAttributeValue<string>("fullname"));
                }

                oData.Add(orgData);
            }

            e.Result = connection.ServiceUri;
        }

        private void bwResolveNameWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingLabel.Text = e.UserState.ToString();
        }

        private void bwResolveNameWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lvTraces.Visible = true;
            loadingPanel.Visible = false;
            loadingLabel.Text = string.Empty;

            if (e.Error != null)
            {
                currentConnection = string.Empty;
                MessageBox.Show(this, Resources.ErrorWhileResolvingNames + e.Error.Message, Resources.MessageBoxErrorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tsslConnection.Text = string.Format(Resources.ConnectedTo, e.Result);
                
                if(files != null && files.Count > 0)
                    LoadFile();
            }
        }

        #endregion Workers

        #endregion Methods
    }
}
