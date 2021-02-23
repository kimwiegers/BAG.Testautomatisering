using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxBagGgaWoonplaatsenInit1
    {
        public byte? Id { get; set; }
        public string BagId { get; set; }
        public byte? GmeId { get; set; }
        public string Gemcode { get; set; }
        public string Gemnaam { get; set; }
        public string Status { get; set; }
        public string NaamNenOrigineel { get; set; }
        public string NaamNen { get; set; }
        public string Naam { get; set; }
        public string NaamPtt { get; set; }
        public string Naamafkorting { get; set; }
        public DateTime? Begindatumtijdvakgeldigheid { get; set; }
    }
}
