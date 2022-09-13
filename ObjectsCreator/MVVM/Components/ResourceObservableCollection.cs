using Core.PlayerNS.InventoryNS.Resources;
using ObjectsCreator.MVVM.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ObjectsCreator.MVVM.Components
{
    public class ResourceObservableCollection<T> : ObservableCollection<ResourceViewModel<T>> where T : IResource, new()
    {
        public event EcObservableCollectionItemChangedEventHandler ItemChanged;

        public delegate void EcObservableCollectionItemChangedEventHandler(object sender,
                                                            EcObservableCollectionItemChangedEventArgs<ResourceViewModel<T>> args);

        public ResourceObservableCollection() : base()
        {
            CollectionChanged +=
                new NotifyCollectionChangedEventHandler(EcObservableCollection_CollectionChanged);
        }

        public ResourceObservableCollection(List<T> items) : this()
        {
            foreach (var item in items)
            {
                Add(new ResourceViewModel<T>(item));
            }
        }

        private void EcObservableCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (ResourceViewModel<T> item in e.NewItems)
                    item.PropertyChanged += new PropertyChangedEventHandler(item_PropertyChanged);
            }
        }
        private void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            EcObservableCollectionItemChangedEventArgs<ResourceViewModel<T>> args =
                new EcObservableCollectionItemChangedEventArgs<ResourceViewModel<T>>();
            args.Item = (ResourceViewModel<T>)sender;
            ItemChanged(this, args);
        }
    }
}
