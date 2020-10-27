using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxWerkgebiedenHv1
    {
        public decimal? Objectid { get; set; }
        public decimal? JobId { get; set; }
        public short? JobType { get; set; }
        public DateTime? Creatiedatum { get; set; }
        public DateTime? Uitcheckdatum { get; set; }
        public string Omschrijving { get; set; }
        public short? JobStatus { get; set; }
        public decimal? GebruikerId { get; set; }
        public string Gebruiker { get; set; }
        public decimal? FmeJobId { get; set; }
    }
}
