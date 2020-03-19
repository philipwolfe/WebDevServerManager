using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualStudio.WebHost;

namespace WebDevServerManager
{
	class ThreadItem : ListViewItem, IThreadItem
	{
		Server _webServer;
		private Guid _id;
		int _port;
		string _virtualDirectory;
		string _physicalDirectory;
		bool _started;
		
		public ThreadItem(Guid id, string port, string virtualDirectory, string physicalDirectory)
		{
			this._id = id;
			this.Text = id.ToString();
			this._port = int.Parse(port);
			this._virtualDirectory = virtualDirectory;
			this._physicalDirectory = physicalDirectory;

			SubItems.Add(port.ToString());
			SubItems.Add(virtualDirectory);
			SubItems.Add(physicalDirectory);
			ImageIndex = 0;
		}
		
		public Guid id
		{
			get { return _id; }
			set { _id = value; }
		}
		public int Port
		{
			get { return _port; }
			set{ _port = value;}
		}
		public string VirtualDirectory
		{
			get { return _virtualDirectory; }
			set{ _virtualDirectory = value;}
		}
		public string PhysicalDirectory
		{
			get { return _physicalDirectory; }
			set{ _physicalDirectory = value;}
		}
		
		
		public void Start()
		{
			if (!_started)
			{
				if (Directory.Exists(PhysicalDirectory))
				{
					_webServer = new Server(Port, VirtualDirectory, PhysicalDirectory);

					try
					{
						_webServer.Start();
						_started = true;
					}
					catch
					{
						MessageBox.Show("Server could not start", "Error", MessageBoxButtons.OK,
									MessageBoxIcon.Error);
					}

				}
				else
				{
					MessageBox.Show(String.Format("Path not found: {0}", _physicalDirectory), "Error", MessageBoxButtons.OK,
					                MessageBoxIcon.Error);
				}
			}
		}

		public void Stop()
		{
			if (_started)
			{
				_webServer.Stop();
				_started = false;
			}
		}
	}
}
