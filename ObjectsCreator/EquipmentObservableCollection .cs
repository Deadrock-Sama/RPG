using Core.PlayerNS.InventoryNS.Equipment;
using ObjectsCreator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace ObjectsCreator
{
    class EquipmentObservableCollection<T> : ObservableCollection<EquipmentView<T>> where T : IEquipment, new()
    {
        public EquipmentObservableCollection() : base()
        {
            this.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(EcObservableCollection_CollectionChanged);
        }

        void EcObservableCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (EquipmentView<T> item in e.NewItems)
                    item.PropertyChanged += new PropertyChangedEventHandler(item_PropertyChanged);
            }
        }
        public EquipmentObservableCollection(List<T> items) : this()
        {
            foreach (var item in items)
            {
                this.Add(new EquipmentView<T>(item));
            }
        }

        void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            EcObservableCollectionItemChangedEventArgs<EquipmentView<T>> args =
                new EcObservableCollectionItemChangedEventArgs<EquipmentView<T>>();
            args.Item = (EquipmentView<T>)sender;
            ItemChanged(this, args);
        }

        public event EcObservableCollectionItemChangedEventHandler ItemChanged;

        public delegate void EcObservableCollectionItemChangedEventHandler(object sender,
                                                            EcObservableCollectionItemChangedEventArgs<EquipmentView<T>> args);
    }


}
