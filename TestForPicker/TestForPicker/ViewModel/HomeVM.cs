using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        //  public ObservableCollection<StocksModel> StockList { get; set; }

        private ObservableCollection<StocksModel> _StockList;

        public ObservableCollection<StocksModel> StockList
        {
            get {
                if (_StockList==null)
                {
                    _StockList = new ObservableCollection<StocksModel>();
                }
                return _StockList; }
            set { _StockList = value; }
        }

        public HomeVM()
        {
            ShowStocksBtnCommand = new Command(ShowStockGO);

          //  StockList = new ObservableCollection<StocksModel>();
        }


        private void ShowStockGO(object obj)
        {
            
            AddStocksMethod();
        }


        void AddStocksMethod()
        {
            StockList.Insert(0, new StocksModel { Stock_Id = 0, Stock_Name = "Pencil" });
            StockList.Insert(1, new StocksModel { Stock_Id = 1, Stock_Name = "Computer" });
            StockList.Insert(2, new StocksModel { Stock_Id = 2, Stock_Name = "Computer" });

        }
    }
}