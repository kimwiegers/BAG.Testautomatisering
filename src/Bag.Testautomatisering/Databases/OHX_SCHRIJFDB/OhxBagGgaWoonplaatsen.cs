using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxBagGgaWoonplaatsen
    {
        public byte Id { get; set; }
        public byte? GmeId { get; set; }
        public string Status { get; set; }
        public string NaamNen { get; set; }
        public string NaamPtt { get; set; }
        public string Naamafkorting { get; set; }
        public string NaamOfficieel { get; set; }
        public string BagId { get; set; }
    }
}
