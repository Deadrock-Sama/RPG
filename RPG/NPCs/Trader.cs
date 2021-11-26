using System;
using System.Collections.Generic;

namespace RPG.NPCs
{
    internal class Trader : GoodSoul
    {

        private List<Item> range;
        public List<Item> Range
        {
            get
            {
                return range;
            }
        }

        public bool buy(Item chosenItem)
        {
            Predicate<Item> predicate = delegate (Item item) { return item.UID == chosenItem.UID; };

            Item FoundItem = range.Find(predicate);

            bool canBeStolen = false;
            if (FoundItem != null)
            {
                canBeStolen = Player.isEnoughMoney(FoundItem.Price);
                if (canBeStolen)
                {
                    range.Remove(FoundItem);
                    FoundItem.decreasePriceAfterPurchase();
                }
            }

            return canBeStolen;
        }


    }
}
