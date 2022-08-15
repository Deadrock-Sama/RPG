using ObjectsCreator.Models;
using RPG.Components.PlayerNS.InventoryNS;
using RPG.Components.PlayerNS.InventoryNS.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace ObjectsCreator
{
    class ResourceObservableCollection<T> : ObservableCollection<ResourceView<T>> where T : IResource, new()
    {
        public ResourceObservableCollection() : base()
        {
            this.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(EcObservableCollection_CollectionChanged);
        }

        void EcObservableCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (ResourceView<T> item in e.NewItems)
                    item.PropertyChanged += new PropertyChangedEventHandler(item_PropertyChanged);
            }
        }
        public ResourceObservableCollection(List<T> items) : this()
        {
            foreach (var item in items)
            {
                this.Add(new ResourceView<T>(item));
            }
        }

        void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            EcObservableCollectionItemChangedEventArgs<ResourceView<T>> args =
                new EcObservableCollectionItemChangedEventArgs<ResourceView<T>>();
            args.Item = (ResourceView<T>)sender;
            ItemChanged(this, args);
        }

        public event EcObservableCollectionItemChangedEventHandler ItemChanged;

        public delegate void EcObservableCollectionItemChangedEventHandler(object sender,
                                                            EcObservableCollectionItemChangedEventArgs<ResourceView<T>> args);
    }

    class EcObservableCollectionItemChangedEventArgs<T> : EventArgs
    {
        public T Item { get; set; }
    }
}
