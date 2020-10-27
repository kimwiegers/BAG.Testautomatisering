using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwHectoIntervallen
    {
        public long WvkId { get; set; }
        public DateTime BegindatumVastlegging { get; set; }
        public DateTime BegindatumWerkelijk { get; set; }
        public int Beginafstand { get; set; }
        public int Eindafstand { get; set; }
        public decimal Beginkilometrering { get; set; }
        public decimal Eindkilometrering { get; set; }
        public string BaanpositieTovWol { get; set; }

        public virtual NwwWegvakEfemeriden NwwWegvakEfemeriden { get; set; }
    }
}
