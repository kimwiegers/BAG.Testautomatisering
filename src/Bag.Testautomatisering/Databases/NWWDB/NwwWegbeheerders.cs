using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwWegbeheerders
    {
        public NwwWegbeheerders()
        {
            NwwWegvakEfemeriden = new HashSet<NwwWegvakEfemeriden>();
        }

        public short Id { get; set; }
        public string Soort { get; set; }
        public string Code { get; set; }
        public string Naam { get; set; }
        public string Telefoonnummer { get; set; }
        public string Email { get; set; }
        public string Link { get; set; }

        public virtual ICollection<NwwWegvakEfemeriden> NwwWegvakEfemeriden { get; set; }
    }
}
