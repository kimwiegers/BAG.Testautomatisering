using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWADB
{
    public partial class GgaProvincies
    {
        public GgaProvincies()
        {
            GgaGemeenteEfemeriden = new HashSet<GgaGemeenteEfemeriden>();
        }

        public string Code { get; set; }
        public short Id { get; set; }
        public string Naam { get; set; }

        public virtual ICollection<GgaGemeenteEfemeriden> GgaGemeenteEfemeriden { get; set; }
    }
}
