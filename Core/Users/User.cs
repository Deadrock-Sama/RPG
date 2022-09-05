﻿using Core.DBInteraction.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Users
{
    public class User : DbEntity
    {
        public virtual string Name { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual bool IsAdmin { get; set; }
    }

}
