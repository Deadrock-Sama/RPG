using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ObjectsCreator.MVVM.Models
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>


    //public class ViewModel : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private readonly Dictionary<string, Dictionary<ViewModel, HashSet<string>>> _links = new();
    //    private readonly object _sync = new();

    //    public void Notify([CallerMemberName] string srcProperty = "")
    //    {
    //        OnPropertyChanged(srcProperty);

    //        lock (_sync)
    //        {
    //            if (!_links.ContainsKey(srcProperty))
    //            {
    //                return;
    //            }

    //            foreach (var target in _links[srcProperty].Keys)
    //            {
    //                foreach (var dstProperty in _links[srcProperty][target])
    //                {
    //                    target.Notify(dstProperty);
    //                }
    //            }

    //        }
    //    }
    //    private void SetDependency(string srcProperty, ViewModel dst, string dstproperty)
    //    {
    //        lock (_sync)
    //        {
    //            if (!_links.ContainsKey(srcProperty))
    //            {
    //                _links[srcProperty] = new Dictionary<ViewModel, HashSet<string>>();
    //            }

    //            if (!_links[srcProperty].ContainsKey(dst))
    //            {
    //                _links[srcProperty][dst] = new HashSet<string>();
    //            }

    //            _links[srcProperty][dst].Add(dstproperty);
    //        }
    //    }
    //    protected void SetDependency(ViewModel dependency, string srcProperty, string dstproperty)
    //    {
    //        dependency.SetDependency(srcProperty, this, dstproperty);
    //    }
    //    protected void SetDependency(string srcProperty, string dstproperty)
    //    {
    //        SetDependency(this, srcProperty, dstproperty);
    //    }

    //    private void OnPropertyChanged(string name)
    //    {
    //        var propertyChangedEventArgs = new PropertyChangedEventArgs(name);
    //        PropertyChanged?.Invoke(this, propertyChangedEventArgs);
    //    }
    //}

    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected void Notify([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
