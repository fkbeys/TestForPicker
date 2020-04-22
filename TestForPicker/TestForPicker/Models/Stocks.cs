using System;
using System.Collections.Generic;
using System.Text;
using TestForPicker.Helper;

namespace TestForPicker.Models
{
    public class StocksModel : BaseViewModel
    {
        public int Stock_Id { get; set; } 

        private string _Stock_Name;
        public string Stock_Name
        {
            get { return _Stock_Name; }
            set
            {
                _Stock_Name = value;
                INotifyPropertyChanged();
            }
        }
    }
}
