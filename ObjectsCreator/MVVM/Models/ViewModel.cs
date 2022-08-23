using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ObjectsCreator.MVVM.Models
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>


    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected void Notify([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
