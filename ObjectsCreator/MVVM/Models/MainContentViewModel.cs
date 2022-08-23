namespace ObjectsCreator.MVVM.Models
{
    public class MainContentViewModel : ViewModel
    {
        public AppNavigator Navigator { get; }

        public MainContentViewModel(AppNavigator navigator)
        {
            Navigator = navigator;
        }

    }
}
