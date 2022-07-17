using RPG.Components.PlayerNS;
using RPG.Components.PlayerNS.InventoryNS.Resources.Food;
using RPG.Components.PlayerNS.InventoryNS.Resources.Materials;
using RPG.Components.PlayerNS.InventoryNS.Resources.Potions;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;

namespace RPG.DBInteraction.Mappings
{
    class MappingsRegistrar
    {

        public MappingConfigurator AddMappings(MappingConfigurator mappingConfigurator)
        {
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<PlayerBasicInfoMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<PlayerMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<MealMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<MaterialMapping>());
            mappingConfigurator.AddMapping(c => c.FluentMappings.Add<PotionMapping>());


            return mappingConfigurator;
        }

    }
}
