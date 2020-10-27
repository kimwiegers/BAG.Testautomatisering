using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class Ohxbag3HectointervallenI
    {
        public int WvkId { get; set; }
        public DateTime BegindatumVastlegging { get; set; }
        public DateTime BegindatumWerkelijk { get; set; }
        public short Beginafstand { get; set; }
        public short Eindafstand { get; set; }
        public decimal Beginkilometrering { get; set; }
        public decimal Eindkilometrering { get; set; }
        public string BaanpositieTovWol { get; set; }
    }
}
