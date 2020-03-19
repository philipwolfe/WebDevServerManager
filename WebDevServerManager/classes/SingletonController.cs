using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Threading;

namespace WebDevServerManager
{
	[Serializable]
	public class SingletonController : MarshalByRefObject
	{
		public delegate void ReceiveDelegate(Arguments args);

		private static Mutex m_mutex;

		static private ReceiveDelegate m_Receive = null;
		static public ReceiveDelegate Receiver
		{
			get { return m_Receive; }
			set { m_Receive = value;}
		}

		public static bool IamFirst(ReceiveDelegate callback)
		{
			if(IamFirst())
			{
				Receiver += callback;
				return true;
			}
			else
				return false;
		}
		public static bool IamFirst()
		{
			bool createdNew;
			m_mutex = new Mutex(true, "WebDevServerManagerMutex", out createdNew);

			if (createdNew)
			{
				//We locked it! We are the first instance!!!
				CreateInstanceChannel();
				return true;
			}
			else
			{
				//Not the first instance!!!
				m_mutex.Close();
				m_mutex = null;
				return false;
			}
		}

		private static void CreateInstanceChannel()
		{
			IChannel ipcCh;
			try
			{
				ipcCh = new IpcChannel("IPChannelName");
			}
			catch (Exception)
			{
				ipcCh = ChannelServices.GetChannel("IPChannelName");
			}

			ChannelServices.RegisterChannel(ipcCh, false);
			RemotingConfiguration.RegisterWellKnownServiceType
			   (typeof(SingletonController),
					   "SingletonController",
					   WellKnownObjectMode.Singleton);
			
		}

		public static void Send(Arguments args)
		{
			try
			{
				IpcChannel ipcCh = new IpcChannel("myClient");
				ChannelServices.RegisterChannel(ipcCh, false);

				SingletonController ctrl = (SingletonController)Activator.GetObject(
						typeof(SingletonController),
						"ipc://IPChannelName/SingletonController");

				ctrl.Receive(args);

				ctrl = null;

				ChannelServices.UnregisterChannel(ipcCh);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
				throw;
			}

		}

		public void Receive(Arguments args)
		{
			if (m_Receive != null)
			{
				m_Receive(args);
			}
		}
	}
}
