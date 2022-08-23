using Core.DBInteraction;
using Core.PlayerNS.InventoryNS.Equipment;
using Core.PlayerNS.InventoryNS.Equipment.Amulets;
using Core.PlayerNS.InventoryNS.Equipment.Armor;
using Core.PlayerNS.InventoryNS.Equipment.Weapons;
using Core.PlayerNS.InventoryNS.Resources;
using Core.PlayerNS.InventoryNS.Resources.Food;
using Core.PlayerNS.InventoryNS.Resources.Materials;
using Core.PlayerNS.InventoryNS.Resources.Potions;
using NHibernate;
using ObjectsCreator.MVVM.Components;
using ObjectsCreator.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RepositoryShell _repo;

        
        private ResourceObservableCollection<Meal> meals;
        private ResourceObservableCollection<Potion> potions;
        private ResourceObservableCollection<Material> materials;

        private EquipmentObservableCollection<Helmet> helmets;
        private EquipmentObservableCollection<Chest> chests;
        private EquipmentObservableCollection<Leggins> leggins;
        private EquipmentObservableCollection<Boots> boots;
        private EquipmentObservableCollection<Sword> swords;
        private EquipmentObservableCollection<Bow> bows;
        private EquipmentObservableCollection<Wand> wands;
        private EquipmentObservableCollection<Earring> earrings;
        private EquipmentObservableCollection<Ring> rings;
        private EquipmentObservableCollection<Necklace> necklaces;
        private EquipmentObservableCollection<Bracelet> bracelets;

        private ItemsControl currGrid;

        public MainWindow()
        {
            _repo = new RepositoryShell();

            //var authorization = new Authorization(_repo);

            //authorization.ShowDialog();

            //if (!authorization.IsAuthorized)
            //{
            //    Close();
            //}

            Loaded += MainWindow_Loaded;

            InitializeComponent();

           
            configureResourceGrids();
            configureEquipmentGrids();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           // CControl.Content = new AuthorizationViewModel();
        }

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
            //helmets = new EquipmentObservableCollection<Helmet>(_repo.GetAll<Helmet>());
            //helmets.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Helmet>);
            //helmets.ItemChanged +=
            //    new EquipmentObservableCollection<Helmet>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Helmet>);
            //Helmets.ItemsSource = helmets;
        }

        private void configureChestsGrid()
        {

            //chests = new EquipmentObservableCollection<Chest>(_repo.GetAll<Chest>());
            //chests.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Chest>);
            //chests.ItemChanged +=
            //    new EquipmentObservableCollection<Chest>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Chest>);
            //Chests.ItemsSource = chests;
        }

        private void configureLegginsGrid()
        {

            //leggins = new EquipmentObservableCollection<Leggins>(_repo.GetAll<Leggins>());
            //leggins.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Leggins>);
            //leggins.ItemChanged +=
            //    new EquipmentObservableCollection<Leggins>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Leggins>);
            //Leggins.ItemsSource = leggins;
        }

        private void configureBootsGrid()
        {

            //boots = new EquipmentObservableCollection<Boots>(_repo.GetAll<Boots>());
            //boots.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Boots>);
            //boots.ItemChanged +=
            //    new EquipmentObservableCollection<Boots>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Boots>);
            //Boots.ItemsSource = boots;
        }

        private void configureSwordsGrid()
        {

            //swords = new EquipmentObservableCollection<Sword>(_repo.GetAll<Sword>());
            //swords.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Sword>);
            //swords.ItemChanged +=
            //    new EquipmentObservableCollection<Sword>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Sword>);
            //Swords.ItemsSource = swords;
        }

        private void configureBowsGrid()
        {

            //bows = new EquipmentObservableCollection<Bow>(_repo.GetAll<Bow>());
            //bows.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Bow>);
            //bows.ItemChanged +=
            //    new EquipmentObservableCollection<Bow>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Bow>);
            //Bows.ItemsSource = bows;
        }

        private void configureWandsGrid()
        {

            //wands = new EquipmentObservableCollection<Wand>(_repo.GetAll<Wand>());
            //wands.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Wand>);
            //wands.ItemChanged +=
            //    new EquipmentObservableCollection<Wand>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Wand>);
            //Wands.ItemsSource = wands;
        }

        private void configureEarringsGrid()
        {

            //earrings = new EquipmentObservableCollection<Earring>(_repo.GetAll<Earring>());
            //earrings.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Earring>);
            //earrings.ItemChanged +=
            //    new EquipmentObservableCollection<Earring>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Earring>);
            //Earrings.ItemsSource = earrings;
        }

        private void configureRingsGrid()
        {

            //rings = new EquipmentObservableCollection<Ring>(_repo.GetAll<Ring>());
            //rings.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Ring>);
            //rings.ItemChanged +=
            //    new EquipmentObservableCollection<Ring>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Ring>);
            //Rings.ItemsSource = rings;
        }

        private void configureNecklacesGrid()
        {

            //necklaces = new EquipmentObservableCollection<Necklace>(_repo.GetAll<Necklace>());
            //necklaces.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Necklace>);
            //necklaces.ItemChanged +=
            //    new EquipmentObservableCollection<Necklace>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Necklace>);
            //Necklaces.ItemsSource = necklaces;
        }

        private void configureBraceletsGrid()
        {

            //bracelets = new EquipmentObservableCollection<Bracelet>(_repo.GetAll<Bracelet>());
            //bracelets.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(equipmentGrid_CollectionChanged<Bracelet>);
            //bracelets.ItemChanged +=
            //    new EquipmentObservableCollection<Bracelet>.EcObservableCollectionItemChangedEventHandler(equipmentGrid_ItemChanged<Bracelet>);
            //Bracelets.ItemsSource = bracelets;
        }

        void configureResourceGrids()
        {

                configureMaterialsGrid();
                configureMealGrid();
                configurePotionsGrid();

        }

        void configureMealGrid()
        {
            //meals = new ResourceObservableCollection<Meal>(_repo.GetAll<Meal>());
            //meals.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(resourceGrid_CollectionChanged<Meal>);
            //meals.ItemChanged +=
            //    new ResourceObservableCollection<Meal>.EcObservableCollectionItemChangedEventHandler(resourceGrid_ItemChanged<Meal>);
            //Meals.ItemsSource = meals;
        }

        void configureMaterialsGrid()
        {
            //materials = new ResourceObservableCollection<Material>(_repo.GetAll<Material>());
            //materials.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(resourceGrid_CollectionChanged<Material>);
            //materials.ItemChanged +=
            //    new ResourceObservableCollection<Material>.EcObservableCollectionItemChangedEventHandler(resourceGrid_ItemChanged<Material>);
            //Materials.ItemsSource = materials;
        }

        void configurePotionsGrid()
        {

            //potions = new ResourceObservableCollection<Potion>(_repo.GetAll<Potion>());
            //potions.CollectionChanged +=
            //    new NotifyCollectionChangedEventHandler(resourceGrid_CollectionChanged<Potion>);
            //potions.ItemChanged +=
            //    new ResourceObservableCollection<Potion>.EcObservableCollectionItemChangedEventHandler(resourceGrid_ItemChanged<Potion>);
            //Potions.ItemsSource = potions;

        }

        void resourceGrid_ItemChanged<T>(object sender, EcObservableCollectionItemChangedEventArgs<ResourceViewModel<T>> args) where T : IResource, new()
        {
            foreach(ResourceViewModel<T> c in (ResourceObservableCollection<T>)sender)
            {
                _repo.AddOrUpdate(c.Item);
            }
            
        }

        void resourceGrid_CollectionChanged<T>(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) where T : IResource, new()
        {

            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    foreach (ResourceViewModel<T> c in e.OldItems)
                    {
                        _repo.Delete(c.Item);
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    foreach (ResourceViewModel<T> c in e.NewItems)
                        _repo.Add(c.Item);
                    break;
                default:
                    foreach (ResourceViewModel<T> c in e.OldItems)
                        _repo.AddOrUpdate(c.Item);
                    break;
            }

        }


        void equipmentGrid_ItemChanged<T>(object sender, EcObservableCollectionItemChangedEventArgs<EquipmentViewModel<T>> args) where T : IEquipment, new()
        {
            foreach (EquipmentViewModel<T> c in (EquipmentObservableCollection<T>)sender)
            {
                _repo.AddOrUpdate(c.Item);
            }

        }

        void equipmentGrid_CollectionChanged<T>(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) where T : IEquipment, new()
        {

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Remove:
                    foreach (EquipmentViewModel<T> c in e.OldItems)
                    {
                        _repo.Delete(c.Item);
                    }
                    break;
                case NotifyCollectionChangedAction.Add:
                    foreach (EquipmentViewModel<T> c in e.NewItems)
                        _repo.Add(c.Item);
                    break;
                default:
                    foreach (EquipmentViewModel<T> c in e.OldItems)
                        _repo.AddOrUpdate(c.Item);
                    break;
            }

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

            

            currGrid = (ItemsControl)sender;

        }
    }
}
