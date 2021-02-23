using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwWbrBenaming
    {
        public NwwWbrBenaming()
        {
            NwwWegvakEfemeriden = new HashSet<NwwWegvakEfemeriden>();
        }

        public decimal Id { get; set; }
        public short? GmeId { get; set; }
        public string Wegnummer { get; set; }
        public string Nummer { get; set; }
        public string Naam { get; set; }

        public virtual ICollection<NwwWegvakEfemeriden> NwwWegvakEfemeriden { get; set; }
    }
}
