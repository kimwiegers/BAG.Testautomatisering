using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwHuisnummers
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public long WvkId { get; set; }
        public DateTime BegindatumVastlegging { get; set; }
        public DateTime BegindatumWerkelijk { get; set; }
        public string Zijde { get; set; }
        public int Afstand { get; set; }
        public int Huisnummer { get; set; }
        public string HuisnummerLetter { get; set; }
        public string HuisnummerToevoeging { get; set; }

        public virtual NwwWegvakEfemeriden NwwWegvakEfemeriden { get; set; }
    }
}
