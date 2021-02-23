using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWADB
{
    public partial class GgaWoonplaatsen
    {
        public short Id { get; set; }
        public short? GmeId { get; set; }
        public string Status { get; set; }
        public string NaamNen { get; set; }
        public string NaamPtt { get; set; }
        public string Naamafkorting { get; set; }
        public string NaamOfficieel { get; set; }
        public string BagId { get; set; }

        public virtual GgaGemeenten Gme { get; set; }
    }
}
