using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxBagNwgZoneEfnI
    {
        public decimal Id { get; set; }
        public string ZneZntCode { get; set; }
        public string ZneCode { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime? Einddatum { get; set; }
        public byte[] SeAnnoCadData { get; set; }
    }
}
