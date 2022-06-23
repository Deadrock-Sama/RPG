using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Item
    {
        private string name;
        private string identifier;
        private int price;

        public string UID { get { return identifier; } }
        public int Price { get => price; set => price = value; }

        public void decreasePriceAfterPurchase()
        {
            price = (int)(price * 0.8);
        }

    }
}
