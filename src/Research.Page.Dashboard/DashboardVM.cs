using CommunityToolkit.Mvvm.ComponentModel;
using Reseach.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research.Page.Dashboard
{
    public partial class DashboardVM : ObservableObject
    {
        private readonly INavService _navigationService;
        public DashboardVM(INavService navService)
        {
            _navigationService = navService;
            EarnRate = "104.5%";
        }

        [ObservableProperty]
        private string earnRate;

        [ObservableProperty]
        private string tradeCount;

        [ObservableProperty]
        private string maxEarnWon;

        [ObservableProperty]
        private string maxLossWon;
    }
}
