using Core.PlayerNS.InventoryNS.Resources;
using ObjectsCreator.MVVM.Models;
using RPG.Components.PlayerNS.InventoryNS;
using RPG.Components.PlayerNS.InventoryNS.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace ObjectsCreator.MVVM.Components
{
    class ResourceObservableCollection<T> : ObservableCollection<ResourceViewModel<T>> where T : IResource, new()
    {
        public ResourceObservableCollection() : base()
        {
            CollectionChanged +=
                new NotifyCollectionChangedEventHandler(EcObservableCollection_CollectionChanged);
        }

        void EcObservableCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (ResourceViewModel<T> item in e.NewItems)
                    item.PropertyChanged += new PropertyChangedEventHandler(item_PropertyChanged);
            }
        }
        public ResourceObservableCollection(List<T> items) : this()
        {
            foreach (var item in items)
            {
                Add(new ResourceViewModel<T>(item));
            }
        }

        void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            EcObservableCollectionItemChangedEventArgs<ResourceViewModel<T>> args =
                new EcObservableCollectionItemChangedEventArgs<ResourceViewModel<T>>();
            args.Item = (ResourceViewModel<T>)sender;
            ItemChanged(this, args);
        }

        public event EcObservableCollectionItemChangedEventHandler ItemChanged;

        public delegate void EcObservableCollectionItemChangedEventHandler(object sender,
                                                            EcObservableCollectionItemChangedEventArgs<ResourceViewModel<T>> args);
    }

    class EcObservableCollectionItemChangedEventArgs<T> : EventArgs
    {
        public T Item { get; set; }
    }
}
