using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwHectopunten
    {
        public long WeeWvkId { get; set; }
        public DateTime WeeBegindatumVastlegging { get; set; }
        public DateTime WeeBegindatumWerkelijk { get; set; }
        public short Hectometrering { get; set; }
        public int Afstand { get; set; }
        public DateTime? Einddatum { get; set; }
        public decimal SdeId { get; set; }
        public byte[] SeAnnoCadData { get; set; }

        public virtual NwwWegvakEfemeriden Wee { get; set; }
    }
}
