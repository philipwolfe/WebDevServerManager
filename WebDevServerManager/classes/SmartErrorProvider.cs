using System.ComponentModel;
using System.Windows.Forms;

namespace WebDevServerManager
{
	public class SmartErrorProvider : ErrorProvider 
	{
		bool _hasErrors;
		
		public SmartErrorProvider() : base()
		{}
		public SmartErrorProvider(ContainerControl parentControl) : base(parentControl)
		{}
		public SmartErrorProvider(IContainer container) : base(container)
		{}

		public new void SetError(Control ctrl, string message)
		{
			if(!message.Equals(string.Empty))
				_hasErrors = true;
			
			base.SetError(ctrl, message);
		}

		
		public bool HasErrors
		{
			get { return _hasErrors; }
		}
		
		public void ClearErrors()
		{
			_hasErrors = false;
		}
	}
}
