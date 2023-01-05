namespace TubePlayer.ViewModels.Base
{
    public partial class AppViewModelBase : ViewModelBase
    {
        public INavigation NavigationServive { get; set; }
        public Page pageService { get; set; }

        protected IApiService _appApiService { get; set; }
        public AppViewModelBase(IApiService appApiService) : base()
        {
            _appApiService = appApiService;    
        }

        [RelayCommand]
        private async Task NavigateBack() =>
            await NavigationServive.PopAsync();

        [RelayCommand]
        private async Task CloseModal() =>
            await NavigationServive.PopModalAsync();
    }
}
