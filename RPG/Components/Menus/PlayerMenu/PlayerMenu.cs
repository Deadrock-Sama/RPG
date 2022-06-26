using RPG.Components.Menus.PlayerMenu.Items;
using RPG.Components.PlayerComponent;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.Menus.PlayerMenu
{
    public class PlayerMenu : IMenu
    {
        public List<IMenuItem> MenuItems { get; }


        public PlayerMenu()
        {
            PlayerDB players = new PlayerDB();
            List<IMenuItem> preMenuItems = new List<IMenuItem>();
 
            foreach (Player player in players.Players)
            {
                preMenuItems.Add(new PlayerMenuItem(player));
            }

            if (players.Players.Count < 6)
            {
                preMenuItems.Add(new NewPlayerMenuItem()); 
            }

            preMenuItems.Add(new BackMenuItem());

            MenuItems = preMenuItems;

        }
    }
}
