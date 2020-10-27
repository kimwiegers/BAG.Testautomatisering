using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class Ohxbag3WegvakEfnMelding
    {
        public int? WvkId { get; set; }
        public DateTime? BegindatumVastlegging { get; set; }
        public DateTime? BegindatumWerkelijk { get; set; }
        public string SttId { get; set; }
        public string GmeId { get; set; }
        public byte? NewGmeId { get; set; }
        public string ChangeType { get; set; }
        public string NaamOfficieel { get; set; }
        public string UpdateAction { get; set; }
        public string Melding { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string NewSttId { get; set; }
        public string NewNaamOfficieel { get; set; }
        public string GmeNaam { get; set; }
        public string NewGmeNaam { get; set; }
    }
}
