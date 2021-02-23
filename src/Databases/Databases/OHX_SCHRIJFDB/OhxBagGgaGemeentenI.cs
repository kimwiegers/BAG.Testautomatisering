using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxBagGgaGemeentenI
    {
        public byte Id { get; set; }
        public string Naam { get; set; }
        public byte? GmeIdInVln { get; set; }
        public DateTime? EinddatumDialoog { get; set; }
    }
}
