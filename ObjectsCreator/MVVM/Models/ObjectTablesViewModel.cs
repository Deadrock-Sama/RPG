using Core.DBInteraction;
using Core.PlayerNS.InventoryNS.Equipment;
using Core.PlayerNS.InventoryNS.Equipment.Amulets;
using Core.PlayerNS.InventoryNS.Equipment.Armor;
using Core.PlayerNS.InventoryNS.Equipment.Weapons;
using Core.PlayerNS.InventoryNS.Resources;
using Core.PlayerNS.InventoryNS.Resources.Food;
using Core.PlayerNS.InventoryNS.Resources.Materials;
using Core.PlayerNS.InventoryNS.Resources.Potions;
using ObjectsCreator.MVVM.Components;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace ObjectsCreator.MVVM.Models
{

    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ObjectTablesViewModel : ViewModel
    {

        public ResourceObservableCollection<Meal> Meals { get; set; }
        public ResourceObservableCollection<Potion> Potions { get; set; } = new ResourceObservableCollection<Potion>();
        public ResourceObservableCollection<Material> Materials { get; set; }
        public EquipmentObservableCollection<Helmet> Helmets { get; set; } = new EquipmentObservableCollection<Helmet>();
        public EquipmentObservableCollection<Chest> Chests { get; set; } = new EquipmentObservableCollection<Chest>();
        public EquipmentObservableCollection<Leggins> Leggins { get; set; } = new EquipmentObservableCollection<Leggins>();
        public EquipmentObservableCollection<Boots> Boots { get; set; } = new EquipmentObservableCollection<Boots>();
        public EquipmentObservableCollection<Sword> Swords { get; set; } = new EquipmentObservableCollection<Sword>();
        public EquipmentObservableCollection<Bow> Bows { get; set; } = new EquipmentObservableCollection<Bow>();
        public EquipmentObservableCollection<Wand> Wands { get; set; } = new EquipmentObservableCollection<Wand>();
        public EquipmentObservableCollection<Earring> Earrings { get; set; } = new EquipmentObservableCollection<Earring>();
        public EquipmentObservableCollection<Ring> Rings { get; set; } = new EquipmentObservableCollection<Ring>();
        public EquipmentObservableCollection<Necklace> Necklaces { get; set; } = new EquipmentObservableCollection<Necklace>();
        public EquipmentObservableCollection<Bracelet> Bracelets { get; set; } = new EquipmentObservableCollection<Bracelet>();

        private ItemsControl _currGrid;
        private RepositoryShell _repositoryShell;
        private AppNavigator _appNavigator;


        //  private ItemsControl currGrid;

        public ObjectTablesViewModel(RepositoryShell repo, AppNavigator appNavigator)

        {
            _repositoryShell = repo;
            _appNavigator = appNavigator;

            EditStats_ClickCommand = new RelayCommand(editStats_Click);
            Grid_MouseRightButtonDownCommand = new RelayCommand(editStats_Click);
        
            configureResourceGrids();
            configureEquipmentGrids();
        }

        //private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        //{
        //    // CControl.Content = new AuthorizationViewModel();
        //}

        void configureEquipmentGrids()
        {

            configureHelmetsGrid();
            configureChestsGrid();
            configureLegginsGrid();
            configureBootsGrid();
            configureSwordsGrid();
            configureBowsGrid();
            configureWandsGrid();
            configureEarringsGrid();
            configureRingsGrid();
            configureNecklacesGrid();
            configureBraceletsGrid();


        }

        private void configureHelmetsGrid()
        {
            Helmets = new EquipmentObservableCollection<Helmet>(_repositoryShell.GetAll<Helmet>());
            Helmets.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Helmet>);
            Helmets.ItemChanged +=
                new EquipmentObservableCollection<Helmet>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
           
        }

        private void configureChestsGrid()
        {

            Chests = new EquipmentObservableCollection<Chest>(_repositoryShell.GetAll<Chest>());
            Chests.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Chest>);
            Chests.ItemChanged +=
                new EquipmentObservableCollection<Chest>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
            
        }

        private void configureLegginsGrid()
        {

            Leggins = new EquipmentObservableCollection<Leggins>(_repositoryShell.GetAll<Leggins>());
            Leggins.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Leggins>);
            Leggins.ItemChanged +=
                new EquipmentObservableCollection<Leggins>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
            
        }

        private void configureBootsGrid()
        {

            Boots = new EquipmentObservableCollection<Boots>(_repositoryShell.GetAll<Boots>());
            Boots.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Boots>);
            Boots.ItemChanged +=
                new EquipmentObservableCollection<Boots>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
            
        }

        private void configureSwordsGrid()
        {

            Swords = new EquipmentObservableCollection<Sword>(_repositoryShell.GetAll<Sword>());
            Swords.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Sword>);
            Swords.ItemChanged +=
                new EquipmentObservableCollection<Sword>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
            
        }

        private void configureBowsGrid()
        {

            Bows = new EquipmentObservableCollection<Bow>(_repositoryShell.GetAll<Bow>());
            Bows.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Bow>);
            Bows.ItemChanged +=
                new EquipmentObservableCollection<Bow>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
            
        }

        private void configureWandsGrid()
        {

            Wands = new EquipmentObservableCollection<Wand>(_repositoryShell.GetAll<Wand>());
            Wands.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Wand>);
            Wands.ItemChanged +=
                new EquipmentObservableCollection<Wand>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
           
        }

        private void configureEarringsGrid()
        {

            Earrings = new EquipmentObservableCollection<Earring>(_repositoryShell.GetAll<Earring>());
            Earrings.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Earring>);
            Earrings.ItemChanged +=
                new EquipmentObservableCollection<Earring>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
            
        }

        private void configureRingsGrid()
        {

            Rings = new EquipmentObservableCollection<Ring>(_repositoryShell.GetAll<Ring>());
            Rings.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Ring>);
            Rings.ItemChanged +=
                new EquipmentObservableCollection<Ring>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
            
        }

        private void configureNecklacesGrid()
        {

            Necklaces = new EquipmentObservableCollection<Necklace>(_repositoryShell.GetAll<Necklace>());
            Necklaces.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Necklace>);
            Necklaces.ItemChanged +=
                new EquipmentObservableCollection<Necklace>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
           
        }

        private void configureBraceletsGrid()
        {

            Bracelets = new EquipmentObservableCollection<Bracelet>(_repositoryShell.GetAll<Bracelet>());
            Bracelets.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Bracelet>);
            Bracelets.ItemChanged +=
                new EquipmentObservableCollection<Bracelet>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged);
           
        }

        void configureResourceGrids()
        {

            configureMaterialsGrid();
            configureMealGrid();
            configurePotionsGrid();

        }

        void configureMealGrid()
        {
            Meals = new ResourceObservableCollection<Meal>(_repositoryShell.GetAll<Meal>());
            Meals.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(resourceGrid_CollectionChanged<Meal>);
            Meals.ItemChanged +=
                new ResourceObservableCollection<Meal>.EcObservableCollectionItemChangedEventHandler(resourceGrid_ItemChanged);
            //Meals.ItemsSource = meals;
        }

        void configureMaterialsGrid()
        {
            Materials = new ResourceObservableCollection<Material>(_repositoryShell.GetAll<Material>());
            Materials.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(resourceGrid_CollectionChanged<Material>);
            Materials.ItemChanged +=
                new ResourceObservableCollection<Material>.EcObservableCollectionItemChangedEventHandler(resourceGrid_ItemChanged);
        }

        void configurePotionsGrid()
        {

            Potions = new ResourceObservableCollection<Potion>(_repositoryShell.GetAll<Potion>());
            Potions.CollectionChanged +=
                new NotifyCollectionChangedEventHandler(resourceGrid_CollectionChanged<Potion>);
            Potions.ItemChanged +=
                new ResourceObservableCollection<Potion>.EcObservableCollectionItemChangedEventHandler(resourceGrid_ItemChanged);
            

        }


        void resourceGrid_ItemChanged<T>(object sender, EcObservableCollectionItemChangedEventArgs<ResourceViewModel<T>> args) where T : IResource, new()
        {
            foreach (ResourceViewModel<T> c in (ResourceObservableCollection<T>)sender)
            {
                _repositoryShell.AddOrUpdate(c.Item);
            }

        }

        void resourceGrid_CollectionChanged<T>(object sender, NotifyCollectionChangedEventArgs e) where T : IResource, new()
        {

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Remove:
                    foreach (ResourceViewModel<T> c in e.OldItems)
                    {
                        _repositoryShell.Delete(c.Item);
                    }
                    break;
                case NotifyCollectionChangedAction.Add:
                    foreach (ResourceViewModel<T> c in e.NewItems)
                        _repositoryShell.Add(c.Item);
                    break;
                default:
                    foreach (ResourceViewModel<T> c in e.OldItems)
                        _repositoryShell.AddOrUpdate(c.Item);
                    break;
            }

        }


        void equipmentGrid_ItemChanged<T>(object sender, EcObservableCollectionItemChangedEventArgs<EquipmentViewModel<T>> args) where T : IEquipment, new()
        {
            foreach (EquipmentViewModel<T> c in (EquipmentObservableCollection<T>)sender)
            {
                _repositoryShell.AddOrUpdate(c.Item);
            }

        }
        void equipmentGrid_CollectionChanged<T>(object sender, NotifyCollectionChangedEventArgs e) where T : IEquipment, new()
        {

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Remove:
                    foreach (EquipmentViewModel<T> c in e.OldItems)
                    {
                        _repositoryShell.Delete(c.Item);
                    }
                    break;
                case NotifyCollectionChangedAction.Add:
                    foreach (EquipmentViewModel<T> c in e.NewItems)
                        _repositoryShell.Add(c.Item);
                    break;
                default:
                    foreach (EquipmentViewModel<T> c in e.OldItems)
                        _repositoryShell.AddOrUpdate(c.Item);
                    break;
            }

        }


        private void editEffects_Click(object sender, RoutedEventArgs e)
        {
            //EditingCharacteristics editingCharacteristics = new EditingCharacteristics();

            //var a = (int)sender; 

        }

        private void editStats_Click(object sender)
        {
            //пробелма с типом, надо как-то 
            dynamic item = (_currGrid.Items.CurrentItem);
            var stats = item.Stats;
            var editingCharacteristics = new EditingCharacteristicsViewModel();
            if (stats != null)
            {
                editingCharacteristics = new EditingCharacteristicsViewModel(stats);
            }

            _appNavigator.Show(editingCharacteristics);

            item.Stats = editingCharacteristics.Stats;
        }

        private void grid_MouseRightButtonDown(object sender)
        {

             _currGrid = (ItemsControl)sender;

        }

        public ICommand EditStats_ClickCommand;
        public ICommand Grid_MouseRightButtonDownCommand;

    }
}
