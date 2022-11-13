using EstimaTEE.Factories;
using EstimaTEE.Interfaces;
using EstimaTEE.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EstimaTEE.ViewModels
{
    public class CreateNewItemViewViewModel : ViewModelBase
    {
        private readonly INavigator? _navigator;
        private AppDbContextFactory? _dbFactory;

        public ICommand? CancelCommand { get; }
        public ICommand? SubmitCommand { get; }

        private Item?  _item;
        public Item? Item
        {
            get => _item;
            set => OnPropertyChanged(ref _item, value);
        }

        private List<Tuple<string, string>>? _itemsColor;
        public List<Tuple<string, string>>? ItemsColor
        {
            get => _itemsColor;
            set => OnPropertyChanged(ref _itemsColor, value);
        }
        public CreateNewItemViewViewModel(INavigator navigator, AppDbContextFactory dbFactory)
        {
            _navigator = navigator;
            _dbFactory = dbFactory;
          if (ItemsColor is null)
          {
            ItemsColor = new List<Tuple<string, string>>();
            ItemsColor.Add(new Tuple<string, string>("black", "Black"));  
            ItemsColor.Add(new Tuple<string, string>("Red", "Red")); 
          }
        }
    }
}
