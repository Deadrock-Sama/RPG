namespace Core.PlayerNS.InventoryNS
{
    public interface IInventoryItem
    {
        string Name { get; set; }
        string Description { get; set; }
        string EffectsMethod { get; set; }
        int Id { get; set; }


    }
}
