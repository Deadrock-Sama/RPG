using Core.DBInteraction.Mappings;
using Core.PlayerNS.InventoryNS.Equipment.Amulets;
using Core.PlayerNS.InventoryNS.Equipment.Armor;
using Core.PlayerNS.InventoryNS.Equipment.Weapons;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.PlayerNS.Sets.EquipmentSets
{
    public class PlayerOutfit : DbEntity
    {
        public virtual Weapon Weapon { get; set; }
        public virtual Helmet Helmet { get; set; }
        public virtual Chest Chest { get; set; }
        public virtual Leggins Leggins { get; set; }
        public virtual Boots Boots { get; set; }
        public virtual Necklace Necklace { get; set; }
        public virtual Earring Earring { get; set; }
        public virtual Ring Ring { get; set; }
        public virtual Bracelet Bracelet { get; set; }
        public virtual Player Player { get; set; }

        public virtual EquipmentStatsSet RecieveEquipmentStatsSet()
        {
            return new EquipmentStatsSet(
                new ArmorSet(Helmet, Chest, Leggins, Boots),
                new AmuletsSet(Ring, Necklace, Earring, Bracelet),
                new WeaponSet(Weapon));
        }

        public class PlayerOutfitMapping : ClassMap<PlayerOutfit>
        {

            public PlayerOutfitMapping()
            {
                Id(c => c.Id);
                References(e => e.Weapon).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
                References(e => e.Helmet).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
                References(e => e.Chest).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
                References(e => e.Leggins).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
                References(e => e.Boots).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
                References(e => e.Ring).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
                References(e => e.Earring).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
                References(e => e.Bracelet).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
                References(e => e.Necklace).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
                References(e => e.Player).Cascade.AllDeleteOrphan()
               .Not.LazyLoad();
            }
        }

    }
}
