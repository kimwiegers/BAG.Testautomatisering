using System;

namespace OHx.Testautomatisering.Data
{
    public class WegvakEfemeridenDiffModel
    {
        public DateTime? BegindatumVastlegging { get; set; }
        public DateTime? BegindatumWerkelijk { get; set; }
        public short? OudGemeenteId { get; set; }
        public short? NieuwGemeenteId { get; set; }
    }
}
