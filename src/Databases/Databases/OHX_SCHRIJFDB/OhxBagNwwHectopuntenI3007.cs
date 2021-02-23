using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxBagNwwHectopuntenI3007
    {
        public int WeeWvkId { get; set; }
        public DateTime WeeBegindatumVastlegging { get; set; }
        public DateTime WeeBegindatumWerkelijk { get; set; }
        public byte Hectometrering { get; set; }
        public short Afstand { get; set; }
        public DateTime? Einddatum { get; set; }
        public decimal? SdeId { get; set; }
        public byte[] SeAnnoCadData { get; set; }
    }
}
