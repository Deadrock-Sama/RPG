using System.ComponentModel;
using System.Text;
using Core.PlayerNS.CharacteristicsNS;
using Core.PlayerNS.InventoryNS.Equipment;

namespace ObjectsCreator.Models
{
    public class EquipmentView<T> : INotifyPropertyChanged where T : IEquipment, new() 
    {


        private T _item;

        public T Item => _item;

        public EquipmentView()
        {
            _item = new T();
        }

        public EquipmentView(T item)
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
        public virtual StatsBonus Stats
        {
            get
            {
                return _item.Stats;
            }
            set
            {
                _item.Stats = value;
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
