﻿using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TinfrastructureManager
    {
        public TinfrastructureManager()
        {
            TorganizationalUnits = new HashSet<TorganizationalUnits>();
        }

        public short TinfrastructureManagerId { get; set; }

        public virtual ICollection<TorganizationalUnits> TorganizationalUnits { get; set; }
    }
}
