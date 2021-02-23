using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWADB
{
    public partial class OhgVGemeenteEfemeridenA
    {
        public short GmeId { get; set; }
        public string Naam { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime? Einddatum { get; set; }
        public string PveCode { get; set; }
        public decimal SdeId { get; set; }
    }
}
