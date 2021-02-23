using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwJuncties
    {
        public NwwJuncties()
        {
            NwwWegvakkenJteIdBeginNavigation = new HashSet<NwwWegvakken>();
            NwwWegvakkenJteIdEindNavigation = new HashSet<NwwWegvakken>();
        }

        public long Id { get; set; }
        public int? SotId { get; set; }
        public DateTime? SoMutatiedatum { get; set; }

        public virtual ICollection<NwwWegvakken> NwwWegvakkenJteIdBeginNavigation { get; set; }
        public virtual ICollection<NwwWegvakken> NwwWegvakkenJteIdEindNavigation { get; set; }
    }
}
