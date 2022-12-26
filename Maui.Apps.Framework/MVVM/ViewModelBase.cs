
namespace Maui.Apps.Framework.MVVM
{
    //State of a View Model on particular time.
    public partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty]
        private string title = string.Empty;

        [ObservableProperty]
        private bool isBusy = false;

        [ObservableProperty]
        private string loadingText = string.Empty;

        [ObservableProperty]
        private bool dataLoaded = false;

        [ObservableProperty]
        private bool isErrorState = false;

        [ObservableProperty]
        private string errorMessage = string.Empty;

        [ObservableProperty]
        private string errorImage = string.Empty;

        public ViewModelBase() =>
            IsErrorState = false;

        //Called on Page Appearing
        public virtual async void OnNavigatedTo(object parameters) =>
            await Task.CompletedTask;

        //Set Loading Indicatiors for Page
        protected void SetDataLoadingIndicators(bool isStarting = true)
        {
            if (isStarting)
            {
                IsBusy = true;
                DataLoaded = false;
                IsErrorState = false;
                ErrorMessage = "";
                ErrorImage = "";
            }
            else
            {
                LoadingText = "";
                IsBusy = false;
            }

        }
        
    }
}