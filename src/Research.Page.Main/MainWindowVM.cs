using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Reseach.Service;
using Research.Page.Dashboard;
using System.Windows.Controls;

namespace Research.Page.Main
{
    public partial class MainWindowVM : ObservableObject
    {
        private readonly INavService _navigationService;

        public MainWindowVM(INavService navigationService)
        {
            _navigationService = navigationService;
        }

        [ObservableProperty]
        private ContentControl selectedContent;


        [RelayCommand]
        private void NavDashboard(object param)
        {
            SelectedContent = (DashboardView)_navigationService.NavigateTo<DashboardView>();
        }
    }
}
