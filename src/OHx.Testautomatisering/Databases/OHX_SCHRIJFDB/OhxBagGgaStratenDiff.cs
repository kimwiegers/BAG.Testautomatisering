using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxBagGgaStratenDiff
    {
        public int? StrId { get; set; }
        public string StrName { get; set; }
        public byte? WpsId { get; set; }
        public string WpsName { get; set; }
        public byte? GmeId { get; set; }
        public string GmeName { get; set; }
        public DateTime? ImportDate { get; set; }
        public string ImportAction { get; set; }
        public string BagId { get; set; }
    }
}
