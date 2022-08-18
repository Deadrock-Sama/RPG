using Core.PlayerNS.CharacteristicsNS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ObjectsCreator
{
    /// <summary>
    /// Interaction logic for EditingCharacteristics.xaml
    /// </summary>
    public partial class EditingCharacteristics : Window
    {
        public StatsBonus stats { get; set; }
        public EditingCharacteristics()
        {
            InitializeComponent();
        }

        private void Apply(object sender, RoutedEventArgs e)
        {
            stats = new StatsBonus();
            //stats.MPBonus = int.Parse(MPBonus.Text);
            //stats.XPBonus = int.Parse(XPBonus.Text);
            //stats.HPBonus = int.Parse(HPBonus.Text);
            //stats.ATKBonus= int.Parse(ATKBonus.Text);

            //stats.MPMultiplier  = double.Parse(MPMultiplier.Text);
            //stats.XPMultiplier  = double.Parse(XPMultiplier.Text);
            //stats.HPMultiplier  = double.Parse(HPMultiplier.Text);
            //stats.ATKMultiplier = double.Parse(ATKMultiplier.Text);

            //stats.CritChance = int.Parse(CritChance.Text);
            //stats.CritDMG = int.Parse(CritDMG.Text);

            Close();
        }

        public EditingCharacteristics(StatsBonus stats)
        {
            InitializeComponent();

            //MPBonus.Text = stats.MPBonus.ToString();
            //XPBonus.Text = stats.XPBonus.ToString();
            //HPBonus.Text = stats.HPBonus.ToString();
            //ATKBonus.Text = stats.ATKBonus.ToString(); 

            //MPMultiplier.Text = stats.MPMultiplier.ToString();
            //XPMultiplier.Text = stats.XPMultiplier.ToString();
            //HPMultiplier.Text = stats.HPMultiplier.ToString();
            //ATKMultiplier.Text = stats.ATKMultiplier.ToString();

            //CritChance.Text = stats.CritChance.ToString();
            //CritDMG.Text = stats.CritDMG.ToString();

        }
    }
}
