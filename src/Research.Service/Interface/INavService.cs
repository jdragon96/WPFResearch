namespace Reseach.Service
{
    public interface INavService
    {
        object NavigateTo<TViewModel>() where TViewModel : class;

        void Register<TViewModel>() where TViewModel : class;
    }
}
