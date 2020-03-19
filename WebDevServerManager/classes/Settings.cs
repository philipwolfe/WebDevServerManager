using System;
using System.Drawing;

namespace WebDevServerManager.Properties
{


	// This class allows you to handle specific events on the settings class:
	//  The SettingChanging event is raised before a setting's value is changed.
	//  The PropertyChanged event is raised after a setting's value is changed.
	//  The SettingsLoaded event is raised after the setting values are loaded.
	//  The SettingsSaving event is raised before the setting values are saved.
	internal sealed partial class Settings
	{
		private Size _formSize;
		private Point _formLocation;

		public Settings()
		{
			// // To add event handlers for saving and changing settings, uncomment the lines below:
			//
			this.SettingChanging += this.SettingChangingEventHandler;

			this.SettingsSaving += this.SettingsSavingEventHandler;

		}

		private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
		{
			//Console.WriteLine(e.SettingName + " Changed");
			//// Add code to handle the SettingChangingEvent event here.

			//if (e.SettingName == "Form_Size")
			//{
			//    _formSize = (Size) e.NewValue;
			//    e.Cancel = true;
			//}
			
			//if(e.SettingName == "Form_Location")
			//{
			//    _formLocation = (Point) e.NewValue;
			//    e.Cancel = true;
			//}
		}

		private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//// Add code to handle the SettingsSaving event here.
			//Console.WriteLine("Settings being saved");

			//Default.Form_Size = _formSize;
			//Default.Form_Location = _formLocation;


		}
	}
}
