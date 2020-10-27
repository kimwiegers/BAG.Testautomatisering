using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWADB
{
    public partial class GgaGemeenten
    {
        public GgaGemeenten()
        {
            GgaGemeenteEfemeriden = new HashSet<GgaGemeenteEfemeriden>();
            GgaWoonplaatsen = new HashSet<GgaWoonplaatsen>();
        }

        public short Id { get; set; }
        public string Naam { get; set; }
        public short? GmeIdInVln { get; set; }
        public DateTime? EinddatumDialoog { get; set; }

        public virtual ICollection<GgaGemeenteEfemeriden> GgaGemeenteEfemeriden { get; set; }
        public virtual ICollection<GgaWoonplaatsen> GgaWoonplaatsen { get; set; }
    }
}
