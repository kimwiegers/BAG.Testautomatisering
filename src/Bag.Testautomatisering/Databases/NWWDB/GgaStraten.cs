using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class GgaStraten
    {
        public GgaStraten()
        {
            NwwWegvakEfemeriden = new HashSet<NwwWegvakEfemeriden>();
        }

        public int Id { get; set; }
        public short GmeId { get; set; }
        public short WpsId { get; set; }
        public string SttType { get; set; }
        public string Naam { get; set; }
        public string NaamOfficieel { get; set; }
        public string NaamPtt { get; set; }
        public string Naamafkorting { get; set; }
        public string BagId { get; set; }

        public virtual ICollection<NwwWegvakEfemeriden> NwwWegvakEfemeriden { get; set; }
    }
}
