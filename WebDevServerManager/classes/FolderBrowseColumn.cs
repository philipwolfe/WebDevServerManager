using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace WebDevServerManager
{
	public class FolderBrowseColumn : DataGridViewColumn
	{
		public FolderBrowseColumn()
			: base(new FolderBrowseCell())
		{ }

		public override DataGridViewCell CellTemplate
		{
			get
			{
				return base.CellTemplate;
			}
			set
			{
				// Ensure that the cell used for the template is a FolderBrowseCell.
				if (value != null && !value.GetType().IsAssignableFrom(typeof(FolderBrowseCell)))
				{
					throw new InvalidCastException("Must be a FolderBrowseCell");
				}
				base.CellTemplate = value;
			}
		}
	}







	public class FolderBrowseCell : DataGridViewTextBoxCell
	{

		public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
		{
			// Set the value of the editing control to the current cell value.
			base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
			FolderBrowseEditingControl ctl = DataGridView.EditingControl as FolderBrowseEditingControl;
			//ctl.Value = this.Value;
		}

		public override Type EditType
		{
			get
			{
				// Return the type of the editing contol that CalendarCell uses.
				return typeof(FolderBrowseEditingControl);
			}
		}

		public override Type ValueType
		{
			get
			{
				// Return the type of the value that CalendarCell contains.
				return typeof(DateTime);
			}
		}

		public override object DefaultNewRowValue
		{
			get
			{
				// Use the current date and time as the default value.
				return DateTime.Now;
			}
		}
	}

	class FolderBrowseEditingControl : TextBox, IDataGridViewEditingControl
	{
		private Button btn;
		private TextBox txt;
		private FolderBrowserDialog dlg;

		DataGridView dataGridView;
		private bool valueChanged = false;
		int rowIndex;

		public FolderBrowseEditingControl()
		{
			btn = new Button();
			btn.Text = "...";

			txt = new TextBox();
			dlg = new FolderBrowserDialog();

			btn.Click += new EventHandler(btn_Click);
		}

		void btn_Click(object sender, EventArgs e)
		{
			DialogResult dlgResult = dlg.ShowDialog();

			if(dlgResult == System.Windows.Forms.DialogResult.OK)
			{
				txt.Text = dlg.SelectedPath;
			}
		}

		// Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
		// property.
		public object EditingControlFormattedValue
		{
			get
			{
				return dlg.SelectedPath;
			}
			set
			{
				String newValue = value as String;
				if (newValue != null)
				{
					txt.Text = newValue;
					dlg.SelectedPath = newValue;
				}
			}
		}

		// Implements the 
		// IDataGridViewEditingControl.GetEditingControlFormattedValue method.
		public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
		{
			return EditingControlFormattedValue;
		}

		// Implements the 
		// IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
		public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
		{
			txt.Font = dataGridViewCellStyle.Font;
			btn.Font = dataGridViewCellStyle.Font;

			txt.ForeColor = dataGridViewCellStyle.ForeColor;
			btn.ForeColor = dataGridViewCellStyle.ForeColor;

			txt.BackColor = dataGridViewCellStyle.BackColor;
			btn.BackColor = dataGridViewCellStyle.BackColor;

		}

		// Implements the IDataGridViewEditingControl.EditingControlRowIndex 
		// property.
		public int EditingControlRowIndex
		{
			get
			{
				return rowIndex;
			}
			set
			{
				rowIndex = value;
			}
		}

		// Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
		// method.
		public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
		{
			// Let the DateTimePicker handle the keys listed.
			switch (key & Keys.KeyCode)
			{
				case Keys.Left:
				case Keys.Up:
				case Keys.Down:
				case Keys.Right:
				case Keys.Home:
				case Keys.End:
				case Keys.PageDown:
				case Keys.PageUp:
					return true;
				default:
					return false;
			}
		}

		// Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
		// method.
		public void PrepareEditingControlForEdit(bool selectAll)
		{
			// No preparation needs to be done.
		}

		// Implements the IDataGridViewEditingControl
		// .RepositionEditingControlOnValueChange property.
		public bool RepositionEditingControlOnValueChange
		{
			get
			{
				return false;
			}
		}

		// Implements the IDataGridViewEditingControl
		// .EditingControlDataGridView property.
		public DataGridView EditingControlDataGridView
		{
			get
			{
				return dataGridView;
			}
			set
			{
				dataGridView = value;
			}
		}

		// Implements the IDataGridViewEditingControl
		// .EditingControlValueChanged property.
		public bool EditingControlValueChanged
		{
			get
			{
				return valueChanged;
			}
			set
			{
				valueChanged = value;
			}
		}

		// Implements the IDataGridViewEditingControl
		// .EditingPanelCursor property.
		public Cursor EditingPanelCursor
		{
			get
			{
				return base.Cursor;
			}
		}
	}
}