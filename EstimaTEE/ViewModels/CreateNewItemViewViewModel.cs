using EstimaTEE.Factories;
using EstimaTEE.Interfaces;
using EstimaTEE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EstimaTEE.ViewModels
{
    public class CreateNewItemViewViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;
        private AppDbContextFactory _dbFactory;

        public ICommand CancelCommand { get; }
        public ICommand SubmitCommand { get; }

        private Item  _item;
        public Item Item
        {
            get => _item;
            set => OnPropertyChanged(ref _item, value);
        }
        public CreateNewItemViewViewModel(INavigator navigator, AppDbContextFactory dbFactory)
        {
            _navigator = navigator;
            _dbFactory = dbFactory;
        }
    }
}
