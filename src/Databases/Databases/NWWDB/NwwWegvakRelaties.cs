using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwWegvakRelaties
    {
        public long WvkIdOpvolger { get; set; }
        public long WvkIdVoorganger { get; set; }

        public virtual NwwWegvakken WvkIdOpvolgerNavigation { get; set; }
        public virtual NwwWegvakken WvkIdVoorgangerNavigation { get; set; }
    }
}
