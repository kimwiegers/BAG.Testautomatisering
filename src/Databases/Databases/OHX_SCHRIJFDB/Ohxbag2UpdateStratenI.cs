using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class Ohxbag2UpdateStratenI
    {
        public int Id { get; set; }
        public byte GmeId { get; set; }
        public byte WpsId { get; set; }
        public string SttType { get; set; }
        public string Naam { get; set; }
        public string NaamOfficieel { get; set; }
        public string NaamPtt { get; set; }
        public string Naamafkorting { get; set; }
    }
}
