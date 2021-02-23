using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwRoutes
    {
        public NwwRoutes()
        {
            NwwWegvakInRoutes = new HashSet<NwwWegvakInRoutes>();
        }

        public int Id { get; set; }
        public string Routeletter { get; set; }
        public short Routenummer { get; set; }

        public virtual ICollection<NwwWegvakInRoutes> NwwWegvakInRoutes { get; set; }
    }
}
