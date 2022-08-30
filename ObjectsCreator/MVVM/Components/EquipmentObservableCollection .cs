using Core.PlayerNS.InventoryNS.Equipment;
using ObjectsCreator.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace ObjectsCreator.MVVM.Components
{
    public class EquipmentObservableCollection<T> : ObservableCollection<EquipmentViewModel<T>> where T : IEquipment, new()
    {

        public event EcObservableCollectionItemChangedEventHandler ItemChanged;

        public delegate void EcObservableCollectionItemChangedEventHandler(object sender,
                                                            EcObservableCollectionItemChangedEventArgs<EquipmentViewModel<T>> args);

        public EquipmentObservableCollection() : base()
        {
            CollectionChanged +=
                new NotifyCollectionChangedEventHandler(EcObservableCollection_CollectionChanged);
        }


        public EquipmentObservableCollection(List<T> items) : this()
        {
            foreach (var item in items)
            {
                Add(new EquipmentViewModel<T>(item));
            }
        }

        private void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            EcObservableCollectionItemChangedEventArgs<EquipmentViewModel<T>> args =
                new EcObservableCollectionItemChangedEventArgs<EquipmentViewModel<T>>();
            args.Item = (EquipmentViewModel<T>)sender;
            ItemChanged(this, args);
        }
        private void EcObservableCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (EquipmentViewModel<T> item in e.NewItems)
                    item.PropertyChanged += new PropertyChangedEventHandler(item_PropertyChanged);
            }
        }

    }


}
