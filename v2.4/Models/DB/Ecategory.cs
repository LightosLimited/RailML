﻿using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ecategory
    {
        public Ecategory()
        {
            Ecategories = new HashSet<Ecategories>();
        }

        public short EcategoryId { get; set; }

        public virtual ICollection<Ecategories> Ecategories { get; set; }
    }
}
