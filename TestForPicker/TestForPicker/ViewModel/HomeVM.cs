using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TestForPicker.Helper;
using TestForPicker.Models;
using Xamarin.Forms;

namespace TestForPicker.ViewModel
{
    public class HomeVM : BaseViewModel
    {
        public ICommand ShowStocksBtnCommand { get; protected set; }

        public HomeVM()
        {
            ShowStocksBtnCommand = new Command(ShowStockGO);
          
        }

      
        private void ShowStockGO(object obj)
        {

            AddStocksMethod(); 
            INotifyPropertyChanged("StockList");

        }



        void AddStocksMethod()
        {
            StockList.Insert(0, new Stocks { Stock_Id = 0, Stock_Name = "Pencil" });
            StockList.Insert(1, new Stocks { Stock_Id = 1, Stock_Name = "Computer" });
            StockList.Insert(2, new Stocks { Stock_Id = 2, Stock_Name = "Computer" });

        }


        private List<Stocks> _StockList;
        public List<Stocks> StockList
        {
            get
            {
                if (_StockList==null)
                {
                    _StockList = new List<Stocks>();
                }
                return _StockList;
            }
            set
            {
                _StockList = value;
                INotifyPropertyChanged();
            }
        }
    }
}
