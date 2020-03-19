using System;
using System.Windows.Forms;

namespace WebDevServerManager
{
	public static class Program
	{
		private static frmMain frm;

		[STAThread]
		static void Main(string[] args)
		{
			Arguments arguments = new Arguments(args);

			if (arguments.NeedHelp())
			{
				ShowUsage();
				return;
			}

			if (string.IsNullOrEmpty(arguments["vpath"]))
			{
				arguments["vpath"] = "/";
			}

			if (SingletonController.IamFirst(controller_Received))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				if(arguments.SomePassed())
					frm = new frmMain(arguments["port"], arguments["vpath"], arguments["path"]);
				else 
					frm = new frmMain();

				Application.Run(frm);
				
			}
			else
			{
				SingletonController.Send(arguments);
			}
		}

		static void controller_Received(Arguments args)
		{
			frm.SendArguments(args);
		}

		static void ShowUsage()
		{
			string msg = @"
WebDevServerManager Usage:
WebDev.WebServer /port:<port number> /path:<physical path> [/vpath:<virtual path>]

	port number:
		[Optional] An unused port number between 1 and 65535.
		The default is 80 (usable if you do not also have IIS listening on the same port).

	physical path:
		A valid directory name where the Web application is rooted.

	virtual path:
		[Optional] The virtual path or application root in the form of '/<app name>'.
		The default is simply '/'.

Example:
WebDev.WebServer /port:8080 /path:""c:\inetpub\wwwroot\MyApp\"" /vpath:""/MyApp""


You can then access the Web application using a URL of the form:
http://localhost:8080/MyApp
";

			MessageBox.Show(msg, "WebDevServerManager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

	}
}