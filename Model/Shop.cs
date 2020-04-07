using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QUETE_MVVM
{
    public class Shop : INotifyPropertyChanged
    {
        private int shopId;
        private string name;
        public int ShopId
        {
            get
            {
                return shopId;
            }
            set
            {
                shopId = value;
                OnPropertyChanged("ShopId");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
