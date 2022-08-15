using RPG.Components.PlayerNS.InventoryNS;
using RPG.Components.PlayerNS.InventoryNS.Resources;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;
using RPG.Components.PlayerNS.InventoryNS.Resources.Materials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectsCreator.Models
{
    public class ResourceView<T> : INotifyPropertyChanged where T : IResource, new()
    {


        private T _item;

        public T Item => _item;

        public ResourceView()
        {
            _item = new T();
        }

        public ResourceView(T item)
        {
            _item = item;
        }

        public virtual int Id
        {
            get { return _item.Id; }
            set
            {
                _item.Id = value;
                NotifyPropertyChanged("Id");
            }
        }
        public virtual string Name
        {
            get { return _item.Name; }
            set
            {
                _item.Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public virtual string Description
        {
            get { return _item.Description; }
            set
            {
                _item.Description = value;
                NotifyPropertyChanged("Description");
            }
        }
        public virtual string EffectsMethods
        {
            get 
            {   
                return _item.EffectsMethod;               
            }
            set
            {
                _item.EffectsMethod = value;
                NotifyPropertyChanged("EffectsMethod");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyChanged)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyChanged));
        }
    }
}
