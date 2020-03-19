using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;


namespace WebDevServerManager
{
	[RunInstaller(true)]
	public partial class WebDevInstaller : Installer
	{
		private const string VS05RENAME = "VS05Rename";
		private const string VS08RENAME = "VS08Rename";

		public WebDevInstaller()
		{
			InitializeComponent();
		}

		public override void Install(IDictionary stateSaver)
		{
			bool vs05Rename = Context.IsParameterTrue(VS05RENAME);
			bool vs08Rename = Context.IsParameterTrue(VS08RENAME);

			Context.LogMessage(string.Format("{0} evaluated as {1}.", VS05RENAME, vs05Rename));
			Context.LogMessage(string.Format("{0} evaluated as {1}.", VS08RENAME, vs08Rename));

			stateSaver[VS05RENAME] = vs05Rename;
			stateSaver[VS08RENAME] = vs08Rename;

			string vs05Path = stateSaver["VS2005WebDev"].ToString();
			
			if(vs05Rename)
			{

			}

			if(vs08Rename)
			{
				
			}


			base.Install(stateSaver);
		}

		public override void Uninstall(IDictionary savedState)
		{
			if (bool.Parse(savedState["VS05Rename"].ToString()))
			{

			}

			if (bool.Parse(savedState["VS08Rename"].ToString()))
			{

			}

			base.Uninstall(savedState);
		}
	}
}
