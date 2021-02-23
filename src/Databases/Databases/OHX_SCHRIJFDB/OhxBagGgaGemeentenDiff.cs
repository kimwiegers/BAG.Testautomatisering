using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxBagGgaGemeentenDiff
    {
        public byte? OldGmeId { get; set; }
        public byte? NewGmeId { get; set; }
        public string OldGmeName { get; set; }
        public string NewGmeName { get; set; }
        public string ChangeType { get; set; }
        public DateTime? ImportDate { get; set; }
        public string ImportAction { get; set; }
    }
}
