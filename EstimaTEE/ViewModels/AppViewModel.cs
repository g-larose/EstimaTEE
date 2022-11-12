using EstimaTEE.Commands;
using EstimaTEE.Factories;
using EstimaTEE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EstimaTEE.ViewModels
{
    /// <summary>
    /// Created by the template
    /// make changes as needed
    /// </summary>
    public class AppViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly AppDbContextFactory _dbFactory;

        public ViewModelBase? CurrentViewModel => _navigator.CurrentViewModel;

        public ICommand? NavigateCreateNewItemViewCommand { get; }

        public AppViewModel(INavigator navigator, AppDbContextFactory dbfactory)
        {
            _navigator = navigator;
            _dbFactory = dbfactory;
            _navigator.CurrentViewModelChanged += OnCurrentViewModelChanged;
            _navigator.CurrentViewModel = new DashboardViewModel();
            NavigateCreateNewItemViewCommand = new NavigateCommand<CreateNewItemViewViewModel>(_navigator, () => new CreateNewItemViewViewModel(_navigator, _dbFactory));
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
