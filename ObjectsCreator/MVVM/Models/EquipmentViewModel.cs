using System.ComponentModel;
using System.Text;
using Core.PlayerNS.CharacteristicsNS;
using Core.PlayerNS.InventoryNS.Equipment;
using Core.PlayerNS.InventoryNS.Equipment.Weapons;

namespace ObjectsCreator.MVVM.Models
{
    public class EquipmentViewModel<T> : ViewModel where T : IEquipment, new()
    {
        public T Item => _item;

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
        public virtual StatsBonus Stats
        {
            get
            {
                return _item.Stats;
            }
            set
            {
                _item.Stats = value;
                Notify();
            }
        }

        public virtual bool IsStartItem
        {
            get
            {
                return (_item is IWeapon) ? ((IWeapon)_item).IsStartItem : false ;
            }
            set
            {
                if (_item is IWeapon) 
                {
                    ((IWeapon)_item).IsStartItem = value;
                    Notify();
                }              
                
            }
        }

        private T _item;
       
        public EquipmentViewModel()
        {
            _item = new T();
        }

        public EquipmentViewModel(T item)
        {
            _item = item;
        }
        
    }
}
