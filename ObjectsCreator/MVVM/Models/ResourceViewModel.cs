using Core.PlayerNS.InventoryNS.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectsCreator.MVVM.Models
{
    public class ResourceViewModel<T> : ViewModel where T : IResource, new()
    {


        private T _item;

        public T Item => _item;

        public ResourceViewModel()
        {
            _item = new T();
        }

        public ResourceViewModel(T item)
        {
            _item = item;
        }

        public virtual int Id
        {
            get { return _item.Id; }
            set
            {
                _item.Id = value;
                Notify();
            }
        }
        public virtual string Name
        {
            get { return _item.Name; }
            set
            {
                _item.Name = value;
                Notify();
            }
        }

        public virtual string Description
        {
            get { return _item.Description; }
            set
            {
                _item.Description = value;
                Notify();
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
                Notify();
            }
        }

    }
}
