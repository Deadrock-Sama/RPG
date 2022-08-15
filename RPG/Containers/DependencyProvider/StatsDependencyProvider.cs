using Castle.MicroKernel.Registration;
using RPG.Components.Containers;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Armor;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons;
using RPG.Components.PlayerNS.Sets;
using RPG.Components.PlayerNS.Sets.EquipmentSets;
using RPG.Components.PlayerNS.Sets.PlayerSets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Containers.DependencyProvider
{
    public class StatsDependencyProvider : IDependencyProvider
    {
        public IEnumerable<IRegistration> GetRegistrations()
        {
            yield return Component.For<IAmulet, Ring>();
            
            yield return Component.For<IAmulet, Bracelet>();

            yield return Component.For<IAmulet,Earring>();

            yield return Component.For<IAmulet, Necklace>();

            yield return Component.For<IArmor, Helmet>();

            yield return Component.For<IArmor, Chest>();

            yield return Component.For<IArmor, Leggins>();

            yield return Component.For<IArmor, Boots>();

            yield return Component.For<IWeapon>();

            yield return Component.For<AmuletsSet>();

            yield return Component.For<ArmorSet>();

            yield return Component.For<EquipmentStatsSet>();

            yield return Component.For<Characteristics>();



        }
    }
}
