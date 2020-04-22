using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestForPicker.Helper
{
   public class BaseViewModel
	{
		 
		public event PropertyChangedEventHandler PropertyChanged;
	 
		 
		protected void INotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanged != null)
			{

				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
