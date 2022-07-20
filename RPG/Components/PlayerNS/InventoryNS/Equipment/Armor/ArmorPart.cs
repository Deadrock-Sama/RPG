using RPG.DBInteraction.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Components.PlayerNS.InventoryNS.Equipment.Armor
{
    public class ArmorPart : DbEntity, IArmor
    {
        public virtual string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual double XPMultiplier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual double HPMultiplier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual double MPMultiplier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual int XPBonus { get => throw new NotImplementedException(); set => throw new NotImplementedException();}

        public virtual int HPBonus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual int MPBonus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual bool isAbleToWear()
        {
            throw new NotImplementedException();
        }
    }
}
