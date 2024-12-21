namespace MauiDemoDataBinding.Models
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Product : INotifyPropertyChanged
    {
        private string _name;

        private decimal _price;

        private int _stock;

        public string Name 
        {
            get => _name; 
            set 
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public decimal Price 
        {
            get => _price; 
            set 
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        public int Stock 
        {
            get => _stock; 
            set 
            {
                _stock = value;
                OnPropertyChanged();
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
