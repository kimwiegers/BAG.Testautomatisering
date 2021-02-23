using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class Ohxbag2WegvakEfnDiff
    {
        public int? WvkId { get; set; }
        public DateTime? BegindatumVastlegging { get; set; }
        public DateTime? BegindatumWerkelijk { get; set; }
        public byte? OldGmeId { get; set; }
        public byte? NewGmeId { get; set; }
        public string OldGmeName { get; set; }
        public string NewGmeName { get; set; }
        public string OldStraatnaam { get; set; }
        public string NewStraatnaam { get; set; }
        public string ChangeType { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateAction { get; set; }
        public decimal? OldSttId { get; set; }
        public decimal? NewSttId { get; set; }
    }
}
