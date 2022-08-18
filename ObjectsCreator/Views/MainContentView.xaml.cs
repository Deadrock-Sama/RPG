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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObjectsCreator
{
    /// <summary>
    /// Логика взаимодействия для MainContentView.xaml
    /// </summary>
    public partial class MainContentView : UserControl
    {
        public MainContentView()
        {
            InitializeComponent();
        }


        private void editEffects_Click(object sender, RoutedEventArgs e)
        {
            //EditingCharacteristics editingCharacteristics = new EditingCharacteristics();

            //var a = (int)sender;

        }

        private void editStats_Click(object sender, RoutedEventArgs e)
        {
            ////пробелма с типом, надо как-то 
            //dynamic item = (currGrid.Items.CurrentItem);
            //var stats = item.Stats;
            //var editingCharacteristics = new EditingCharacteristics();
            //if (stats != null)
            //{
            //    editingCharacteristics = new EditingCharacteristics(stats);
            //}

            //editingCharacteristics.ShowDialog();

            //item.Stats = editingCharacteristics.stats;
        }

        private void grid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {



            //currGrid = (ItemsControl)sender;

        }


    }
}
