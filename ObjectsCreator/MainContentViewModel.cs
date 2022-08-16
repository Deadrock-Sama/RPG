namespace ObjectsCreator
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
