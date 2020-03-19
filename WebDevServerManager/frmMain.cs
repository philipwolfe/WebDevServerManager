using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using WebDevServerManager.Properties;

namespace WebDevServerManager
{
	public partial class frmMain : Form
	{
		private const int RED = 0;
		private const int GREEN = 1;
		private const int YELLOW = 2;

		public frmMain()
		{
			InitializeComponent();


			LoadData();
		}

		public frmMain(string port, string vpath, string path)
			: this()
		{
			AddItem(port, vpath, path);
		}

		#region Site Context Menu

		private void siteContextMenu_Opening(object sender, CancelEventArgs e)
		{
			//get current item
			if (listView1.SelectedIndices.Count == 0)
			{
				siteContextMenu.Enabled = false;
			}
			else
			{
				siteContextMenu.Enabled = true;

				ListView.SelectedIndexCollection col = listView1.SelectedIndices;

				int idx = col[0];

				ListViewItem itm = listView1.Items[idx];

				siteCTXMNUStart.Enabled = !itm.Checked;
				siteCTXMNURestart.Enabled = itm.Checked;
				siteCTXMNUStop.Enabled = itm.Checked;
			}
		}

		private void siteCTXMNUStart_Click(object sender, EventArgs e)
		{
			ListView.SelectedIndexCollection col = listView1.SelectedIndices;

			int idx = col[0];

			ListViewItem itm = listView1.Items[idx];

			StartServer(itm);
		}

		private void siteCTXMNUStop_Click(object sender, EventArgs e)
		{
			ListView.SelectedIndexCollection col = listView1.SelectedIndices;

			int idx = col[0];

			ListViewItem itm = listView1.Items[idx];

			StopServer(itm);
		}

		private void siteCTXMNUDelete_Click(object sender, EventArgs e)
		{
			ListView.SelectedIndexCollection col = listView1.SelectedIndices;

			int idx = col[0];
			ListViewItem itm = listView1.Items[idx];

			if (itm.Checked)
			{
				StopServer(itm);
			}

			string query =
				string.Format(Resources.SiteSearchString,
							  itm.SubItems[1].Text,
							  itm.SubItems[2].Text,
							  itm.SubItems[3].Text);
			DataRow[] rows = foldersDataSet.WebSite.Select(query);

			foreach (DataRow row in rows)
			{
				row.Delete();
			}
			foldersDataSet.AcceptChanges();
			foldersDataSet.WriteXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Resources.SaveFile));

			listView1.Items.RemoveAt(idx);
		}

		private void siteCTXMNUView_Click(object sender, EventArgs e)
		{
			ListView.SelectedIndexCollection col = listView1.SelectedIndices;

			int idx = col[0];
			ListViewItem itm = listView1.Items[idx];

			OpenBrowser(itm.SubItems[1].Text, itm.SubItems[2].Text);
		}

		private void siteCTXMNURestart_Click(object sender, EventArgs e)
		{
			ListView.SelectedIndexCollection col = listView1.SelectedIndices;

			int idx = col[0];

			ListViewItem itm = listView1.Items[idx];

			StopServer(itm);

			//BeginInvoke(new ChangeLightInvoker(ChangeLight), new object[] {itm, YELLOW});

			itm.ImageIndex = YELLOW;
			Thread.Sleep(1000); //TODO: make it change to yellow and continue

			StartServer(itm);
		}

		//private delegate void ChangeLightInvoker(ListViewItem itm, int imageIndex);

		//private void ChangeLight(ListViewItem itm, int imageIndex)
		//{
		//    itm.ImageIndex = imageIndex;
		//    Thread.Sleep(1000);
		//}

		#endregion

		#region Buttons

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			DialogResult rslt = physicalPathFolderDlg.ShowDialog();
			if (rslt == DialogResult.OK)
			{
				txtPhysicalPath.Text = physicalPathFolderDlg.SelectedPath;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			errorProvider1.ClearErrors();
			ValidateChildren();
			if (!errorProvider1.HasErrors)
			{
				AddItem(txtPort.Text, txtVirtualPath.Text, txtPhysicalPath.Text, false);

				txtPhysicalPath.Text = string.Empty;
				txtPort.Text = string.Empty;
				txtVirtualPath.Text = "/";
			}
		}

		#endregion

		#region Validators

		private void txtPort_Validating(object sender, CancelEventArgs e)
		{
			Int16 i = 0;
			try
			{
				i = Int16.Parse(txtPort.Text);
			}
			catch
			{
			}

			if (i <= 0)
			{
				errorProvider1.SetError(txtPort, "Port must be a positive integer.");
			}
			else
			{
				errorProvider1.SetError(txtPort, string.Empty);
			}
		}

		private void txtVirtualPath_Validating(object sender, CancelEventArgs e)
		{
			if (txtVirtualPath.Text.Length == 0)
			{
				errorProvider1.SetError(txtVirtualPath, "Virtual path must be specified.");
			}
			else
			{
				errorProvider1.SetError(txtVirtualPath, string.Empty);
			}
		}

		private void txtPhysicalPath_Validating(object sender, CancelEventArgs e)
		{
			if (!Directory.Exists(txtPhysicalPath.Text))
			{
				errorProvider1.SetError(txtPhysicalPath, "Virtual path must reference a folder.");
			}
			else
			{
				errorProvider1.SetError(txtPhysicalPath, string.Empty);
			}
		}

		#endregion

		#region Form

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			//save settings if not minimized
			if (WindowState == FormWindowState.Normal)
			{
				notifyIcon1_MouseDoubleClick(this, null);
			}
			Settings.Default.Save();

			StopServers();
		}

		private void frmMain_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				ShowInTaskbar = false;
				Hide();
			}
		}

		#endregion

		#region Icon

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			WindowState = FormWindowState.Normal;
			ShowInTaskbar = true;
			Show();
		}

		private void iconCTXMNUExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion

		#region Menus

		private void mnuFileExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mnuFileExport_Click(object sender, EventArgs e)
		{
			DialogResult rslt = saveFileDialog1.ShowDialog();

			if (rslt == System.Windows.Forms.DialogResult.OK)
			{
				foldersDataSet.WriteXml(saveFileDialog1.FileName);
			}
		}

		private void mnuFileOpen_Click(object sender, EventArgs e)
		{
			DialogResult rslt =
				MessageBox.Show("Importing Folders will stop all running sites.  Do you want to continue?",
								"Question",
								MessageBoxButtons.YesNo,
								MessageBoxIcon.Question);

			if (rslt == DialogResult.Yes)
			{
				rslt = openFileDialog1.ShowDialog();

				if (rslt == System.Windows.Forms.DialogResult.OK)
				{
					try
					{
						StopServers();
						foldersDataSet.ReadXml(openFileDialog1.FileName, XmlReadMode.IgnoreSchema);

						Directory.CreateDirectory(
							Path.GetDirectoryName(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Resources.SaveFile)));

						foldersDataSet.WriteXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Resources.SaveFile));
						DataBind();
					}
					catch (Exception)
					{
						MessageBox.Show(
							"An error occured while importing the folders file.  Please ensure that the file is in the approriate format.");
					}
				}
			}
		}

		private void mnuHelpAbout_Click(object sender, EventArgs e)
		{
			AboutBox1 about = new AboutBox1();
			about.ShowDialog();
		}


		#endregion

		#region Methods

		private void LoadData()
		{
			if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WebDevServerManager")))
				Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WebDevServerManager"));

			//load folders from xml
			if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Resources.SaveFile)))
			{
				foldersDataSet.ReadXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Resources.SaveFile));

				DataBind();
			}
		}

		private void DataBind()
		{
			if (foldersDataSet != null)
			{
				if (foldersDataSet.Tables.Count > 0)
				{
					foreach (Folders.WebSiteRow row in foldersDataSet.WebSite)
					{
						ThreadItem itm = new ThreadItem(row.ID, row.Port, row.Vpath, row.Path);

						listView1.Items.Add(itm);
					}
				}
			}
		}

		internal void AddItem(string port, string vpath, string path)
		{
			AddItem(port, vpath, path, true);
		}
		internal void AddItem(string port, string vpath, string path, bool startServer)
		{
			ListViewItem item;
			DataRow[] rows =
				foldersDataSet.WebSite.Select(String.Format(Resources.SiteSearchString, port, vpath, path));

			//check if item is in the dataset
			if (rows.Length == 0)
			{
				Folders.WebSiteRow row = foldersDataSet.WebSite.NewWebSiteRow();
				row.Path = path;
				row.Port = port;
				row.Vpath = vpath;
				row.ID = Guid.NewGuid();

				foldersDataSet.WebSite.AddWebSiteRow(row);
				foldersDataSet.AcceptChanges();

				string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Resources.SaveFile);



				foldersDataSet.WriteXml(filepath);

				ThreadItem itm = new ThreadItem(row.ID, row.Port, row.Vpath, row.Path);

				item = listView1.Items.Add(itm);
			}
			else
			{
				item = listView1.FindItemWithText(((Folders.WebSiteRow)rows[0]).ID.ToString());
			}

			//start the server if it told to
			if (startServer)
			{
				if (item != null)
				{
					item.Selected = true;
					StartServer(item);
					Thread.Sleep(1000);
					//OpenBrowser(item.SubItems[1].Text, item.SubItems[2].Text);
				}
			}
		}

		private void StartServer(ListViewItem item)
		{
			item.Checked = true;
			item.ImageIndex = GREEN;

			IThreadItem ti = (IThreadItem)item;

			ti.Start();
		}

		private void StopServer(ListViewItem item)
		{
			item.Checked = false;
			item.ImageIndex = RED;

			IThreadItem ti = (IThreadItem)item;
			ti.Stop();
		}

		private void StopServers()
		{
			//stop servers
			foreach (ListViewItem item in listView1.Items)
			{
				StopServer(item);
			}
		}

		public void SendArguments(Arguments args)
		{
			BeginInvoke(new MyAddItem(AddItem), new object[] { args["port"], args["vpath"], args["path"] });
		}

		private delegate void MyAddItem(string port, string vpath, string path);

		void OpenBrowser(string port, string path)
		{
			//DON'T REUSE BROWSER WINDOWS
			RegistryKey browserKey = Registry.ClassesRoot.OpenSubKey(@"HTTP\shell\open\ddeexec\application", false);
			string defaultBrowser = browserKey.GetValue(null, null).ToString();

			ProcessStartInfo sInfo =
				new ProcessStartInfo(defaultBrowser,
									 String.Format("http://localhost:{0}{1}", port, path));
			Process.Start(sInfo);
		}
		#endregion

		private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			// Set the ListViewItemSorter property to a new ListViewItemComparer 
			// object. Setting this property immediately sorts the 
			// ListView using the ListViewItemComparer object.
			listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
		}

	}

	// Implements the manual sorting of items by columns.
	class ListViewItemComparer : IComparer
	{
		private int col = 0;
		private static bool reverse;
		public ListViewItemComparer(int column)
		{
			col = column;
		}
		public int Compare(object x, object y)
		{
			return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
		}
	}

}