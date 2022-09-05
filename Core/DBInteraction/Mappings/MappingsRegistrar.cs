using Core.PlayerNS;
using Core.PlayerNS.CharacteristicsNS;
using Core.PlayerNS.Classes;
using Core.PlayerNS.InventoryNS.Equipment.Amulets;
using Core.PlayerNS.InventoryNS.Equipment.Armor;
using Core.PlayerNS.InventoryNS.Equipment.Weapons;
using Core.PlayerNS.InventoryNS.Resources.Food;
using Core.PlayerNS.InventoryNS.Resources.Materials;
using Core.PlayerNS.InventoryNS.Resources.Potions;
using Core.Users;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;


namespace Core.DBInteraction.Mappings
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
