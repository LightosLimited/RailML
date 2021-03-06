﻿using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TbufferStop
    {
        public TbufferStop()
        {
            EtrackNode = new HashSet<EtrackNode>();
        }

        public short TbufferStopId { get; set; }

        public virtual ICollection<EtrackNode> EtrackNode { get; set; }
    }
}
