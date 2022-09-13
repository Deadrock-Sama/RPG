using Castle.MicroKernel.Registration;
using Core.Containers;
using Core.PlayerNS.InventoryNS.Equipment.Amulets;
using Core.PlayerNS.InventoryNS.Equipment.Armor;
using Core.PlayerNS.InventoryNS.Equipment.Weapons;
using Core.PlayerNS.Sets.EquipmentSets;
using Core.PlayerNS.Sets.PlayerSets;
using System.Collections.Generic;

namespace RPG.Containers.DependencyProvider
{
    public class StatsDependencyProvider : IDependencyProvider
    {
        public IEnumerable<IRegistration> GetRegistrations()
        {
            yield return Component.For<Amulet, Ring>();
            
            yield return Component.For<Amulet, Bracelet>();

            yield return Component.For<Amulet,Earring>();

            yield return Component.For<Amulet, Necklace>();

            yield return Component.For<ArmorPart, Helmet>();

            yield return Component.For<ArmorPart, Chest>();

            yield return Component.For<ArmorPart, Leggins>();

            yield return Component.For<ArmorPart, Boots>();

            yield return Component.For<IWeapon>();

            yield return Component.For<AmuletsSet>();

            yield return Component.For<ArmorSet>();

            yield return Component.For<EquipmentStatsSet>();

            yield return Component.For<Characteristics>();



        }
    }
}
