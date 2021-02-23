using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwWegvakInRoutes
    {
        public long WeeWvkId { get; set; }
        public DateTime WeeBegindatumVastlegging { get; set; }
        public DateTime WeeBegindatumWerkelijk { get; set; }
        public int RteId { get; set; }

        public virtual NwwRoutes Rte { get; set; }
        public virtual NwwWegvakEfemeriden Wee { get; set; }
    }
}
