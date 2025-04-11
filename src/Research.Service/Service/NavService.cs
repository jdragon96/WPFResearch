using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseach.Service
{
    public class NavService : INavService
    {
        private readonly Dictionary<Type, object> _views = new Dictionary<Type, object>();
        private readonly IServiceProvider _serviceProvider;

        public NavService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public object NavigateTo<TViewModel>() where TViewModel : class
        {
            Type viewType = typeof(TViewModel);
            if (!_views.ContainsKey(viewType))
            {
                _views[viewType] = _serviceProvider.GetService(viewType);
            }
            if (_views[viewType] == null)
            {
                _views[viewType] = _serviceProvider.GetService(viewType);
            }
            return _views[viewType];
        }

        public void Register<TViewModel>() where TViewModel : class
        {
            Type viewType = typeof(TViewModel);
            _views[viewType] = null;
        }
    }
}
