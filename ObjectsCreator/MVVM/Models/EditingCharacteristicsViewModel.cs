using Core.PlayerNS.CharacteristicsNS;
using ObjectsCreator.MVVM.Components;
using System.Windows.Input;

namespace ObjectsCreator.MVVM.Models
{
    public class EditingCharacteristicsViewModel : ViewModel
    {
        

        public StatsBonus Stats => _stats;
        
        private StatsBonus _stats;
        
        public string HPMultiplier
        {
            get => _stats.HPMultiplier.ToString();
            set
            {
                _stats.HPMultiplier = int.Parse(value);
                Notify();
            }
        }
        public string XPMultiplier
        {
            get => _stats.XPMultiplier.ToString();
            set
            {
                _stats.XPMultiplier = int.Parse(value);
                Notify();
            }
        }
        public string MPMultiplier
        {
            get => _stats.MPMultiplier.ToString();
            set
            {
                _stats.MPMultiplier = int.Parse(value);
                Notify();
            }
        }
        public string ATKMultiplier
        {
            get => _stats.ATKMultiplier.ToString();
            set
            {
                _stats.ATKMultiplier = int.Parse(value);
                Notify();
            }
        }
        public string HPBonus
        {
            get => _stats.HPBonus.ToString();
            set
            {
                _stats.HPBonus = int.Parse(value);
                Notify();
            }
        }
        public string MPBonus
        {
            get => _stats.MPBonus.ToString();
            set
            {
                _stats.MPBonus = int.Parse(value);
                Notify();
            }
        }
        public string XPBonus
        {
            get => _stats.XPBonus.ToString();
            set
            {
                _stats.XPBonus = int.Parse(value);
                Notify();
            }
        }
        public string ATKBonus
        {
            get => _stats.ATKBonus.ToString();
            set
            {
                _stats.ATKBonus = int.Parse(value);
                Notify();
            }
        }
        public string CritChance
        {
            get => _stats.CritChance.ToString();
            set
            {
                _stats.CritChance = int.Parse(value);
                Notify();
            }
        }
        public string CritDMG
        {
            get => _stats.CritDMG.ToString();
            set
            {
                _stats.CritDMG = int.Parse(value);
                Notify();
            }
        }
       
        public ICommand Apply { get; }
        public ICommand Authorize { get; }

        public EditingCharacteristicsViewModel(StatsBonus stats)
        {
            _stats = stats;


            MPBonus = stats.MPBonus.ToString();
            XPBonus = stats.XPBonus.ToString();
            HPBonus = stats.HPBonus.ToString();
            ATKBonus = stats.ATKBonus.ToString();

            MPMultiplier = stats.MPMultiplier.ToString();
            XPMultiplier = stats.XPMultiplier.ToString();
            HPMultiplier = stats.HPMultiplier.ToString();
            ATKMultiplier = stats.ATKMultiplier.ToString();

            CritChance = stats.CritChance.ToString();
            CritDMG = stats.CritDMG.ToString();

            Apply = new RelayCommand(ApplyAction);

        }
        public EditingCharacteristicsViewModel()
        {
            
        }
        public void ApplyAction(object parameter)
        {



        }
    }
}





