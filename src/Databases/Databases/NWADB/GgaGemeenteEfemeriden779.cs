using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWADB
{
    public partial class GgaGemeenteEfemeriden779
    {
        public short GmeId { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime? Einddatum { get; set; }
        public string PveCode { get; set; }
        public decimal SdeId { get; set; }
        public byte[] SeAnnoCadData { get; set; }
    }
}
