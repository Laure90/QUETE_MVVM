using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace QUETE_MVVM
{
    public class ShopViewModel
    {
        private IList<Shop> _ShopList;

        public ShopViewModel()
        {
            _ShopList = new List<Shop>
            {
                new Shop { ShopId = 1, Name = "Shop1" },
                new Shop { ShopId = 2, Name = "Shop2" },
                new Shop { ShopId = 3, Name = "Shop3" },
                new Shop { ShopId = 4, Name = "Shop4" }
            };
        }

        public IList<Shop> Shops
        {
            get { return _ShopList; }
            set { _ShopList = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                {
                    mUpdater = new Updater();
                }
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }
            public event EventHandler CanExecuteChanged;
            public void Execute (object parameter)
            {
                
            }
        }

        private ICommand mAdder;
        public ICommand AddCommand
        {
            get
            {
                if (mAdder == null)
                {
                    mAdder = new Adder();
                }
                return mAdder;
            }
            set
            {
                mAdder = value;
            }
        }

    }
}
