using RPG.Components.PlayerNS;
using RPG.Components.PlayerNS.Characteristics;
using RPG.Components.PlayerNS.Classes;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Amulets;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Armor;
using RPG.Components.PlayerNS.InventoryNS.Equipment.Weapons;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;
using RPG.Components.PlayerNS.InventoryNS.Resources.Materials;
using RPG.Components.PlayerNS.InventoryNS.Resources.Potions;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;
using RPG.Components.Users;
using static RPG.Components.PlayerNS.Characteristics.StatsBonus;

namespace RPG.DBInteraction.Mappings
{
    public class MappingsRegistrar
    {

        public MappingConfigurator AddMappings(MappingConfigurator mappingConfigurator)
        {
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<PlayerBasicInfoMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<StatsBonusMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<PlayerMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<MealMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<MaterialMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<PotionMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<AmuletMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<BraceletMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<EarringMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<NecklaceMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<RingMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<ArmorPartMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<BootsMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<ChestMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<HelmetMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<LegginsMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<WeaponMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<BowMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<WandMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<SwordMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<UserMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<ItemControllerMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<ItemMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<PlayerClassMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<ArcherMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<WarriorMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<WizardMapping>());


            return mappingConfigurator;
        }

    }
}
