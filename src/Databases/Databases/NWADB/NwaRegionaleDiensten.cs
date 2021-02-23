using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWADB
{
    public partial class NwaRegionaleDiensten
    {
        public NwaRegionaleDiensten()
        {
            NwaDistricten = new HashSet<NwaDistricten>();
        }

        public string Code { get; set; }
        public string Naam { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime? Einddatum { get; set; }

        public virtual ICollection<NwaDistricten> NwaDistricten { get; set; }
    }
}
