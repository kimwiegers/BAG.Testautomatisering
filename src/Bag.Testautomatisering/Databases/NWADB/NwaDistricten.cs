using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWADB
{
    public partial class NwaDistricten
    {
        public decimal Id { get; set; }
        public short Nummer { get; set; }
        public string RdtCode { get; set; }
        public string Naam { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime? Einddatum { get; set; }

        public virtual NwaRegionaleDiensten RdtCodeNavigation { get; set; }
    }
}
