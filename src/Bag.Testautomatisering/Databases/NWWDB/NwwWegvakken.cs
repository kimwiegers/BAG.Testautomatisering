using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwWegvakken
    {
        public NwwWegvakken()
        {
            NwwWegvakEfemeriden = new HashSet<NwwWegvakEfemeriden>();
            NwwWegvakRelatiesWvkIdOpvolgerNavigation = new HashSet<NwwWegvakRelaties>();
            NwwWegvakRelatiesWvkIdVoorgangerNavigation = new HashSet<NwwWegvakRelaties>();
        }

        public long Id { get; set; }
        public long JteIdBegin { get; set; }
        public long JteIdEind { get; set; }
        public int? SokId { get; set; }
        public int? SotId { get; set; }
        public DateTime? SoMutatiedatum { get; set; }
        public string GedwongenRijrichting { get; set; }
        public int? VknIdGeheel { get; set; }
        public int? VknIdLinks { get; set; }
        public int? VknIdRechts { get; set; }

        public virtual NwwJuncties JteIdBeginNavigation { get; set; }
        public virtual NwwJuncties JteIdEindNavigation { get; set; }
        public virtual ICollection<NwwWegvakEfemeriden> NwwWegvakEfemeriden { get; set; }
        public virtual ICollection<NwwWegvakRelaties> NwwWegvakRelatiesWvkIdOpvolgerNavigation { get; set; }
        public virtual ICollection<NwwWegvakRelaties> NwwWegvakRelatiesWvkIdVoorgangerNavigation { get; set; }
    }
}
