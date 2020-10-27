using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxBagGgaGemeenteEfnI
    {
        public byte GmeId { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime? Einddatum { get; set; }
        public string PveCode { get; set; }
        public decimal? SdeId { get; set; }
        public byte[] SeAnnoCadData { get; set; }
    }
}
